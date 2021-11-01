using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PL.Views
{
    public partial class Formulario : Form
    {
        public int? IdEmpleado;
         
        public Formulario(int? IdEmpleado = null)
        {
            InitializeComponent();

            this.IdEmpleado = IdEmpleado;
            if(IdEmpleado != null)
            {
                 CargarDatos();//GetById
            }

        }


        private void CargarDatos()
        {
            ML_2.Empleado usuario = new ML_2.Empleado();
            ML_2.Result result = BL_2.Empleado.GetById(IdEmpleado);

            usuario.IdEmpleado = ((ML_2.Empleado)result.Object).IdEmpleado;
            usuario.Nombre = ((ML_2.Empleado)result.Object).Nombre;
            usuario.ApellidoPaterno = ((ML_2.Empleado)result.Object).ApellidoPaterno;
            usuario.ApellidoMaterno = ((ML_2.Empleado)result.Object).ApellidoMaterno;
            usuario.RFC = ((ML_2.Empleado)result.Object).RFC;
            usuario.Sueldo = ((ML_2.Empleado)result.Object).Sueldo;

            Id.Text = Convert.ToString(usuario.IdEmpleado);
            Nombre.Text = usuario.Nombre;
            Paterno.Text = usuario.ApellidoPaterno;
            Materno.Text = usuario.ApellidoMaterno;
            RFC.Text = usuario.Nombre;
            Sueldo.Text = Convert.ToString(usuario.Sueldo);
        }






        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {


            ML_2.Empleado empleado = new ML_2.Empleado();

            if (IdEmpleado == null)
            {

                empleado.Nombre = Nombre.Text;
                empleado.ApellidoPaterno = Paterno.Text;
                empleado.ApellidoMaterno = Materno.Text;
                empleado.RFC = RFC.Text;
                empleado.Sueldo = Convert.ToDecimal(Sueldo.Text);

                ML_2.Result result = BL_2.Empleado.Add(empleado);

                if (result.Correct == true)
                {

                    MessageBox.Show("Registro agregado correctamente");

                }
                else
                {
                    MessageBox.Show("El registro no se agrego ");
                }

                this.Close();
            }
            else
            {

                empleado.IdEmpleado = Convert.ToInt32(Id.Text);
                empleado.Nombre = Nombre.Text;
                empleado.ApellidoPaterno = Paterno.Text;
                empleado.ApellidoMaterno = Materno.Text;
                empleado.RFC = RFC.Text;
                empleado.Sueldo = Convert.ToDecimal(Sueldo.Text);

                ML_2.Result result = BL_2.Empleado.Update(empleado);
                if (result.Correct == true)
                {
                    MessageBox.Show("Registro actualizado correctamente");
                }
                else
                {
                    MessageBox.Show("El registro no se actualizo ");
                }
                this.Close();
            }





        }
    }
}
