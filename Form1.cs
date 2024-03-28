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

        //if(File.Exists("dxvk.conf"))
        // {
        //    

        private void buttonCreate_Click(object sender, System.EventArgs e)
        {
            string aString = "";
            /*
            foreach (Control c in this.Controls)
            {
                if (c is CheckBox)
                {
                    c.Controls.
                }
              */
            if (checkBoxDevinfo.Checked)
                aString = "\ndxvk.hud=devinfo";

            /*
            if (!File.Exists("dxvk.conf"))
            {

                File.Create("dxvk.conf").Close();
                using (StreamWriter sw = File.AppendText("dxvk.conf"))
                { sw.WriteLine("dxvk.enableAsync=true" +
                            "\nRADV_PERFTEST = gpl" +
                            "\ndxvk.gplAsyncCache = true"+aString); 
                }
             }
                          
            else
            {
                File.WriteAllText("dxvk.conf", string.Empty);
                using (StreamWriter sw = File.AppendText("dxvk.conf"))
                {
                    sw.WriteLine("Write some text");
                   
                    }
                }
            */
            File.Create("dxvk.conf").Close();
            using (StreamWriter sw = File.AppendText("dxvk.conf"))
            {
                sw.WriteLine("dxvk.enableAsync=true" +
                          "\nRADV_PERFTEST = gpl" +
                          "\ndxvk.gplAsyncCache = true" + aString);

            }

        }
    }
}