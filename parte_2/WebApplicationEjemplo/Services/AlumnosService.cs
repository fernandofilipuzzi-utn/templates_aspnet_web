using WebApplicationEjemplo.DALs;
using WebApplicationEjemplo.Models;

namespace WebApplicationEjemplo.Services
{
    public class AlumnosService
    {
        //Server=nombre_del_servidor;Database=nombre_de_la_base_de_datos;User Id=usuario;Password=contraseña;
        string connectionString = @"Data Source=TSP;Initial Catalog=bd_Alumnos;Integrated Security=True;TrustServerCertificate=True";
        IAlumnoDAL alumnoDao;


        public AlumnosService()
        {
            alumnoDao = new AlumnoSQLServerDAL(connectionString);
        }

        public List<Alumno> GetAll()
        { 
            return alumnoDao.GetAll();
        }

        public Alumno GetById(int id)
        {

            return alumnoDao.GetById(id);
        }

        public Alumno Create(Alumno nuevo)
        {
            return alumnoDao.Add(nuevo);
        }

        public bool Update(Alumno aActualizar)
        {
            return alumnoDao.Update(aActualizar);
        }

        public bool Delete(int id)
        {
            return alumnoDao.Delete(id);
        }
    }
}
