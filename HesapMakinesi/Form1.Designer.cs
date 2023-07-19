namespace HesapMakinesi
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_FirstNumber = new System.Windows.Forms.TextBox();
            this.txt_SecondNumber = new System.Windows.Forms.TextBox();
            this.btn_Plus = new System.Windows.Forms.Button();
            this.btn_Minus = new System.Windows.Forms.Button();
            this.btn_Times = new System.Windows.Forms.Button();
            this.btn_Divide = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "1. sayıyı girin:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "2. sayıyı girin:";
            // 
            // txt_FirstNumber
            // 
            this.txt_FirstNumber.Location = new System.Drawing.Point(127, 33);
            this.txt_FirstNumber.Name = "txt_FirstNumber";
            this.txt_FirstNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_FirstNumber.TabIndex = 2;
            // 
            // txt_SecondNumber
            // 
            this.txt_SecondNumber.Location = new System.Drawing.Point(127, 72);
            this.txt_SecondNumber.Name = "txt_SecondNumber";
            this.txt_SecondNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_SecondNumber.TabIndex = 3;
            // 
            // btn_Plus
            // 
            this.btn_Plus.Location = new System.Drawing.Point(70, 137);
            this.btn_Plus.Name = "btn_Plus";
            this.btn_Plus.Size = new System.Drawing.Size(38, 34);
            this.btn_Plus.TabIndex = 4;
            this.btn_Plus.Text = "+";
            this.btn_Plus.UseVisualStyleBackColor = true;
            this.btn_Plus.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Minus
            // 
            this.btn_Minus.Location = new System.Drawing.Point(114, 137);
            this.btn_Minus.Name = "btn_Minus";
            this.btn_Minus.Size = new System.Drawing.Size(35, 34);
            this.btn_Minus.TabIndex = 5;
            this.btn_Minus.Text = "-";
            this.btn_Minus.UseVisualStyleBackColor = true;
            this.btn_Minus.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Times
            // 
            this.btn_Times.Location = new System.Drawing.Point(155, 137);
            this.btn_Times.Name = "btn_Times";
            this.btn_Times.Size = new System.Drawing.Size(33, 34);
            this.btn_Times.TabIndex = 6;
            this.btn_Times.Text = "*";
            this.btn_Times.UseVisualStyleBackColor = true;
            this.btn_Times.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Divide
            // 
            this.btn_Divide.Location = new System.Drawing.Point(194, 137);
            this.btn_Divide.Name = "btn_Divide";
            this.btn_Divide.Size = new System.Drawing.Size(34, 34);
            this.btn_Divide.TabIndex = 7;
            this.btn_Divide.Text = "/";
            this.btn_Divide.UseVisualStyleBackColor = true;
            this.btn_Divide.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(61, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Sonuç:";
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(127, 110);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(13, 13);
            this.lbl_Result.TabIndex = 9;
            this.lbl_Result.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 214);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Divide);
            this.Controls.Add(this.btn_Times);
            this.Controls.Add(this.btn_Minus);
            this.Controls.Add(this.btn_Plus);
            this.Controls.Add(this.txt_SecondNumber);
            this.Controls.Add(this.txt_FirstNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinesi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_FirstNumber;
        private System.Windows.Forms.TextBox txt_SecondNumber;
        private System.Windows.Forms.Button btn_Plus;
        private System.Windows.Forms.Button btn_Minus;
        private System.Windows.Forms.Button btn_Times;
        private System.Windows.Forms.Button btn_Divide;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_Result;
    }
}

