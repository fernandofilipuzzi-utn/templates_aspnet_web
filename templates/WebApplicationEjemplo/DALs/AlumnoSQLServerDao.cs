using Microsoft.Data.SqlClient;
using WebApplicationEjemplo.ApiControllers;
using WebApplicationEjemplo.Models;

namespace WebApplicationEjemplo.DALs;

public class AlumnoSQLServerDao : IAlumnoDao
{
    private readonly string _connectionString;

    public AlumnoSQLServerDao(string connectionString)
    {
        _connectionString = connectionString;
    }

    public List<Alumno> GetAll()
    {
        var alumnos = new List<Alumno>();
        using var connection = new SqlConnection(_connectionString);

        connection.Open();

        string sql = 
@"SELECT Id, Nombre, Nota 
FROM Alumnos";

        var command = new SqlCommand(sql, connection);
        using var reader = command.ExecuteReader();

        while (reader.Read())
        {
            alumnos.Add(new Alumno
            {
                Id = reader.GetInt32(0),
                Nombre = reader.GetString(1),
                Nota = reader.GetDecimal(2)
            });
        }

        return alumnos;
    }

    public Alumno GetById(int id)
    {
        using var connection = new SqlConnection(_connectionString);

        connection.Open();

        string sql = "SELECT Id, Nombre, Nota FROM Alumnos WHERE Id = @Id";

        var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@Id", id);

        using var reader = command.ExecuteReader();

        if (reader.Read())
        {
            return new Alumno
            {
                Id = reader.GetInt32(0),
                Nombre = reader.GetString(1),
                Nota = reader.GetDecimal(2)
            };
        }
    
        return null;
    }

    public Alumno Add(Alumno alumno)
    {
        using var connection = new SqlConnection(_connectionString) ;
        
        connection.Open();

        string sql =
@"INSERT INTO Alumnos (Nombre, Nota)  
OUTPUT INSERTED.ID
VALUES (@Nombre, @Nota)";

        var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@Nombre", alumno.Nombre);
        command.Parameters.AddWithValue("@Nota", alumno.Nota);

        int id=(int)command.ExecuteScalar();        
        alumno.Id = id;

        return alumno;
    }

    public bool Update(Alumno alumno)
    {
        using var connection = new SqlConnection(_connectionString);
        
        connection.Open();

        string sql = 
@"UPDATE Alumnos SET Nombre = @Nombre, Nota = @Nota 
WHERE Id = @Id";

        var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@Id", alumno.Id);
        command.Parameters.AddWithValue("@Nombre", alumno.Nombre);
        command.Parameters.AddWithValue("@Nota", alumno.Nota);

        command.ExecuteNonQuery();

        return true;
    }

    public bool Delete(int id)
    {
        using var connection = new SqlConnection(_connectionString);
        
        connection.Open();

        string sql = 
@"DELETE FROM Alumnos 
WHERE Id = @Id";

        var command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@Id", id);
        command.ExecuteNonQuery();

        return true;
    }
}
