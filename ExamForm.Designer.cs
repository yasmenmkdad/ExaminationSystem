
namespace ExaminationSystem
{
    partial class ExamForm
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
            this.label_Question = new System.Windows.Forms.TextBox();
            this.button_RigthArrow = new System.Windows.Forms.Button();
            this.button_LeftArrow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Question
            // 
            this.label_Question.BackColor = System.Drawing.Color.White;
            this.label_Question.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.label_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Question.ForeColor = System.Drawing.Color.Black;
            this.label_Question.Location = new System.Drawing.Point(216, 109);
            this.label_Question.Multiline = true;
            this.label_Question.Name = "label_Question";
            this.label_Question.Size = new System.Drawing.Size(917, 109);
            this.label_Question.TabIndex = 6;
            this.label_Question.Text = "Question";
            this.label_Question.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button_RigthArrow
            // 
            this.button_RigthArrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_RigthArrow.BackgroundImage = global::ExaminationSystem.Properties.Resources.RightArrow;
            this.button_RigthArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_RigthArrow.FlatAppearance.BorderSize = 0;
            this.button_RigthArrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_RigthArrow.ForeColor = System.Drawing.Color.White;
            this.button_RigthArrow.Location = new System.Drawing.Point(1066, 599);
            this.button_RigthArrow.Margin = new System.Windows.Forms.Padding(10);
            this.button_RigthArrow.Name = "button_RigthArrow";
            this.button_RigthArrow.Size = new System.Drawing.Size(156, 91);
            this.button_RigthArrow.TabIndex = 7;
            this.button_RigthArrow.UseVisualStyleBackColor = true;
            this.button_RigthArrow.Click += new System.EventHandler(this.button_RigthArrow_Click);
            // 
            // button_LeftArrow
            // 
            this.button_LeftArrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_LeftArrow.BackgroundImage = global::ExaminationSystem.Properties.Resources.RightLeft;
            this.button_LeftArrow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_LeftArrow.FlatAppearance.BorderSize = 0;
            this.button_LeftArrow.Location = new System.Drawing.Point(83, 599);
            this.button_LeftArrow.Margin = new System.Windows.Forms.Padding(10);
            this.button_LeftArrow.Name = "button_LeftArrow";
            this.button_LeftArrow.Size = new System.Drawing.Size(156, 91);
            this.button_LeftArrow.TabIndex = 8;
            this.button_LeftArrow.UseVisualStyleBackColor = true;
            this.button_LeftArrow.Click += new System.EventHandler(this.button_LeftArrow_Click);
            // 
            // ExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1302, 733);
            this.Controls.Add(this.button_LeftArrow);
            this.Controls.Add(this.button_RigthArrow);
            this.Controls.Add(this.label_Question);
            this.Name = "ExamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ExamForm";
            this.Load += new System.EventHandler(this.ExamForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox label_Question;
        private System.Windows.Forms.Button button_RigthArrow;
        private System.Windows.Forms.Button button_LeftArrow;
    }
}