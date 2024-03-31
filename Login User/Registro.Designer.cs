namespace Login_User
{
    partial class Registro
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
            this.UsuarioContraseña = new System.Windows.Forms.Panel();
            this.ContraseñaSinNumeros = new System.Windows.Forms.Label();
            this.ContraseñaMuyCorta = new System.Windows.Forms.Label();
            this.NombreUsuarioNoDisponible = new System.Windows.Forms.Label();
            this.InfoConfPassword = new System.Windows.Forms.Label();
            this.InfoIngresaUsuario = new System.Windows.Forms.Label();
            this.InfoCreaContraseñaSegura = new System.Windows.Forms.Label();
            this.ConfirmarPassword = new System.Windows.Forms.TextBox();
            this.InfoConfirmarContraseña = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.InfoContraseña = new System.Windows.Forms.Label();
            this.InfoNombreUsuario = new System.Windows.Forms.Label();
            this.NombreUsuario = new System.Windows.Forms.TextBox();
            this.Siguiente = new System.Windows.Forms.Button();
            this.NombreApellido = new System.Windows.Forms.Panel();
            this.InfoCrearCuenta = new System.Windows.Forms.Label();
            this.InfoIngresarDatos = new System.Windows.Forms.Label();
            this.Apellidos = new System.Windows.Forms.TextBox();
            this.InfoApellidos = new System.Windows.Forms.Label();
            this.InfoNombre = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.TextBox();
            this.Atras = new System.Windows.Forms.Button();
            this.DatosContacto = new System.Windows.Forms.Panel();
            this.InfoNumTelefono = new System.Windows.Forms.Label();
            this.InfoCorreo = new System.Windows.Forms.Label();
            this.InfoContacto = new System.Windows.Forms.Label();
            this.InfoContacto2 = new System.Windows.Forms.Label();
            this.NumeroTelefono = new System.Windows.Forms.TextBox();
            this.CorreoElectronico = new System.Windows.Forms.TextBox();
            this.InfoCampoVacio = new System.Windows.Forms.Label();
            this.Registrarse = new System.Windows.Forms.Button();
            this.UsuarioContraseña.SuspendLayout();
            this.NombreApellido.SuspendLayout();
            this.DatosContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsuarioContraseña
            // 
            this.UsuarioContraseña.Controls.Add(this.ContraseñaSinNumeros);
            this.UsuarioContraseña.Controls.Add(this.ContraseñaMuyCorta);
            this.UsuarioContraseña.Controls.Add(this.NombreUsuarioNoDisponible);
            this.UsuarioContraseña.Controls.Add(this.InfoConfPassword);
            this.UsuarioContraseña.Controls.Add(this.InfoIngresaUsuario);
            this.UsuarioContraseña.Controls.Add(this.InfoCreaContraseñaSegura);
            this.UsuarioContraseña.Controls.Add(this.ConfirmarPassword);
            this.UsuarioContraseña.Controls.Add(this.InfoConfirmarContraseña);
            this.UsuarioContraseña.Controls.Add(this.Password);
            this.UsuarioContraseña.Controls.Add(this.InfoContraseña);
            this.UsuarioContraseña.Controls.Add(this.InfoNombreUsuario);
            this.UsuarioContraseña.Controls.Add(this.NombreUsuario);
            this.UsuarioContraseña.Location = new System.Drawing.Point(70, 33);
            this.UsuarioContraseña.Name = "UsuarioContraseña";
            this.UsuarioContraseña.Size = new System.Drawing.Size(658, 308);
            this.UsuarioContraseña.TabIndex = 1;
            // 
            // ContraseñaSinNumeros
            // 
            this.ContraseñaSinNumeros.AutoSize = true;
            this.ContraseñaSinNumeros.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñaSinNumeros.ForeColor = System.Drawing.Color.Red;
            this.ContraseñaSinNumeros.Location = new System.Drawing.Point(175, 277);
            this.ContraseñaSinNumeros.Name = "ContraseñaSinNumeros";
            this.ContraseñaSinNumeros.Size = new System.Drawing.Size(316, 20);
            this.ContraseñaSinNumeros.TabIndex = 36;
            this.ContraseñaSinNumeros.Text = "¡La contraseña debe contener al menos un numero!";
            // 
            // ContraseñaMuyCorta
            // 
            this.ContraseñaMuyCorta.AutoSize = true;
            this.ContraseñaMuyCorta.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñaMuyCorta.ForeColor = System.Drawing.Color.Red;
            this.ContraseñaMuyCorta.Location = new System.Drawing.Point(179, 277);
            this.ContraseñaMuyCorta.Name = "ContraseñaMuyCorta";
            this.ContraseñaMuyCorta.Size = new System.Drawing.Size(312, 20);
            this.ContraseñaMuyCorta.TabIndex = 35;
            this.ContraseñaMuyCorta.Text = "¡La contraseña  debe contener al menos  8 digitos!";
            // 
            // NombreUsuarioNoDisponible
            // 
            this.NombreUsuarioNoDisponible.AutoSize = true;
            this.NombreUsuarioNoDisponible.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreUsuarioNoDisponible.ForeColor = System.Drawing.Color.Red;
            this.NombreUsuarioNoDisponible.Location = new System.Drawing.Point(225, 257);
            this.NombreUsuarioNoDisponible.Name = "NombreUsuarioNoDisponible";
            this.NombreUsuarioNoDisponible.Size = new System.Drawing.Size(219, 20);
            this.NombreUsuarioNoDisponible.TabIndex = 34;
            this.NombreUsuarioNoDisponible.Text = "¡Nombre de Usuario no Disponible!";
            // 
            // InfoConfPassword
            // 
            this.InfoConfPassword.AutoSize = true;
            this.InfoConfPassword.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoConfPassword.ForeColor = System.Drawing.Color.Red;
            this.InfoConfPassword.Location = new System.Drawing.Point(204, 257);
            this.InfoConfPassword.Name = "InfoConfPassword";
            this.InfoConfPassword.Size = new System.Drawing.Size(257, 20);
            this.InfoConfPassword.TabIndex = 33;
            this.InfoConfPassword.Text = "¡La Contrseña debe ser igual a la anterior!";
            // 
            // InfoIngresaUsuario
            // 
            this.InfoIngresaUsuario.AutoSize = true;
            this.InfoIngresaUsuario.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoIngresaUsuario.Location = new System.Drawing.Point(215, 77);
            this.InfoIngresaUsuario.Name = "InfoIngresaUsuario";
            this.InfoIngresaUsuario.Size = new System.Drawing.Size(246, 24);
            this.InfoIngresaUsuario.TabIndex = 32;
            this.InfoIngresaUsuario.Text = "Ingresa tu Usuario y Contraseña";
            // 
            // InfoCreaContraseñaSegura
            // 
            this.InfoCreaContraseñaSegura.AutoSize = true;
            this.InfoCreaContraseñaSegura.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoCreaContraseñaSegura.Location = new System.Drawing.Point(171, 20);
            this.InfoCreaContraseñaSegura.Name = "InfoCreaContraseñaSegura";
            this.InfoCreaContraseñaSegura.Size = new System.Drawing.Size(332, 33);
            this.InfoCreaContraseñaSegura.TabIndex = 31;
            this.InfoCreaContraseñaSegura.Text = "Crea una Contraseña Segura";
            // 
            // ConfirmarPassword
            // 
            this.ConfirmarPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ConfirmarPassword.Location = new System.Drawing.Point(258, 216);
            this.ConfirmarPassword.Name = "ConfirmarPassword";
            this.ConfirmarPassword.Size = new System.Drawing.Size(158, 26);
            this.ConfirmarPassword.TabIndex = 30;
            this.ConfirmarPassword.TextChanged += new System.EventHandler(this.ConfirmarPassword_TextChanged);
            // 
            // InfoConfirmarContraseña
            // 
            this.InfoConfirmarContraseña.AutoSize = true;
            this.InfoConfirmarContraseña.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoConfirmarContraseña.Location = new System.Drawing.Point(44, 218);
            this.InfoConfirmarContraseña.Name = "InfoConfirmarContraseña";
            this.InfoConfirmarContraseña.Size = new System.Drawing.Size(176, 24);
            this.InfoConfirmarContraseña.TabIndex = 29;
            this.InfoConfirmarContraseña.Text = "Confirmar Contraseña:";
            // 
            // Password
            // 
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Password.Location = new System.Drawing.Point(258, 175);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(158, 26);
            this.Password.TabIndex = 28;
            this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // InfoContraseña
            // 
            this.InfoContraseña.AutoSize = true;
            this.InfoContraseña.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoContraseña.Location = new System.Drawing.Point(44, 177);
            this.InfoContraseña.Name = "InfoContraseña";
            this.InfoContraseña.Size = new System.Drawing.Size(99, 24);
            this.InfoContraseña.TabIndex = 27;
            this.InfoContraseña.Text = "Contraseña:";
            // 
            // InfoNombreUsuario
            // 
            this.InfoNombreUsuario.AutoSize = true;
            this.InfoNombreUsuario.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoNombreUsuario.Location = new System.Drawing.Point(44, 135);
            this.InfoNombreUsuario.Name = "InfoNombreUsuario";
            this.InfoNombreUsuario.Size = new System.Drawing.Size(157, 24);
            this.InfoNombreUsuario.TabIndex = 26;
            this.InfoNombreUsuario.Text = "Nombre de Usuario:";
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombreUsuario.Location = new System.Drawing.Point(258, 133);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(158, 26);
            this.NombreUsuario.TabIndex = 25;
            this.NombreUsuario.TextChanged += new System.EventHandler(this.NombreUsuario_TextChanged);
            // 
            // Siguiente
            // 
            this.Siguiente.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Siguiente.Location = new System.Drawing.Point(602, 372);
            this.Siguiente.Name = "Siguiente";
            this.Siguiente.Size = new System.Drawing.Size(126, 40);
            this.Siguiente.TabIndex = 2;
            this.Siguiente.Text = "Siguiente";
            this.Siguiente.UseVisualStyleBackColor = true;
            this.Siguiente.Click += new System.EventHandler(this.Siguiente_Click);
            // 
            // NombreApellido
            // 
            this.NombreApellido.Controls.Add(this.InfoCrearCuenta);
            this.NombreApellido.Controls.Add(this.InfoIngresarDatos);
            this.NombreApellido.Controls.Add(this.Apellidos);
            this.NombreApellido.Controls.Add(this.InfoApellidos);
            this.NombreApellido.Controls.Add(this.InfoNombre);
            this.NombreApellido.Controls.Add(this.Nombre);
            this.NombreApellido.Location = new System.Drawing.Point(135, 33);
            this.NombreApellido.Name = "NombreApellido";
            this.NombreApellido.Size = new System.Drawing.Size(508, 228);
            this.NombreApellido.TabIndex = 3;
            // 
            // InfoCrearCuenta
            // 
            this.InfoCrearCuenta.AutoSize = true;
            this.InfoCrearCuenta.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoCrearCuenta.Location = new System.Drawing.Point(176, 37);
            this.InfoCrearCuenta.Name = "InfoCrearCuenta";
            this.InfoCrearCuenta.Size = new System.Drawing.Size(199, 33);
            this.InfoCrearCuenta.TabIndex = 29;
            this.InfoCrearCuenta.Text = "Crea una Cuenta";
            // 
            // InfoIngresarDatos
            // 
            this.InfoIngresarDatos.AutoSize = true;
            this.InfoIngresarDatos.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoIngresarDatos.Location = new System.Drawing.Point(196, 82);
            this.InfoIngresarDatos.Name = "InfoIngresarDatos";
            this.InfoIngresarDatos.Size = new System.Drawing.Size(147, 24);
            this.InfoIngresarDatos.TabIndex = 28;
            this.InfoIngresarDatos.Text = "Ingresa tu Nombre";
            // 
            // Apellidos
            // 
            this.Apellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Apellidos.Location = new System.Drawing.Point(193, 165);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(158, 26);
            this.Apellidos.TabIndex = 27;
            // 
            // InfoApellidos
            // 
            this.InfoApellidos.AutoSize = true;
            this.InfoApellidos.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoApellidos.Location = new System.Drawing.Point(85, 165);
            this.InfoApellidos.Name = "InfoApellidos";
            this.InfoApellidos.Size = new System.Drawing.Size(79, 24);
            this.InfoApellidos.TabIndex = 26;
            this.InfoApellidos.Text = "Apellidos:";
            // 
            // InfoNombre
            // 
            this.InfoNombre.AutoSize = true;
            this.InfoNombre.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoNombre.Location = new System.Drawing.Point(85, 129);
            this.InfoNombre.Name = "InfoNombre";
            this.InfoNombre.Size = new System.Drawing.Size(74, 24);
            this.InfoNombre.TabIndex = 25;
            this.InfoNombre.Text = "Nombre:";
            // 
            // Nombre
            // 
            this.Nombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nombre.Location = new System.Drawing.Point(193, 127);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(158, 26);
            this.Nombre.TabIndex = 24;
            // 
            // Atras
            // 
            this.Atras.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Atras.Location = new System.Drawing.Point(70, 372);
            this.Atras.Name = "Atras";
            this.Atras.Size = new System.Drawing.Size(126, 39);
            this.Atras.TabIndex = 4;
            this.Atras.Text = "Atras";
            this.Atras.UseVisualStyleBackColor = true;
            this.Atras.Click += new System.EventHandler(this.Atras_Click);
            // 
            // DatosContacto
            // 
            this.DatosContacto.Controls.Add(this.InfoNumTelefono);
            this.DatosContacto.Controls.Add(this.InfoCorreo);
            this.DatosContacto.Controls.Add(this.InfoContacto);
            this.DatosContacto.Controls.Add(this.InfoContacto2);
            this.DatosContacto.Controls.Add(this.NumeroTelefono);
            this.DatosContacto.Controls.Add(this.CorreoElectronico);
            this.DatosContacto.Location = new System.Drawing.Point(70, 29);
            this.DatosContacto.Name = "DatosContacto";
            this.DatosContacto.Size = new System.Drawing.Size(660, 312);
            this.DatosContacto.TabIndex = 34;
            // 
            // InfoNumTelefono
            // 
            this.InfoNumTelefono.AutoSize = true;
            this.InfoNumTelefono.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoNumTelefono.Location = new System.Drawing.Point(80, 188);
            this.InfoNumTelefono.Name = "InfoNumTelefono";
            this.InfoNumTelefono.Size = new System.Drawing.Size(165, 24);
            this.InfoNumTelefono.TabIndex = 33;
            this.InfoNumTelefono.Text = "Numero de Telefono:";
            // 
            // InfoCorreo
            // 
            this.InfoCorreo.AutoSize = true;
            this.InfoCorreo.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoCorreo.Location = new System.Drawing.Point(80, 145);
            this.InfoCorreo.Name = "InfoCorreo";
            this.InfoCorreo.Size = new System.Drawing.Size(148, 24);
            this.InfoCorreo.TabIndex = 32;
            this.InfoCorreo.Text = "Correo Electronico:";
            // 
            // InfoContacto
            // 
            this.InfoContacto.AutoSize = true;
            this.InfoContacto.Font = new System.Drawing.Font("Arial Narrow", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoContacto.Location = new System.Drawing.Point(192, 46);
            this.InfoContacto.Name = "InfoContacto";
            this.InfoContacto.Size = new System.Drawing.Size(286, 33);
            this.InfoContacto.TabIndex = 31;
            this.InfoContacto.Text = "Informacion de Contacto";
            // 
            // InfoContacto2
            // 
            this.InfoContacto2.AutoSize = true;
            this.InfoContacto2.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoContacto2.Location = new System.Drawing.Point(214, 92);
            this.InfoContacto2.Name = "InfoContacto2";
            this.InfoContacto2.Size = new System.Drawing.Size(233, 24);
            this.InfoContacto2.TabIndex = 30;
            this.InfoContacto2.Text = "Ingresa tus Datos de Contacto";
            // 
            // NumeroTelefono
            // 
            this.NumeroTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NumeroTelefono.Location = new System.Drawing.Point(257, 186);
            this.NumeroTelefono.Name = "NumeroTelefono";
            this.NumeroTelefono.Size = new System.Drawing.Size(158, 26);
            this.NumeroTelefono.TabIndex = 29;
            // 
            // CorreoElectronico
            // 
            this.CorreoElectronico.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CorreoElectronico.Location = new System.Drawing.Point(257, 143);
            this.CorreoElectronico.Name = "CorreoElectronico";
            this.CorreoElectronico.Size = new System.Drawing.Size(158, 26);
            this.CorreoElectronico.TabIndex = 28;
            // 
            // InfoCampoVacio
            // 
            this.InfoCampoVacio.AutoSize = true;
            this.InfoCampoVacio.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoCampoVacio.ForeColor = System.Drawing.Color.Red;
            this.InfoCampoVacio.Location = new System.Drawing.Point(284, 344);
            this.InfoCampoVacio.Name = "InfoCampoVacio";
            this.InfoCampoVacio.Size = new System.Drawing.Size(245, 20);
            this.InfoCampoVacio.TabIndex = 35;
            this.InfoCampoVacio.Text = "!Por favor, complete todos los campos!";
            // 
            // Registrarse
            // 
            this.Registrarse.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registrarse.Location = new System.Drawing.Point(602, 372);
            this.Registrarse.Name = "Registrarse";
            this.Registrarse.Size = new System.Drawing.Size(128, 39);
            this.Registrarse.TabIndex = 36;
            this.Registrarse.Text = "Registrarse";
            this.Registrarse.UseVisualStyleBackColor = true;
            this.Registrarse.Click += new System.EventHandler(this.Registrarse_Click);
            // 
            // Registro
            // 
            this.AcceptButton = this.Registrarse;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Atras;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.Registrarse);
            this.Controls.Add(this.InfoCampoVacio);
            this.Controls.Add(this.DatosContacto);
            this.Controls.Add(this.Atras);
            this.Controls.Add(this.Siguiente);
            this.Controls.Add(this.UsuarioContraseña);
            this.Controls.Add(this.NombreApellido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Registro";
            this.Text = "Registro";
            this.UsuarioContraseña.ResumeLayout(false);
            this.UsuarioContraseña.PerformLayout();
            this.NombreApellido.ResumeLayout(false);
            this.NombreApellido.PerformLayout();
            this.DatosContacto.ResumeLayout(false);
            this.DatosContacto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel UsuarioContraseña;
        private System.Windows.Forms.Label InfoIngresaUsuario;
        private System.Windows.Forms.Label InfoCreaContraseñaSegura;
        private System.Windows.Forms.TextBox ConfirmarPassword;
        private System.Windows.Forms.Label InfoConfirmarContraseña;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label InfoContraseña;
        private System.Windows.Forms.Label InfoNombreUsuario;
        private System.Windows.Forms.TextBox NombreUsuario;
        private System.Windows.Forms.Button Siguiente;
        private System.Windows.Forms.Panel NombreApellido;
        private System.Windows.Forms.Label InfoCrearCuenta;
        private System.Windows.Forms.Label InfoIngresarDatos;
        private System.Windows.Forms.TextBox Apellidos;
        private System.Windows.Forms.Label InfoApellidos;
        private System.Windows.Forms.Label InfoNombre;
        private System.Windows.Forms.TextBox Nombre;
        private System.Windows.Forms.Button Atras;
        private System.Windows.Forms.Label InfoConfPassword;
        private System.Windows.Forms.Panel DatosContacto;
        private System.Windows.Forms.TextBox NumeroTelefono;
        private System.Windows.Forms.TextBox CorreoElectronico;
        private System.Windows.Forms.Label InfoContacto;
        private System.Windows.Forms.Label InfoContacto2;
        private System.Windows.Forms.Label InfoNumTelefono;
        private System.Windows.Forms.Label InfoCorreo;
        private System.Windows.Forms.Label InfoCampoVacio;
        private System.Windows.Forms.Button Registrarse;
        private System.Windows.Forms.Label NombreUsuarioNoDisponible;
        private System.Windows.Forms.Label ContraseñaSinNumeros;
        private System.Windows.Forms.Label ContraseñaMuyCorta;
    }
}