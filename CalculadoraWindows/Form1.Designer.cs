namespace CalculadoraWindows
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnC = new System.Windows.Forms.Button();
            this.btnMais = new System.Windows.Forms.Button();
            this.btnMenos = new System.Windows.Forms.Button();
            this.btnVezes = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.txbTela = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(13, 99);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(74, 67);
            this.btn7.TabIndex = 0;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.Numero_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(93, 99);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(73, 67);
            this.btn8.TabIndex = 1;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.Numero_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(172, 99);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 67);
            this.btn9.TabIndex = 2;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.Numero_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(13, 172);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(74, 64);
            this.btn4.TabIndex = 3;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.Numero_Click);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(93, 172);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(73, 64);
            this.btn5.TabIndex = 4;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.Numero_Click);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(172, 172);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 64);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.Numero_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(13, 241);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(74, 60);
            this.btn1.TabIndex = 6;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.Numero_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(93, 241);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(73, 60);
            this.btn2.TabIndex = 7;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.Numero_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(172, 242);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 60);
            this.btn3.TabIndex = 8;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.Numero_Click);
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(13, 305);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(153, 65);
            this.btn0.TabIndex = 9;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.Numero_Click);
            // 
            // btnC
            // 
            this.btnC.ForeColor = System.Drawing.Color.Red;
            this.btnC.Location = new System.Drawing.Point(172, 305);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(75, 65);
            this.btnC.TabIndex = 10;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // btnMais
            // 
            this.btnMais.Location = new System.Drawing.Point(259, 242);
            this.btnMais.Name = "btnMais";
            this.btnMais.Size = new System.Drawing.Size(74, 60);
            this.btnMais.TabIndex = 11;
            this.btnMais.Text = "+";
            this.btnMais.UseVisualStyleBackColor = true;
            // 
            // btnMenos
            // 
            this.btnMenos.Location = new System.Drawing.Point(258, 205);
            this.btnMenos.Name = "btnMenos";
            this.btnMenos.Size = new System.Drawing.Size(74, 31);
            this.btnMenos.TabIndex = 12;
            this.btnMenos.Text = "-";
            this.btnMenos.UseVisualStyleBackColor = true;
            // 
            // btnVezes
            // 
            this.btnVezes.Location = new System.Drawing.Point(259, 158);
            this.btnVezes.Name = "btnVezes";
            this.btnVezes.Size = new System.Drawing.Size(73, 41);
            this.btnVezes.TabIndex = 13;
            this.btnVezes.Text = "X";
            this.btnVezes.UseVisualStyleBackColor = true;
            // 
            // btnIgual
            // 
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnIgual.Location = new System.Drawing.Point(258, 305);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(74, 65);
            this.btnIgual.TabIndex = 14;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(258, 99);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(74, 53);
            this.btnDividir.TabIndex = 15;
            this.btnDividir.Text = "÷";
            this.btnDividir.UseVisualStyleBackColor = true;
            // 
            // txbTela
            // 
            this.txbTela.BackColor = System.Drawing.SystemColors.Window;
            this.txbTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTela.Location = new System.Drawing.Point(13, 12);
            this.txbTela.Name = "txbTela";
            this.txbTela.Size = new System.Drawing.Size(320, 80);
            this.txbTela.TabIndex = 16;
            this.txbTela.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(338, 375);
            this.Controls.Add(this.txbTela);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnVezes);
            this.Controls.Add(this.btnMenos);
            this.Controls.Add(this.btnMais);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.Button btnMais;
        private System.Windows.Forms.Button btnMenos;
        private System.Windows.Forms.Button btnVezes;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.TextBox txbTela;
    }
}

