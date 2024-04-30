
namespace ООП_ЛБ2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStoim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOtch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCounSotr = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSumma = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFixSumma = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProdag = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPercent = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(332, 94);
            this.button3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 26);
            this.button3.TabIndex = 31;
            this.button3.Text = "Поиск";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(332, 55);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 26);
            this.button2.TabIndex = 30;
            this.button2.Text = "Подсчитать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 153);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Стоимость дня:";
            // 
            // txtStoim
            // 
            this.txtStoim.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtStoim.Location = new System.Drawing.Point(171, 149);
            this.txtStoim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStoim.Name = "txtStoim";
            this.txtStoim.Size = new System.Drawing.Size(151, 20);
            this.txtStoim.TabIndex = 28;
            this.txtStoim.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStoim_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 117);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Количество рабочих дней:";
            // 
            // txtCount
            // 
            this.txtCount.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCount.Location = new System.Drawing.Point(171, 113);
            this.txtCount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(151, 20);
            this.txtCount.TabIndex = 26;
            this.txtCount.TextChanged += new System.EventHandler(this.txtCount_TextChanged);
            this.txtCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCount_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Отчество:";
            // 
            // txtOtch
            // 
            this.txtOtch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtOtch.Location = new System.Drawing.Point(171, 83);
            this.txtOtch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOtch.Name = "txtOtch";
            this.txtOtch.Size = new System.Drawing.Size(151, 20);
            this.txtOtch.TabIndex = 24;
            this.txtOtch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOtch_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Имя:";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtName.Location = new System.Drawing.Point(171, 52);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(151, 20);
            this.txtName.TabIndex = 22;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 19);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Фамилия:";
            // 
            // txtFam
            // 
            this.txtFam.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFam.Location = new System.Drawing.Point(171, 19);
            this.txtFam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFam.Name = "txtFam";
            this.txtFam.Size = new System.Drawing.Size(151, 20);
            this.txtFam.TabIndex = 20;
            this.txtFam.TextChanged += new System.EventHandler(this.txtFam_TextChanged);
            this.txtFam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFam_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 284);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Количество сотрудников:";
            // 
            // txtCounSotr
            // 
            this.txtCounSotr.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCounSotr.Location = new System.Drawing.Point(171, 284);
            this.txtCounSotr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCounSotr.Name = "txtCounSotr";
            this.txtCounSotr.ReadOnly = true;
            this.txtCounSotr.Size = new System.Drawing.Size(151, 20);
            this.txtCounSotr.TabIndex = 18;
            this.txtCounSotr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCounSotr_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 27);
            this.button1.TabIndex = 17;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 317);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Сумма:";
            // 
            // txtSumma
            // 
            this.txtSumma.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSumma.Location = new System.Drawing.Point(171, 313);
            this.txtSumma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSumma.Name = "txtSumma";
            this.txtSumma.ReadOnly = true;
            this.txtSumma.Size = new System.Drawing.Size(151, 20);
            this.txtSumma.TabIndex = 32;
            this.txtSumma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSumma_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(328, 132);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(163, 101);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип сотрудника";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(4, 80);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(123, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Процент от продаж";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(4, 53);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(106, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Оплата по дням";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(4, 25);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(159, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "С фиксированной оплатой";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 183);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Фиксированная оплата:";
            // 
            // txtFixSumma
            // 
            this.txtFixSumma.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFixSumma.Location = new System.Drawing.Point(171, 179);
            this.txtFixSumma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFixSumma.Name = "txtFixSumma";
            this.txtFixSumma.Size = new System.Drawing.Size(151, 20);
            this.txtFixSumma.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 217);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Сумма продаж:";
            // 
            // txtProdag
            // 
            this.txtProdag.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtProdag.Location = new System.Drawing.Point(171, 213);
            this.txtProdag.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProdag.Name = "txtProdag";
            this.txtProdag.Size = new System.Drawing.Size(151, 20);
            this.txtProdag.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 249);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Доля от продаж:";
            // 
            // txtPercent
            // 
            this.txtPercent.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPercent.Location = new System.Drawing.Point(171, 245);
            this.txtPercent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPercent.Name = "txtPercent";
            this.txtPercent.Size = new System.Drawing.Size(151, 20);
            this.txtPercent.TabIndex = 39;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(502, 354);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPercent);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtProdag);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFixSumma);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSumma);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtStoim);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOtch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCounSotr);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStoim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOtch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCounSotr;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSumma;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFixSumma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProdag;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPercent;
    }
}

