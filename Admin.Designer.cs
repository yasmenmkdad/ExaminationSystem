namespace ExaminationSystem
{
    partial class Admin
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.log_btn = new System.Windows.Forms.Button();
            this.AdminName = new System.Windows.Forms.TextBox();
            this.btn_Courses = new System.Windows.Forms.Button();
            this.btn_Students = new System.Windows.Forms.Button();
            this.btn_Instructors = new System.Windows.Forms.Button();
            this.data_grd = new System.Windows.Forms.DataGridView();
            this.save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_grd)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Brown;
            this.splitContainer1.Panel1.Controls.Add(this.log_btn);
            this.splitContainer1.Panel1.Controls.Add(this.AdminName);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Courses);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Students);
            this.splitContainer1.Panel1.Controls.Add(this.btn_Instructors);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel2.BackgroundImage = global::ExaminationSystem.Properties.Resources.itiBuilding;
            this.splitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel2.Controls.Add(this.save);
            this.splitContainer1.Panel2.Controls.Add(this.data_grd);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(976, 596);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // log_btn
            // 
            this.log_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.log_btn.BackColor = System.Drawing.Color.White;
            this.log_btn.FlatAppearance.BorderSize = 0;
            this.log_btn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.log_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_btn.ForeColor = System.Drawing.Color.White;
            this.log_btn.Location = new System.Drawing.Point(5, 438);
            this.log_btn.Margin = new System.Windows.Forms.Padding(2);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(210, 48);
            this.log_btn.TabIndex = 10;
            this.log_btn.Text = "Logout";
            this.log_btn.UseVisualStyleBackColor = false;
            this.log_btn.Click += new System.EventHandler(this.log_btn_Click);
            // 
            // AdminName
            // 
            this.AdminName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AdminName.BackColor = System.Drawing.Color.Brown;
            this.AdminName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AdminName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminName.ForeColor = System.Drawing.SystemColors.Window;
            this.AdminName.Location = new System.Drawing.Point(6, 65);
            this.AdminName.Margin = new System.Windows.Forms.Padding(2);
            this.AdminName.Multiline = true;
            this.AdminName.Name = "AdminName";
            this.AdminName.Size = new System.Drawing.Size(205, 53);
            this.AdminName.TabIndex = 9;
            this.AdminName.Text = "AdminName";
            this.AdminName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Courses
            // 
            this.btn_Courses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Courses.BackColor = System.Drawing.Color.White;
            this.btn_Courses.FlatAppearance.BorderSize = 0;
            this.btn_Courses.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Courses.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Courses.ForeColor = System.Drawing.Color.White;
            this.btn_Courses.Location = new System.Drawing.Point(6, 353);
            this.btn_Courses.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Courses.Name = "btn_Courses";
            this.btn_Courses.Size = new System.Drawing.Size(210, 48);
            this.btn_Courses.TabIndex = 8;
            this.btn_Courses.Text = "Courses";
            this.btn_Courses.UseVisualStyleBackColor = false;
            this.btn_Courses.Click += new System.EventHandler(this.btn_Courses_Click);
            // 
            // btn_Students
            // 
            this.btn_Students.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Students.BackColor = System.Drawing.Color.White;
            this.btn_Students.FlatAppearance.BorderSize = 0;
            this.btn_Students.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Students.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Students.ForeColor = System.Drawing.Color.White;
            this.btn_Students.Location = new System.Drawing.Point(5, 278);
            this.btn_Students.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Students.Name = "btn_Students";
            this.btn_Students.Size = new System.Drawing.Size(210, 48);
            this.btn_Students.TabIndex = 7;
            this.btn_Students.Text = "Students";
            this.btn_Students.UseVisualStyleBackColor = false;
            this.btn_Students.Click += new System.EventHandler(this.btn_Students_Click);
            // 
            // btn_Instructors
            // 
            this.btn_Instructors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Instructors.BackColor = System.Drawing.Color.White;
            this.btn_Instructors.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_Instructors.FlatAppearance.BorderSize = 0;
            this.btn_Instructors.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Instructors.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Instructors.ForeColor = System.Drawing.Color.White;
            this.btn_Instructors.Location = new System.Drawing.Point(5, 200);
            this.btn_Instructors.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Instructors.Name = "btn_Instructors";
            this.btn_Instructors.Size = new System.Drawing.Size(210, 48);
            this.btn_Instructors.TabIndex = 6;
            this.btn_Instructors.Text = "Instructors";
            this.btn_Instructors.UseVisualStyleBackColor = false;
            this.btn_Instructors.Click += new System.EventHandler(this.btn_Instructors_Click);
            // 
            // data_grd
            // 
            this.data_grd.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.data_grd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grd.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.data_grd.Location = new System.Drawing.Point(41, 65);
            this.data_grd.Name = "data_grd";
            this.data_grd.Size = new System.Drawing.Size(685, 506);
            this.data_grd.TabIndex = 0;
            // 
            // save
            // 
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save.Location = new System.Drawing.Point(331, 25);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 1;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Brown;
            this.BackgroundImage = global::ExaminationSystem.Properties.Resources.WhatsApp_Image_2022_02_10_at_1_31_25_AM_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(976, 596);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(992, 635);
            this.MinimumSize = new System.Drawing.Size(992, 635);
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_grd)).EndInit();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox AdminName;
        private System.Windows.Forms.Button btn_Instructors;
        private System.Windows.Forms.Button btn_Students;
        private System.Windows.Forms.Button log_btn;
        private System.Windows.Forms.Button btn_Courses;
        private System.Windows.Forms.DataGridView data_grd;
        private System.Windows.Forms.Button save;
    }
}