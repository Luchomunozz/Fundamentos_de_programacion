
namespace ExposiciónCiclos
{
    partial class Form1
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
            this.Ejecut = new System.Windows.Forms.Button();
            this.Números = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Ejecut
            // 
            this.Ejecut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Ejecut.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ejecut.Location = new System.Drawing.Point(210, 244);
            this.Ejecut.Name = "Ejecut";
            this.Ejecut.Size = new System.Drawing.Size(100, 35);
            this.Ejecut.TabIndex = 0;
            this.Ejecut.Text = "Ejecutar";
            this.Ejecut.UseVisualStyleBackColor = true;
            this.Ejecut.Click += new System.EventHandler(this.Ejecut_Click);
            // 
            // Números
            // 
            this.Números.FormattingEnabled = true;
            this.Números.Location = new System.Drawing.Point(200, 85);
            this.Números.Name = "Números";
            this.Números.Size = new System.Drawing.Size(123, 134);
            this.Números.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 400);
            this.Controls.Add(this.Números);
            this.Controls.Add(this.Ejecut);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Ejecut;
        private System.Windows.Forms.ListBox Números;
    }
}

