namespace calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calculadora));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.btnadicao = new System.Windows.Forms.Button();
            this.btnsubitracao = new System.Windows.Forms.Button();
            this.btnmultiplicacao = new System.Windows.Forms.Button();
            this.btndivisao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtresultado = new System.Windows.Forms.TextBox();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite o 2º numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(43, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Digite o 1º numero";
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(233, 61);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(155, 20);
            this.txtnum1.TabIndex = 1;
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(233, 112);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(155, 20);
            this.txtnum2.TabIndex = 1;
            // 
            // btnadicao
            // 
            this.btnadicao.BackColor = System.Drawing.Color.SandyBrown;
            this.btnadicao.FlatAppearance.BorderSize = 0;
            this.btnadicao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btnadicao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnadicao.Location = new System.Drawing.Point(69, 162);
            this.btnadicao.Name = "btnadicao";
            this.btnadicao.Size = new System.Drawing.Size(54, 33);
            this.btnadicao.TabIndex = 2;
            this.btnadicao.Text = "+";
            this.btnadicao.UseVisualStyleBackColor = false;
            this.btnadicao.Click += new System.EventHandler(this.btnadicao_Click);
            // 
            // btnsubitracao
            // 
            this.btnsubitracao.BackColor = System.Drawing.Color.SandyBrown;
            this.btnsubitracao.FlatAppearance.BorderSize = 0;
            this.btnsubitracao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btnsubitracao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsubitracao.Location = new System.Drawing.Point(152, 162);
            this.btnsubitracao.Name = "btnsubitracao";
            this.btnsubitracao.Size = new System.Drawing.Size(55, 33);
            this.btnsubitracao.TabIndex = 2;
            this.btnsubitracao.Text = "-";
            this.btnsubitracao.UseVisualStyleBackColor = false;
            this.btnsubitracao.Click += new System.EventHandler(this.btnsubitracao_Click);
            // 
            // btnmultiplicacao
            // 
            this.btnmultiplicacao.BackColor = System.Drawing.Color.SandyBrown;
            this.btnmultiplicacao.FlatAppearance.BorderSize = 0;
            this.btnmultiplicacao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btnmultiplicacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnmultiplicacao.Location = new System.Drawing.Point(233, 162);
            this.btnmultiplicacao.Name = "btnmultiplicacao";
            this.btnmultiplicacao.Size = new System.Drawing.Size(57, 33);
            this.btnmultiplicacao.TabIndex = 2;
            this.btnmultiplicacao.Text = "*";
            this.btnmultiplicacao.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnmultiplicacao.UseVisualStyleBackColor = false;
            this.btnmultiplicacao.Click += new System.EventHandler(this.btnmultiplicacao_Click);
            // 
            // btndivisao
            // 
            this.btndivisao.BackColor = System.Drawing.Color.SandyBrown;
            this.btndivisao.FlatAppearance.BorderSize = 0;
            this.btndivisao.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGreen;
            this.btndivisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndivisao.Location = new System.Drawing.Point(313, 162);
            this.btndivisao.Name = "btndivisao";
            this.btndivisao.Size = new System.Drawing.Size(59, 33);
            this.btndivisao.TabIndex = 2;
            this.btndivisao.Text = "/";
            this.btndivisao.UseVisualStyleBackColor = false;
            this.btndivisao.Click += new System.EventHandler(this.btndivisao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "Resultado";
            // 
            // txtresultado
            // 
            this.txtresultado.Location = new System.Drawing.Point(173, 243);
            this.txtresultado.Name = "txtresultado";
            this.txtresultado.Size = new System.Drawing.Size(139, 20);
            this.txtresultado.TabIndex = 4;
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.LightGreen;
            this.btnlimpar.Location = new System.Drawing.Point(108, 313);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(82, 33);
            this.btnlimpar.TabIndex = 5;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.Color.LightGreen;
            this.btnsair.Location = new System.Drawing.Point(265, 313);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(82, 33);
            this.btnsair.TabIndex = 5;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::calculadora.Properties.Resources.window_programming_icon_icons_com_48366;
            this.ClientSize = new System.Drawing.Size(445, 396);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.txtresultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btndivisao);
            this.Controls.Add(this.btnmultiplicacao);
            this.Controls.Add(this.btnsubitracao);
            this.Controls.Add(this.btnadicao);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Button btnadicao;
        private System.Windows.Forms.Button btnsubitracao;
        private System.Windows.Forms.Button btnmultiplicacao;
        private System.Windows.Forms.Button btndivisao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtresultado;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnsair;
    }
}

