using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExaminationSystem
{
    public partial class ReportForm : Form
    {
        public ReportForm()
        {
            InitializeComponent();
        }
        
        private void StudentForm_Load(object sender, EventArgs e)
        {
            #region Gui

            //Buttons BackGround
            button_rep1.FlatStyle = FlatStyle.Flat;
            button_rep1.BackColor = Color.Transparent;
            button_rep1.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 1, 1, 1);

            button_rep2.FlatStyle = FlatStyle.Flat;
            button_rep2.BackColor = Color.Transparent;
            button_rep2.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 1, 1, 1);

            button_rep3.FlatStyle = FlatStyle.Flat;
            button_rep3.BackColor = Color.Transparent;
            button_rep3.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 1, 1, 1);

            button_rep4.FlatStyle = FlatStyle.Flat;
            button_rep4.BackColor = Color.Transparent;
            button_rep4.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 1, 1, 1);

            button_rep5.FlatStyle = FlatStyle.Flat;
            button_rep5.BackColor = Color.Transparent;
            button_rep5.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 1, 1, 1);

            button_rep6.FlatStyle = FlatStyle.Flat;
            button_rep6.BackColor = Color.Transparent;
            button_rep6.FlatAppearance.MouseOverBackColor = Color.FromArgb(20, 1, 1, 1);

            #endregion


        }

        private void button_rep1_Click(object sender, EventArgs e)
        {
            //Gui
            HideAllCombobox();
            label_rep1.Visible = true;
            comboBox_rep1.Visible = true;



        }

        private void button_rep2_Click(object sender, EventArgs e)
        {
            //Gui
            HideAllCombobox();
            label_rep2.Visible = true;
            comboBox_rep2.Visible = true;
        }

        private void button_rep3_Click(object sender, EventArgs e)
        {
            //Gui
            HideAllCombobox();
            label_rep3.Visible = true;
            comboBox_rep3.Visible = true;
        }

        private void button_rep4_Click(object sender, EventArgs e)
        {
            //Gui
            HideAllCombobox();
            label_rep4.Visible = true;
            comboBox_rep4.Visible = true;
        }

        private void button_rep5_Click(object sender, EventArgs e)
        {
            //Gui
            HideAllCombobox();
            label_rep_5_6.Visible = true;
            comboBox_rep5_6.Visible = true;

        }

        private void button_rep6_Click(object sender, EventArgs e)
        {
            //Gui
            HideAllCombobox();
            label_rep_5_6.Visible = true;
            comboBox_rep5_6.Visible = true;
            label_rep6.Visible = true;
            comboBox_rep6.Visible = true;

        }
        private void HideAllCombobox()
        {
            label_rep_5_6.Visible = false;
            comboBox_rep5_6.Visible = false;
            label_rep6.Visible = false;
            comboBox_rep6.Visible = false;

            label_rep4.Visible = false;
            comboBox_rep4.Visible = false;

            label_rep3.Visible = false;
            comboBox_rep3.Visible = false;

            label_rep2.Visible = false;
            comboBox_rep2.Visible = false;

            label_rep1.Visible = false;
            comboBox_rep1.Visible = false;

            ButtonShowReport.Visible = true;
        }

        private void ButtonShowReport_Click(object sender, EventArgs e)
        {
            if (label_rep1.Visible)
            {
                int DeptIDRep1;
                if (int.TryParse(comboBox_rep1.Text, out int id))
                    DeptIDRep1 = id;
                else
                    DeptIDRep1 = -1;
                DeptIDRep1 = 10; ///////////////////   Try   
                FormReport1 formReport1 = new FormReport1(DeptIDRep1);
                formReport1.ShowDialog();
            }
            if (label_rep2.Visible)
            {
                int StdIDRep2;
                if (int.TryParse(comboBox_rep1.Text, out int id))
                    StdIDRep2 = id;
                else
                    StdIDRep2 = -1;
                StdIDRep2 = 1; ///////////////////   Try   
                FormReport2 formReport2 = new FormReport2(StdIDRep2);
                formReport2.ShowDialog();
            }
            if (label_rep3.Visible)
            {

                int InsIDRep3;
                if (int.TryParse(comboBox_rep3.Text, out int id))
                    InsIDRep3 = id;
                else
                    InsIDRep3 = -1;
                InsIDRep3 = 1; ///////////////////   Try   

                FormReport3 formReport3 = new FormReport3(InsIDRep3);
                formReport3.ShowDialog();
            }

            if (label_rep4.Visible)
            {
                int CrsIDRep4;
                if (int.TryParse(comboBox_rep4.Text, out int id))
                    CrsIDRep4 = id;
                else
                    CrsIDRep4 = -1;
                CrsIDRep4 = 1; ///////////////////   Try   

                FormReport4 formReport4 = new FormReport4(CrsIDRep4);
                formReport4.ShowDialog();
            }
            if(label_rep6.Visible)
            {
                int ExamIDRep6;
                int StudentIDRep6;
                if (int.TryParse(comboBox_rep5_6.Text, out int id))
                    ExamIDRep6 = id;
                else
                    ExamIDRep6 = -1;

                if (int.TryParse(comboBox_rep6.Text, out id))
                    StudentIDRep6 = id;
                else
                    StudentIDRep6 = -1;

                ExamIDRep6 = 1; ///////////////////   Try   
                StudentIDRep6 = 1; ///////////////////   Try   

                FormReport6 formReport6 = new FormReport6(ExamIDRep6,StudentIDRep6);
                formReport6.ShowDialog();
            }
            else if (label_rep_5_6.Visible)
            {
                int ExamIDRep5;
                if (int.TryParse(comboBox_rep5_6.Text, out int id))
                    ExamIDRep5 = id;
                else
                    ExamIDRep5 = -1;
                ExamIDRep5 = 1; ///////////////////   Try   

                FormReport5 formReport5 = new FormReport5(ExamIDRep5);
                formReport5.ShowDialog();
            }

        }
    }
}
