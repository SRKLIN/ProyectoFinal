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
    public partial class registrocarreraForm : Form
    {
        public registrocarreraForm()
        {
            InitializeComponent();
        }

        private void registrocarreraForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'universidadDataSetklin1.Carrera' Puede moverla o quitarla según sea necesario.
            this.carreraTableAdapter1.Fill(this.universidadDataSetklin1.Carrera);
            // TODO: esta línea de código carga datos en la tabla 'universidadDataSet.Carrera' Puede moverla o quitarla según sea necesario.
          //  this.carreraTableAdapter.Fill(this.universidadDataSet.Carrera);


            //#############################################################

            fnCodigodepartamento();
            txtIdBuscar.Enabled = false;
            btnSeleccionar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void rdbtnSi_CheckedChanged(object sender, EventArgs e)
        {
            codigocarreraTextbox.Enabled = false;
            nombrecarreraTextbox.Enabled = true;
            txtIdBuscar.Enabled = true;
            btnGuardar.Enabled = false;
            btnSeleccionar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
        }

        private void rdbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            codigocarreraTextbox.Enabled = true;
            txtIdBuscar.Enabled = false;
            btnGuardar.Enabled = true;
            btnSeleccionar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        //#############################################################
        //DropDown Menu
        public void fnCodigodepartamento()
        {
            ConectorBD conectorBDX = new ConectorBD();
            SqlConnection conexion = conectorBDX.ObtieneConexion();

            string Consulta = "SELECT * FROM Departamento";
            SqlCommand Comando = new SqlCommand(Consulta, conexion);
            SqlDataReader LectorDatos = Comando.ExecuteReader();
            while (LectorDatos.Read())
            {
                cmbCodigodepartamento.Items.Add(LectorDatos.GetString(0));
            }
            conectorBDX.CierraConexion();
        }

        //#############################################################
        public void fnmostrarCodigodepartamento()
        {
            //para leer del combobox al textbox


            ConectorBD conectorBDX = new ConectorBD();
            SqlConnection conexion = conectorBDX.ObtieneConexion();

            string Consulta = "SELECT * FROM Departamento WHERE Cod_Depto = '" + cmbCodigodepartamento.Text + "'";
            SqlCommand Comando = new SqlCommand(Consulta, conexion);
            SqlDataReader LectorDatos = Comando.ExecuteReader();
            while (LectorDatos.Read())
            {
                lblCodigodepartamento.Text = LectorDatos["Nombre_Depto"].ToString();
            }
            conectorBDX.CierraConexion();
        }



        //#############################################################

        public void fnLimpiar()
        {
            codigocarreraTextbox.Text = "";
            nombrecarreraTextbox.Text = "";
            cmbCodigodepartamento.SelectedIndex = -1; //Devuelve al valor predetrerminado cuando carga el form
            lblCodigodepartamento.Text = "<==Seleccione un código";
            txtIdBuscar.Text = "";
           
        }

        //#############################################################
        public void fnGuardar()
        {
            try
            {
                ConectorBD conectorBDX = new ConectorBD();
                SqlConnection conexion = conectorBDX.ObtieneConexion();


                string codigo_carrera = "";
                string nombre = "";
                int codigo_departamento;

                codigo_carrera = "'" + this.codigocarreraTextbox.Text + "'";
                nombre = "'" + this.nombrecarreraTextbox.Text + "'";
                codigo_departamento = Convert.ToInt32(cmbCodigodepartamento.Text);

                SqlCommand comando = new SqlCommand("INSERT INTO Carrera VALUES (" + codigo_carrera + "," + nombre + "," + codigo_departamento + ")", conexion);
                comando.ExecuteNonQuery();
                conectorBDX.CierraConexion();


                MessageBox.Show("Registros Guardados correctamente", "Agregar Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                fnLimpiar();

            }
            catch (Exception)
            {
                MessageBox.Show("Asegurese de llenar todos los campos requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.fnActualizarDGV();
        }


        //#############################################################

        public void fnActualizarDGV()
        {
            ConectorBD conectorBDX = new ConectorBD();
            SqlConnection conexion = conectorBDX.ObtieneConexion();

            SqlDataAdapter AdaptadorDB = new SqlDataAdapter("Select * from Carrera", conexion);
            DataSet ds = new DataSet();
            AdaptadorDB.Fill(ds, "Carrera");
            this.dgvBase.DataSource = ds.Tables[0];
        }




        //#############################################################
        public void fnSeleccionar()
        {
            txtIdBuscar.Text = Convert.ToString(dgvBase.CurrentRow.Cells[0].Value);
            nombrecarreraTextbox.Text = Convert.ToString(dgvBase.CurrentRow.Cells[1].Value);
            cmbCodigodepartamento.Text = Convert.ToString(dgvBase.CurrentRow.Cells[2].Value);
            
       }

        //#############################################################

        public void fnEliminar()
        {
            DialogResult result = MessageBox.Show("Eliminado es permanente, ¿Esta seguro que desea continuar?", "Advertencia!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                ConectorBD conectorBDX = new ConectorBD();
                SqlConnection conexion = conectorBDX.ObtieneConexion();

                string codigo_carrera;


                codigo_carrera = "'" + this.txtIdBuscar.Text + "'";
                SqlCommand eliminar = new SqlCommand("DELETE FROM Carrera WHERE Cod_Carrera like (" + codigo_carrera+ ")", conexion);

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

        public void fnModificar()
        {
            string codigo_carrera = "";
            string nombre = "";
            string codigo_departamento = "";

            codigo_carrera = txtIdBuscar.Text;
            nombre = nombrecarreraTextbox.Text;
            codigo_departamento = cmbCodigodepartamento.Text;

            DialogResult result = MessageBox.Show("La actualización hace cambios permanentes, ¿Está seguro que desea continuar?", "Advertencia!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)


            {
                ConectorBD conectorBDX = new ConectorBD();
                SqlConnection conexion = conectorBDX.ObtieneConexion();

                string Query = "UPDATE Carrera SET cod_Carrera = @codigo_carrera, Nomb_Carrera = @nombre, Cod_depto = @codigo_departamento WHERE Cod_Carrera = @codigo_carrera";

                using (SqlCommand command = new SqlCommand(Query, conexion))
                {
                    command.Parameters.AddWithValue("@codigo_carrera", codigo_carrera);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@codigo_departamento", codigo_departamento);

                    int rowsAffected = command.ExecuteNonQuery();
                    conectorBDX.CierraConexion();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registro actualizado con éxito", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.fnActualizarDGV();
                        fnLimpiar();

                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (result == DialogResult.Cancel)
            {
                MessageBox.Show("Actualización cancelada", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //#############################################################
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            fnGuardar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            fnLimpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            fnSeleccionar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            fnModificar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            fnEliminar();
        }

        private void cmbCodigodepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            fnmostrarCodigodepartamento();
        }
    }
}
