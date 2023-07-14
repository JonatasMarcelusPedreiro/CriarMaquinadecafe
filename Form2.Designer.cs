
namespace Aula05CriarMaquinadecomida
{
    partial class Form2
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
            this.lblFini = new System.Windows.Forms.Label();
            this.btnPix = new System.Windows.Forms.Button();
            this.btnDinheiro = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPagamento = new System.Windows.Forms.Label();
            this.btnComprar2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFini
            // 
            this.lblFini.AutoSize = true;
            this.lblFini.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFini.Font = new System.Drawing.Font("NewsGoth Lt BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFini.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFini.Location = new System.Drawing.Point(44, 40);
            this.lblFini.Name = "lblFini";
            this.lblFini.Size = new System.Drawing.Size(284, 29);
            this.lblFini.TabIndex = 6;
            this.lblFini.Text = "FORMAS DE PAGAMENTO";
            // 
            // btnPix
            // 
            this.btnPix.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPix.Location = new System.Drawing.Point(110, 88);
            this.btnPix.Name = "btnPix";
            this.btnPix.Size = new System.Drawing.Size(148, 56);
            this.btnPix.TabIndex = 7;
            this.btnPix.Text = "PIX";
            this.btnPix.UseVisualStyleBackColor = true;
            this.btnPix.Click += new System.EventHandler(this.btnPix_Click);
            // 
            // btnDinheiro
            // 
            this.btnDinheiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDinheiro.Location = new System.Drawing.Point(110, 163);
            this.btnDinheiro.Name = "btnDinheiro";
            this.btnDinheiro.Size = new System.Drawing.Size(148, 56);
            this.btnDinheiro.TabIndex = 8;
            this.btnDinheiro.Text = "DINHEIRO";
            this.btnDinheiro.UseVisualStyleBackColor = true;
            this.btnDinheiro.Click += new System.EventHandler(this.btnDinheiro_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(110, 235);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(148, 56);
            this.button2.TabIndex = 9;
            this.button2.Text = "CARTÃO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(91, 349);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(179, 20);
            this.txtValor.TabIndex = 10;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("NewsGoth Lt BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(88, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Digite o valor do produto:";
            // 
            // lblPagamento
            // 
            this.lblPagamento.AutoSize = true;
            this.lblPagamento.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPagamento.Font = new System.Drawing.Font("NewsGoth Lt BT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPagamento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPagamento.Location = new System.Drawing.Point(87, 372);
            this.lblPagamento.Name = "lblPagamento";
            this.lblPagamento.Size = new System.Drawing.Size(181, 19);
            this.lblPagamento.TabIndex = 11;
            this.lblPagamento.Text = "FORMA DE PAGAMENTO";
            // 
            // btnComprar2
            // 
            this.btnComprar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComprar2.Location = new System.Drawing.Point(110, 408);
            this.btnComprar2.Name = "btnComprar2";
            this.btnComprar2.Size = new System.Drawing.Size(121, 36);
            this.btnComprar2.TabIndex = 13;
            this.btnComprar2.Text = "COMPRAR";
            this.btnComprar2.UseVisualStyleBackColor = true;
            this.btnComprar2.Click += new System.EventHandler(this.btnComprar2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(394, 465);
            this.Controls.Add(this.btnComprar2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblPagamento);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDinheiro);
            this.Controls.Add(this.btnPix);
            this.Controls.Add(this.lblFini);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFini;
        private System.Windows.Forms.Button btnPix;
        private System.Windows.Forms.Button btnDinheiro;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPagamento;
        private System.Windows.Forms.Button btnComprar2;
    }
}