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
    public partial class mainframeForm : Form
    {
        public mainframeForm()
        {
            InitializeComponent();
        }

        private void masToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registroestudianteForm llamarForm = new registroestudianteForm();
            llamarForm.MdiParent = this;
            llamarForm.Show();
        }

        private void registroProfesorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registroprofesorForm llamarForm = new registroprofesorForm();
            llamarForm.MdiParent = this;
            llamarForm.Show();
        }

        private void registroCarreraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registrocarreraForm llamarForm = new registrocarreraForm();
            llamarForm.MdiParent = this;
            llamarForm.Show();
        }

        private void registroDepartamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            regdepartamentoForm llamarForm = new regdepartamentoForm();
            llamarForm.MdiParent = this;
            llamarForm.Show();
        }

        private void registroUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registromateriasForm llamarForm = new registromateriasForm();
            llamarForm.MdiParent = this;
            llamarForm.Show();
        }

        private void registroUsuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void inscribirMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inscribemateriaForm llamarForm = new inscribemateriaForm();
            llamarForm.MdiParent = this;
            llamarForm.Show();
        }

        private void asignarMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            asignarmateriaForm llamarForm = new asignarmateriaForm();
            llamarForm.MdiParent = this;
            llamarForm.Show();
        }

        private void mainframeForm_Load(object sender, EventArgs e)
        {

           
          menuStrip1.Visible = false;
        }



        //PARA EL LOGING EN  EL PANEL 
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
                   // mainframeForm abrir = new mainframeForm();
                    //abrir.Show();
                    conectorBDX.CierraConexion();
                    panellogin.Visible = false;
                    menuStrip1.Visible = true;
                    
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
    }
}
