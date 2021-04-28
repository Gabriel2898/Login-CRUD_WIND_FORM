using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Crud : Form
    {
        CN_Productos cn = new CN_Productos();
            private string id = null;
        private bool editar = false;
        public Crud()
        {
            InitializeComponent();
        }

        private void Crud_Load(object sender, EventArgs e)
        {
            MostrarProductos(); 
        }
        private void MostrarProductos()
        {
            CN_Productos p = new CN_Productos();
            dataGridView1.DataSource = p.MostrarProd();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (editar == false)
            {
                try
                {

                    cn.InsertarPRod(txtNombre.Text, txtDesc.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarProductos();
                    limpiarForm();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se inserto debido a:"  + ex);
                }
            }else if (editar==true)
            {
                try
                {

                    cn.EditarProd(txtNombre.Text, txtDesc.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text, id);
                    MessageBox.Show("se edito correctamente");
                    MostrarProductos();
                    limpiarForm();
                    editar = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se edito debido a:" + ex);
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                editar = true;
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtDesc.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();
                id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
            }
            else
            {
                MessageBox.Show("seleccionar una fila");
            }
        }
        private void limpiarForm()
        {
            txtDesc.Clear();
            txtMarca.Text = "";
            txtPrecio.Clear();
            txtStock.Clear();
            txtNombre.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                id = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                cn.EliminarPRod(id);
                MessageBox.Show("se elimino correctamente");
                MostrarProductos();
            }
            else
            {
                MessageBox.Show("seleccione una fila");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiarForm();
        }
    }
}

