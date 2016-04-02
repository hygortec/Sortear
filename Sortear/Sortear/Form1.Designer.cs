namespace Sortear
{
    partial class TelaPrincipal
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
            this.lbInicial = new System.Windows.Forms.Label();
            this.tbInicial = new System.Windows.Forms.TextBox();
            this.tbFinal = new System.Windows.Forms.TextBox();
            this.lbFinal = new System.Windows.Forms.Label();
            this.btSortear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbInicial
            // 
            this.lbInicial.AutoSize = true;
            this.lbInicial.Location = new System.Drawing.Point(31, 17);
            this.lbInicial.Name = "lbInicial";
            this.lbInicial.Size = new System.Drawing.Size(34, 13);
            this.lbInicial.TabIndex = 0;
            this.lbInicial.Text = "Inicial";
            // 
            // tbInicial
            // 
            this.tbInicial.Location = new System.Drawing.Point(34, 33);
            this.tbInicial.Name = "tbInicial";
            this.tbInicial.Size = new System.Drawing.Size(100, 20);
            this.tbInicial.TabIndex = 1;
            // 
            // tbFinal
            // 
            this.tbFinal.Location = new System.Drawing.Point(140, 33);
            this.tbFinal.Name = "tbFinal";
            this.tbFinal.Size = new System.Drawing.Size(100, 20);
            this.tbFinal.TabIndex = 3;
            // 
            // lbFinal
            // 
            this.lbFinal.AutoSize = true;
            this.lbFinal.Location = new System.Drawing.Point(137, 17);
            this.lbFinal.Name = "lbFinal";
            this.lbFinal.Size = new System.Drawing.Size(29, 13);
            this.lbFinal.TabIndex = 2;
            this.lbFinal.Text = "Final";
            // 
            // btSortear
            // 
            this.btSortear.Location = new System.Drawing.Point(246, 30);
            this.btSortear.Name = "btSortear";
            this.btSortear.Size = new System.Drawing.Size(75, 23);
            this.btSortear.TabIndex = 4;
            this.btSortear.Text = "Sortear";
            this.btSortear.UseVisualStyleBackColor = true;
            this.btSortear.Click += new System.EventHandler(this.acaoBotaoSortear);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 261);
            this.Controls.Add(this.btSortear);
            this.Controls.Add(this.tbFinal);
            this.Controls.Add(this.lbFinal);
            this.Controls.Add(this.tbInicial);
            this.Controls.Add(this.lbInicial);
            this.Name = "TelaPrincipal";
            this.Text = "Sorteador de Numeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbInicial;
        private System.Windows.Forms.TextBox tbInicial;
        private System.Windows.Forms.TextBox tbFinal;
        private System.Windows.Forms.Label lbFinal;
        private System.Windows.Forms.Button btSortear;
    }
}

