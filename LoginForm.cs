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


namespace ProyectoFinal
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

    
        private void iniciosesionBtn_Click(object sender, EventArgs e)
        {

            string username = usuarioTextbox.Text;
            string password = passwordTextbox.Text;

            // Crear una instancia del conector a la base de datos
            ConectorBD conectorBDX = new ConectorBD();

                // Obtener la conexión abierta
                SqlConnection conexion = conectorBDX.ObtieneConexion();


                // Crear el comando SQL

                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM Usuarios WHERE Usuario=@username AND Password=@password", conexion))
                {
                    // Agregar parámetros al comando
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    // Ejecutar el comando y obtener el resultado
                    int result = (int)command.ExecuteScalar();

                    // Verificar el resultado
                    if (result > 0)
                    {
                        MessageBox.Show("Inicio de sesión exitoso.");
                        // Aquí colocamos el formulario principal
                        mainframeForm abrir = new mainframeForm();
                        abrir.Show();
                        conectorBDX.CierraConexion();
                }

                    else
                    {
                        MessageBox.Show("Nombre de usuario o contraseña incorrectos.");
                        // Limpia los TextBox
                        usuarioTextbox.Text = "";
                        passwordTextbox.Text = "";
                        conectorBDX.CierraConexion();
                }

                }
            }

        private void salirBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

        