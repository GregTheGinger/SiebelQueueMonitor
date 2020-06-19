using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiebelQueueMonitor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            selectedMenu("default");
        }

        private void selectedMenu(string nm)
        {
            switch (nm)
            {
                case "reports":
                    selectedMarker.Top = btnReports.Top;
                    selectedMarker.Height = btnReports.Height;
                    break;
                case "manage_con":
                    selectedMarker.Top = btnManage_Consultants.Top;
                    selectedMarker.Height = btnManage_Consultants.Height;
                    break;
                case "settings":
                    selectedMarker.Top = btnSettings.Top;
                    selectedMarker.Height = btnSettings.Height;
                    break;
                default:
                    selectedMarker.Top = btnDashboard.Top;
                    selectedMarker.Height = btnDashboard.Height;
                    break;
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            selectedMenu("default");
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            selectedMenu("reports");
        }

        private void btnManage_Consultants_Click(object sender, EventArgs e)
        {
            selectedMenu("manage_con");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            selectedMenu("settings");
        }
    }
}
