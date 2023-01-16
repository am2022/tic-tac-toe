namespace tic_tac_toe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.lb_pl1 = new System.Windows.Forms.Label();
            this.lb_pls1 = new System.Windows.Forms.Label();
            this.lb_pl2 = new System.Windows.Forms.Label();
            this.lb_pls2 = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 77);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(252, 194);
            this.btn1.TabIndex = 0;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(270, 77);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(252, 194);
            this.btn2.TabIndex = 1;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(528, 77);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(252, 194);
            this.btn3.TabIndex = 2;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 277);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(252, 194);
            this.btn4.TabIndex = 3;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(270, 277);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(252, 194);
            this.btn5.TabIndex = 4;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(528, 277);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(252, 194);
            this.btn6.TabIndex = 5;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 477);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(252, 194);
            this.btn7.TabIndex = 6;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(270, 477);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(252, 194);
            this.btn8.TabIndex = 7;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(528, 477);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(252, 194);
            this.btn9.TabIndex = 8;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // lb_pl1
            // 
            this.lb_pl1.AutoSize = true;
            this.lb_pl1.Location = new System.Drawing.Point(12, 9);
            this.lb_pl1.Name = "lb_pl1";
            this.lb_pl1.Size = new System.Drawing.Size(122, 41);
            this.lb_pl1.TabIndex = 9;
            this.lb_pl1.Text = "player1:";
            // 
            // lb_pls1
            // 
            this.lb_pls1.AutoSize = true;
            this.lb_pls1.Location = new System.Drawing.Point(167, 9);
            this.lb_pls1.Name = "lb_pls1";
            this.lb_pls1.Size = new System.Drawing.Size(34, 41);
            this.lb_pls1.TabIndex = 10;
            this.lb_pls1.Text = "0";
            // 
            // lb_pl2
            // 
            this.lb_pl2.AutoSize = true;
            this.lb_pl2.Location = new System.Drawing.Point(528, 9);
            this.lb_pl2.Name = "lb_pl2";
            this.lb_pl2.Size = new System.Drawing.Size(122, 41);
            this.lb_pl2.TabIndex = 11;
            this.lb_pl2.Text = "player2:";
            // 
            // lb_pls2
            // 
            this.lb_pls2.AutoSize = true;
            this.lb_pls2.Location = new System.Drawing.Point(683, 9);
            this.lb_pls2.Name = "lb_pls2";
            this.lb_pls2.Size = new System.Drawing.Size(34, 41);
            this.lb_pls2.TabIndex = 12;
            this.lb_pls2.Text = "0";
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(270, 12);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(252, 58);
            this.btn_reset.TabIndex = 13;
            this.btn_reset.Text = "reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 690);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lb_pls2);
            this.Controls.Add(this.lb_pl2);
            this.Controls.Add(this.lb_pls1);
            this.Controls.Add(this.lb_pl1);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Label lb_pl1;
        private Label lb_pls1;
        private Label lb_pl2;
        private Label lb_pls2;
        private Button btn_reset;
    }
}