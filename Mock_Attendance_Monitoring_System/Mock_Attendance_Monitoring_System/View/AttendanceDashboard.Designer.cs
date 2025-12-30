namespace Mock_Attendance_Monitoring_System.View
{
    partial class AttendanceDashboard
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
            this.DPTattendance = new System.Windows.Forms.DateTimePicker();
            this.AttendanceTable = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_accNum = new System.Windows.Forms.TextBox();
            this.btn_enterID = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtposition = new System.Windows.Forms.TextBox();
            this.txtTimein = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimeout = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.txtcivilstat = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DPTattendance
            // 
            this.DPTattendance.Location = new System.Drawing.Point(1291, 57);
            this.DPTattendance.Name = "DPTattendance";
            this.DPTattendance.Size = new System.Drawing.Size(291, 26);
            this.DPTattendance.TabIndex = 0;
            this.DPTattendance.ValueChanged += new System.EventHandler(this.DPTattendance_ValueChanged);
            // 
            // AttendanceTable
            // 
            this.AttendanceTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AttendanceTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column8,
            this.Column5,
            this.Column6,
            this.Column7});
            this.AttendanceTable.Location = new System.Drawing.Point(465, 121);
            this.AttendanceTable.Name = "AttendanceTable";
            this.AttendanceTable.RowHeadersWidth = 62;
            this.AttendanceTable.RowTemplate.Height = 28;
            this.AttendanceTable.Size = new System.Drawing.Size(1117, 369);
            this.AttendanceTable.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(463, 493);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type in your employee ID and select ENTER to log in/log-out:";
            // 
            // txt_accNum
            // 
            this.txt_accNum.Location = new System.Drawing.Point(465, 579);
            this.txt_accNum.Name = "txt_accNum";
            this.txt_accNum.Size = new System.Drawing.Size(565, 26);
            this.txt_accNum.TabIndex = 3;
            // 
            // btn_enterID
            // 
            this.btn_enterID.BackColor = System.Drawing.Color.Navy;
            this.btn_enterID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enterID.ForeColor = System.Drawing.Color.White;
            this.btn_enterID.Location = new System.Drawing.Point(1054, 548);
            this.btn_enterID.Name = "btn_enterID";
            this.btn_enterID.Size = new System.Drawing.Size(261, 57);
            this.btn_enterID.TabIndex = 4;
            this.btn_enterID.Text = "ENTER";
            this.btn_enterID.UseVisualStyleBackColor = false;
            this.btn_enterID.Click += new System.EventHandler(this.btn_enterID_Click);
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblname.Location = new System.Drawing.Point(54, 84);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(28, 28);
            this.lblname.TabIndex = 5;
            this.lblname.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Department:";
            // 
            // txtdepartment
            // 
            this.txtdepartment.Location = new System.Drawing.Point(59, 171);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.ReadOnly = true;
            this.txtdepartment.Size = new System.Drawing.Size(309, 26);
            this.txtdepartment.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 28);
            this.label3.TabIndex = 8;
            this.label3.Text = "Position:";
            // 
            // txtposition
            // 
            this.txtposition.Location = new System.Drawing.Point(59, 257);
            this.txtposition.Name = "txtposition";
            this.txtposition.ReadOnly = true;
            this.txtposition.Size = new System.Drawing.Size(309, 26);
            this.txtposition.TabIndex = 9;
            // 
            // txtTimein
            // 
            this.txtTimein.Location = new System.Drawing.Point(59, 346);
            this.txtTimein.Name = "txtTimein";
            this.txtTimein.ReadOnly = true;
            this.txtTimein.Size = new System.Drawing.Size(309, 26);
            this.txtTimein.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 28);
            this.label4.TabIndex = 11;
            this.label4.Text = "Time in:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "Time out:";
            // 
            // txtTimeout
            // 
            this.txtTimeout.Location = new System.Drawing.Point(59, 431);
            this.txtTimeout.Name = "txtTimeout";
            this.txtTimeout.ReadOnly = true;
            this.txtTimeout.Size = new System.Drawing.Size(309, 26);
            this.txtTimeout.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 28);
            this.label6.TabIndex = 14;
            this.label6.Text = "Attendance";
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btn_back.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_back.Location = new System.Drawing.Point(-1, -3);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(153, 48);
            this.btn_back.TabIndex = 15;
            this.btn_back.Text = "MENU";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // txtcivilstat
            // 
            this.txtcivilstat.Location = new System.Drawing.Point(59, 511);
            this.txtcivilstat.Name = "txtcivilstat";
            this.txtcivilstat.ReadOnly = true;
            this.txtcivilstat.Size = new System.Drawing.Size(309, 26);
            this.txtcivilstat.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Civil status:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.txtdepartment);
            this.panel1.Controls.Add(this.txtcivilstat);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtposition);
            this.panel1.Controls.Add(this.txtTimeout);
            this.panel1.Controls.Add(this.txtTimein);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-1, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 643);
            this.panel1.TabIndex = 18;
            // 
            // btn_refresh
            // 
            this.btn_refresh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_refresh.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btn_refresh.Location = new System.Drawing.Point(1321, 548);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(261, 57);
            this.btn_refresh.TabIndex = 19;
            this.btn_refresh.Text = "REFRESH";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Employee ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Department";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Position";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Civil status";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Time in";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Time out";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Date";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.Width = 150;
            // 
            // AttendanceDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1630, 685);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_enterID);
            this.Controls.Add(this.txt_accNum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AttendanceTable);
            this.Controls.Add(this.DPTattendance);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AttendanceDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AttendanceListLoad);
            ((System.ComponentModel.ISupportInitialize)(this.AttendanceTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DPTattendance;
        private System.Windows.Forms.DataGridView AttendanceTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_accNum;
        private System.Windows.Forms.Button btn_enterID;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtposition;
        private System.Windows.Forms.TextBox txtTimein;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimeout;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox txtcivilstat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}