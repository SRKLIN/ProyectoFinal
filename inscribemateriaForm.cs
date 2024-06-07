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
    public partial class inscribemateriaForm : Form
    {
        public inscribemateriaForm()
        {
            InitializeComponent();
        }

        private void inscribemateriaForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'universidadDataSetklin1.Materia_Inscrita' Puede moverla o quitarla según sea necesario.
            this.materia_InscritaTableAdapter1.Fill(this.universidadDataSetklin1.Materia_Inscrita);
            // TODO: esta línea de código carga datos en la tabla 'universidadDataSetklin1.Materia' Puede moverla o quitarla según sea necesario.
            this.materiaTableAdapter1.Fill(this.universidadDataSetklin1.Materia);
            // TODO: esta línea de código carga datos en la tabla 'universidadDataSet.Materia_Inscrita' Puede moverla o quitarla según sea necesario.
          //  this.materia_InscritaTableAdapter.Fill(this.universidadDataSet.Materia_Inscrita);
            // TODO: esta línea de código carga datos en la tabla 'universidadDataSet.Estudiante' Puede moverla o quitarla según sea necesario.
          //  this.estudianteTableAdapter.Fill(this.universidadDataSet.Estudiante);
            // TODO: esta línea de código carga datos en la tabla 'universidadDataSet.Materia' Puede moverla o quitarla según sea necesario.
          //  this.materiaTableAdapter.Fill(this.universidadDataSet.Materia);


            fnCodigomateria();
            fnCodigoestudiante();
            btnSeleccionar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        //#############################################################
        //DropDown Menu
        public void fnCodigoestudiante()
        {
            ConectorBD conectorBDX = new ConectorBD();
            SqlConnection conexion = conectorBDX.ObtieneConexion();

            string Consulta = "SELECT * FROM Estudiante";
            SqlCommand Comando = new SqlCommand(Consulta, conexion);
            SqlDataReader LectorDatos = Comando.ExecuteReader();
            while (LectorDatos.Read())
            {
                cmbCodigoestudiante.Items.Add(LectorDatos.GetString(0));
            }
            conectorBDX.CierraConexion();
        }

        //#############################################################
        public void fnmostrarCodigoestudiante()
        {
            //para leer del combobox al textbox


            ConectorBD conectorBDX = new ConectorBD();
            SqlConnection conexion = conectorBDX.ObtieneConexion();

            string Consulta = "SELECT * FROM Estudiante WHERE Cod_Estudiante = '" + cmbCodigoestudiante.Text + "'";
            SqlCommand Comando = new SqlCommand(Consulta, conexion);
            SqlDataReader LectorDatos = Comando.ExecuteReader();
            while (LectorDatos.Read())
            {
                txtboxNombre.Text = LectorDatos["Nomb_Estudiante"].ToString();
                txtApellido.Text = LectorDatos["Ape_Estudiante"].ToString();
            }
            conectorBDX.CierraConexion();
        }

        //#############################################################
        //DropDown Menu
        public void fnCodigomateria()
        {
            ConectorBD conectorBDX = new ConectorBD();
            SqlConnection conexion = conectorBDX.ObtieneConexion();

            string Consulta = "SELECT * FROM Materia";
            SqlCommand Comando = new SqlCommand(Consulta, conexion);
            SqlDataReader LectorDatos = Comando.ExecuteReader();
            while (LectorDatos.Read())
            {
                cmbCodigomateria.Items.Add(LectorDatos.GetString(0));
            }
            conectorBDX.CierraConexion();
        }

        //#############################################################
        public void fnmostrarCodigomateria()
        {
            //para leer del combobox al textbox


            ConectorBD conectorBDX = new ConectorBD();
            SqlConnection conexion = conectorBDX.ObtieneConexion();

            string Consulta = "SELECT * FROM Materia WHERE Cod_Materia = '" + cmbCodigomateria.Text + "'";
            SqlCommand Comando = new SqlCommand(Consulta, conexion);
            SqlDataReader LectorDatos = Comando.ExecuteReader();
            while (LectorDatos.Read())
            {
                txtboxMateria.Text = LectorDatos["Nomb_Materia"].ToString();

            }
            conectorBDX.CierraConexion();
        }



        //#############################################################

        public void fnActualizarDGV()
        {
            ConectorBD conectorBDX = new ConectorBD();
            SqlConnection conexion = conectorBDX.ObtieneConexion();
            SqlDataAdapter AdaptadorDB = new SqlDataAdapter("Select * from Materia_Inscrita", conexion);
            DataSet ds = new DataSet();
            AdaptadorDB.Fill(ds, "Materia_Inscrita");
            this.dgvBase.DataSource = ds.Tables[0];
            conectorBDX.CierraConexion();
        }

        //#############################################################
        public void fnGuardar()
        {
            try
            {
                string cod_estudiante = "";
                string cod_materia = "";

                cod_estudiante = "'" + this.cmbCodigoestudiante.Text + "'";
                cod_materia = "'" + this.cmbCodigomateria.Text + "'";

                ConectorBD conectorBDX = new ConectorBD();
                SqlConnection conexion = conectorBDX.ObtieneConexion();

                SqlCommand comando = new SqlCommand("INSERT INTO Materia_Inscrita VALUES (" + cod_estudiante + "," + cod_materia + ")", conexion);
                comando.ExecuteNonQuery();
                conectorBDX.CierraConexion();

                MessageBox.Show("Registros Guardados correctamente", "Agregar Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.fnLimpiar();
                fnActualizarDGV();

            }

            catch (Exception)
            {
                MessageBox.Show("Asegurese de llenar todos los campos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.fnLimpiar();
            }

        }

        //#############################################################


        public void fnLimpiar()
        {
            cmbCodigoestudiante.SelectedIndex = -1; //Devuelve al valor predetrerminado cuando carga el form
            txtboxNombre.Text = "";
            txtApellido.Text = "";
            txtboxMateria.Text = "";
            cmbCodigomateria.SelectedIndex = -1;
            txtValorestudiante.Text = "";
            txtValormateria.Text = "";

        }

        //#############################################################
        public void fnSeleccionar()
        {

            cmbCodigoestudiante.Text = Convert.ToString(dgvBase.CurrentRow.Cells[0].Value);
            cmbCodigomateria.Text = Convert.ToString(dgvBase.CurrentRow.Cells[1].Value);

            txtValorestudiante.Text = cmbCodigoestudiante.SelectedItem.ToString();
            txtValormateria.Text = cmbCodigomateria.SelectedItem.ToString();

        }

        //#############################################################

        public void fnEliminar()
        {
            DialogResult result = MessageBox.Show("Eliminado es permanente, ¿Está seguro que desea continuar?", "Advertencia!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                ConectorBD conectorBDX = new ConectorBD();
                SqlConnection conexion = conectorBDX.ObtieneConexion();

                string cod_estudiante= this.txtValorestudiante.Text;
                string cod_materia = this.txtValormateria.Text;

                SqlCommand eliminar = new SqlCommand("DELETE FROM Materia_Inscrita WHERE Cod_Estudiante = @cod_estudiante AND Cod_materia = @cod_materia", conexion);
                eliminar.Parameters.AddWithValue("@cod_estudiante", cod_estudiante);
                eliminar.Parameters.AddWithValue("@cod_materia", cod_materia);
                 
                eliminar.ExecuteNonQuery();
                conectorBDX.CierraConexion();

                MessageBox.Show("Registro eliminado con éxito", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.fnActualizarDGV();
                fnLimpiar();
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Cancelado", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void rdbtnSi_CheckedChanged(object sender, EventArgs e)
        {
            btnInscribir.Enabled = false;
            btnSeleccionar.Enabled = true;
            btnEliminar.Enabled = true;
            cmbCodigoestudiante.Enabled = false;
            cmbCodigomateria.Enabled = false;
            fnLimpiar();
        }

        private void rdbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            btnInscribir.Enabled = true;
            btnSeleccionar.Enabled = false;
            btnEliminar.Enabled = false;
            cmbCodigoestudiante.Enabled = true;
            cmbCodigomateria.Enabled = true;
        }

        private void cmbCodigoestudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            fnmostrarCodigoestudiante();
        }

        private void cmbCodigomateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            fnmostrarCodigomateria();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            fnLimpiar();
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            fnGuardar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            fnSeleccionar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            fnEliminar();
        }
    }
}
