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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region GUI
                //WindowState = FormWindowState.Maximized;
                //Background
                panel1.BackColor = Color.FromArgb(90, 0,0,0);
                label1.BackColor = System.Drawing.Color.Transparent;
                label_Login.BackColor = System.Drawing.Color.Transparent;
                label_Password.BackColor = System.Drawing.Color.Transparent;
                //button1.BackColor = System.Drawing.Color.Transparent;
                //Panel Location in Center
                panel1.Location = new Point(
                this.ClientSize.Width / 2 - panel1.Size.Width / 2,
                this.ClientSize.Height / 2 - panel1.Size.Height / 2);
                panel1.Anchor = AnchorStyles.None;
            #endregion
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Login_Click(object sender, EventArgs e)
        {
                this.Hide();
                StudentForm f1 = new StudentForm();
                f1.ShowDialog();
                this.Close();
        }
    }
}
