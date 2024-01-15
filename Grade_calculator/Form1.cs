using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grade_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        List<Student> students = new List<Student>();
        string IDstd ;
        string nameStd ;
        double scoreStd;
        int[] countGrade = new int[8];


       

        public void Save_button_Click(object sender, EventArgs e)
        {

            IDstd = text_IDstd.Text;
            nameStd = text_Name.Text;
            scoreStd = double.Parse(text_Score.Text);
            Student student = new Student();
            student.id = IDstd;
            student.name = nameStd;
            student.score = scoreStd;
            students.Add(student);
            text_Name.Text = string.Empty;
            text_IDstd.Text = string.Empty;
            text_Score.Text = string.Empty;

            double max_score = 0;
            foreach (Student std in students)
            {
                if (std.score > max_score)
                {
                    max_score = std.score;
                    IDstd_max.Text = std.id;
                    nameStd_max.Text = std.name;
                    scoreStd_max.Text = std.score.ToString();
                }
            }

            double min_score = max_score;
            foreach(Student std in students)
            {
                if (std.score < min_score)
                {
                    min_score = std.score;
                    IDstd_min.Text = std.id;
                    nameStd_min.Text = std.name;
                    scoreStd_min.Text = std.score.ToString();
                }
            }

            double Sum_score = 0;
            foreach(Student std in students)
            {
                Sum_score += std.score;
            }
            AVG_score.Text = (Sum_score / students.Count).ToString("0.00");

            if (student.score >= 80 && student.score <= 100)
            {
                countGrade[0]++;
                A_box.Text = countGrade[0].ToString();
            }
            else if (student.score >= 75 && student.score <= 79)
            {
                countGrade[1]++;
                BB_box.Text = countGrade[1].ToString();
            }
            else if (student.score >= 70 && student.score <= 74)
            {
                countGrade[2]++;
                B_box.Text = countGrade[2].ToString();
            }
            else if (student.score  >= 65 && student.score <= 69)
            {
                countGrade[3]++;
                CC_box.Text = countGrade[3].ToString();
            }
            else if (student.score >= 60 && student.score <= 64)
            {
                countGrade[4] += 1;
                C_box.Text = countGrade[4].ToString();
            }
            else if (student.score >= 55 && student.score <= 59)
            {
                countGrade[5] += 1;
                DD_box.Text = countGrade[5].ToString();
            }
            else if (student.score >= 50 && student.score <= 54)
            {
                countGrade[6] += 1;
                D_box.Text = countGrade[6].ToString();
            }
            else
            {
                countGrade[7] += 1;
                F_box.Text = countGrade[7].ToString();
            }

            double[] weight_grade = { 4.0, 3.5, 3.0 , 2.5 , 2.0 , 1.5 , 1.0 };
            double sum_weight = 0;
            for (int i = 0; i < weight_grade.Length; i++)
            {
                sum_weight += weight_grade[i] * countGrade[i];
            }

            GPA_box.Text = (sum_weight / students.Count).ToString("0.00");
        }

    }
}
