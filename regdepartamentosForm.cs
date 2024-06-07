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
    public partial class regdepartamentoForm : Form
    {
        public regdepartamentoForm()
        {
            InitializeComponent();
        }

        private void regdepartamentoForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'universidadDataSetklin1.Departamento' Puede moverla o quitarla según sea necesario.
            this.departamentoTableAdapter1.Fill(this.universidadDataSetklin1.Departamento);
            //#############################################################
            // TODO: esta línea de código carga datos en la tabla 'universidadDataSet.Departamento' Puede moverla o quitarla según sea necesario.
           // this.departamentoTableAdapter.Fill(this.universidadDataSet.Departamento);


            //#############################################################



            txtIdBuscar.Enabled = false;
            btnSeleccionar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        private void rdbtnSi_CheckedChanged(object sender, EventArgs e)
        {
            codigodepartamentoTextbox.Enabled = false;
            nombredepartamentoTextBox.Enabled = true;
            txtIdBuscar.Enabled = true;
            btnGuardar.Enabled = false;
            btnSeleccionar.Enabled = true;
            btnActualizar.Enabled = true;
            btnEliminar.Enabled = true;
            fnLimpiar();
        }

        private void rdbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            codigodepartamentoTextbox.Enabled = true;
            txtIdBuscar.Enabled = false;
            btnGuardar.Enabled = true;
            btnSeleccionar.Enabled = false;
            btnActualizar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        //#############################################################
        public void fnSeleccionar()
        {
            txtIdBuscar.Text = Convert.ToString(dgvBase.CurrentRow.Cells[0].Value);
            nombredepartamentoTextBox.Text = Convert.ToString(dgvBase.CurrentRow.Cells[1].Value);
        }

        //#############################################################
        public void fnLimpiar()
        {
            codigodepartamentoTextbox.Text = "";
            nombredepartamentoTextBox.Text = "";
            txtIdBuscar.Text = "";
        }
        //#############################################################

        public void fnActualizarDGV()
        {
            ConectorBD conectorBDX = new ConectorBD();
            SqlConnection conexion = conectorBDX.ObtieneConexion();
            SqlDataAdapter AdaptadorDB = new SqlDataAdapter("Select * from Departamento",conexion);
            DataSet ds = new DataSet();
            AdaptadorDB.Fill(ds, "Departamento");
            this.dgvBase.DataSource = ds.Tables[0];
            conectorBDX.CierraConexion();
        }

        //#############################################################
        public void fnGuardar()
        {
            try
            {
                int cod_departamento;
                string departamento = "";
                
                cod_departamento = Convert.ToInt32(codigodepartamentoTextbox.Text);
                departamento = "'" + this.nombredepartamentoTextBox.Text + "'";

                ConectorBD conectorBDX = new ConectorBD();
                SqlConnection conexion = conectorBDX.ObtieneConexion();

                SqlCommand comando = new SqlCommand("INSERT INTO Departamento VALUES (" + cod_departamento + "," + departamento + ")", conexion);
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
public void fnEliminar()
{
   DialogResult result = MessageBox.Show("Eliminado es permanente, ¿Esta seguro que desea continuar?", "Advertencia!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

   if (result == DialogResult.OK)
   {
     
                ConectorBD conectorBDX = new ConectorBD();
                SqlConnection conexion = conectorBDX.ObtieneConexion();

                int codigo_departamento;

       codigo_departamento = Convert.ToInt32(txtIdBuscar.Text);
       SqlCommand eliminar = new SqlCommand("delete from Departamento where Cod_Depto like (" + codigo_departamento + ")", conexion);
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
           int codigo_departamento;
           string departamento = "";
          
           codigo_departamento = Convert.ToInt32(txtIdBuscar.Text);
           departamento = nombredepartamentoTextBox.Text;

           DialogResult result = MessageBox.Show("La actualización hace cambios permanentes, ¿Está seguro que desea continuar?", "Advertencia!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

           if (result == DialogResult.OK)
           {

                ConectorBD conectorBDX = new ConectorBD();
                SqlConnection conexion = conectorBDX.ObtieneConexion();
                string query = "UPDATE Departamento SET Cod_Depto = @codigo_departamento, Nombre_Depto = @departamento WHERE Cod_Depto = @codigo_departamento";

               using (SqlCommand command = new SqlCommand(query, conexion))
               {
                   command.Parameters.AddWithValue("@codigo_departamento", codigo_departamento);
                   command.Parameters.AddWithValue("@departamento", departamento);
                   
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            fnEliminar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            fnModificar();
        }

        private void dgvBase_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
