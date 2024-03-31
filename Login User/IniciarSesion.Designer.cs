namespace Login_User
{
    partial class IniciarSesion
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.InfoRegistrarse = new System.Windows.Forms.Button();
            this.Canselar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreUsuario = new System.Windows.Forms.TextBox();
            this.BotonIniciarSesion = new System.Windows.Forms.Button();
            this.InfoUsuarioIncorrecto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(300, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(193, 37);
            this.label5.TabIndex = 19;
            this.label5.Text = "¡Bienbenidos!";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 351);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(209, 20);
            this.label4.TabIndex = 18;
            this.label4.Text = "¿Aun no tienes una cuenta?";
            // 
            // InfoRegistrarse
            // 
            this.InfoRegistrarse.AutoSize = true;
            this.InfoRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.InfoRegistrarse.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoRegistrarse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.InfoRegistrarse.Location = new System.Drawing.Point(332, 374);
            this.InfoRegistrarse.Name = "InfoRegistrarse";
            this.InfoRegistrarse.Size = new System.Drawing.Size(131, 38);
            this.InfoRegistrarse.TabIndex = 17;
            this.InfoRegistrarse.Text = "Registrarse";
            this.InfoRegistrarse.UseVisualStyleBackColor = true;
            this.InfoRegistrarse.Click += new System.EventHandler(this.InfoRegistrarse_Click);
            // 
            // Canselar
            // 
            this.Canselar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Canselar.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Canselar.Location = new System.Drawing.Point(628, 374);
            this.Canselar.Name = "Canselar";
            this.Canselar.Size = new System.Drawing.Size(114, 38);
            this.Canselar.TabIndex = 16;
            this.Canselar.Text = "Canselar";
            this.Canselar.UseVisualStyleBackColor = true;
            this.Canselar.Click += new System.EventHandler(this.Canselar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(348, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "Iniciar sesion";
            // 
            // Password
            // 
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Location = new System.Drawing.Point(320, 184);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(158, 26);
            this.Password.TabIndex = 14;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(198, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 24);
            this.label2.TabIndex = 13;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(198, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Usuario:";
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombreUsuario.Location = new System.Drawing.Point(320, 146);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(158, 26);
            this.NombreUsuario.TabIndex = 11;
            // 
            // BotonIniciarSesion
            // 
            this.BotonIniciarSesion.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotonIniciarSesion.Location = new System.Drawing.Point(320, 256);
            this.BotonIniciarSesion.Name = "BotonIniciarSesion";
            this.BotonIniciarSesion.Size = new System.Drawing.Size(158, 43);
            this.BotonIniciarSesion.TabIndex = 10;
            this.BotonIniciarSesion.Text = "Iniciar sesion";
            this.BotonIniciarSesion.UseVisualStyleBackColor = true;
            this.BotonIniciarSesion.Click += new System.EventHandler(this.BotonIniciarSesion_Click);
            // 
            // InfoUsuarioIncorrecto
            // 
            this.InfoUsuarioIncorrecto.AutoSize = true;
            this.InfoUsuarioIncorrecto.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoUsuarioIncorrecto.ForeColor = System.Drawing.Color.Red;
            this.InfoUsuarioIncorrecto.Location = new System.Drawing.Point(266, 223);
            this.InfoUsuarioIncorrecto.Name = "InfoUsuarioIncorrecto";
            this.InfoUsuarioIncorrecto.Size = new System.Drawing.Size(262, 20);
            this.InfoUsuarioIncorrecto.TabIndex = 20;
            this.InfoUsuarioIncorrecto.Text = "El usuario o la contraseña son Incorrectos!";
            // 
            // IniciarSesion
            // 
            this.AcceptButton = this.BotonIniciarSesion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.Canselar;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InfoUsuarioIncorrecto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InfoRegistrarse);
            this.Controls.Add(this.Canselar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NombreUsuario);
            this.Controls.Add(this.BotonIniciarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "IniciarSesion";
            this.Text = "Iniciar Sesion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button InfoRegistrarse;
        private System.Windows.Forms.Button Canselar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NombreUsuario;
        private System.Windows.Forms.Button BotonIniciarSesion;
        private System.Windows.Forms.Label InfoUsuarioIncorrecto;
    }
}

