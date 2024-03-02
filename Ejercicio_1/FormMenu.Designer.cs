namespace Ejercicio_1
{
    partial class FormMenu
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
            this.btnAgregarEstudiantes = new System.Windows.Forms.Button();
            this.btnReporteEstudiantes = new System.Windows.Forms.Button();
            this.btnListadoEstudiantes = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAgregarEstudiantes
            // 
            this.btnAgregarEstudiantes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarEstudiantes.Location = new System.Drawing.Point(90, 92);
            this.btnAgregarEstudiantes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarEstudiantes.Name = "btnAgregarEstudiantes";
            this.btnAgregarEstudiantes.Size = new System.Drawing.Size(319, 59);
            this.btnAgregarEstudiantes.TabIndex = 0;
            this.btnAgregarEstudiantes.Text = "Ingresar datos de nuevo estudiante";
            this.btnAgregarEstudiantes.UseVisualStyleBackColor = true;
            this.btnAgregarEstudiantes.Click += new System.EventHandler(this.btnAgregarEstudiantes_Click);
            // 
            // btnReporteEstudiantes
            // 
            this.btnReporteEstudiantes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteEstudiantes.Location = new System.Drawing.Point(90, 279);
            this.btnReporteEstudiantes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReporteEstudiantes.Name = "btnReporteEstudiantes";
            this.btnReporteEstudiantes.Size = new System.Drawing.Size(319, 59);
            this.btnReporteEstudiantes.TabIndex = 1;
            this.btnReporteEstudiantes.Text = "Reporte de estudiantes";
            this.btnReporteEstudiantes.UseVisualStyleBackColor = true;
            this.btnReporteEstudiantes.Click += new System.EventHandler(this.btnReporteEstudiantes_Click);
            // 
            // btnListadoEstudiantes
            // 
            this.btnListadoEstudiantes.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListadoEstudiantes.Location = new System.Drawing.Point(90, 186);
            this.btnListadoEstudiantes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnListadoEstudiantes.Name = "btnListadoEstudiantes";
            this.btnListadoEstudiantes.Size = new System.Drawing.Size(319, 59);
            this.btnListadoEstudiantes.TabIndex = 2;
            this.btnListadoEstudiantes.Text = "Ver listado de estudiantes inscritos";
            this.btnListadoEstudiantes.UseVisualStyleBackColor = true;
            this.btnListadoEstudiantes.Click += new System.EventHandler(this.btnListadoEstudiantes_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(90, 373);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(319, 59);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 43);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mantenimiento de Usuarios";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 453);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListadoEstudiantes);
            this.Controls.Add(this.btnReporteEstudiantes);
            this.Controls.Add(this.btnAgregarEstudiantes);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarEstudiantes;
        private System.Windows.Forms.Button btnReporteEstudiantes;
        private System.Windows.Forms.Button btnListadoEstudiantes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
    }
}

