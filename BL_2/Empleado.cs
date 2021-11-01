using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_2
{
    public class Empleado
    {

        public static ML_2.Result Add(ML_2.Empleado empleado)
        {
            ML_2.Result result = new ML_2.Result();

            try
            {
                using (EF.MicroSystemEntities conexion = new EF.MicroSystemEntities())
                {
                    var query = conexion.UsuarioAdd(empleado.Nombre, empleado.ApellidoPaterno, empleado.ApellidoMaterno, empleado.RFC, empleado.Sueldo);

                    if (query > 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo ingresar el empleado";
                    }
                    result.Correct = true;
                    }
               
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }


        public static ML_2.Result Update(ML_2.Empleado empleado)
        {
            ML_2.Result result  = new ML_2.Result();

            try
            {
                using(EF.MicroSystemEntities conexion = new EF.MicroSystemEntities())
                {
                    var query = conexion.UsuarioUpdate(empleado.IdEmpleado, empleado.Nombre, empleado.ApellidoPaterno, empleado.ApellidoMaterno, empleado.RFC, empleado.Sueldo);

                    if (query > 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No se pudo modificar correctamente";
                    }
                    result.Correct = true;
                }
            }
            catch (Exception ex)
            {
                result.Correct = true;
                result.ErrorMessage = ex.Message;
            }
            return result;

        }

        public static ML_2.Result Delete(int? IdEmpleado)
        {
            ML_2.Result result = new ML_2.Result();

            try
            {
                using (EF.MicroSystemEntities conexion = new EF.MicroSystemEntities())
                {
                    var query = conexion.UsuariDelete(IdEmpleado);
                    if (query > 1)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }

                    result.Correct = true;
                    
                }

            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }


        public static ML_2.Result GetAll()
        {
            ML_2.Result result = new ML_2.Result();

            try
            {
                using(EF.MicroSystemEntities conexion = new EF.MicroSystemEntities())
                {
                    var query = conexion.UsuarioGetAll().ToList();
                    
                    result.Objects = new List<object>();

                    if (query != null)
                    {
                        //result.Objects = new List<object>();

                        foreach (var obj in query)
                        {
                            ML_2.Empleado empleado = new ML_2.Empleado();
                            empleado.IdEmpleado = obj.IdEmpleado;
                            empleado.Nombre = obj.Nombre;
                            empleado.ApellidoPaterno = obj.ApellidoPaterno;
                            empleado.ApellidoMaterno = obj.ApellidoMaterno;
                            empleado.RFC = obj.RFC;
                            empleado.Sueldo = obj.Sueldo.Value;
                            result.Objects.Add(empleado);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "No hay informacion que mostrar";
                    }
                    result.Correct = true;

                }
            }
            catch (Exception ex) {
                result.Correct = true;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }


        public static ML_2.Result GetById(int? IdEmpleado)
        {
            ML_2.Result result = new ML_2.Result();

            try
            {
                using(EF.MicroSystemEntities conexion = new EF.MicroSystemEntities())
                {
                    var query = conexion.GetByIdUusuario(IdEmpleado).FirstOrDefault();

                    ML_2.Empleado empleado = new ML_2.Empleado();

                    empleado.IdEmpleado = query.IdEmpleado;
                    empleado.Nombre = query.Nombre;
                    empleado.ApellidoPaterno = query.ApellidoPaterno;
                    empleado.ApellidoMaterno = query.RFC;
                    empleado.Sueldo = query.Sueldo.Value;

                    result.Object = empleado;
                    result.Correct = true;

                    if(query!= null)
                    {
                        result.Correct= true;
                    }
                    else{
                        result.Correct= false;
                        result.ErrorMessage= "No existe la informacion";
                    }
                    
                }
            }
            catch (Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
            }
            return result;
        }
       


    }
}
