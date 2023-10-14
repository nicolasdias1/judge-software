
namespace SistemaNotas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblQual = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.btnSalvarNota = new System.Windows.Forms.Button();
            this.lvlSurfista = new System.Windows.Forms.Label();
            this.lblLookNota = new System.Windows.Forms.Label();
            this.lblMediaPontuacoes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHow = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblQual
            // 
            this.lblQual.AutoSize = true;
            this.lblQual.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblQual.Location = new System.Drawing.Point(12, 23);
            this.lblQual.Name = "lblQual";
            this.lblQual.Size = new System.Drawing.Size(183, 13);
            this.lblQual.TabIndex = 0;
            this.lblQual.Text = "Qual Surfista deseja anotar as notas?";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Gabriel Medina",
            "Italo Ferreira"});
            this.comboBox1.Location = new System.Drawing.Point(15, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(12, 96);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(121, 20);
            this.txtNota.TabIndex = 2;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(12, 75);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(95, 13);
            this.lblNota.TabIndex = 3;
            this.lblNota.Text = "Qual a nota dada?";
            // 
            // btnSalvarNota
            // 
            this.btnSalvarNota.Location = new System.Drawing.Point(197, 168);
            this.btnSalvarNota.Name = "btnSalvarNota";
            this.btnSalvarNota.Size = new System.Drawing.Size(95, 23);
            this.btnSalvarNota.TabIndex = 6;
            this.btnSalvarNota.Text = "Salvar Nota";
            this.btnSalvarNota.UseVisualStyleBackColor = true;
            this.btnSalvarNota.Click += new System.EventHandler(this.btnSalvarNota_Click);
            // 
            // lvlSurfista
            // 
            this.lvlSurfista.AutoSize = true;
            this.lvlSurfista.Location = new System.Drawing.Point(29, 145);
            this.lvlSurfista.Name = "lvlSurfista";
            this.lvlSurfista.Size = new System.Drawing.Size(145, 13);
            this.lvlSurfista.TabIndex = 7;
            this.lvlSurfista.Text = "Nenhum Surfista selecionado";
            // 
            // lblLookNota
            // 
            this.lblLookNota.AutoSize = true;
            this.lblLookNota.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblLookNota.Location = new System.Drawing.Point(305, 23);
            this.lblLookNota.Name = "lblLookNota";
            this.lblLookNota.Size = new System.Drawing.Size(89, 13);
            this.lblLookNota.TabIndex = 10;
            this.lblLookNota.Text = "DEFINA A NOTA";
            // 
            // lblMediaPontuacoes
            // 
            this.lblMediaPontuacoes.AutoSize = true;
            this.lblMediaPontuacoes.Location = new System.Drawing.Point(305, 75);
            this.lblMediaPontuacoes.Name = "lblMediaPontuacoes";
            this.lblMediaPontuacoes.Size = new System.Drawing.Size(143, 13);
            this.lblMediaPontuacoes.TabIndex = 11;
            this.lblMediaPontuacoes.Text = "MÉDIA DAS PONTUAÇÕES";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Retroica", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(243, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(412, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Desenvolvido por NICOLAS DIAS";
            // 
            // btnHow
            // 
            this.btnHow.Location = new System.Drawing.Point(516, 211);
            this.btnHow.Name = "btnHow";
            this.btnHow.Size = new System.Drawing.Size(127, 51);
            this.btnHow.TabIndex = 13;
            this.btnHow.Text = "Como funciona?";
            this.btnHow.UseVisualStyleBackColor = true;
            this.btnHow.Click += new System.EventHandler(this.btnHow_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(450, 93);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(129, 23);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir Dados";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(655, 299);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnHow);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMediaPontuacoes);
            this.Controls.Add(this.lblLookNota);
            this.Controls.Add(this.lvlSurfista);
            this.Controls.Add(this.btnSalvarNota);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblQual);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOTAS BY Nicolas Dias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQual;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Button btnSalvarNota;
        private System.Windows.Forms.Label lvlSurfista;
        private System.Windows.Forms.Label lblLookNota;
        private System.Windows.Forms.Label lblMediaPontuacoes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHow;
        private System.Windows.Forms.Button btnExcluir;
    }
}

