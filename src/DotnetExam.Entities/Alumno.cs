namespace DotnetExam.Entities
{
    public class Alumno : Persona
    {
        public int AlumnoId { get; set; }
        public string Legajo { get; set; }
        public int Nota { get; set; }

        public bool _aprobado
        {
            get
            {
                if (Nota < 6)
                {
                    return false;
                }
                else return true;
            }
        }

        public string NombreCompleto
        {
            get {
                return $"[{_Id}] {_apellido.ToUpper()}, {_nombre}";
                }
        }

    }
}