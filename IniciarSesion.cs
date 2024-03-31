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

namespace Login_User
{
    public partial class IniciarSesion : Form
    {
        public IniciarSesion()
        {
            InitializeComponent();
            InfoUsuarioIncorrecto.Visible = false;
        }

        private void InfoRegistrarse_Click(object sender, EventArgs e)
        {
            Registro registro = new Registro();
            registro.Show();
            this.Hide();
        }

        private void Canselar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Password_TextChanged(object sender, EventArgs e)
        {
            Password.PasswordChar = '*';
        }

        private void BotonIniciarSesion_Click(object sender, EventArgs e)
        {
            string hashContraseña = Registro.CalcularHashContraseña(Password.Text); // Calcula el hash de la contraseña ingresada
            string usuario = NombreUsuario.Text; // Se asigna el Nombre de Usuario Ingresado a la variable usuario
            string contraseña = hashContraseña;  // Se asigna la Contraseña ingresada a la variable contraseña
            using (SqlConnection conexion = new SqlConnection("server = CARLOS\\SQLEXPRESS; database = Usuarios; integrated security = true"))
            {
                conexion.Open();

                string consulta = "SELECT COUNT(*) \r\nFROM Contraseña\r\nWHERE Usuario = @Usuario AND Contraseña = @Contraseña;";

                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@Usuario", usuario);
                    comando.Parameters.AddWithValue("@Contraseña", contraseña);         

                    int resultado = (int)comando.ExecuteScalar();
                    conexion.Close();
                    if (resultado > 0)
                    {
                        Usuarios usuarios = new Usuarios();
                        usuarios.Show();
                        this.Hide();
                        MessageBox.Show($"¡Bienvenido {usuario}!");
                        
                     
                        InfoUsuarioIncorrecto.Visible = false; // Oculta el mensaje de usuario o contraseña incorrecto
                    }
                    else
                    {
                        InfoUsuarioIncorrecto.Visible = true; // Mustra el mensaje de usuario o contraseña incorrecto
                    }

                }
            }
        }
    }
}
