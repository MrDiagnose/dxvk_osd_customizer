using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dxvk_osd_customizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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


            File.Create("dxvk.conf").Close();
            using (StreamWriter sw = File.AppendText("dxvk.conf"))
            {
                sw.WriteLine("dxvk.enableAsync=true" +
                          "\nRADV_PERFTEST = gpl" +
                          "\ndxvk.gplAsyncCache = true" + dxvk_osd_feature);

            }

        }
    }
}