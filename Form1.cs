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
            File.Create("dxvk.conf").Close();
            using (StreamWriter sw = File.AppendText("dxvk.conf"))
            sw.WriteLine("dxvk.enableAsync=true" +
                    "\nRADV_PERFTEST = gpl" +
                    "\ndxvk.gplAsyncCache = true");
        }                
                //{
                
                //}
           /* }
            else
            {
            File.WriteAllText("dxvk.conf", string.Empty);
            using (StreamWriter sw = File.AppendText("dxvk.conf")) ;
            {
            sw.WriteLine("yoyo");
            }
            }
            }*/
}
}