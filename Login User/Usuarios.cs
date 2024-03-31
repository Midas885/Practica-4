using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login_User
{
    public partial class Usuarios : Form
    {

        public static DataGridView UsuariosView;
        public Usuarios()
        {
            InitializeComponent();
            UsuariosView = new DataGridView();
            UsuariosView.Dock = DockStyle.Fill; 
            this.Controls.Add(UsuariosView);

        }

        // Se crea la conexión a la base de datos
        readonly string conexion = "Data Source = CARLOS\\SQLEXPRESS; Initial Catalog = Usuarios;Integrated Security=True";
        private void Usuarios_Load(object sender, EventArgs e)
        {                   
            SqlConnection connection = new SqlConnection(conexion);
            string consulta = "SELECT * FROM Usuarios";                // Se crea el comando SQL
            SqlCommand comando = new SqlCommand(consulta, connection);            
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);    // Se crea el adaptador de datos           
            DataTable dt = new DataTable();                            // Se crea el DataTable para almacenar los datos
            adaptador.Fill(dt);                                        // Se llena el DataTable con los datos de la base de datos
            Usuarios.UsuariosView.DataSource = dt;                     // Asignar el DataTable como origen de datos del DataGridView
        }

        private void BotonNuevo_Click(object sender, EventArgs e)  // Boton para agregar nuevos usuarios
        {
            Registro registro = new Registro();    // Instancia de clase Registo
            registro.Show();                       // Se invoca la clase Registro
            this.Hide();                           // Cirra la Ventana de la clase Usuarios 
        }

        private void Actualizar_Click(object sender, EventArgs e)      // Boton para actualizar la ventana
        {
            
            SqlConnection connection = new SqlConnection(conexion);       // Se crea la Instancia de clase conexion SQL 
            string consulta = "SELECT * FROM Usuarios";                   // Se crea la consulta SQL
            SqlCommand comando = new SqlCommand(consulta, connection);    // Se crea la instancia de clase Comando SQL
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);       // Se crea la instancia de clase adaptador
            DataTable dt = new DataTable();                               // Se crea el DataTable para almacenar los datos
            adaptador.Fill(dt);                                           // Se vuelve llenar el DataTable con los datos de la base de datos para actualizar
            Usuarios.UsuariosView.DataSource = dt;

        }
 
        private void CerrarSecion_Click(object sender, EventArgs e)       // Boton para cerrar sesion
        {
            IniciarSesion iniciarSesion = new IniciarSesion();            // Se crea una instancia de la clase Iniciar Sesion
            iniciarSesion.Show();                                         // Se Invoca la ventana de la clase Iniciar sesion
            this.Hide();                                                  // Cierra la ventana de la Clase Usuarios
        }

        private void Eliminar_Click(object sender, EventArgs e)                 // Boton para eliminar registros
        {
            int ID = (int)UsuariosView.SelectedRows[0].Cells["ID"].Value;       // Se obtiene el ID del registro seleccionado
            SqlConnection connection = new SqlConnection(conexion);             // Se crea la conexión a la base de datos
            string consulta = "DELETE FROM Contraseña WHERE UsuarioID = @ID";
            SqlCommand comando = new SqlCommand(consulta, connection);
            comando.Parameters.AddWithValue("@ID", ID);
            connection.Open();                              // Se abre la conexion
            comando.ExecuteNonQuery();                      // Se ejecuta el comando
            connection.Close();                             // Se cierra la conexion

            ID = (int)UsuariosView.SelectedRows[0].Cells["ID"].Value;
            string consulta1 = "DELETE FROM Usuarios WHERE ID = @ID";                  // Se crea el comando SQL
            SqlCommand comando1 = new SqlCommand(consulta1, connection);
            comando1.Parameters.AddWithValue("@ID", ID);
            connection.Open();                               // Se abre la conexion
            comando1.ExecuteNonQuery();                      // Se ejecuta el comando
            connection.Close();                              // Se cierra la conexion

            MessageBox.Show("¡Usuario eliminado!");          // Muestra un mensaje de confirmasion

            Actualizar_Click(sender, e);                     // Invocacion del metodo actualizar 
        }
    }
}
