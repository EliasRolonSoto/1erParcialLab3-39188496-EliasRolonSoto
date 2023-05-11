﻿namespace DotnetExam.Entities
{
    public class Materia
    {
        public int MateriaId { get; set; }
        public string Nombre { get; set; }
        public List<Alumno> Alumnos { get; set; }


        public Materia(int materiaId, string nombre)
        {
            MateriaId = materiaId;
            Nombre = nombre;

            Alumnos = new List<Alumno>();
        }


        public Materia()
        {
            Alumnos = new List<Alumno>();        
        }



    }
}