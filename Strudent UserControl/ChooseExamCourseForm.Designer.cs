
namespace ExaminationSystem
{
    partial class ChooseExamCourseForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button_StartExam = new ExaminationSystem.RJButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose Course First";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Snow;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(252, 235);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // button_StartExam
            // 
            this.button_StartExam.BackColor = System.Drawing.Color.Crimson;
            this.button_StartExam.BackgroundColor = System.Drawing.Color.Crimson;
            this.button_StartExam.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.button_StartExam.BorderRadius = 20;
            this.button_StartExam.BorderSize = 0;
            this.button_StartExam.FlatAppearance.BorderSize = 0;
            this.button_StartExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_StartExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_StartExam.ForeColor = System.Drawing.Color.White;
            this.button_StartExam.Location = new System.Drawing.Point(234, 382);
            this.button_StartExam.Name = "button_StartExam";
            this.button_StartExam.Size = new System.Drawing.Size(150, 40);
            this.button_StartExam.TabIndex = 8;
            this.button_StartExam.Text = "Start Exam";
            this.button_StartExam.TextColor = System.Drawing.Color.White;
            this.button_StartExam.UseVisualStyleBackColor = false;
            this.button_StartExam.Click += new System.EventHandler(this.button_Login_Click);
            // 
            // ChooseExamCourseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_StartExam);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "ChooseExamCourseForm";
            this.Size = new System.Drawing.Size(649, 624);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private RJButton button_StartExam;
    }
}
