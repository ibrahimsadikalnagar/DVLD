namespace DVLD
{
    partial class AddEditPoepleForm
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
            this.userControlPoeple1 = new DVLD.UserControlPoeple();
            this.lblTitlePoeple = new System.Windows.Forms.Label();
            this.labelPersonID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // userControlPoeple1
            // 
            this.userControlPoeple1.Location = new System.Drawing.Point(12, 131);
            this.userControlPoeple1.Name = "userControlPoeple1";
            this.userControlPoeple1.Size = new System.Drawing.Size(930, 494);
            this.userControlPoeple1.TabIndex = 0;
            this.userControlPoeple1.Load += new System.EventHandler(this.userControlPoeple1_Load);
            // 
            // lblTitlePoeple
            // 
            this.lblTitlePoeple.AutoSize = true;
            this.lblTitlePoeple.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePoeple.ForeColor = System.Drawing.Color.Maroon;
            this.lblTitlePoeple.Location = new System.Drawing.Point(343, 38);
            this.lblTitlePoeple.Name = "lblTitlePoeple";
            this.lblTitlePoeple.Size = new System.Drawing.Size(297, 41);
            this.lblTitlePoeple.TabIndex = 1;
            this.lblTitlePoeple.Text = "Add New Person";
            // 
            // labelPersonID
            // 
            this.labelPersonID.AutoSize = true;
            this.labelPersonID.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonID.Location = new System.Drawing.Point(30, 104);
            this.labelPersonID.Name = "labelPersonID";
            this.labelPersonID.Size = new System.Drawing.Size(104, 24);
            this.labelPersonID.TabIndex = 2;
            this.labelPersonID.Text = "Person ID:";
            // 
            // AddEditPoepleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 651);
            this.Controls.Add(this.labelPersonID);
            this.Controls.Add(this.lblTitlePoeple);
            this.Controls.Add(this.userControlPoeple1);
            this.Name = "AddEditPoepleForm";
            this.Text = "AddEditPoepleForm";
            this.Load += new System.EventHandler(this.AddEditPoepleForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControlPoeple userControlPoeple1;
        private System.Windows.Forms.Label lblTitlePoeple;
        private System.Windows.Forms.Label labelPersonID;
    }
}