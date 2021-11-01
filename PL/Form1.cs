using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            Views.Formulario tabla = new Views.Formulario();
            tabla.ShowDialog();

            Refrescar();
        }


        public void  Refrescar()
        {
            ML_2.Empleado empleado = new ML_2.Empleado();
            ML_2.Result result = BL_2.Empleado.GetAll();
            empleado.Empleados = result.Objects;
            dataGridView1.DataSource = empleado.Empleados;
            dataGridView1.Columns[5].Visible = true;
        }




        //obtener ID
        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void Editar_Click(object sender, EventArgs e)
        {
            int? IdEmpleado = GetId();
            if (IdEmpleado != null)
            {
                Views.Formulario tabla = new Views.Formulario(IdEmpleado);
                tabla.ShowDialog();
                Refrescar();
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            int? IdEmpleado = GetId();
            if (MessageBox.Show("¿Desea eliminar el registro?", "Eliminar registro", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (IdEmpleado != null)
                {
                    ML_2.Result result = BL_2.Empleado.Delete(IdEmpleado);
                    MessageBox.Show("Registro eliminado con exito");
                    Refrescar();
                }
                //MessageBox.Show("Pago realizado");

            }

            else
            {

                MessageBox.Show("Registro no eliminado");

            }
        }




    }
}
