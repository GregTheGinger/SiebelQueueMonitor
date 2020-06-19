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
        Timer t = new Timer();

        public Form1()
        {
            InitializeComponent();
            selectedMenu("default");            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //timer interval
            t.Interval = 1000;  //in milliseconds

            t.Tick += new EventHandler(this.clock_Tick);

            //start timer when form loads
            t.Start();  //this will use t_Tick() method
        }

        private void clock_Tick(object sender, EventArgs e)
        {            
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;
            
            string time = "";

            int hh_prefernce;
            if (hh < 12)
                hh_prefernce = (hh - 12);
            else
                hh_prefernce = hh;

            if (hh_prefernce < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
                            
            time += ":";

            if (mm < 10)            
                time += "0" + mm;            
            else
            
                time += mm;     
            
            time += ":";

            if (ss < 10)            
                time += "0" + ss;            
            else            
                time += ss;

            if (hh < 12)
                time += " AM";
            else
                time += " PM";

            clockDisplay.Text = time;
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
            openChildForm(new Dashboard());
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
            openChildForm(new Settings());
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
