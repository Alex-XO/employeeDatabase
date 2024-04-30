
namespace ООП_ЛБ2
{
    partial class FrmInfo
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
            this.Label1 = new System.Windows.Forms.Label();
            this.txtFam = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOtch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSumma = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(11, 12);
            this.Label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(59, 13);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "Фамилия:";
            // 
            // txtFam
            // 
            this.txtFam.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFam.Location = new System.Drawing.Point(100, 12);
            this.txtFam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFam.Name = "txtFam";
            this.txtFam.ReadOnly = true;
            this.txtFam.Size = new System.Drawing.Size(149, 20);
            this.txtFam.TabIndex = 1;
            this.txtFam.TextChanged += new System.EventHandler(this.txtFam_TextChanged);
            this.txtFam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFam_KeyPress);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtName.Location = new System.Drawing.Point(100, 49);
            this.txtName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(149, 20);
            this.txtName.TabIndex = 3;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 49);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя:";
            // 
            // txtOtch
            // 
            this.txtOtch.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtOtch.Location = new System.Drawing.Point(100, 85);
            this.txtOtch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtOtch.Name = "txtOtch";
            this.txtOtch.ReadOnly = true;
            this.txtOtch.Size = new System.Drawing.Size(149, 20);
            this.txtOtch.TabIndex = 5;
            this.txtOtch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOtch_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 89);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Отчество:";
            // 
            // txtSumma
            // 
            this.txtSumma.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSumma.Location = new System.Drawing.Point(100, 121);
            this.txtSumma.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSumma.Name = "txtSumma";
            this.txtSumma.ReadOnly = true;
            this.txtSumma.Size = new System.Drawing.Size(149, 20);
            this.txtSumma.TabIndex = 7;
            this.txtSumma.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSumma_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Зарплата:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(11, 171);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 26);
            this.button1.TabIndex = 8;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(260, 212);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSumma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOtch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFam);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmInfo";
            this.Text = "FrmInfo";
            this.Shown += new System.EventHandler(this.FrmInfo_Shown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmInfo_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txtFam;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOtch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSumma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}