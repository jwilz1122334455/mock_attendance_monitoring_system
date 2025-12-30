namespace Mock_Attendance_Monitoring_System.View
{
    partial class MenuForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_attenddashboard = new System.Windows.Forms.Button();
            this.btn_dataentry = new System.Windows.Forms.Button();
            this.btn_accountlist = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Attendance monitoring - MAIN MENU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_attenddashboard
            // 
            this.btn_attenddashboard.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_attenddashboard.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_attenddashboard.Location = new System.Drawing.Point(58, 146);
            this.btn_attenddashboard.Name = "btn_attenddashboard";
            this.btn_attenddashboard.Size = new System.Drawing.Size(219, 88);
            this.btn_attenddashboard.TabIndex = 1;
            this.btn_attenddashboard.Text = "Attendance Dashboard";
            this.btn_attenddashboard.UseVisualStyleBackColor = false;
            this.btn_attenddashboard.Click += new System.EventHandler(this.btn_attenddashboard_Click);
            // 
            // btn_dataentry
            // 
            this.btn_dataentry.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_dataentry.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_dataentry.Location = new System.Drawing.Point(58, 251);
            this.btn_dataentry.Name = "btn_dataentry";
            this.btn_dataentry.Size = new System.Drawing.Size(219, 88);
            this.btn_dataentry.TabIndex = 2;
            this.btn_dataentry.Text = "Create data";
            this.btn_dataentry.UseVisualStyleBackColor = false;
            this.btn_dataentry.Click += new System.EventHandler(this.btn_dataentry_Click);
            // 
            // btn_accountlist
            // 
            this.btn_accountlist.BackColor = System.Drawing.Color.NavajoWhite;
            this.btn_accountlist.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_accountlist.Location = new System.Drawing.Point(326, 146);
            this.btn_accountlist.Name = "btn_accountlist";
            this.btn_accountlist.Size = new System.Drawing.Size(219, 88);
            this.btn_accountlist.TabIndex = 3;
            this.btn_accountlist.Text = "Account List";
            this.btn_accountlist.UseVisualStyleBackColor = false;
            this.btn_accountlist.Click += new System.EventHandler(this.btn_accountlist_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.DarkSalmon;
            this.btn_logout.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.Location = new System.Drawing.Point(326, 251);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(219, 88);
            this.btn_logout.TabIndex = 4;
            this.btn_logout.Text = "Log out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(608, 93);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Mock_Attendance_Monitoring_System.Properties.Resources.profile_img02;
            this.pictureBox1.Location = new System.Drawing.Point(-10, -148);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 388);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(1, 388);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(608, 163);
            this.panel2.TabIndex = 7;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 551);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_accountlist);
            this.Controls.Add(this.btn_dataentry);
            this.Controls.Add(this.btn_attenddashboard);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_attenddashboard;
        private System.Windows.Forms.Button btn_dataentry;
        private System.Windows.Forms.Button btn_accountlist;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
    }
}