
namespace Calculadora_de_IMC
{
    partial class FormCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculadora));
            this.lbPeso = new System.Windows.Forms.Label();
            this.lbAltura = new System.Windows.Forms.Label();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.lbResultado = new System.Windows.Forms.Label();
            this.lbClassificacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPeso
            // 
            this.lbPeso.AutoSize = true;
            this.lbPeso.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.lbPeso.Location = new System.Drawing.Point(12, 27);
            this.lbPeso.Name = "lbPeso";
            this.lbPeso.Size = new System.Drawing.Size(60, 25);
            this.lbPeso.TabIndex = 0;
            this.lbPeso.Text = "Peso:";
            this.lbPeso.Click += new System.EventHandler(this.lbPeso_Click);
            // 
            // lbAltura
            // 
            this.lbAltura.AutoSize = true;
            this.lbAltura.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.lbAltura.Location = new System.Drawing.Point(6, 65);
            this.lbAltura.Name = "lbAltura";
            this.lbAltura.Size = new System.Drawing.Size(74, 25);
            this.lbAltura.TabIndex = 1;
            this.lbAltura.Text = "Altura:";
            // 
            // txtPeso
            // 
            this.txtPeso.BackColor = System.Drawing.SystemColors.Info;
            this.txtPeso.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(86, 24);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(254, 32);
            this.txtPeso.TabIndex = 2;
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAltura
            // 
            this.txtAltura.BackColor = System.Drawing.SystemColors.Info;
            this.txtAltura.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.txtAltura.Location = new System.Drawing.Point(86, 62);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(254, 32);
            this.txtAltura.TabIndex = 3;
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalcula
            // 
            this.btnCalcula.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCalcula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcula.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.btnCalcula.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCalcula.Location = new System.Drawing.Point(11, 112);
            this.btnCalcula.Margin = new System.Windows.Forms.Padding(5);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(329, 32);
            this.btnCalcula.TabIndex = 4;
            this.btnCalcula.Text = "Calcular IMC";
            this.btnCalcula.UseVisualStyleBackColor = false;
            // 
            // lbResultado
            // 
            this.lbResultado.AutoSize = true;
            this.lbResultado.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.lbResultado.Location = new System.Drawing.Point(6, 159);
            this.lbResultado.Name = "lbResultado";
            this.lbResultado.Size = new System.Drawing.Size(106, 25);
            this.lbResultado.TabIndex = 5;
            this.lbResultado.Text = "Resultado:";
            // 
            // lbClassificacao
            // 
            this.lbClassificacao.AutoSize = true;
            this.lbClassificacao.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.lbClassificacao.Location = new System.Drawing.Point(6, 196);
            this.lbClassificacao.Name = "lbClassificacao";
            this.lbClassificacao.Size = new System.Drawing.Size(137, 25);
            this.lbClassificacao.TabIndex = 6;
            this.lbClassificacao.Text = "Classificação:";
            this.lbClassificacao.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(352, 441);
            this.Controls.Add(this.lbClassificacao);
            this.Controls.Add(this.lbResultado);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.lbAltura);
            this.Controls.Add(this.lbPeso);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCalculadora";
            this.Text = "Calculadora de IMC";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPeso;
        private System.Windows.Forms.Label lbAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Label lbResultado;
        private System.Windows.Forms.Label lbClassificacao;
    }
}

