namespace Grade_calculator
{
    partial class Form1
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
            this.text_IDstd = new System.Windows.Forms.TextBox();
            this.student_id_label = new System.Windows.Forms.Label();
            this.text_Name = new System.Windows.Forms.TextBox();
            this.name_label = new System.Windows.Forms.Label();
            this.text_Score = new System.Windows.Forms.TextBox();
            this.point_label = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.IDstd_max = new System.Windows.Forms.TextBox();
            this.IDstd_min = new System.Windows.Forms.TextBox();
            this.nameStd_max = new System.Windows.Forms.TextBox();
            this.nameStd_min = new System.Windows.Forms.TextBox();
            this.scoreStd_max = new System.Windows.Forms.TextBox();
            this.scoreStd_min = new System.Windows.Forms.TextBox();
            this.AVG_score = new System.Windows.Forms.TextBox();
            this.avg_point_label = new System.Windows.Forms.Label();
            this.max_point_label = new System.Windows.Forms.Label();
            this.min_point_label = new System.Windows.Forms.Label();
            this.student_id_label2 = new System.Windows.Forms.Label();
            this.name_label2 = new System.Windows.Forms.Label();
            this.point_label2 = new System.Windows.Forms.Label();
            this.group_enter_data_box = new System.Windows.Forms.GroupBox();
            this.group_result_box = new System.Windows.Forms.GroupBox();
            this.label_avg = new System.Windows.Forms.Label();
            this.GPA_box = new System.Windows.Forms.TextBox();
            this.label_F = new System.Windows.Forms.Label();
            this.F_box = new System.Windows.Forms.TextBox();
            this.label_D_box = new System.Windows.Forms.Label();
            this.D_box = new System.Windows.Forms.TextBox();
            this.label_D_plus = new System.Windows.Forms.Label();
            this.DD_box = new System.Windows.Forms.TextBox();
            this.label_C = new System.Windows.Forms.Label();
            this.C_box = new System.Windows.Forms.TextBox();
            this.label_C_plus = new System.Windows.Forms.Label();
            this.CC_box = new System.Windows.Forms.TextBox();
            this.label_B = new System.Windows.Forms.Label();
            this.B_box = new System.Windows.Forms.TextBox();
            this.label_B_plus = new System.Windows.Forms.Label();
            this.BB_box = new System.Windows.Forms.TextBox();
            this.label_A = new System.Windows.Forms.Label();
            this.A_box = new System.Windows.Forms.TextBox();
            this.group_enter_data_box.SuspendLayout();
            this.group_result_box.SuspendLayout();
            this.SuspendLayout();
            // 
            // text_IDstd
            // 
            this.text_IDstd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_IDstd.Location = new System.Drawing.Point(168, 35);
            this.text_IDstd.Name = "text_IDstd";
            this.text_IDstd.Size = new System.Drawing.Size(100, 30);
            this.text_IDstd.TabIndex = 1;
            // 
            // student_id_label
            // 
            this.student_id_label.AutoSize = true;
            this.student_id_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_id_label.Location = new System.Drawing.Point(27, 35);
            this.student_id_label.Name = "student_id_label";
            this.student_id_label.Size = new System.Drawing.Size(136, 29);
            this.student_id_label.TabIndex = 2;
            this.student_id_label.Text = "รหัสนักศึกษา";
            this.student_id_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // text_Name
            // 
            this.text_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Name.Location = new System.Drawing.Point(168, 80);
            this.text_Name.Name = "text_Name";
            this.text_Name.Size = new System.Drawing.Size(100, 30);
            this.text_Name.TabIndex = 3;
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label.Location = new System.Drawing.Point(27, 80);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(125, 29);
            this.name_label.TabIndex = 4;
            this.name_label.Text = "ชื่อ-นามสกุล";
            // 
            // text_Score
            // 
            this.text_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_Score.Location = new System.Drawing.Point(168, 131);
            this.text_Score.Name = "text_Score";
            this.text_Score.Size = new System.Drawing.Size(100, 30);
            this.text_Score.TabIndex = 5;
            // 
            // point_label
            // 
            this.point_label.AutoSize = true;
            this.point_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point_label.Location = new System.Drawing.Point(27, 131);
            this.point_label.Name = "point_label";
            this.point_label.Size = new System.Drawing.Size(83, 29);
            this.point_label.TabIndex = 6;
            this.point_label.Text = "คะแนน";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(168, 182);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(90, 50);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = " บักทึก";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // IDstd_max
            // 
            this.IDstd_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDstd_max.Location = new System.Drawing.Point(472, 100);
            this.IDstd_max.Name = "IDstd_max";
            this.IDstd_max.Size = new System.Drawing.Size(117, 30);
            this.IDstd_max.TabIndex = 8;
            // 
            // IDstd_min
            // 
            this.IDstd_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDstd_min.Location = new System.Drawing.Point(472, 149);
            this.IDstd_min.Name = "IDstd_min";
            this.IDstd_min.Size = new System.Drawing.Size(117, 30);
            this.IDstd_min.TabIndex = 9;
            // 
            // nameStd_max
            // 
            this.nameStd_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameStd_max.Location = new System.Drawing.Point(595, 100);
            this.nameStd_max.Name = "nameStd_max";
            this.nameStd_max.Size = new System.Drawing.Size(124, 30);
            this.nameStd_max.TabIndex = 9;
            // 
            // nameStd_min
            // 
            this.nameStd_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameStd_min.Location = new System.Drawing.Point(595, 151);
            this.nameStd_min.Name = "nameStd_min";
            this.nameStd_min.Size = new System.Drawing.Size(124, 30);
            this.nameStd_min.TabIndex = 10;
            // 
            // scoreStd_max
            // 
            this.scoreStd_max.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreStd_max.Location = new System.Drawing.Point(728, 100);
            this.scoreStd_max.Name = "scoreStd_max";
            this.scoreStd_max.Size = new System.Drawing.Size(125, 30);
            this.scoreStd_max.TabIndex = 11;
            // 
            // scoreStd_min
            // 
            this.scoreStd_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreStd_min.Location = new System.Drawing.Point(728, 151);
            this.scoreStd_min.Name = "scoreStd_min";
            this.scoreStd_min.Size = new System.Drawing.Size(125, 30);
            this.scoreStd_min.TabIndex = 12;
            // 
            // AVG_score
            // 
            this.AVG_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AVG_score.Location = new System.Drawing.Point(728, 212);
            this.AVG_score.Name = "AVG_score";
            this.AVG_score.Size = new System.Drawing.Size(125, 30);
            this.AVG_score.TabIndex = 13;
            // 
            // avg_point_label
            // 
            this.avg_point_label.AutoSize = true;
            this.avg_point_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avg_point_label.Location = new System.Drawing.Point(588, 212);
            this.avg_point_label.Name = "avg_point_label";
            this.avg_point_label.Size = new System.Drawing.Size(131, 29);
            this.avg_point_label.TabIndex = 14;
            this.avg_point_label.Text = "คะแนนเฉลี่ย";
            // 
            // max_point_label
            // 
            this.max_point_label.AutoSize = true;
            this.max_point_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_point_label.Location = new System.Drawing.Point(334, 100);
            this.max_point_label.Name = "max_point_label";
            this.max_point_label.Size = new System.Drawing.Size(132, 29);
            this.max_point_label.TabIndex = 15;
            this.max_point_label.Text = "คะแนนสูงสุด";
            // 
            // min_point_label
            // 
            this.min_point_label.AutoSize = true;
            this.min_point_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.min_point_label.Location = new System.Drawing.Point(334, 151);
            this.min_point_label.Name = "min_point_label";
            this.min_point_label.Size = new System.Drawing.Size(132, 29);
            this.min_point_label.TabIndex = 16;
            this.min_point_label.Text = "คะแนนต่ำสุด";
            // 
            // student_id_label2
            // 
            this.student_id_label2.AutoSize = true;
            this.student_id_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_id_label2.Location = new System.Drawing.Point(467, 53);
            this.student_id_label2.Name = "student_id_label2";
            this.student_id_label2.Size = new System.Drawing.Size(136, 29);
            this.student_id_label2.TabIndex = 17;
            this.student_id_label2.Text = "รหัสนักศึกษา";
            // 
            // name_label2
            // 
            this.name_label2.AutoSize = true;
            this.name_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_label2.Location = new System.Drawing.Point(594, 53);
            this.name_label2.Name = "name_label2";
            this.name_label2.Size = new System.Drawing.Size(125, 29);
            this.name_label2.TabIndex = 18;
            this.name_label2.Text = "ชื่อ-นามสกุล";
            // 
            // point_label2
            // 
            this.point_label2.AutoSize = true;
            this.point_label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.point_label2.Location = new System.Drawing.Point(749, 53);
            this.point_label2.Name = "point_label2";
            this.point_label2.Size = new System.Drawing.Size(83, 29);
            this.point_label2.TabIndex = 19;
            this.point_label2.Text = "คะแนน";
            // 
            // group_enter_data_box
            // 
            this.group_enter_data_box.Controls.Add(this.student_id_label);
            this.group_enter_data_box.Controls.Add(this.text_IDstd);
            this.group_enter_data_box.Controls.Add(this.text_Name);
            this.group_enter_data_box.Controls.Add(this.name_label);
            this.group_enter_data_box.Controls.Add(this.text_Score);
            this.group_enter_data_box.Controls.Add(this.point_label);
            this.group_enter_data_box.Controls.Add(this.SaveBtn);
            this.group_enter_data_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_enter_data_box.Location = new System.Drawing.Point(58, 63);
            this.group_enter_data_box.Name = "group_enter_data_box";
            this.group_enter_data_box.Size = new System.Drawing.Size(335, 254);
            this.group_enter_data_box.TabIndex = 20;
            this.group_enter_data_box.TabStop = false;
            this.group_enter_data_box.Text = "ส่วนข้อมูล";
            // 
            // group_result_box
            // 
            this.group_result_box.Controls.Add(this.label_avg);
            this.group_result_box.Controls.Add(this.GPA_box);
            this.group_result_box.Controls.Add(this.label_F);
            this.group_result_box.Controls.Add(this.F_box);
            this.group_result_box.Controls.Add(this.label_D_box);
            this.group_result_box.Controls.Add(this.D_box);
            this.group_result_box.Controls.Add(this.label_D_plus);
            this.group_result_box.Controls.Add(this.DD_box);
            this.group_result_box.Controls.Add(this.label_C);
            this.group_result_box.Controls.Add(this.C_box);
            this.group_result_box.Controls.Add(this.label_C_plus);
            this.group_result_box.Controls.Add(this.CC_box);
            this.group_result_box.Controls.Add(this.label_B);
            this.group_result_box.Controls.Add(this.B_box);
            this.group_result_box.Controls.Add(this.label_B_plus);
            this.group_result_box.Controls.Add(this.BB_box);
            this.group_result_box.Controls.Add(this.label_A);
            this.group_result_box.Controls.Add(this.A_box);
            this.group_result_box.Controls.Add(this.nameStd_min);
            this.group_result_box.Controls.Add(this.IDstd_max);
            this.group_result_box.Controls.Add(this.point_label2);
            this.group_result_box.Controls.Add(this.IDstd_min);
            this.group_result_box.Controls.Add(this.name_label2);
            this.group_result_box.Controls.Add(this.nameStd_max);
            this.group_result_box.Controls.Add(this.student_id_label2);
            this.group_result_box.Controls.Add(this.scoreStd_max);
            this.group_result_box.Controls.Add(this.min_point_label);
            this.group_result_box.Controls.Add(this.scoreStd_min);
            this.group_result_box.Controls.Add(this.max_point_label);
            this.group_result_box.Controls.Add(this.AVG_score);
            this.group_result_box.Controls.Add(this.avg_point_label);
            this.group_result_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_result_box.Location = new System.Drawing.Point(472, 63);
            this.group_result_box.Name = "group_result_box";
            this.group_result_box.Size = new System.Drawing.Size(902, 586);
            this.group_result_box.TabIndex = 21;
            this.group_result_box.TabStop = false;
            this.group_result_box.Text = "ส่วนผลลัพธ์";
            // 
            // label_avg
            // 
            this.label_avg.AutoSize = true;
            this.label_avg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_avg.Location = new System.Drawing.Point(10, 532);
            this.label_avg.Name = "label_avg";
            this.label_avg.Size = new System.Drawing.Size(109, 29);
            this.label_avg.TabIndex = 37;
            this.label_avg.Text = "เกรดเฉลี่ย";
            // 
            // GPA_box
            // 
            this.GPA_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPA_box.Location = new System.Drawing.Point(114, 529);
            this.GPA_box.Name = "GPA_box";
            this.GPA_box.Size = new System.Drawing.Size(126, 30);
            this.GPA_box.TabIndex = 36;
            // 
            // label_F
            // 
            this.label_F.AutoSize = true;
            this.label_F.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_F.Location = new System.Drawing.Point(51, 470);
            this.label_F.Name = "label_F";
            this.label_F.Size = new System.Drawing.Size(28, 29);
            this.label_F.TabIndex = 35;
            this.label_F.Text = "F";
            // 
            // F_box
            // 
            this.F_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.F_box.Location = new System.Drawing.Point(114, 467);
            this.F_box.Name = "F_box";
            this.F_box.Size = new System.Drawing.Size(126, 30);
            this.F_box.TabIndex = 34;
            // 
            // label_D_box
            // 
            this.label_D_box.AutoSize = true;
            this.label_D_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_D_box.Location = new System.Drawing.Point(51, 416);
            this.label_D_box.Name = "label_D_box";
            this.label_D_box.Size = new System.Drawing.Size(30, 29);
            this.label_D_box.TabIndex = 33;
            this.label_D_box.Text = "D";
            // 
            // D_box
            // 
            this.D_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.D_box.Location = new System.Drawing.Point(114, 413);
            this.D_box.Name = "D_box";
            this.D_box.Size = new System.Drawing.Size(126, 30);
            this.D_box.TabIndex = 32;
            // 
            // label_D_plus
            // 
            this.label_D_plus.AutoSize = true;
            this.label_D_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_D_plus.Location = new System.Drawing.Point(51, 358);
            this.label_D_plus.Name = "label_D_plus";
            this.label_D_plus.Size = new System.Drawing.Size(44, 29);
            this.label_D_plus.TabIndex = 31;
            this.label_D_plus.Text = "D+";
            // 
            // DD_box
            // 
            this.DD_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DD_box.Location = new System.Drawing.Point(114, 355);
            this.DD_box.Name = "DD_box";
            this.DD_box.Size = new System.Drawing.Size(126, 30);
            this.DD_box.TabIndex = 30;
            // 
            // label_C
            // 
            this.label_C.AutoSize = true;
            this.label_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_C.Location = new System.Drawing.Point(51, 305);
            this.label_C.Name = "label_C";
            this.label_C.Size = new System.Drawing.Size(30, 29);
            this.label_C.TabIndex = 29;
            this.label_C.Text = "C";
            // 
            // C_box
            // 
            this.C_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.C_box.Location = new System.Drawing.Point(114, 302);
            this.C_box.Name = "C_box";
            this.C_box.Size = new System.Drawing.Size(126, 30);
            this.C_box.TabIndex = 28;
            // 
            // label_C_plus
            // 
            this.label_C_plus.AutoSize = true;
            this.label_C_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_C_plus.Location = new System.Drawing.Point(51, 257);
            this.label_C_plus.Name = "label_C_plus";
            this.label_C_plus.Size = new System.Drawing.Size(44, 29);
            this.label_C_plus.TabIndex = 27;
            this.label_C_plus.Text = "C+";
            // 
            // CC_box
            // 
            this.CC_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CC_box.Location = new System.Drawing.Point(114, 254);
            this.CC_box.Name = "CC_box";
            this.CC_box.Size = new System.Drawing.Size(126, 30);
            this.CC_box.TabIndex = 26;
            // 
            // label_B
            // 
            this.label_B.AutoSize = true;
            this.label_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_B.Location = new System.Drawing.Point(51, 203);
            this.label_B.Name = "label_B";
            this.label_B.Size = new System.Drawing.Size(29, 29);
            this.label_B.TabIndex = 25;
            this.label_B.Text = "B";
            // 
            // B_box
            // 
            this.B_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_box.Location = new System.Drawing.Point(114, 200);
            this.B_box.Name = "B_box";
            this.B_box.Size = new System.Drawing.Size(126, 30);
            this.B_box.TabIndex = 24;
            // 
            // label_B_plus
            // 
            this.label_B_plus.AutoSize = true;
            this.label_B_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_B_plus.Location = new System.Drawing.Point(51, 156);
            this.label_B_plus.Name = "label_B_plus";
            this.label_B_plus.Size = new System.Drawing.Size(43, 29);
            this.label_B_plus.TabIndex = 23;
            this.label_B_plus.Text = "B+";
            // 
            // BB_box
            // 
            this.BB_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BB_box.Location = new System.Drawing.Point(114, 153);
            this.BB_box.Name = "BB_box";
            this.BB_box.Size = new System.Drawing.Size(126, 30);
            this.BB_box.TabIndex = 22;
            // 
            // label_A
            // 
            this.label_A.AutoSize = true;
            this.label_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_A.Location = new System.Drawing.Point(51, 107);
            this.label_A.Name = "label_A";
            this.label_A.Size = new System.Drawing.Size(28, 29);
            this.label_A.TabIndex = 21;
            this.label_A.Text = "A";
            // 
            // A_box
            // 
            this.A_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A_box.Location = new System.Drawing.Point(114, 104);
            this.A_box.Name = "A_box";
            this.A_box.Size = new System.Drawing.Size(126, 30);
            this.A_box.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 724);
            this.Controls.Add(this.group_result_box);
            this.Controls.Add(this.group_enter_data_box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.group_enter_data_box.ResumeLayout(false);
            this.group_enter_data_box.PerformLayout();
            this.group_result_box.ResumeLayout(false);
            this.group_result_box.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox text_IDstd;
        private System.Windows.Forms.Label student_id_label;
        private System.Windows.Forms.TextBox text_Name;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox text_Score;
        private System.Windows.Forms.Label point_label;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox IDstd_max;
        private System.Windows.Forms.TextBox IDstd_min;
        private System.Windows.Forms.TextBox nameStd_max;
        private System.Windows.Forms.TextBox nameStd_min;
        private System.Windows.Forms.TextBox scoreStd_max;
        private System.Windows.Forms.TextBox scoreStd_min;
        private System.Windows.Forms.TextBox AVG_score;
        private System.Windows.Forms.Label avg_point_label;
        private System.Windows.Forms.Label max_point_label;
        private System.Windows.Forms.Label min_point_label;
        private System.Windows.Forms.Label student_id_label2;
        private System.Windows.Forms.Label name_label2;
        private System.Windows.Forms.Label point_label2;
        private System.Windows.Forms.GroupBox group_enter_data_box;
        private System.Windows.Forms.GroupBox group_result_box;
        private System.Windows.Forms.Label label_B_plus;
        private System.Windows.Forms.TextBox BB_box;
        private System.Windows.Forms.Label label_A;
        private System.Windows.Forms.TextBox A_box;
        private System.Windows.Forms.Label label_B;
        private System.Windows.Forms.TextBox B_box;
        private System.Windows.Forms.Label label_D_plus;
        private System.Windows.Forms.TextBox DD_box;
        private System.Windows.Forms.Label label_C;
        private System.Windows.Forms.TextBox C_box;
        private System.Windows.Forms.Label label_C_plus;
        private System.Windows.Forms.TextBox CC_box;
        private System.Windows.Forms.Label label_avg;
        private System.Windows.Forms.TextBox GPA_box;
        private System.Windows.Forms.Label label_F;
        private System.Windows.Forms.TextBox F_box;
        private System.Windows.Forms.Label label_D_box;
        private System.Windows.Forms.TextBox D_box;
    }
}

