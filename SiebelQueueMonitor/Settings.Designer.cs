namespace SiebelQueueMonitor
{
    partial class Settings
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
            this.SettingsTab = new System.Windows.Forms.TabControl();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSetting_Save = new System.Windows.Forms.Button();
            this.btnSetting_Cancel = new System.Windows.Forms.Button();
            this.SettingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // SettingsTab
            // 
            this.SettingsTab.Controls.Add(this.tabSettings);
            this.SettingsTab.Controls.Add(this.tabPage2);
            this.SettingsTab.Location = new System.Drawing.Point(12, 12);
            this.SettingsTab.Name = "SettingsTab";
            this.SettingsTab.SelectedIndex = 0;
            this.SettingsTab.Size = new System.Drawing.Size(776, 382);
            this.SettingsTab.TabIndex = 0;
            // 
            // tabSettings
            // 
            this.tabSettings.Location = new System.Drawing.Point(4, 22);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(768, 356);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.Text = "tabPage1";
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 356);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSetting_Save
            // 
            this.btnSetting_Save.Location = new System.Drawing.Point(709, 400);
            this.btnSetting_Save.Name = "btnSetting_Save";
            this.btnSetting_Save.Size = new System.Drawing.Size(75, 23);
            this.btnSetting_Save.TabIndex = 1;
            this.btnSetting_Save.Text = "Save";
            this.btnSetting_Save.UseVisualStyleBackColor = true;
            // 
            // btnSetting_Cancel
            // 
            this.btnSetting_Cancel.Location = new System.Drawing.Point(628, 400);
            this.btnSetting_Cancel.Name = "btnSetting_Cancel";
            this.btnSetting_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btnSetting_Cancel.TabIndex = 2;
            this.btnSetting_Cancel.Text = "Cancel";
            this.btnSetting_Cancel.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(40)))), ((int)(((byte)(47)))));
            this.ClientSize = new System.Drawing.Size(1145, 682);
            this.Controls.Add(this.btnSetting_Cancel);
            this.Controls.Add(this.btnSetting_Save);
            this.Controls.Add(this.SettingsTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.SettingsTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl SettingsTab;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSetting_Save;
        private System.Windows.Forms.Button btnSetting_Cancel;
    }
}