namespace CajeroAutomatico
{
    partial class Config
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
            this.txt_confirmar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Monto = new System.Windows.Forms.TextBox();
            this.Clave = new System.Windows.Forms.TextBox();
            this.Apellido = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_confirmar
            // 
            this.txt_confirmar.Location = new System.Drawing.Point(125, 122);
            this.txt_confirmar.Name = "txt_confirmar";
            this.txt_confirmar.PasswordChar = '*';
            this.txt_confirmar.Size = new System.Drawing.Size(171, 22);
            this.txt_confirmar.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "Confirmar pin:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Monto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Clave:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Apellido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nombre:";
            // 
            // Monto
            // 
            this.Monto.Location = new System.Drawing.Point(125, 151);
            this.Monto.Margin = new System.Windows.Forms.Padding(4);
            this.Monto.Name = "Monto";
            this.Monto.Size = new System.Drawing.Size(171, 22);
            this.Monto.TabIndex = 20;
            // 
            // Clave
            // 
            this.Clave.Location = new System.Drawing.Point(125, 93);
            this.Clave.Margin = new System.Windows.Forms.Padding(4);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(171, 22);
            this.Clave.TabIndex = 13;
            // 
            // Apellido
            // 
            this.Apellido.Location = new System.Drawing.Point(125, 61);
            this.Apellido.Margin = new System.Windows.Forms.Padding(4);
            this.Apellido.Name = "Apellido";
            this.Apellido.Size = new System.Drawing.Size(171, 22);
            this.Apellido.TabIndex = 12;
            // 
            // Nombre
            // 
            this.Nombre.Location = new System.Drawing.Point(125, 29);
            this.Nombre.Margin = new System.Windows.Forms.Padding(4);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(171, 22);
            this.Nombre.TabIndex = 11;
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.Location = new System.Drawing.Point(182, 191);
            this.buttonActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(100, 28);
            this.buttonActualizar.TabIndex = 10;
            this.buttonActualizar.Text = "Actualizar";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 288);
            this.Controls.Add(this.txt_confirmar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Monto);
            this.Controls.Add(this.Clave);
            this.Controls.Add(this.Apellido);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.buttonActualizar);
            this.Name = "Config";
            this.Text = "Config";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_confirmar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Monto;
        private System.Windows.Forms.TextBox Clave;
        private System.Windows.Forms.TextBox Apellido;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Button buttonActualizar;
    }
}