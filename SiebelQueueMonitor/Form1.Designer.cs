namespace SiebelQueueMonitor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.toolbar = new System.Windows.Forms.Panel();
            this.selectedMarker = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnManage_Consultants = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.clockDisplay = new System.Windows.Forms.Label();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.toolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 79);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dashboard";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // toolbar
            // 
            this.toolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(75)))), ((int)(((byte)(117)))));
            this.toolbar.Controls.Add(this.selectedMarker);
            this.toolbar.Controls.Add(this.btnSettings);
            this.toolbar.Controls.Add(this.btnReports);
            this.toolbar.Controls.Add(this.btnManage_Consultants);
            this.toolbar.Controls.Add(this.btnDashboard);
            this.toolbar.Controls.Add(this.panel2);
            this.toolbar.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolbar.Location = new System.Drawing.Point(0, 0);
            this.toolbar.Name = "toolbar";
            this.toolbar.Size = new System.Drawing.Size(166, 727);
            this.toolbar.TabIndex = 4;
            // 
            // selectedMarker
            // 
            this.selectedMarker.BackColor = System.Drawing.Color.White;
            this.selectedMarker.Location = new System.Drawing.Point(159, 119);
            this.selectedMarker.Name = "selectedMarker";
            this.selectedMarker.Size = new System.Drawing.Size(7, 72);
            this.selectedMarker.TabIndex = 4;
            // 
            // btnSettings
            // 
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSettings.ForeColor = System.Drawing.Color.White;
            this.btnSettings.Image = ((System.Drawing.Image)(resources.GetObject("btnSettings.Image")));
            this.btnSettings.Location = new System.Drawing.Point(0, 636);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(163, 79);
            this.btnSettings.TabIndex = 3;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnReports
            // 
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.Image = ((System.Drawing.Image)(resources.GetObject("btnReports.Image")));
            this.btnReports.Location = new System.Drawing.Point(0, 204);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(163, 79);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "Reports";
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReports.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // btnManage_Consultants
            // 
            this.btnManage_Consultants.FlatAppearance.BorderSize = 0;
            this.btnManage_Consultants.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManage_Consultants.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManage_Consultants.ForeColor = System.Drawing.Color.White;
            this.btnManage_Consultants.Image = ((System.Drawing.Image)(resources.GetObject("btnManage_Consultants.Image")));
            this.btnManage_Consultants.Location = new System.Drawing.Point(0, 289);
            this.btnManage_Consultants.Name = "btnManage_Consultants";
            this.btnManage_Consultants.Size = new System.Drawing.Size(163, 79);
            this.btnManage_Consultants.TabIndex = 1;
            this.btnManage_Consultants.Text = "Manage Consultants";
            this.btnManage_Consultants.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnManage_Consultants.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnManage_Consultants.UseVisualStyleBackColor = true;
            this.btnManage_Consultants.Click += new System.EventHandler(this.btnManage_Consultants_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.Location = new System.Drawing.Point(0, 119);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(163, 79);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(42)))), ((int)(((byte)(117)))));
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 76);
            this.panel2.TabIndex = 0;
            // 
            // clock
            // 
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // clockDisplay
            // 
            this.clockDisplay.AutoSize = true;
            this.clockDisplay.Location = new System.Drawing.Point(172, 9);
            this.clockDisplay.Name = "clockDisplay";
            this.clockDisplay.Size = new System.Drawing.Size(118, 21);
            this.clockDisplay.TabIndex = 5;
            this.clockDisplay.Text = "HH:MM:SS AM";
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoSize = true;
            this.panelChildForm.Location = new System.Drawing.Point(176, 33);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1145, 682);
            this.panelChildForm.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1333, 727);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.clockDisplay);
            this.Controls.Add(this.toolbar);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1349, 766);
            this.MinimumSize = new System.Drawing.Size(1349, 766);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queue Monitor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolbar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel toolbar;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnManage_Consultants;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Panel selectedMarker;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Label clockDisplay;
        private System.Windows.Forms.Panel panelChildForm;
    }
}

