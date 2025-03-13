namespace DVLD
{
    partial class MainForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuDrivers = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuAccountSetting = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuApplication,
            this.toolStripMenuPeople,
            this.toolStripMenuDrivers,
            this.ToolStripMenuUser,
            this.toolStripMenuAccountSetting});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1094, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuApplication
            // 
            this.MenuApplication.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuApplication.Image = global::DVLD.Properties.Resources.Application1;
            this.MenuApplication.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MenuApplication.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.MenuApplication.Name = "MenuApplication";
            this.MenuApplication.Size = new System.Drawing.Size(150, 44);
            this.MenuApplication.Text = "Application";
            // 
            // toolStripMenuPeople
            // 
            this.toolStripMenuPeople.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuPeople.Image = global::DVLD.Properties.Resources.People;
            this.toolStripMenuPeople.Name = "toolStripMenuPeople";
            this.toolStripMenuPeople.Size = new System.Drawing.Size(115, 44);
            this.toolStripMenuPeople.Text = "People";
            this.toolStripMenuPeople.Click += new System.EventHandler(this.toolStripMenuPeople_Click);
            // 
            // toolStripMenuDrivers
            // 
            this.toolStripMenuDrivers.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuDrivers.Image = global::DVLD.Properties.Resources.DriversLiecense;
            this.toolStripMenuDrivers.Name = "toolStripMenuDrivers";
            this.toolStripMenuDrivers.Size = new System.Drawing.Size(117, 44);
            this.toolStripMenuDrivers.Text = "Drivers";
            // 
            // ToolStripMenuUser
            // 
            this.ToolStripMenuUser.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuUser.Image = global::DVLD.Properties.Resources.Userss;
            this.ToolStripMenuUser.Name = "ToolStripMenuUser";
            this.ToolStripMenuUser.Size = new System.Drawing.Size(105, 44);
            this.ToolStripMenuUser.Text = "Users";
            // 
            // toolStripMenuAccountSetting
            // 
            this.toolStripMenuAccountSetting.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuAccountSetting.Image = global::DVLD.Properties.Resources.AccountSettingpng;
            this.toolStripMenuAccountSetting.Name = "toolStripMenuAccountSetting";
            this.toolStripMenuAccountSetting.Size = new System.Drawing.Size(186, 44);
            this.toolStripMenuAccountSetting.Text = "Account Setting";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1094, 521);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuApplication;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuPeople;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDrivers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuAccountSetting;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuUser;
    }
}

