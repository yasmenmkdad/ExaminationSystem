using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Drawing.Drawing2D;

namespace ExaminationSystem
{
    partial class ReportForm
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
            this.button_rep6 = new System.Windows.Forms.Button();
            this.button_rep5 = new System.Windows.Forms.Button();
            this.button_rep4 = new System.Windows.Forms.Button();
            this.button_rep3 = new System.Windows.Forms.Button();
            this.button_rep2 = new System.Windows.Forms.Button();
            this.button_rep1 = new System.Windows.Forms.Button();
            this.ButtonShowReport = new ExaminationSystem.RJButton();
            this.comboBox_rep6 = new System.Windows.Forms.ComboBox();
            this.label_rep6 = new System.Windows.Forms.Label();
            this.comboBox_rep5_6 = new System.Windows.Forms.ComboBox();
            this.label_rep_5_6 = new System.Windows.Forms.Label();
            this.comboBox_rep4 = new System.Windows.Forms.ComboBox();
            this.label_rep4 = new System.Windows.Forms.Label();
            this.comboBox_rep3 = new System.Windows.Forms.ComboBox();
            this.label_rep3 = new System.Windows.Forms.Label();
            this.comboBox_rep2 = new System.Windows.Forms.ComboBox();
            this.label_rep2 = new System.Windows.Forms.Label();
            this.label_rep1 = new System.Windows.Forms.Label();
            this.comboBox_rep1 = new System.Windows.Forms.ComboBox();
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Brown;
            this.splitContainer1.Panel1.Controls.Add(this.button_rep6);
            this.splitContainer1.Panel1.Controls.Add(this.button_rep5);
            this.splitContainer1.Panel1.Controls.Add(this.button_rep4);
            this.splitContainer1.Panel1.Controls.Add(this.button_rep3);
            this.splitContainer1.Panel1.Controls.Add(this.button_rep2);
            this.splitContainer1.Panel1.Controls.Add(this.button_rep1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.ButtonShowReport);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox_rep6);
            this.splitContainer1.Panel2.Controls.Add(this.label_rep6);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox_rep5_6);
            this.splitContainer1.Panel2.Controls.Add(this.label_rep_5_6);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox_rep4);
            this.splitContainer1.Panel2.Controls.Add(this.label_rep4);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox_rep3);
            this.splitContainer1.Panel2.Controls.Add(this.label_rep3);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox_rep2);
            this.splitContainer1.Panel2.Controls.Add(this.label_rep2);
            this.splitContainer1.Panel2.Controls.Add(this.label_rep1);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox_rep1);
            this.splitContainer1.Size = new System.Drawing.Size(1301, 734);
            this.splitContainer1.SplitterDistance = 293;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_rep6
            // 
            this.button_rep6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_rep6.BackColor = System.Drawing.Color.Brown;
            this.button_rep6.FlatAppearance.BorderSize = 0;
            this.button_rep6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_rep6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rep6.ForeColor = System.Drawing.Color.White;
            this.button_rep6.Location = new System.Drawing.Point(8, 606);
            this.button_rep6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_rep6.Name = "button_rep6";
            this.button_rep6.Size = new System.Drawing.Size(280, 115);
            this.button_rep6.TabIndex = 12;
            this.button_rep6.Text = "Show Answer of student in Exam";
            this.button_rep6.UseVisualStyleBackColor = false;
            this.button_rep6.Click += new System.EventHandler(this.button_rep6_Click);
            // 
            // button_rep5
            // 
            this.button_rep5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_rep5.BackColor = System.Drawing.Color.Brown;
            this.button_rep5.FlatAppearance.BorderSize = 0;
            this.button_rep5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_rep5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rep5.ForeColor = System.Drawing.Color.White;
            this.button_rep5.Location = new System.Drawing.Point(8, 518);
            this.button_rep5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_rep5.Name = "button_rep5";
            this.button_rep5.Size = new System.Drawing.Size(280, 70);
            this.button_rep5.TabIndex = 11;
            this.button_rep5.Text = "Show Exam";
            this.button_rep5.UseVisualStyleBackColor = false;
            this.button_rep5.Click += new System.EventHandler(this.button_rep5_Click);
            // 
            // button_rep4
            // 
            this.button_rep4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_rep4.BackColor = System.Drawing.Color.Brown;
            this.button_rep4.FlatAppearance.BorderSize = 0;
            this.button_rep4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_rep4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rep4.ForeColor = System.Drawing.Color.White;
            this.button_rep4.Location = new System.Drawing.Point(10, 427);
            this.button_rep4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_rep4.Name = "button_rep4";
            this.button_rep4.Size = new System.Drawing.Size(280, 70);
            this.button_rep4.TabIndex = 10;
            this.button_rep4.Text = "Show topics of cource";
            this.button_rep4.UseVisualStyleBackColor = false;
            this.button_rep4.Click += new System.EventHandler(this.button_rep4_Click);
            // 
            // button_rep3
            // 
            this.button_rep3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_rep3.BackColor = System.Drawing.Color.Brown;
            this.button_rep3.FlatAppearance.BorderSize = 0;
            this.button_rep3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_rep3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rep3.ForeColor = System.Drawing.Color.White;
            this.button_rep3.Location = new System.Drawing.Point(8, 293);
            this.button_rep3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_rep3.Name = "button_rep3";
            this.button_rep3.Size = new System.Drawing.Size(280, 115);
            this.button_rep3.TabIndex = 8;
            this.button_rep3.Text = "Show courses instructor teaches and total student in course";
            this.button_rep3.UseVisualStyleBackColor = false;
            this.button_rep3.Click += new System.EventHandler(this.button_rep3_Click);
            // 
            // button_rep2
            // 
            this.button_rep2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_rep2.BackColor = System.Drawing.Color.Brown;
            this.button_rep2.FlatAppearance.BorderSize = 0;
            this.button_rep2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_rep2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rep2.ForeColor = System.Drawing.Color.White;
            this.button_rep2.Location = new System.Drawing.Point(10, 155);
            this.button_rep2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_rep2.Name = "button_rep2";
            this.button_rep2.Size = new System.Drawing.Size(280, 115);
            this.button_rep2.TabIndex = 7;
            this.button_rep2.Text = " Show the grades of the student in all courses";
            this.button_rep2.UseVisualStyleBackColor = false;
            this.button_rep2.Click += new System.EventHandler(this.button_rep2_Click);
            // 
            // button_rep1
            // 
            this.button_rep1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_rep1.BackColor = System.Drawing.Color.Brown;
            this.button_rep1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_rep1.FlatAppearance.BorderSize = 0;
            this.button_rep1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button_rep1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_rep1.ForeColor = System.Drawing.Color.White;
            this.button_rep1.Location = new System.Drawing.Point(8, 14);
            this.button_rep1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_rep1.Name = "button_rep1";
            this.button_rep1.Size = new System.Drawing.Size(280, 115);
            this.button_rep1.TabIndex = 6;
            this.button_rep1.Text = "Show students information according to Department";
            this.button_rep1.UseVisualStyleBackColor = false;
            this.button_rep1.Click += new System.EventHandler(this.button_rep1_Click);
            // 
            // ButtonShowReport
            // 
            this.ButtonShowReport.BackColor = System.Drawing.Color.Brown;
            this.ButtonShowReport.BackgroundColor = System.Drawing.Color.Brown;
            this.ButtonShowReport.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.ButtonShowReport.BorderRadius = 20;
            this.ButtonShowReport.BorderSize = 0;
            this.ButtonShowReport.FlatAppearance.BorderSize = 0;
            this.ButtonShowReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonShowReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonShowReport.ForeColor = System.Drawing.Color.White;
            this.ButtonShowReport.Location = new System.Drawing.Point(342, 427);
            this.ButtonShowReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButtonShowReport.Name = "ButtonShowReport";
            this.ButtonShowReport.Size = new System.Drawing.Size(149, 39);
            this.ButtonShowReport.TabIndex = 13;
            this.ButtonShowReport.Text = "Show";
            this.ButtonShowReport.TextColor = System.Drawing.Color.White;
            this.ButtonShowReport.UseVisualStyleBackColor = false;
            this.ButtonShowReport.Visible = false;
            this.ButtonShowReport.Click += new System.EventHandler(this.ButtonShowReport_Click);
            // 
            // comboBox_rep6
            // 
            this.comboBox_rep6.FormattingEnabled = true;
            this.comboBox_rep6.Location = new System.Drawing.Point(409, 306);
            this.comboBox_rep6.Name = "comboBox_rep6";
            this.comboBox_rep6.Size = new System.Drawing.Size(182, 24);
            this.comboBox_rep6.TabIndex = 12;
            this.comboBox_rep6.Visible = false;
            // 
            // label_rep6
            // 
            this.label_rep6.AutoSize = true;
            this.label_rep6.Location = new System.Drawing.Point(252, 309);
            this.label_rep6.Name = "label_rep6";
            this.label_rep6.Size = new System.Drawing.Size(74, 17);
            this.label_rep6.TabIndex = 11;
            this.label_rep6.Text = "Student ID";
            this.label_rep6.Visible = false;
            // 
            // comboBox_rep5_6
            // 
            this.comboBox_rep5_6.FormattingEnabled = true;
            this.comboBox_rep5_6.Location = new System.Drawing.Point(409, 233);
            this.comboBox_rep5_6.Name = "comboBox_rep5_6";
            this.comboBox_rep5_6.Size = new System.Drawing.Size(182, 24);
            this.comboBox_rep5_6.TabIndex = 10;
            this.comboBox_rep5_6.Visible = false;
            // 
            // label_rep_5_6
            // 
            this.label_rep_5_6.AutoSize = true;
            this.label_rep_5_6.Location = new System.Drawing.Point(252, 236);
            this.label_rep_5_6.Name = "label_rep_5_6";
            this.label_rep_5_6.Size = new System.Drawing.Size(94, 17);
            this.label_rep_5_6.TabIndex = 9;
            this.label_rep_5_6.Text = "Exam number";
            this.label_rep_5_6.Visible = false;
            // 
            // comboBox_rep4
            // 
            this.comboBox_rep4.FormattingEnabled = true;
            this.comboBox_rep4.Location = new System.Drawing.Point(409, 233);
            this.comboBox_rep4.Name = "comboBox_rep4";
            this.comboBox_rep4.Size = new System.Drawing.Size(182, 24);
            this.comboBox_rep4.TabIndex = 8;
            this.comboBox_rep4.Visible = false;
            // 
            // label_rep4
            // 
            this.label_rep4.AutoSize = true;
            this.label_rep4.Location = new System.Drawing.Point(267, 233);
            this.label_rep4.Name = "label_rep4";
            this.label_rep4.Size = new System.Drawing.Size(70, 17);
            this.label_rep4.TabIndex = 7;
            this.label_rep4.Text = "Course ID";
            this.label_rep4.Visible = false;
            // 
            // comboBox_rep3
            // 
            this.comboBox_rep3.FormattingEnabled = true;
            this.comboBox_rep3.Location = new System.Drawing.Point(409, 233);
            this.comboBox_rep3.Name = "comboBox_rep3";
            this.comboBox_rep3.Size = new System.Drawing.Size(182, 24);
            this.comboBox_rep3.TabIndex = 6;
            this.comboBox_rep3.Visible = false;
            // 
            // label_rep3
            // 
            this.label_rep3.AutoSize = true;
            this.label_rep3.Location = new System.Drawing.Point(267, 233);
            this.label_rep3.Name = "label_rep3";
            this.label_rep3.Size = new System.Drawing.Size(84, 17);
            this.label_rep3.TabIndex = 5;
            this.label_rep3.Text = "Instructor ID";
            this.label_rep3.Visible = false;
            // 
            // comboBox_rep2
            // 
            this.comboBox_rep2.FormattingEnabled = true;
            this.comboBox_rep2.Location = new System.Drawing.Point(409, 233);
            this.comboBox_rep2.Name = "comboBox_rep2";
            this.comboBox_rep2.Size = new System.Drawing.Size(182, 24);
            this.comboBox_rep2.TabIndex = 4;
            this.comboBox_rep2.Visible = false;
            // 
            // label_rep2
            // 
            this.label_rep2.AutoSize = true;
            this.label_rep2.Location = new System.Drawing.Point(277, 236);
            this.label_rep2.Name = "label_rep2";
            this.label_rep2.Size = new System.Drawing.Size(74, 17);
            this.label_rep2.TabIndex = 3;
            this.label_rep2.Text = "Student ID";
            this.label_rep2.Visible = false;
            // 
            // label_rep1
            // 
            this.label_rep1.AutoSize = true;
            this.label_rep1.Location = new System.Drawing.Point(252, 236);
            this.label_rep1.Name = "label_rep1";
            this.label_rep1.Size = new System.Drawing.Size(99, 17);
            this.label_rep1.TabIndex = 1;
            this.label_rep1.Text = "Department ID";
            this.label_rep1.Visible = false;
            // 
            // comboBox_rep1
            // 
            this.comboBox_rep1.FormattingEnabled = true;
            this.comboBox_rep1.Location = new System.Drawing.Point(409, 233);
            this.comboBox_rep1.Name = "comboBox_rep1";
            this.comboBox_rep1.Size = new System.Drawing.Size(182, 24);
            this.comboBox_rep1.TabIndex = 0;
            this.comboBox_rep1.Visible = false;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1301, 734);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.Load += new System.EventHandler(this.StudentForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_rep3;
        private System.Windows.Forms.Button button_rep2;
        private System.Windows.Forms.Button button_rep1;
        private Button button_rep6;
        private Button button_rep5;
        private Button button_rep4;
        private ComboBox comboBox_rep6;
        private Label label_rep6;
        private ComboBox comboBox_rep5_6;
        private Label label_rep_5_6;
        private ComboBox comboBox_rep4;
        private Label label_rep4;
        private ComboBox comboBox_rep3;
        private Label label_rep3;
        private ComboBox comboBox_rep2;
        private Label label_rep2;
        private Label label_rep1;
        private ComboBox comboBox_rep1;
        private RJButton ButtonShowReport;
    }
}