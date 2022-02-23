
namespace ExaminationSystem
{
    partial class StudentForm
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
            this.label_StudentName = new System.Windows.Forms.TextBox();
            this.button_ShowGrades = new System.Windows.Forms.Button();
            this.button_Exam = new System.Windows.Forms.Button();
            this.button_profile = new System.Windows.Forms.Button();
            this.profile1 = new ExaminationSystem.Profile();
            this.showCoursesGrades1 = new ExaminationSystem.ShowCoursesGrades();
            this.chooseExamCourseForm1 = new ExaminationSystem.ChooseExamCourseForm();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.label_StudentName);
            this.splitContainer1.Panel1.Controls.Add(this.button_ShowGrades);
            this.splitContainer1.Panel1.Controls.Add(this.button_Exam);
            this.splitContainer1.Panel1.Controls.Add(this.button_profile);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.profile1);
            this.splitContainer1.Panel2.Controls.Add(this.showCoursesGrades1);
            this.splitContainer1.Panel2.Controls.Add(this.chooseExamCourseForm1);
            this.splitContainer1.Size = new System.Drawing.Size(976, 596);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 0;
            // 
            // label_StudentName
            // 
            this.label_StudentName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label_StudentName.BackColor = System.Drawing.Color.Brown;
            this.label_StudentName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_StudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_StudentName.ForeColor = System.Drawing.SystemColors.Window;
            this.label_StudentName.Location = new System.Drawing.Point(6, 66);
            this.label_StudentName.Margin = new System.Windows.Forms.Padding(2);
            this.label_StudentName.Multiline = true;
            this.label_StudentName.Name = "label_StudentName";
            this.label_StudentName.Size = new System.Drawing.Size(205, 52);
            this.label_StudentName.TabIndex = 9;
            this.label_StudentName.Text = "StudentName";
            this.label_StudentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.label_StudentName.TextChanged += new System.EventHandler(this.label_StudentName_TextChanged);
            // 
            // button_ShowGrades
            // 
            this.button_ShowGrades.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ShowGrades.BackColor = System.Drawing.Color.Brown;
            this.button_ShowGrades.FlatAppearance.BorderSize = 0;
            this.button_ShowGrades.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_ShowGrades.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ShowGrades.ForeColor = System.Drawing.Color.White;
            this.button_ShowGrades.Location = new System.Drawing.Point(6, 353);
            this.button_ShowGrades.Margin = new System.Windows.Forms.Padding(2);
            this.button_ShowGrades.Name = "button_ShowGrades";
            this.button_ShowGrades.Size = new System.Drawing.Size(210, 48);
            this.button_ShowGrades.TabIndex = 8;
            this.button_ShowGrades.Text = "ShowGrades";
            this.button_ShowGrades.UseVisualStyleBackColor = false;
            this.button_ShowGrades.Click += new System.EventHandler(this.button_ShowGrades_Click);
            // 
            // button_Exam
            // 
            this.button_Exam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Exam.BackColor = System.Drawing.Color.Brown;
            this.button_Exam.FlatAppearance.BorderSize = 0;
            this.button_Exam.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_Exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exam.ForeColor = System.Drawing.Color.White;
            this.button_Exam.Location = new System.Drawing.Point(5, 278);
            this.button_Exam.Margin = new System.Windows.Forms.Padding(2);
            this.button_Exam.Name = "button_Exam";
            this.button_Exam.Size = new System.Drawing.Size(210, 48);
            this.button_Exam.TabIndex = 7;
            this.button_Exam.Text = "Exam";
            this.button_Exam.UseVisualStyleBackColor = false;
            this.button_Exam.Click += new System.EventHandler(this.button_Exam_Click);
            // 
            // button_profile
            // 
            this.button_profile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_profile.BackColor = System.Drawing.Color.Brown;
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
            // profile1
            // 
            this.profile1.AutoSize = true;
            this.profile1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.profile1.Location = new System.Drawing.Point(154, 10);
            this.profile1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.profile1.Name = "profile1";
            this.profile1.Size = new System.Drawing.Size(568, 632);
            this.profile1.TabIndex = 3;
            this.profile1.Load += new System.EventHandler(this.profile1_Load);
            // 
            // showCoursesGrades1
            // 
            this.showCoursesGrades1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.showCoursesGrades1.Location = new System.Drawing.Point(-8, 2);
            this.showCoursesGrades1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showCoursesGrades1.Name = "showCoursesGrades1";
            this.showCoursesGrades1.Size = new System.Drawing.Size(728, 688);
            this.showCoursesGrades1.TabIndex = 2;
            this.showCoursesGrades1.Load += new System.EventHandler(this.showCoursesGrades1_Load);
            // 
            // chooseExamCourseForm1
            // 
            this.chooseExamCourseForm1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseExamCourseForm1.Location = new System.Drawing.Point(147, 47);
            this.chooseExamCourseForm1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chooseExamCourseForm1.Name = "chooseExamCourseForm1";
            this.chooseExamCourseForm1.Size = new System.Drawing.Size(456, 599);
            this.chooseExamCourseForm1.TabIndex = 0;
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(976, 596);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox label_StudentName;
        private System.Windows.Forms.Button button_ShowGrades;
        private System.Windows.Forms.Button button_Exam;
        private System.Windows.Forms.Button button_profile;
        private ChooseExamCourseForm chooseExamCourseForm1;
        private ShowCoursesGrades showCoursesGrades1;
        private Profile profile1;
    }
}