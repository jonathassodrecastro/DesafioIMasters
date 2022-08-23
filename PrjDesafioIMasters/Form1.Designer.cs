namespace DesafioIMasters
{
    partial class frmVerifica
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtCaractere = new System.Windows.Forms.TextBox();
            this.btnVerifica = new System.Windows.Forms.Button();
            this.lblCaractere = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(26, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(165, 34);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Informe o Caractere";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCaractere
            // 
            this.txtCaractere.Location = new System.Drawing.Point(53, 56);
            this.txtCaractere.Name = "txtCaractere";
            this.txtCaractere.Size = new System.Drawing.Size(94, 23);
            this.txtCaractere.TabIndex = 1;
            // 
            // btnVerifica
            // 
            this.btnVerifica.Location = new System.Drawing.Point(53, 85);
            this.btnVerifica.Name = "btnVerifica";
            this.btnVerifica.Size = new System.Drawing.Size(95, 23);
            this.btnVerifica.TabIndex = 2;
            this.btnVerifica.Text = "Verifica";
            this.btnVerifica.UseVisualStyleBackColor = true;
            this.btnVerifica.Click += new System.EventHandler(this.btnVerifica_Click);
            // 
            // lblCaractere
            // 
            this.lblCaractere.Location = new System.Drawing.Point(26, 121);
            this.lblCaractere.Name = "lblCaractere";
            this.lblCaractere.Size = new System.Drawing.Size(165, 35);
            this.lblCaractere.TabIndex = 3;
            // 
            // frmVerifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 178);
            this.Controls.Add(this.lblCaractere);
            this.Controls.Add(this.btnVerifica);
            this.Controls.Add(this.txtCaractere);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVerifica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verifica Caractere";
            this.Load += new System.EventHandler(this.frmVerifica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitulo;
        private TextBox txtCaractere;
        private Button btnVerifica;
        private Label lblCaractere;
    }
}