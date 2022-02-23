
namespace ExaminationSystem
{
    partial class ShowCoursesGrades
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CourseNameCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GradeCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseNameCol,
            this.GradeCol});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.Location = new System.Drawing.Point(299, 86);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(480, 527);
            this.dataGridView1.TabIndex = 0;
            // 
            // CourseNameCol
            // 
            this.CourseNameCol.FillWeight = 93.67681F;
            this.CourseNameCol.HeaderText = "CourseName";
            this.CourseNameCol.MinimumWidth = 6;
            this.CourseNameCol.Name = "CourseNameCol";
            this.CourseNameCol.ReadOnly = true;
            this.CourseNameCol.Width = 200;
            // 
            // GradeCol
            // 
            this.GradeCol.FillWeight = 106.3232F;
            this.GradeCol.HeaderText = "Grade";
            this.GradeCol.MinimumWidth = 6;
            this.GradeCol.Name = "GradeCol";
            this.GradeCol.ReadOnly = true;
            this.GradeCol.Width = 227;
            // 
            // ShowCoursesGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Name = "ShowCoursesGrades";
            this.Size = new System.Drawing.Size(1012, 734);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseNameCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn GradeCol;
    }
}
