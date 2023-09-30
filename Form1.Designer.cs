namespace JogoDaDigitacao
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
            this.components = new System.ComponentModel.Container();
            this.lsbLetras = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCorretos = new System.Windows.Forms.Label();
            this.lblErrados = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPrecisao = new System.Windows.Forms.Label();
            this.btnComecar = new System.Windows.Forms.Button();
            this.prgDificuldade = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.timerJogo = new System.Windows.Forms.Timer(this.components);
            this.tmrBotao = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lsbLetras
            // 
            this.lsbLetras.Font = new System.Drawing.Font("Arial monospaced for SAP", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbLetras.FormattingEnabled = true;
            this.lsbLetras.HorizontalScrollbar = true;
            this.lsbLetras.ItemHeight = 107;
            this.lsbLetras.Location = new System.Drawing.Point(-1, -1);
            this.lsbLetras.MultiColumn = true;
            this.lsbLetras.Name = "lsbLetras";
            this.lsbLetras.Size = new System.Drawing.Size(801, 111);
            this.lsbLetras.TabIndex = 0;
            this.lsbLetras.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lsbLetras_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Corretos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Errados:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Precisão:";
            // 
            // lblCorretos
            // 
            this.lblCorretos.AutoSize = true;
            this.lblCorretos.Location = new System.Drawing.Point(65, 144);
            this.lblCorretos.Name = "lblCorretos";
            this.lblCorretos.Size = new System.Drawing.Size(0, 13);
            this.lblCorretos.TabIndex = 5;
            // 
            // lblErrados
            // 
            this.lblErrados.AutoSize = true;
            this.lblErrados.Location = new System.Drawing.Point(204, 144);
            this.lblErrados.Name = "lblErrados";
            this.lblErrados.Size = new System.Drawing.Size(0, 13);
            this.lblErrados.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(347, 144);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 7;
            // 
            // lblPrecisao
            // 
            this.lblPrecisao.AutoSize = true;
            this.lblPrecisao.Location = new System.Drawing.Point(490, 144);
            this.lblPrecisao.Name = "lblPrecisao";
            this.lblPrecisao.Size = new System.Drawing.Size(0, 13);
            this.lblPrecisao.TabIndex = 8;
            // 
            // btnComecar
            // 
            this.btnComecar.Location = new System.Drawing.Point(363, 174);
            this.btnComecar.Name = "btnComecar";
            this.btnComecar.Size = new System.Drawing.Size(75, 23);
            this.btnComecar.TabIndex = 9;
            this.btnComecar.Text = "Começar!";
            this.btnComecar.UseVisualStyleBackColor = true;
            this.btnComecar.Click += new System.EventHandler(this.btnComecar_Click);
            // 
            // prgDificuldade
            // 
            this.prgDificuldade.Location = new System.Drawing.Point(636, 139);
            this.prgDificuldade.Maximum = 10000;
            this.prgDificuldade.Name = "prgDificuldade";
            this.prgDificuldade.Size = new System.Drawing.Size(152, 23);
            this.prgDificuldade.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(570, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Dificuldade";
            // 
            // timerJogo
            // 
            this.timerJogo.Interval = 1000;
            this.timerJogo.Tick += new System.EventHandler(this.timerJogo_Tick);
            // 
            // tmrBotao
            // 
            this.tmrBotao.Enabled = true;
            this.tmrBotao.Interval = 1000;
            this.tmrBotao.Tick += new System.EventHandler(this.tmrBotao_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 209);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.prgDificuldade);
            this.Controls.Add(this.btnComecar);
            this.Controls.Add(this.lblPrecisao);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblErrados);
            this.Controls.Add(this.lblCorretos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsbLetras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbLetras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCorretos;
        private System.Windows.Forms.Label lblErrados;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPrecisao;
        private System.Windows.Forms.Button btnComecar;
        private System.Windows.Forms.ProgressBar prgDificuldade;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Timer timerJogo;
        private System.Windows.Forms.Timer tmrBotao;
    }
}

