
namespace ExaminationSystem
{
    partial class InstructorForm
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
            this.InstructorName = new System.Windows.Forms.TextBox();
            this.button_StudInfo = new System.Windows.Forms.Button();
            this.btn_GenerateExam = new System.Windows.Forms.Button();
            this.button_profile = new System.Windows.Forms.Button();
            this.generateExam = new System.Windows.Forms.Panel();
            this.student_panel = new System.Windows.Forms.Panel();
            this.studentgrd = new System.Windows.Forms.DataGridView();
            this.std_info = new System.Windows.Forms.Label();
            this.examgeneration = new System.Windows.Forms.Panel();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.Txt_TF = new System.Windows.Forms.TextBox();
            this.txt_MCQ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelTF = new System.Windows.Forms.Label();
            this.labelcrs = new System.Windows.Forms.Label();
            this.examlabel = new System.Windows.Forms.Label();
            this.course_panel = new System.Windows.Forms.Panel();
            this.courses_grid = new System.Windows.Forms.DataGridView();
            this.crsName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.generateExam.SuspendLayout();
            this.student_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentgrd)).BeginInit();
            this.examgeneration.SuspendLayout();
            this.course_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.courses_grid)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.InstructorName);
            this.splitContainer1.Panel1.Controls.Add(this.button_StudInfo);
            this.splitContainer1.Panel1.Controls.Add(this.btn_GenerateExam);
            this.splitContainer1.Panel1.Controls.Add(this.button_profile);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.splitContainer1.Panel2.Controls.Add(this.generateExam);
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
            this.log_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // InstructorName
            // 
            this.InstructorName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InstructorName.BackColor = System.Drawing.Color.Brown;
            this.InstructorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InstructorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructorName.ForeColor = System.Drawing.SystemColors.Window;
            this.InstructorName.Location = new System.Drawing.Point(6, 65);
            this.InstructorName.Margin = new System.Windows.Forms.Padding(2);
            this.InstructorName.Multiline = true;
            this.InstructorName.Name = "InstructorName";
            this.InstructorName.Size = new System.Drawing.Size(205, 53);
            this.InstructorName.TabIndex = 9;
            this.InstructorName.Text = "InstructorName";
            this.InstructorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_StudInfo
            // 
            this.button_StudInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_StudInfo.BackColor = System.Drawing.Color.White;
            this.button_StudInfo.FlatAppearance.BorderSize = 0;
            this.button_StudInfo.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_StudInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_StudInfo.ForeColor = System.Drawing.Color.White;
            this.button_StudInfo.Location = new System.Drawing.Point(6, 353);
            this.button_StudInfo.Margin = new System.Windows.Forms.Padding(2);
            this.button_StudInfo.Name = "button_StudInfo";
            this.button_StudInfo.Size = new System.Drawing.Size(210, 48);
            this.button_StudInfo.TabIndex = 8;
            this.button_StudInfo.Text = "Students Info";
            this.button_StudInfo.UseVisualStyleBackColor = false;
            this.button_StudInfo.Click += new System.EventHandler(this.button_StudInfo_Click);
            // 
            // btn_GenerateExam
            // 
            this.btn_GenerateExam.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_GenerateExam.BackColor = System.Drawing.Color.White;
            this.btn_GenerateExam.FlatAppearance.BorderSize = 0;
            this.btn_GenerateExam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_GenerateExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenerateExam.ForeColor = System.Drawing.Color.White;
            this.btn_GenerateExam.Location = new System.Drawing.Point(5, 278);
            this.btn_GenerateExam.Margin = new System.Windows.Forms.Padding(2);
            this.btn_GenerateExam.Name = "btn_GenerateExam";
            this.btn_GenerateExam.Size = new System.Drawing.Size(210, 48);
            this.btn_GenerateExam.TabIndex = 7;
            this.btn_GenerateExam.Text = "Generate Exam";
            this.btn_GenerateExam.UseVisualStyleBackColor = false;
            this.btn_GenerateExam.Click += new System.EventHandler(this.button_Exam_Click);
            // 
            // button_profile
            // 
            this.button_profile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_profile.BackColor = System.Drawing.Color.White;
            this.button_profile.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_profile.FlatAppearance.BorderSize = 0;
            this.button_profile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_profile.ForeColor = System.Drawing.Color.White;
            this.button_profile.Location = new System.Drawing.Point(5, 200);
            this.button_profile.Margin = new System.Windows.Forms.Padding(2);
            this.button_profile.Name = "button_profile";
            this.button_profile.Size = new System.Drawing.Size(210, 48);
            this.button_profile.TabIndex = 6;
            this.button_profile.Text = "Profile";
            this.button_profile.UseVisualStyleBackColor = false;
            this.button_profile.Click += new System.EventHandler(this.button_profile_Click);
            // 
            // generateExam
            // 
            this.generateExam.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.generateExam.BackColor = System.Drawing.Color.White;
            this.generateExam.BackgroundImage = global::ExaminationSystem.Properties.Resources.WhatsApp_Image_2022_02_10_at_1_31_25_AM_1_;
            this.generateExam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.generateExam.Controls.Add(this.student_panel);
            this.generateExam.Controls.Add(this.examgeneration);
            this.generateExam.Controls.Add(this.course_panel);
            this.generateExam.Location = new System.Drawing.Point(-1, -8);
            this.generateExam.Name = "generateExam";
            this.generateExam.Size = new System.Drawing.Size(754, 602);
            this.generateExam.TabIndex = 4;
            this.generateExam.Paint += new System.Windows.Forms.PaintEventHandler(this.generateExam_Paint);
            // 
            // student_panel
            // 
            this.student_panel.Controls.Add(this.studentgrd);
            this.student_panel.Controls.Add(this.std_info);
            this.student_panel.Location = new System.Drawing.Point(55, 73);
            this.student_panel.Name = "student_panel";
            this.student_panel.Size = new System.Drawing.Size(652, 486);
            this.student_panel.TabIndex = 4;
            // 
            // studentgrd
            // 
            this.studentgrd.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.studentgrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentgrd.GridColor = System.Drawing.SystemColors.ControlLight;
            this.studentgrd.Location = new System.Drawing.Point(16, 52);
            this.studentgrd.Name = "studentgrd";
            this.studentgrd.Size = new System.Drawing.Size(620, 397);
            this.studentgrd.TabIndex = 1;
            // 
            // std_info
            // 
            this.std_info.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.std_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.std_info.ForeColor = System.Drawing.Color.Black;
            this.std_info.Location = new System.Drawing.Point(12, 15);
            this.std_info.Name = "std_info";
            this.std_info.Size = new System.Drawing.Size(86, 33);
            this.std_info.TabIndex = 0;
            this.std_info.Text = "Students";
            this.std_info.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // examgeneration
            // 
            this.examgeneration.BackColor = System.Drawing.Color.Snow;
            this.examgeneration.Controls.Add(this.txt_name);
            this.examgeneration.Controls.Add(this.Txt_TF);
            this.examgeneration.Controls.Add(this.txt_MCQ);
            this.examgeneration.Controls.Add(this.label3);
            this.examgeneration.Controls.Add(this.labelTF);
            this.examgeneration.Controls.Add(this.labelcrs);
            this.examgeneration.Controls.Add(this.examlabel);
            this.examgeneration.Location = new System.Drawing.Point(176, 86);
            this.examgeneration.Name = "examgeneration";
            this.examgeneration.Size = new System.Drawing.Size(422, 420);
            this.examgeneration.TabIndex = 3;
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(44, 124);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(102, 22);
            this.txt_name.TabIndex = 6;
            // 
            // Txt_TF
            // 
            this.Txt_TF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_TF.Location = new System.Drawing.Point(40, 239);
            this.Txt_TF.Name = "Txt_TF";
            this.Txt_TF.Size = new System.Drawing.Size(106, 22);
            this.Txt_TF.TabIndex = 5;
            // 
            // txt_MCQ
            // 
            this.txt_MCQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MCQ.Location = new System.Drawing.Point(40, 368);
            this.txt_MCQ.Name = "txt_MCQ";
            this.txt_MCQ.Size = new System.Drawing.Size(106, 22);
            this.txt_MCQ.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of MCQ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTF
            // 
            this.labelTF.AutoSize = true;
            this.labelTF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTF.Location = new System.Drawing.Point(36, 203);
            this.labelTF.Name = "labelTF";
            this.labelTF.Size = new System.Drawing.Size(110, 20);
            this.labelTF.TabIndex = 2;
            this.labelTF.Text = "Number of T/F";
            this.labelTF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelcrs
            // 
            this.labelcrs.AutoSize = true;
            this.labelcrs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelcrs.Location = new System.Drawing.Point(40, 85);
            this.labelcrs.Name = "labelcrs";
            this.labelcrs.Size = new System.Drawing.Size(106, 20);
            this.labelcrs.TabIndex = 1;
            this.labelcrs.Text = "Course Name";
            // 
            // examlabel
            // 
            this.examlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.examlabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.examlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.examlabel.Location = new System.Drawing.Point(145, 13);
            this.examlabel.Name = "examlabel";
            this.examlabel.Size = new System.Drawing.Size(106, 37);
            this.examlabel.TabIndex = 0;
            this.examlabel.Text = "Exam ";
            this.examlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // course_panel
            // 
            this.course_panel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.course_panel.Controls.Add(this.courses_grid);
            this.course_panel.Controls.Add(this.crsName);
            this.course_panel.Location = new System.Drawing.Point(55, 73);
            this.course_panel.Name = "course_panel";
            this.course_panel.Size = new System.Drawing.Size(652, 486);
            this.course_panel.TabIndex = 4;
            // 
            // courses_grid
            // 
            this.courses_grid.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.courses_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.courses_grid.GridColor = System.Drawing.SystemColors.HighlightText;
            this.courses_grid.Location = new System.Drawing.Point(16, 52);
            this.courses_grid.Name = "courses_grid";
            this.courses_grid.Size = new System.Drawing.Size(620, 397);
            this.courses_grid.TabIndex = 1;
            // 
            // crsName
            // 
            this.crsName.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.crsName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crsName.ForeColor = System.Drawing.Color.Black;
            this.crsName.Location = new System.Drawing.Point(12, 15);
            this.crsName.Name = "crsName";
            this.crsName.Size = new System.Drawing.Size(86, 33);
            this.crsName.TabIndex = 0;
            this.crsName.Text = "Courses";
            this.crsName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InstructorForm
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
            this.Name = "InstructorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InstructorForm";
            this.Load += new System.EventHandler(this.InstructorForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.generateExam.ResumeLayout(false);
            this.student_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.studentgrd)).EndInit();
            this.examgeneration.ResumeLayout(false);
            this.examgeneration.PerformLayout();
            this.course_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.courses_grid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox InstructorName;
        private System.Windows.Forms.Button button_StudInfo;
        private System.Windows.Forms.Button btn_GenerateExam;
        private System.Windows.Forms.Button button_profile;
        private System.Windows.Forms.Button log_btn;
        private System.Windows.Forms.Panel generateExam;
        private System.Windows.Forms.Panel course_panel;
        private System.Windows.Forms.DataGridView courses_grid;
        private System.Windows.Forms.Label crsName;
        private System.Windows.Forms.Panel examgeneration;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox Txt_TF;
        private System.Windows.Forms.TextBox txt_MCQ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelTF;
        private System.Windows.Forms.Label labelcrs;
        private System.Windows.Forms.Label examlabel;
        private System.Windows.Forms.Panel student_panel;
        private System.Windows.Forms.Label std_info;
        private System.Windows.Forms.DataGridView studentgrd;
    }
}