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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProyectoFinal
{
    public partial class registroestudianteForm : Form
    {
        public registroestudianteForm()
        {
            InitializeComponent();
        }

        private void registroestudianteForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'universidadDataSetklin1.Estudiante' Puede moverla o quitarla según sea necesario.
            this.estudianteTableAdapter.Fill(this.universidadDataSetklin1.Estudiante);
            // TODO: esta línea de código carga datos en la tabla 'universidadDataSet.Estudiante' Puede moverla o quitarla según sea necesario.
           // this.estudianteTableAdapter1.Fill(this.universidadDataSet.Estudiante);
            // TODO: esta línea de código carga datos en la tabla 'universidadDataSet.Estudiante' Puede moverla o quitarla según sea necesario.
            //this.estudianteTableAdapter.Fill(this.universidadDataSet.Estudiante);

            //#############################################################




            fnCodigoCarrera();
            txtIdBuscar.Enabled = false;
            btnSeleccionar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }



        //BOLEANO SI
        private void rdbtnSi_CheckedChanged(object sender, EventArgs e)
        {
            codigoestudianteTextbox.Enabled = false;
            txtIdBuscar.Enabled = true;
            btnGuardar.Enabled = false;
            btnSeleccionar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            fnLimpiar();
        }

        //BOLEANO NO
        private void rdbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            codigoestudianteTextbox.Enabled = true;
            txtIdBuscar.Enabled = false;
            btnGuardar.Enabled = true;
            btnSeleccionar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }


        //FUNCIONES

        //TIRA UNA ACTULIZACION PARA QUE EL CMBOX PUEDA UTILIZARSE

        public void fnCodigoCarrera()
        {
            ConectorBD conectorBDX = new ConectorBD();
            SqlConnection conexion = conectorBDX.ObtieneConexion();

            string Consulta = "SELECT * FROM Carrera";
            SqlCommand Comando = new SqlCommand(Consulta, conexion);
            SqlDataReader LectorDatos = Comando.ExecuteReader();
            while (LectorDatos.Read())
            {
                cmbCodigoCarrera.Items.Add(LectorDatos.GetString(0));
            }
            conectorBDX.CierraConexion();
        }

        //ACTUALIZA EL DATAGRID
        public void fnActualizarDGV()
        {
            ConectorBD conectorBDX = new ConectorBD();
            SqlConnection conexion = conectorBDX.ObtieneConexion();

            SqlDataAdapter AdaptadorDB = new SqlDataAdapter("Select * from Estudiante", conexion);
            DataSet ds = new DataSet();
            AdaptadorDB.Fill(ds, "Estudiante");
            this.dgvBDEstudiante.DataSource = ds.Tables[0];
        }



        //COMBOBOX  MUESTRE EL CODIGO DE LA CARRERA Y MUESTRE EN EL LABEL EL NOMBRE DE ESTA MISMA
        public void fnmostrarCodigodeCarrera()
        {
            //para leer del combobox al textbox


            ConectorBD conectorBDX = new ConectorBD();
            SqlConnection conexion = conectorBDX.ObtieneConexion();

            string Consulta = "SELECT * FROM Carrera WHERE  Cod_carrera = '" + cmbCodigoCarrera.Text + "'";
            SqlCommand Comando = new SqlCommand(Consulta, conexion);
            SqlDataReader LectorDatos = Comando.ExecuteReader();
            while (LectorDatos.Read())
            {
                lblCarrera.Text = LectorDatos["Nomb_carrera"].ToString();
            }
            conectorBDX.CierraConexion();
        }

        //PARA LIMPIAR
        public void fnLimpiar()
        {
            codigoestudianteTextbox.Text = "";
            nombreTextbox.Text = "";
            apellidoTextbox.Text = "";
            cmbCodigoCarrera.SelectedIndex = -1; //Devuelve al valor predetrerminado cuando carga el form
            lblCarrera.Text = "<==Seleccione un código";
            txtIdBuscar.Text = "";

        }

        //GUARDAR LOS DATOS QUE INGRESEMOS EN LA TABLA 
        public void fnGuardar()
        {
            try
            {
                ConectorBD conectorBDX = new ConectorBD();
                SqlConnection conexion = conectorBDX.ObtieneConexion();


                string codigo_estudiante = "";
                string nombre = "";
                string apellido = "";
                string codigo_carrera;

                codigo_estudiante = "'" + this.codigoestudianteTextbox.Text + "'";
                nombre = "'" + this.nombreTextbox.Text + "'";
                apellido = "'" + this.apellidoTextbox.Text + "'";
                codigo_carrera = "'" + this.cmbCodigoCarrera.Text + "'";

                SqlCommand comando = new SqlCommand("INSERT INTO Estudiante VALUES (" + codigo_estudiante + "," + nombre + "," + apellido + "," + codigo_carrera + ")", conexion);
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


        // PARA SELECCIONAR LOS DATOS DE LA ID QUE SELECCIONEMOS VALGA LA REDUNDANCIA
        public void fnSeleccionar()
        {
            txtIdBuscar.Text = Convert.ToString(dgvBDEstudiante.CurrentRow.Cells[0].Value);
            nombreTextbox.Text = Convert.ToString(dgvBDEstudiante.CurrentRow.Cells[1].Value);
            apellidoTextbox.Text = Convert.ToString(dgvBDEstudiante.CurrentRow.Cells[2].Value);
            cmbCodigoCarrera.Text = Convert.ToString(dgvBDEstudiante.CurrentRow.Cells[3].Value);
            fnmostrarCodigodeCarrera();
        }


        //ELIMINAR LOS DATOS LA TABLA CON LA ID SELECCIONADA
        public void fnEliminar()
        {
            DialogResult result = MessageBox.Show("Eliminado es permanente, ¿Esta seguro que desea continuar?", "Advertencia!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                ConectorBD conectorBDX = new ConectorBD();
                SqlConnection conexion = conectorBDX.ObtieneConexion();

                string codigo_Estudiante;


                codigo_Estudiante = "'" + this.txtIdBuscar.Text + "'";
                SqlCommand eliminar = new SqlCommand("DELETE FROM Estudiante WHERE Cod_Estudiante like (" + codigo_Estudiante + ")", conexion);

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

        // PARA MODIFICAR LOS DATOS QUE SE QUIERAN DE LA TABLA
        public void fnModificar()
        {
            string codigo_Estudiante = "";
            string nombre = "";
            string apellido = "";
            string codigo_Carrera = "";

            codigo_Estudiante = txtIdBuscar.Text;
            nombre = nombreTextbox.Text;
            apellido = apellidoTextbox.Text;
            codigo_Carrera = cmbCodigoCarrera.Text;

            DialogResult result = MessageBox.Show("La actualización hace cambios permanentes, ¿Está seguro que desea continuar?", "Advertencia!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)


            {
                ConectorBD conectorBDX = new ConectorBD();
                SqlConnection conexion = conectorBDX.ObtieneConexion();

                string Query = "UPDATE Estudiante SET Cod_Estudiante = @codigo_Estudiante, Nomb_Estudiante = @nombre, Ape_Estudiante = @apellido, Cod_Carrera = @codigo_Carrera WHERE Cod_Estudiante = @codigo_Estudiante";

                using (SqlCommand command = new SqlCommand(Query, conexion))
                {
                    command.Parameters.AddWithValue("@codigo_Estudiante", codigo_Estudiante);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@apellido", apellido);
                    command.Parameters.AddWithValue("@codigo_Carrera", codigo_Carrera);

                    int rowsAffected = command.ExecuteNonQuery();
                    conectorBDX.CierraConexion();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Registro actualizado con éxito", "Éxito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.fnActualizarDGV();
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
                fnLimpiar();
            }
        }


        //#################################################################
        // ******************** BOTONES *********************************** 
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            fnSeleccionar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            fnModificar();
        }

        private void cmbCodigoCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            fnmostrarCodigodeCarrera();
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            fnGuardar();
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click_1(object sender, EventArgs e)
        {
            fnLimpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            fnEliminar();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbCodigoCarrera_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            fnmostrarCodigodeCarrera();
        }
    }
}


