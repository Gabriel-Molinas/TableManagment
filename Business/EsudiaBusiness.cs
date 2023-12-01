using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BLL
{
    public class EsudiaBusiness
    {
        private EstudianDAO aplicacionDAO = new EstudianDAO();
        public void CargarAplicaciones(List<Estudienty> aplicaciones)
        {
            if (aplicaciones.Count == 0)
                throw new Exception("La lista esta vacia, agrega una aplicacion");

            using (var trx = new TransactionScope())
            {
                foreach (Estudienty app in aplicaciones)
                {
                    CargarApp(app);
                }

                trx.Complete();
            }
        }

        static int CalcularEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;
            int edad = fechaActual.Year - fechaNacimiento.Year;

            // Ajusta la edad si aún no ha cumplido años en el año actual
            if (fechaNacimiento > fechaActual.AddYears(-edad))
            {
                edad--;
            }

            return edad;
        }
        public void CargarApp(Estudienty app)
        {
            if (app.Promedio < 0) throw new Exception("El promedio no puede ser menor a cero");
       
            int edad = CalcularEdad(app.Fecha);
            if (edad < 18) throw new Exception("No se puede registrar tine menos de 18 años");




            if (app.idCurso.ToString().Length == 0) throw new Exception("Debe ingresar una categoria almenos");

            using (var trx = new TransactionScope())
            {
                aplicacionDAO.CargarAplicacion(app);
                trx.Complete();
            }
        }

        public List<Estudienty> listarAplicaciones()
        {
            return aplicacionDAO.listarAplicaciones();
        }
       

        public void EditarAplicacion(Estudienty aplicacion)
        {
            if (aplicacion.Nombre == null) throw new Exception("Completa el campo de nombre");
            if (aplicacion.id == null) throw new Exception("Completa el campo de id");
            using (var trx = new TransactionScope())
            {
                aplicacionDAO.EditarAplicacion(aplicacion);
                trx.Complete();
            }
        }

        public void EliminarAPP(Estudienty aplicacion)
        {
            if (aplicacion.id == null) throw new Exception("Completa el campo de id");
            using (var trx = new TransactionScope())
            {
                aplicacionDAO.EliminarAPP(aplicacion);
                trx.Complete(); 
            }
        }

    }
}
