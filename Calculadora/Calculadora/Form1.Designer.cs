namespace Calculadora
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
            btn1 = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn0 = new Button();
            btnSomar = new Button();
            btnSubtrair = new Button();
            btnMultiplicar = new Button();
            btnApagar = new Button();
            btnIgual = new Button();
            btnDividir = new Button();
            lblCalc = new Label();
            txtvalor = new TextBox();
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.Location = new Point(37, 276);
            btn1.Name = "btn1";
            btn1.Size = new Size(65, 48);
            btn1.TabIndex = 0;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(179, 168);
            btn9.Name = "btn9";
            btn9.Size = new Size(65, 48);
            btn9.TabIndex = 1;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(108, 168);
            btn8.Name = "btn8";
            btn8.Size = new Size(65, 48);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(37, 168);
            btn7.Name = "btn7";
            btn7.Size = new Size(65, 48);
            btn7.TabIndex = 3;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(179, 222);
            btn6.Name = "btn6";
            btn6.Size = new Size(65, 48);
            btn6.TabIndex = 4;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(108, 222);
            btn5.Name = "btn5";
            btn5.Size = new Size(65, 48);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(37, 222);
            btn4.Name = "btn4";
            btn4.Size = new Size(65, 48);
            btn4.TabIndex = 6;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(179, 276);
            btn3.Name = "btn3";
            btn3.Size = new Size(65, 48);
            btn3.TabIndex = 7;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(108, 276);
            btn2.Name = "btn2";
            btn2.Size = new Size(65, 48);
            btn2.TabIndex = 8;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(37, 114);
            btn0.Name = "btn0";
            btn0.Size = new Size(65, 48);
            btn0.TabIndex = 9;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // btnSomar
            // 
            btnSomar.Location = new Point(250, 276);
            btnSomar.Name = "btnSomar";
            btnSomar.Size = new Size(65, 48);
            btnSomar.TabIndex = 10;
            btnSomar.Text = "+";
            btnSomar.UseVisualStyleBackColor = true;
            btnSomar.Click += btnSomar_Click;
            // 
            // btnSubtrair
            // 
            btnSubtrair.Location = new Point(250, 222);
            btnSubtrair.Name = "btnSubtrair";
            btnSubtrair.Size = new Size(65, 48);
            btnSubtrair.TabIndex = 11;
            btnSubtrair.Text = "-";
            btnSubtrair.UseVisualStyleBackColor = true;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(250, 168);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(65, 48);
            btnMultiplicar.TabIndex = 12;
            btnMultiplicar.Text = "X";
            btnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // btnApagar
            // 
            btnApagar.Location = new Point(108, 114);
            btnApagar.Name = "btnApagar";
            btnApagar.Size = new Size(65, 48);
            btnApagar.TabIndex = 13;
            btnApagar.Text = "APAGAR";
            btnApagar.UseVisualStyleBackColor = true;
            btnApagar.Click += btnApagar_Click;
            // 
            // btnIgual
            // 
            btnIgual.Location = new Point(179, 114);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(65, 48);
            btnIgual.TabIndex = 14;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = true;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(250, 114);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(65, 48);
            btnDividir.TabIndex = 15;
            btnDividir.Text = "/";
            btnDividir.UseVisualStyleBackColor = true;
            // 
            // lblCalc
            // 
            lblCalc.AutoSize = true;
            lblCalc.Cursor = Cursors.Cross;
            lblCalc.Location = new Point(37, 9);
            lblCalc.Name = "lblCalc";
            lblCalc.Size = new Size(38, 15);
            lblCalc.TabIndex = 16;
            lblCalc.Text = "label1";
            // 
            // txtvalor
            // 
            txtvalor.Location = new Point(37, 68);
            txtvalor.Name = "txtvalor";
            txtvalor.Size = new Size(207, 23);
            txtvalor.TabIndex = 17;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 337);
            Controls.Add(txtvalor);
            Controls.Add(lblCalc);
            Controls.Add(btnDividir);
            Controls.Add(btnIgual);
            Controls.Add(btnApagar);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnSubtrair);
            Controls.Add(btnSomar);
            Controls.Add(btn0);
            Controls.Add(btn2);
            Controls.Add(btn3);
            Controls.Add(btn4);
            Controls.Add(btn5);
            Controls.Add(btn6);
            Controls.Add(btn7);
            Controls.Add(btn8);
            Controls.Add(btn9);
            Controls.Add(btn1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn1;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btn3;
        private Button btn2;
        private Button btn0;
        private Button btnSomar;
        private Button btnSubtrair;
        private Button btnMultiplicar;
        private Button btnApagar;
        private Button btnIgual;
        private Button btnDividir;
        private Label lblCalc;
        private TextBox txtvalor;
    }
}
