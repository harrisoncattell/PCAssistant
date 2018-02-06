using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
using System.Windows.Forms;

namespace PCAssistant
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

            lblSerialNumber.Text = getHardwareInfo.getProcessorID();

            lblOS.Text = getHardwareInfo.getOS();

            if(getHardwareInfo.is64bitSystem() == "1")
            {

                lbl64bit.Text = "64-bit";

            }

            else
            {
                lbl64bit.Text = "32-bit";

            }

        }

    }
}
