namespace CajeroAutomatico.esp
{
    partial class Retirootro
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_monto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_monto
            // 
            this.txt_monto.Location = new System.Drawing.Point(72, 75);
            this.txt_monto.Multiline = true;
            this.txt_monto.Name = "txt_monto";
            this.txt_monto.Size = new System.Drawing.Size(196, 38);
            this.txt_monto.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "Listo ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Digite la cantidd deseada ";
            // 
            // Retirootro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 232);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_monto);
            this.Name = "Retirootro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_monto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}
