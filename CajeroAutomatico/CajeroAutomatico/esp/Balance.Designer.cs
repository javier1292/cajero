namespace CajeroAutomatico.esp
{
    partial class Balance
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
            this.labelBlance = new System.Windows.Forms.Label();
            this.buttonOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelBlance
            // 
            this.labelBlance.BackColor = System.Drawing.Color.Transparent;
            this.labelBlance.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBlance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.labelBlance.Location = new System.Drawing.Point(205, 261);
            this.labelBlance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBlance.Name = "labelBlance";
            this.labelBlance.Size = new System.Drawing.Size(309, 59);
            this.labelBlance.TabIndex = 1;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(561, 430);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(148, 49);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Su balance es:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 277);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "RD";
            // 
            // Balance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 494);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.labelBlance);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Balance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Balance";
            this.Load += new System.EventHandler(this.Balance_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelBlance;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}