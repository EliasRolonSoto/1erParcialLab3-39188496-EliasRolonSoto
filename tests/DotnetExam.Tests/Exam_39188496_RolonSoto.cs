using DotnetExam.Entities;

namespace DotnetExam.Tests
{
    public class Exam_DNI39188496_RolonSotoElias
    {



        [Fact]
        public void Test_1_Teoria_Winform()
        {

            //Que es winform en .NET con sus palabras.  ¿Para que se utiliza?  ¿Donde se puede desplegar o ejecutar (en cuales clientes)?
            var respuesta = "Es una herramienta que nos permite crear, editar y gestionar una interfaz grafica de uso con el ambiente windows en la cual podemos modificar tanto sus componentes como sus atributos y eventos. Se utiliza principalmente para desarrollar aplicaciones de escritorio para entorno windows";

            Assert.NotEmpty(respuesta);



        }


        [Fact]
        public void Test_2_Teoria_Eventos()
        {

            //¿Cuál es la diferencia entre el evento Click y el evento Load en un botón de WinForms?
            var respuesta = "El evento load se produce una vez junto con la carga del formulario (en su inicializacion) en cambio el evento click se activa y ejecuta cuando hacemos click en un lugar determinado previamente por nosotros para que conlleve una accion";

            Assert.NotEmpty(respuesta);



        }


        [Fact]
        public void Test_3_Teoria_Delegados()
        {

            //¿Qué es un delegado en C# y cuál es su propósito principal?
            var respuesta = "Un delegado en C# es un tipo de dato que representa una referencia a un método con un conjunto específico de parámetros y un tipo de retorno, y su propósito principal es permitir la programación orientada a eventos.";

            Assert.NotEmpty(respuesta);


        }



        [Fact]
        public void Test_4_DemoMaterias()
        {
            MateriaGenerador g = new MateriaGenerador();
            var materias = g.Generar(cantidad: 100, alumnosPorMateria: 25);

            Assert.NotEmpty(materias);
            Assert.Equal(100, materias.Count());
            Assert.Equal("Materia 1", materias.First().Nombre);
            Assert.Equal(1, materias.First().Alumnos.First().AlumnoId);
            Assert.True(materias.First().Alumnos.First().Nota > 0);
            Assert.IsType<bool>(materias.First().Alumnos.First()._aprobado);

        }


    }
}