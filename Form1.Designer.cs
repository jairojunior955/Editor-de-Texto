
namespace EditorDeTexto
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
            this.textoConteudo = new System.Windows.Forms.TextBox();
            this.botaoGrava = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textoBusca = new System.Windows.Forms.TextBox();
            this.botaoBusca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textoConteudo
            // 
            this.textoConteudo.Location = new System.Drawing.Point(12, 12);
            this.textoConteudo.Multiline = true;
            this.textoConteudo.Name = "textoConteudo";
            this.textoConteudo.Size = new System.Drawing.Size(776, 298);
            this.textoConteudo.TabIndex = 0;
            // 
            // botaoGrava
            // 
            this.botaoGrava.Location = new System.Drawing.Point(12, 334);
            this.botaoGrava.Name = "botaoGrava";
            this.botaoGrava.Size = new System.Drawing.Size(75, 23);
            this.botaoGrava.TabIndex = 1;
            this.botaoGrava.Text = "Gravar";
            this.botaoGrava.UseVisualStyleBackColor = true;
            this.botaoGrava.Click += new System.EventHandler(this.botaoGrava_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 313);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Find and Replace";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Find";
            // 
            // textoBusca
            // 
            this.textoBusca.Location = new System.Drawing.Point(452, 336);
            this.textoBusca.Name = "textoBusca";
            this.textoBusca.Size = new System.Drawing.Size(100, 20);
            this.textoBusca.TabIndex = 4;
            // 
            // botaoBusca
            // 
            this.botaoBusca.Location = new System.Drawing.Point(452, 362);
            this.botaoBusca.Name = "botaoBusca";
            this.botaoBusca.Size = new System.Drawing.Size(75, 23);
            this.botaoBusca.TabIndex = 5;
            this.botaoBusca.Text = "Find";
            this.botaoBusca.UseVisualStyleBackColor = true;
            this.botaoBusca.Click += new System.EventHandler(this.botaoBusca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoBusca);
            this.Controls.Add(this.textoBusca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoGrava);
            this.Controls.Add(this.textoConteudo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textoConteudo;
        private System.Windows.Forms.Button botaoGrava;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textoBusca;
        private System.Windows.Forms.Button botaoBusca;
    }
}

