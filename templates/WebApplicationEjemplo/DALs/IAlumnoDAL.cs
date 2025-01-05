using WebApplicationEjemplo.Models;

namespace WebApplicationEjemplo.DALs;

public interface IAlumnoDAL
{
    List<Alumno> GetAll();
    Alumno GetById(int id);
    Alumno Add(Alumno alumno);
    bool Update(Alumno alumno);
    bool Delete(int id);
}
