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
    public partial class asignarmateriaForm : Form
    {
        public asignarmateriaForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void asignarmateriaForm_Load(object sender, EventArgs e)
        {
          
            // TODO: esta línea de código carga datos en la tabla 'universidadDataSetklin1.Materia_Asignada' Puede moverla o quitarla según sea necesario.
            this.materia_AsignadaTableAdapter1.Fill(this.universidadDataSetklin1.Materia_Asignada);




            // TODO: esta línea de código carga datos en la tabla 'universidadDataSet.Materia' Puede moverla o quitarla según sea necesario.
            // this.materiaTableAdapter.Fill(this.universidadDataSet.Materia);
            // TODO: esta línea de código carga datos en la tabla 'universidadDataSet.Materia_Asignada' Puede moverla o quitarla según sea necesario.
            // this.materia_AsignadaTableAdapter.Fill(this.universidadDataSet.Materia_Asignada);



            //#############################################################


            fnCodigomateria();
            fnCodigoprofesor();
            btnSeleccionar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        //#############################################################
        //DropDown Menu
        public void fnCodigoprofesor()
        {
            ConectorBD conectorBDX = new ConectorBD();
            SqlConnection conexion = conectorBDX.ObtieneConexion();

            string Consulta = "SELECT * FROM Profesor";
            SqlCommand Comando = new SqlCommand(Consulta, conexion);
            SqlDataReader LectorDatos = Comando.ExecuteReader();
            while (LectorDatos.Read())
            {
                cmbCodigoprofesor.Items.Add(LectorDatos.GetString(0));
            }
            conectorBDX.CierraConexion();
        }

        //#############################################################
        public void fnmostrarCodigoprofesor()
        {
            //para leer del combobox al textbox


            ConectorBD conectorBDX = new ConectorBD();
            SqlConnection conexion = conectorBDX.ObtieneConexion();

            string Consulta = "SELECT * FROM Profesor WHERE Cod_Prof = '" + cmbCodigoprofesor.Text + "'";
            SqlCommand Comando = new SqlCommand(Consulta, conexion);
            SqlDataReader LectorDatos = Comando.ExecuteReader();
            while (LectorDatos.Read())
            {
                txtboxNombre.Text = LectorDatos["Nomb_Prof"].ToString();
                txtApellido.Text = LectorDatos["Ape_Prof"].ToString();
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
            SqlDataAdapter AdaptadorDB = new SqlDataAdapter("Select * from Materia_Asignada", conexion);
            DataSet ds = new DataSet();
            AdaptadorDB.Fill(ds, "Materia_Asignada");
            this.dgvBase.DataSource = ds.Tables[0];
            conectorBDX.CierraConexion();
        }

        //#############################################################
        public void fnGuardar()
        {
            try
            {
                string cod_profesor = "";
                string cod_materia = "";

                cod_profesor = "'" + this.cmbCodigoprofesor.Text + "'";
                cod_materia = "'" + this.cmbCodigomateria.Text + "'";

                ConectorBD conectorBDX = new ConectorBD();
                SqlConnection conexion = conectorBDX.ObtieneConexion();

                SqlCommand comando = new SqlCommand("INSERT INTO Materia_Asignada VALUES (" + cod_profesor + "," + cod_materia + ")", conexion);
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
            cmbCodigoprofesor.SelectedIndex = -1; //Devuelve al valor predetrerminado cuando carga el form
            txtboxNombre.Text = "";
            txtApellido.Text = "";
            txtboxMateria.Text = "";
            cmbCodigomateria.SelectedIndex = -1;
            txtValorprofesor.Text = "";
            txtValormateria.Text = "";

        }

        //#############################################################
        public void fnSeleccionar()
        {
            /* txtIdBuscar.Text = Convert.ToString(dgvBase.CurrentRow.Cells[0].Value);
            cmbCodigoprofesor.Enabled = false;
            cmbCodigomateria.Enabled = false; */
            cmbCodigoprofesor.Text = Convert.ToString(dgvBase.CurrentRow.Cells[0].Value);
            cmbCodigomateria.Text = Convert.ToString(dgvBase.CurrentRow.Cells[1].Value);
            
            txtValorprofesor.Text = cmbCodigoprofesor.SelectedItem.ToString();
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

                string cod_profesor = this.txtValorprofesor.Text;
                string cod_materia = this.txtValormateria.Text;

                SqlCommand eliminar = new SqlCommand("DELETE FROM Materia_Asignada WHERE Cod_prof = @cod_profesor AND Cod_Materia = @cod_materia", conexion);
                eliminar.Parameters.AddWithValue("@cod_profesor", cod_profesor);
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
     
        //#############################################################


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            fnGuardar();
        }

        private void cmbCodigoprofesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            fnmostrarCodigoprofesor();
          
        }

        private void cmbCodigomateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            fnmostrarCodigomateria();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtboxMateria_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            fnLimpiar();
        }

        private void rdbtnSi_CheckedChanged(object sender, EventArgs e)
        {
            btnInscribir.Enabled = false;
            btnSeleccionar.Enabled = true;
            btnEliminar.Enabled = true;
            cmbCodigoprofesor.Enabled = false;
            cmbCodigomateria.Enabled = false;
            fnLimpiar();
        }

        private void rdbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            btnInscribir.Enabled = true;
            btnSeleccionar.Enabled = false;
            btnEliminar.Enabled = false;
            cmbCodigoprofesor.Enabled = true;
            cmbCodigomateria.Enabled = true;
        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

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
