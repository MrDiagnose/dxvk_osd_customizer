﻿using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System;
using System.Diagnostics;

namespace dxvk_osd_customizer
{
    public partial class FormDxvk : Form
    {
        public FormDxvk()
        {
            InitializeComponent();

            this.listBoxGame.DragDrop += new
                DragEventHandler(this.listBoxGame_DragDrop);
            this.listBoxGame.DragEnter += new
                DragEventHandler(this.listBoxGame_DragEnter);


            String line;
            try
            {
                StreamReader sr = new StreamReader("game_list.txt");
                line = sr.ReadLine();
                while (line != null)
                {

                    listBoxGame.Items.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception hey)
            {
                Console.WriteLine("Exceeption: " + hey.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }
            comboBoxDxvk.SelectedItem ="dxvk-async"; //set default dxvk type
            comboBoxBit.SelectedItem = "64 bit"; //set default bit
            if (listBoxGame.Items.Count>0)
              listBoxGame.SelectedIndex = 0;//select 1st item




        }

        private void listBoxGame_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void listBoxGame_DragDrop(object sender, DragEventArgs e)
        {
            string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
            //Console.WriteLine(s[0]);
            int i;
            for (i = 0; i < s.Length; i++)
                { 
                if (System.IO.Path.GetExtension(s[i]).Equals(".exe", StringComparison.InvariantCultureIgnoreCase))
                    {
                        listBoxGame.Items.Add(s[i]);
                    }
                else
                {
                    MessageBox.Show("Please select an exe file");
                }
            }
            
            
            
        }
     

        private void buttonCreate_Click(object sender, System.EventArgs e)
        {
            string dxvk_osd_feature = "\ndxvk.hud=";

            if (!checkBoxSelectAll.Checked)
            {
                if (checkBoxDevinfo.Checked)
                    dxvk_osd_feature += "devinfo,";
                if (checkBoxfps.Checked)
                    dxvk_osd_feature += "fps,";
                if (checkBoxframetime.Checked)
                    dxvk_osd_feature += "frametime,";
                if (checkBoxSubmissions.Checked)
                    dxvk_osd_feature += "submissions,";
                if (checkBoxDrawcalls.Checked)
                    dxvk_osd_feature += "drawcalls,";
                if (checkBoxGpuload.Checked)
                    dxvk_osd_feature += "gpuload,";
                if (checkBoxVersion.Checked)
                    dxvk_osd_feature += "version,";
                if (checkBoxCompiler.Checked)
                    dxvk_osd_feature += "compiler,";
                if (checkBoxPipelines.Checked)
                    dxvk_osd_feature += "pipelines,";
                if (checkBoxDescriptors.Checked)
                    dxvk_osd_feature += "descriptors,";
                if (checkBoxMemory.Checked)
                    dxvk_osd_feature += "memory,";
                if (checkBoxApi.Checked)
                    dxvk_osd_feature += "api,";
                if (checkBoxCS.Checked)
                    dxvk_osd_feature += "cs,";
                if (checkBoxSamplers.Checked)
                    dxvk_osd_feature += "samplers,";
                if (checkBoxScaleX.Checked)
                    dxvk_osd_feature += "scale=x,";
                if (checkBoxOpacityY.Checked)
                    dxvk_osd_feature += "opacity=y,";
            }
            else
            {
                dxvk_osd_feature += "full";
            }

            string FpsLimit = "";
            if (checkBoxFrameLimit.Checked)
            {
                FpsLimit=numericUpDownFrameLimit.Value.ToString();
            }

            File.Create("dxvk.conf").Close();
            using (StreamWriter sw = File.AppendText("dxvk.conf"))
            {
                sw.WriteLine("dxvk.enableAsync="+ checkBoxAsync.Checked +
                          "\ndxvk.gplAsyncCache=true" + 
                          dxvk_osd_feature+
                          "\ndxgi.maxFrameRate="+
                          FpsLimit+
                          "\nd3d9.maxFrameRate="+
                          FpsLimit);
                sw.Close();

            }

                String destDir ="";

            if (listBoxGame.Items.Count > 0)
            {
                destDir = System.IO.Path.GetDirectoryName(listBoxGame.SelectedItem.ToString());
                File.Copy("dxvk.conf", Path.Combine(destDir, "dxvk.conf"), true);
            }
        }
        
        private void buttonFind_Click(object sender, System.EventArgs e)
        {
            /*
            string registry_key = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall";
            using (Microsoft.Win32.RegistryKey key = Registry.LocalMachine.OpenSubKey(registry_key))
            {
                foreach (string subkey_name in key.GetSubKeyNames())
                {
                    using (RegistryKey subkey = key.OpenSubKey(subkey_name))
                    {
                        Console.WriteLine(subkey.GetValue("DisplayName"));                 
                    }
                }
            }*/
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
                listBoxGame.Items.Remove(listBoxGame.SelectedItem);
        }

        private void buttonInstall_Click(object sender, EventArgs e)
        {
            string dxvkPath = @"dxvk\";

            if ((listBoxGame.SelectedIndex!=-1) & (comboBoxBit.SelectedIndex!=-1) & (comboBoxDxvk.SelectedIndex!=-1))
            {
                string dxvkVersion = comboBoxDxvk.SelectedItem.ToString();
                string bit = comboBoxBit.SelectedItem.ToString();
                
                if (bit=="32 bit")
                {
                    dxvkPath += dxvkVersion + @"\x32";
                }
                else
                    dxvkPath += dxvkVersion + @"\x64";
                string sourceDir = dxvkPath;
                string destDir = System.IO.Path.GetDirectoryName(listBoxGame.SelectedItem.ToString());
                try
                {
                    string[] dxvkFiles = Directory.GetFiles(sourceDir, "*.dll");
                    foreach (string f in dxvkFiles)
                    {
                        // Remove path from the file name.
                        string fName = f.Substring(sourceDir.Length + 1);

                        // Use the Path.Combine method to safely append the file name to the path.
                        // Will overwrite if the destination file already exists.
                        File.Copy(Path.Combine(sourceDir, fName), Path.Combine(destDir, fName), true);
                    }

                }
                catch (DirectoryNotFoundException dirNotFound)
                {
                    Console.WriteLine(dirNotFound.Message);
                }
                File.Copy("dxvk.conf", Path.Combine(destDir,"dxvk.conf"),true);
            }
            else
            {
                MessageBox.Show("Please select game, bit & dxvk");
            }
        }

        private void buttonUninstall_Click(object sender, EventArgs e)
        {
            string destDir = System.IO.Path.GetDirectoryName(listBoxGame.SelectedItem.ToString());
            if (listBoxGame.SelectedIndex != -1)
            {
                File.Delete(Path.Combine(destDir, "dxvk.conf"));
                File.Delete(Path.Combine(destDir, "d3d9.dll"));
                File.Delete(Path.Combine(destDir, "d3d10core.dll"));
                File.Delete(Path.Combine(destDir, "d3d11.dll"));
                File.Delete(Path.Combine(destDir, "dxgi.dll"));
            }
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            /*
            string game = "\""+listBoxGame.SelectedItem.ToString()+"\"";
            Console.WriteLine(game);
            if (listBoxGame.SelectedIndex != -1)
                System.Diagnostics.Process.Start(game);
            //not working as intended
             */

            
        }

        private void buttonSaveList_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("game_list.txt");
                foreach (string s in listBoxGame.Items)
                {
                    sw.WriteLine(s);
                    Console.WriteLine(s);
                }
                sw.Close();
                
            }
            catch (Exception heyoooo)
            {
                Console.WriteLine("Exception: " + heyoooo.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        private void buttonLoadList_Click(object sender, EventArgs e)
        {
            String line;
            try
            {
                StreamReader sr = new StreamReader("game_list.txt");
                line = sr.ReadLine();
                while (line != null)
                {
                    
                    listBoxGame.Items.Add(line);
                    line = sr.ReadLine();
                }
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception hey)
            {
                Console.WriteLine("Exceeption: " + hey.Message);
            }
            finally
            {
                Console.WriteLine("finally");
            }
            
        }

        private void checkBoxSelectAll_CheckedChanged_1(object sender, EventArgs e)
        {
            foreach (CheckBox c in groupBoxBasic.Controls.OfType<CheckBox>())
            {
                if (checkBoxSelectAll.Checked)
                    c.Checked = true;
                else
                    c.Checked = false;
            }
            foreach (CheckBox c in groupBoxAdvanced.Controls.OfType<CheckBox>())
            {
                if (checkBoxSelectAll.Checked)
                    c.Checked = true;
                else
                    c.Checked = false;
            }
            foreach (CheckBox c in groupBoxHudSize.Controls.OfType<CheckBox>())
            {
                if (checkBoxSelectAll.Checked)
                    c.Checked = true;
                else
                    c.Checked = false;
            }
        }

        private void linkLabelSource_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/MrDiagnose/dxvk_osd_customizer");
        }

        private void linkLabelYoutubeGaming_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/@johndrippergaming");
        }

        private void linkLabelYoutubeCoding_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/@johndrippercodes"); 

        }

        private void linkLabelDiscord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.com/invite/fpUaAfyxxR");
        }
    }
}