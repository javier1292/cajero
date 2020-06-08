namespace CajeroAutomatico
{
    partial class Start
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button = new System.Windows.Forms.Button();
            this.buttonConfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(179, 190);
            this.button.Margin = new System.Windows.Forms.Padding(4);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(148, 49);
            this.button.TabIndex = 0;
            this.button.Text = "Continuar";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonConfig
            // 
            this.buttonConfig.Location = new System.Drawing.Point(13, 264);
            this.buttonConfig.Margin = new System.Windows.Forms.Padding(4);
            this.buttonConfig.Name = "buttonConfig";
            this.buttonConfig.Size = new System.Drawing.Size(100, 28);
            this.buttonConfig.TabIndex = 1;
            this.buttonConfig.Text = "Registro ";
            this.buttonConfig.UseVisualStyleBackColor = true;
            this.buttonConfig.Click += new System.EventHandler(this.buttonConfig_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 65);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(488, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido si ya tiene una cuenta dele a continuar \r\nsi no ,entre a registro ";
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(562, 370);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.buttonConfig);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BancoLUDO";
            this.Load += new System.EventHandler(this.Start_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Button buttonConfig;
        private System.Windows.Forms.Label label1;
    }
}

