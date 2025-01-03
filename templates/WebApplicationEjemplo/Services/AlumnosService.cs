﻿using WebApplicationEjemplo.Models;

namespace WebApplicationEjemplo.Services
{
    public class AlumnosService
    {
        private static readonly List<Alumno> Alumnos = new()
        {
            new Alumno { Id = 1, Nombre = "Ana", Nota = 100 },
            new Alumno { Id = 2, Nombre = "Ema", Nota = 80 },
            new Alumno { Id = 3, Nombre = "Samuel", Nota = 50 }
        };
        static int GEN = 1;

        public List<Alumno> GetAll()
        { 
            return Alumnos.OrderBy(a => a.Id).ToList();
        }

        public Alumno GetById(int id)
        {
            var alumno = Alumnos.FirstOrDefault(p => p.Id == id);
            return alumno;
        }

        public Alumno Create(Alumno nuevo)
        {
            nuevo.Id = GEN + 1;
            Alumnos.Add(nuevo);
            return nuevo;
        }

        public bool Update(Alumno aActualizar)
        {
            var alumno = Alumnos.FirstOrDefault(p => p.Id == aActualizar.Id);

            if (alumno == null)
                return false;

            alumno.Nombre = aActualizar.Nombre;
            alumno.Nota = aActualizar.Nota;

            return true;
        }

        public bool Delete(int id)
        {
            var product = Alumnos.FirstOrDefault(p => p.Id == id);

            if (product == null) return false;
           

            Alumnos.Remove(product);
            return true;
        }
    }
}