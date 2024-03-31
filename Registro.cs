using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Diagnostics.Contracts;

namespace Login_User
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            NombreApellido.Visible = true;              // Muestra la ventana para ingresar el Nombre y Apellido
            UsuarioContraseña.Visible = false;          // Oculta la ventana para ingresar el Usuario y la Contraseña
            DatosContacto.Visible = false;              // Oculta la ventana para Ingresar el Correo y el #Telefono
            Siguiente.Visible = true;                   // Muestra el boton Siguiente
            Registrarse.Visible = false;                // Oculta el boton Registrarse
            InfoConfPassword.Visible = false;           // Oculta el mensaje de contraseña distinta a la anterior
            InfoCampoVacio.Visible = false;             // Oculta el mensaje de Campo vacio
            NombreUsuarioNoDisponible.Visible = false;
            ContraseñaMuyCorta.Visible = false;
            ContraseñaSinNumeros.Visible = false;
            
        }


        // Se crea la conexión a la base de datos
        readonly string conexion = "Data Source = CARLOS\\SQLEXPRESS; Initial Catalog = Usuarios;Integrated Security=True";

        private void NombreUsuario_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < NombreUsuario.Text.Length; i++)
            {
                if (UsuarioContraseña.Visible)
                {
                    using (SqlConnection connection = new SqlConnection(conexion))
                    {
                        string consulta = "SELECT COUNT(*) \r\nFROM Usuarios\r\nWHERE Usuario = @Usuario";

                        using (SqlCommand comando = new SqlCommand(consulta, connection))
                        {
                            connection.Open();
                            string usuario = NombreUsuario.Text;
                            comando.Parameters.AddWithValue("@Usuario", usuario);
                            int resultado = (int)comando.ExecuteScalar();
                            connection.Close();
                            if (resultado > 0)
                            { NombreUsuarioNoDisponible.Visible = true; }        // Muestra el mensaje de nombre de usuario no disponible
                            else
                            { NombreUsuarioNoDisponible.Visible = false; }
                            
                            if (NombreUsuarioNoDisponible.Visible)
                            { Siguiente.Visible = false; }
                        }
                    }
                }
            }
        }


        private void Password_TextChanged(object sender, EventArgs e)              // Caja de texto para la contrseña
        {
            Password.PasswordChar = '*';                                           // Oculta los caracteres al ingresar la contraseña
            for (int i = 0; i < Password.Text.Length; i++)
            {
                if (Password.Text.Length < 8)                                          // Comprueba si la contraseña ingresada tiene menos de 8 digitos
                { ContraseñaMuyCorta.Visible = true; }                                 // Si se cumple muenta el mensage contraseña muy corta
                else { ContraseñaMuyCorta.Visible = false; }

                bool ContieneNumero = false;                                                // Se inicializa la varible contienenumero
                for (int j = 0; j < Password.Text.Length; j++)                              // Recorre contraseña caracter por catacter
                {
                    if (Char.IsDigit(Password.Text[j]))                                     // Comprueba si alguno de los caracteres recorridos es un numero
                    {
                        ContieneNumero = true;
                        break;
                    }
                }

                if (!ContieneNumero)                                                        // Invierte el valor actual de la variable
                { ContraseñaSinNumeros.Visible = true; }                                    // Si la contraseña no contenia algun numero la variable = true y se imprime el mensage
                else { ContraseñaSinNumeros.Visible = false; }

                if (ContraseñaMuyCorta.Visible || ContraseñaSinNumeros.Visible)
                { Siguiente.Visible = false;}
            }
        }



        private void ConfirmarPassword_TextChanged(object sender, EventArgs e)     // Caja de texto para la confirmar contrseña
        {
           
            ConfirmarPassword.PasswordChar = '*';                                  // Oculta los caracteres al ingresar la contraseña 

            for (int i = 0; i < ConfirmarPassword.Text.Length; i++)
            {              
                if (Password.Text != ConfirmarPassword.Text)                          // Comprueva si la contraseña y la confirmacion son iguales 
                { InfoConfPassword.Visible = true; }                                        // Si no Muestra la info de contraseña distinta a la anterior 
                else 
                { 
                    InfoConfPassword.Visible = false; 
                    Siguiente.Visible = true;
                }
                if (NombreUsuarioNoDisponible.Visible || ContraseñaMuyCorta.Visible || ContraseñaSinNumeros.Visible || InfoConfPassword.Visible)
                { Siguiente.Visible = false; }

            }
        }



        public static string CalcularHashContraseña(string contraseña)
        {      
            using (SHA256 sha256 = SHA256.Create())                                // Se crea la instancia de la clase SHA256
            {
                byte[] bytes = Encoding.UTF8.GetBytes(contraseña);                 // Convertir la contraseña a bytes
                byte[] hash = sha256.ComputeHash(bytes);                           // Calcular el hash
                StringBuilder sb = new StringBuilder();                            // Convertir el hash a una cadena hexadecimal
                for (int i = 0; i < hash.Length; i++)
                { sb.Append(hash[i].ToString("x2")); }             

            return sb.ToString();
            }
        }


        private void Registrarse_Click(object sender, EventArgs e)                  // Boton Registrarse
        {
            // Verifica que los campos de correo electrónico y número de teléfono no estén vacios
            if (string.IsNullOrEmpty(CorreoElectronico.Text) || string.IsNullOrEmpty(NumeroTelefono.Text))
            { InfoCampoVacio.Visible = true; }          // Muestra el Mensaje de Campo Vacio


            else 
            {
                using (SqlConnection connection = new SqlConnection(conexion))
                {
                   
                    // Insertar los datos del usuario en la tabla Usuarios
                    string ConsultaUsuarios = "INSERT INTO Usuarios (Usuario, Nombre, Apellidos, CorreoElectronico, Telefono) VALUES (@Usuario, @Nombre, @Apellidos, @CorreoElectronico, @Telefono) ; SELECT SCOPE_IDENTITY();";
                    using (SqlCommand ComandoUsuarios = new SqlCommand(ConsultaUsuarios, connection))
                    {
                        connection.Open();
                        ComandoUsuarios.Parameters.AddWithValue("@Usuario", NombreUsuario.Text);                         // Agrega el Nombre de Usuario a la tabla
                        ComandoUsuarios.Parameters.AddWithValue("@Nombre", Nombre.Text);                                 // Agrega el Nombre a la tabla 
                        ComandoUsuarios.Parameters.AddWithValue("@Apellidos", Apellidos.Text);                           // Agrega el Nombre y Apellido a la tabla 
                        ComandoUsuarios.Parameters.AddWithValue("@CorreoElectronico", CorreoElectronico.Text);           // Agrega el Correo Electronico a la tabla 
                        ComandoUsuarios.Parameters.AddWithValue("@Telefono", NumeroTelefono.Text);                       // Agrega el Numero de Telefono a la tabla 
                                                                                
                        
                        int usuarioID = Convert.ToInt32(ComandoUsuarios.ExecuteScalar());    // Obtiene el ID del usuario que acabamos de registrar

                        // Inserta la contraseña del usuario en la tabla Contraseñas
                        string ConsultaContraseña = "INSERT INTO Contraseña (UsuarioID, Usuario, Contraseña) VALUES (@UsuarioID, @Usuario, @Contraseña)";
                        using (SqlCommand ComandoContraseña = new SqlCommand(ConsultaContraseña, connection))
                        {
                            ComandoContraseña.Parameters.AddWithValue("@UsuarioID", usuarioID);                                  // Agrega el ID obtemido a la tabla contrseña
                            ComandoContraseña.Parameters.AddWithValue("@Usuario", NombreUsuario.Text);                           // Agrega el Nombre de Usuario a la columna Usuario de la tabla Contraseña
                            ComandoContraseña.Parameters.AddWithValue("@Contraseña", CalcularHashContraseña(Password.Text));     // Agrega el hash de la contrseña a la tabla 
                                                                          
                            ComandoContraseña.ExecuteNonQuery();          // Se ejecuta el comando
                            connection.Close();                             // Se cierra la conexion

                            IniciarSesion iniciarsesion = new IniciarSesion();         // Se crea una unstancia de la clase iniciar sesion
                            iniciarsesion.Show();                                      // Se invoca la ventana de la clase iniciar sesion
                            this.Hide();                                               // Se cierra la ventana de Registro
                            MessageBox.Show("¡Usuario Registrado!");                   // Muestra un mensage de confirmacion
                        }
                    }
                }
            }
            
        }

        private void Siguiente_Click(object sender, EventArgs e)                                // Boton Siguiente
        {
            if (NombreApellido.Visible)                                                         // Comprueba si la ventana Nombre y Apellido esta visible
            {
                if (string.IsNullOrEmpty(Nombre.Text) || string.IsNullOrEmpty(Apellidos.Text))  // Comprueba si la caja de texto del Nombre y Apellido estan vacios
                { InfoCampoVacio.Visible = true; }                                              // Si se cumple la condicion se muestra la info de campo vacio

                else                                                                            // Si no
                {
                    NombreApellido.Visible = false;                                             // Se muestra la ventana 
                    InfoCampoVacio.Visible = false;                                             // Se oculta el mensaje de campo vacio
                    UsuarioContraseña.Visible = true;                                           // Se muestra la ventana Usuario y Contraseña
                    Siguiente.Visible = false;
                }
            }
            else if (UsuarioContraseña.Visible)                                                 // Comprueba si la ventana de Usuario y contraseña esta visible
            {                                                                                   // Si se cumple verifica que los campos no esten vacios
                if (string.IsNullOrEmpty(NombreUsuario.Text) || string.IsNullOrEmpty(Password.Text) || string.IsNullOrEmpty(ConfirmarPassword.Text))
                { InfoCampoVacio.Visible = true; }                                              // Si no muestra el mensage de campo vacio               

                else
                {
                    InfoCampoVacio.Visible = false;                  // Oculta el Mensage de Campo Vacio
                    UsuarioContraseña.Visible = false;               // Oculta la Ventana Usuario Y Contraseña
                    DatosContacto.Visible = true;                    // Mustra la Ventana Informacion de Contacto
                    Siguiente.Visible = false;                       // Muestra el boton Registrarse
                    Registrarse.Visible = true;                      // Oculta el boton Siguiente
                    NombreUsuarioNoDisponible.Visible = true;
                }
                
            }
        }

        private void Atras_Click(object sender, EventArgs e)                  // Boton atras
        {
            if (DatosContacto.Visible)                                        // Comprueba si la ventana de Informacioon de contacto esta visible
            {
                UsuarioContraseña.Visible = true;                             // Si se cumple muesta la ventana de usuario y contraseña
                DatosContacto.Visible = false;                                // Y oculta la ventana de Informacioon de contacto
            }
            
            else if (UsuarioContraseña.Visible)                               // Comprueva si la ventana de usuario y contraseña esta visible
            {
                NombreApellido.Visible = true;                                // Si se cumple muesta la ventana de Nombre y Apellido
                UsuarioContraseña.Visible = false;                            // Y oculta la ventana de usuario y contraseña
            }

            else if (Application.OpenForms.OfType<Registro>().Any())          // Comprueva si la ventana de Registro esta visible
            {                                                                 
                IniciarSesion iniciarsesion = new IniciarSesion();            // Si se cumple crea una instanca de la clase iniciar sesion
                iniciarsesion.Show();                                         // Y invoca la ventana de la clase iniciar sesion
                this.Hide();                                                  // Cierra la ventana de registro
            }

            Registrarse.Visible = false;                                      // Ocuta el boton Registrarse
            Siguiente.Visible = true;                                         // Muestra el boton Siguiente
            InfoConfPassword.Visible = false;                                 // Oculta la info de contraseña distinta
            InfoCampoVacio.Visible = false;                                   // Oculta el mensage de campo vacio
            NombreUsuarioNoDisponible.Visible = false;
        }

       
    }
}
