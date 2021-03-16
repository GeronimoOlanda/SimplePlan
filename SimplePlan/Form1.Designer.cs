
namespace SimplePlan
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
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonBorracha = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CbExpressuraCaneta = new System.Windows.Forms.ComboBox();
            this.buttonCorCaneta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelPintura = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonLimpar);
            this.groupBox1.Controls.Add(this.buttonSalvar);
            this.groupBox1.Controls.Add(this.buttonBorracha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.CbExpressuraCaneta);
            this.groupBox1.Controls.Add(this.buttonCorCaneta);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(799, 72);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personalizar";
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(523, 25);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(95, 25);
            this.buttonLimpar.TabIndex = 7;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(711, 27);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(76, 23);
            this.buttonSalvar.TabIndex = 6;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonBorracha
            // 
            this.buttonBorracha.Location = new System.Drawing.Point(409, 25);
            this.buttonBorracha.Name = "buttonBorracha";
            this.buttonBorracha.Size = new System.Drawing.Size(87, 25);
            this.buttonBorracha.TabIndex = 4;
            this.buttonBorracha.Text = "Borracha";
            this.buttonBorracha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonBorracha.UseVisualStyleBackColor = true;
            this.buttonBorracha.Click += new System.EventHandler(this.buttonBorracha_Click);
            this.buttonBorracha.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonBorracha_MouseDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(185, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Expressura da Caneta";
            // 
            // CbExpressuraCaneta
            // 
            this.CbExpressuraCaneta.FormattingEnabled = true;
            this.CbExpressuraCaneta.Location = new System.Drawing.Point(204, 40);
            this.CbExpressuraCaneta.Name = "CbExpressuraCaneta";
            this.CbExpressuraCaneta.Size = new System.Drawing.Size(121, 26);
            this.CbExpressuraCaneta.TabIndex = 2;
            this.CbExpressuraCaneta.SelectedIndexChanged += new System.EventHandler(this.CbExpressuraCaneta_SelectedIndexChanged);
            // 
            // buttonCorCaneta
            // 
            this.buttonCorCaneta.BackColor = System.Drawing.Color.LightGreen;
            this.buttonCorCaneta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonCorCaneta.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.buttonCorCaneta.Location = new System.Drawing.Point(37, 39);
            this.buttonCorCaneta.Name = "buttonCorCaneta";
            this.buttonCorCaneta.Size = new System.Drawing.Size(60, 26);
            this.buttonCorCaneta.TabIndex = 1;
            this.buttonCorCaneta.UseVisualStyleBackColor = false;
            this.buttonCorCaneta.Click += new System.EventHandler(this.buttonCorCaneta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cor da Caneta";
            // 
            // panelPintura
            // 
            this.panelPintura.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPintura.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelPintura.Location = new System.Drawing.Point(10, 79);
            this.panelPintura.Name = "panelPintura";
            this.panelPintura.Size = new System.Drawing.Size(778, 361);
            this.panelPintura.TabIndex = 1;
            this.panelPintura.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPintura_MouseDown);
            this.panelPintura.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelPintura_MouseMove);
            this.panelPintura.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelPintura_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPintura);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbExpressuraCaneta;
        private System.Windows.Forms.Button buttonCorCaneta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonBorracha;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Panel panelPintura;
    }
}

