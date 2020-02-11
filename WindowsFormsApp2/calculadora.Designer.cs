namespace WindowsFormsApp2
{
    partial class calculadora
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
            this.lbl_val = new System.Windows.Forms.Label();
            this.txtbox_val1 = new System.Windows.Forms.TextBox();
            this.btn_soma = new System.Windows.Forms.Button();
            this.lbl_val2 = new System.Windows.Forms.Label();
            this.txtbox_val2 = new System.Windows.Forms.TextBox();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_mul = new System.Windows.Forms.Button();
            this.txt_resul = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_val
            // 
            this.lbl_val.AutoSize = true;
            this.lbl_val.Location = new System.Drawing.Point(28, 39);
            this.lbl_val.Name = "lbl_val";
            this.lbl_val.Size = new System.Drawing.Size(43, 13);
            this.lbl_val.TabIndex = 0;
            this.lbl_val.Text = "Valor 1:";
            // 
            // txtbox_val1
            // 
            this.txtbox_val1.Location = new System.Drawing.Point(77, 36);
            this.txtbox_val1.Name = "txtbox_val1";
            this.txtbox_val1.Size = new System.Drawing.Size(180, 20);
            this.txtbox_val1.TabIndex = 1;
            // 
            // btn_soma
            // 
            this.btn_soma.Location = new System.Drawing.Point(31, 111);
            this.btn_soma.Name = "btn_soma";
            this.btn_soma.Size = new System.Drawing.Size(52, 23);
            this.btn_soma.TabIndex = 2;
            this.btn_soma.Text = "Soma";
            this.btn_soma.UseVisualStyleBackColor = true;
            this.btn_soma.Click += new System.EventHandler(this.btn_soma_Click);
            // 
            // lbl_val2
            // 
            this.lbl_val2.AutoSize = true;
            this.lbl_val2.Location = new System.Drawing.Point(28, 72);
            this.lbl_val2.Name = "lbl_val2";
            this.lbl_val2.Size = new System.Drawing.Size(43, 13);
            this.lbl_val2.TabIndex = 3;
            this.lbl_val2.Text = "Valor 2:";
            this.lbl_val2.Click += new System.EventHandler(this.lbl_val2_Click);
            // 
            // txtbox_val2
            // 
            this.txtbox_val2.Location = new System.Drawing.Point(77, 72);
            this.txtbox_val2.Name = "txtbox_val2";
            this.txtbox_val2.Size = new System.Drawing.Size(180, 20);
            this.txtbox_val2.TabIndex = 4;
            this.txtbox_val2.TextChanged += new System.EventHandler(this.txtbox_val2_TextChanged);
            // 
            // btn_sub
            // 
            this.btn_sub.Location = new System.Drawing.Point(89, 111);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(52, 23);
            this.btn_sub.TabIndex = 5;
            this.btn_sub.Text = "Sub";
            this.btn_sub.UseVisualStyleBackColor = true;
            this.btn_sub.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_div
            // 
            this.btn_div.Location = new System.Drawing.Point(147, 111);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(52, 23);
            this.btn_div.TabIndex = 6;
            this.btn_div.Text = "Div";
            this.btn_div.UseVisualStyleBackColor = true;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_mul
            // 
            this.btn_mul.Location = new System.Drawing.Point(205, 111);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(52, 23);
            this.btn_mul.TabIndex = 7;
            this.btn_mul.Text = "Mul";
            this.btn_mul.UseVisualStyleBackColor = true;
            this.btn_mul.Click += new System.EventHandler(this.btn_mul_Click);
            // 
            // txt_resul
            // 
            this.txt_resul.Location = new System.Drawing.Point(92, 150);
            this.txt_resul.Name = "txt_resul";
            this.txt_resul.Size = new System.Drawing.Size(165, 20);
            this.txt_resul.TabIndex = 9;
            this.txt_resul.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Resultado:";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(31, 186);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(226, 23);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_resul);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_mul);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.txtbox_val2);
            this.Controls.Add(this.lbl_val2);
            this.Controls.Add(this.btn_soma);
            this.Controls.Add(this.txtbox_val1);
            this.Controls.Add(this.lbl_val);
            this.Name = "calculadora";
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_val;
        private System.Windows.Forms.TextBox txtbox_val1;
        private System.Windows.Forms.Button btn_soma;
        private System.Windows.Forms.Label lbl_val2;
        private System.Windows.Forms.TextBox txtbox_val2;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.TextBox txt_resul;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_clear;
    }
}

