namespace Login_User
{
    partial class Usuarios
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
            this.BotonNuevo = new System.Windows.Forms.Button();
            this.CerrarSecion = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonNuevo
            // 
            this.BotonNuevo.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonNuevo.Location = new System.Drawing.Point(72, 366);
            this.BotonNuevo.Name = "BotonNuevo";
            this.BotonNuevo.Size = new System.Drawing.Size(134, 43);
            this.BotonNuevo.TabIndex = 0;
            this.BotonNuevo.Text = "Nuevo";
            this.BotonNuevo.UseVisualStyleBackColor = true;
            this.BotonNuevo.Click += new System.EventHandler(this.BotonNuevo_Click);
            // 
            // CerrarSecion
            // 
            this.CerrarSecion.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CerrarSecion.Location = new System.Drawing.Point(638, 366);
            this.CerrarSecion.Name = "CerrarSecion";
            this.CerrarSecion.Size = new System.Drawing.Size(134, 43);
            this.CerrarSecion.TabIndex = 1;
            this.CerrarSecion.Text = "Cerrar Sesion";
            this.CerrarSecion.UseVisualStyleBackColor = true;
            this.CerrarSecion.Click += new System.EventHandler(this.CerrarSecion_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.Location = new System.Drawing.Point(448, 366);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(134, 43);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizar.Location = new System.Drawing.Point(256, 366);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(134, 43);
            this.Actualizar.TabIndex = 3;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(847, 450);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.Eliminar);
            this.Controls.Add(this.CerrarSecion);
            this.Controls.Add(this.BotonNuevo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonNuevo;
        private System.Windows.Forms.Button CerrarSecion;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Actualizar;
    }
}