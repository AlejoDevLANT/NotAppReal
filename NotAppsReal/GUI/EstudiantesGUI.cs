using NotAppsReal.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
   
namespace NotAppsReal.GUI
{
    public class EstudiantesGUI
    {
        ServicioEstudiante ServicioEstudiante = new ServicioEstudiante();
        public void CapturarNotas()
        {
            Estudiante estudiante = new Estudiante();
            Console.Clear();
            Console.WriteLine("SISTEMAS DE PROCESAMIENTO DE NOTAS V:0.1");

            Console.Write("ID: ");
            estudiante.Id = int.Parse(Console.ReadLine());
            Console.Write("Nombre: ");
            estudiante.Nombre = Console.ReadLine();

            Console.Write("Sexo: ");
            estudiante.Sexo = Console.ReadLine();

           
            do
            {
                Console.Write("NOTA 1: ");
                estudiante.Nota1 = float.Parse(Console.ReadLine());
                if(estudiante.Nota1 < 0 || estudiante.Nota1 > 5)
                {
                    Console.WriteLine("La nota debe estar entre 0 y 5");
                }
            } while(estudiante.Nota1 < 0 || estudiante.Nota1 > 5);
            do
            {
                Console.Write("NOTA 2: ");
                estudiante.Nota2 = float.Parse(Console.ReadLine());
                if(estudiante.Nota2 < 0 || estudiante.Nota2 > 5)
                {
                    Console.WriteLine("La nota debe estar entre 0 y 5");
                }
            } while(estudiante.Nota2 < 0 || estudiante.Nota2 > 5);

            do
            {
                Console.Write("NOTA 3: ");
                estudiante.Nota3 = float.Parse(Console.ReadLine());
                if(estudiante.Nota3 < 0 || estudiante.Nota3 > 5)
                {
                    Console.WriteLine("La nota debe estar entre 0 y 5");
                }

            } while(estudiante.Nota3 < 0 || estudiante.Nota3 > 5);



            Console.Write(ServicioEstudiante.AgregarEstudiante(estudiante));
        }
        public void ImprimirResultados()
        {
            Console.Clear();
            Console.SetCursorPosition(10, 5); Console.Write("SISTEMAS DE PROCESAMIENTO DE NOTAS V:0.1");
            int i = 0;
            foreach (var item in ServicioEstudiante.ConsultarTodos())
            {
                Console.SetCursorPosition(8, 8); Console.Write("Nombre");
                Console.SetCursorPosition(15, 8); Console.Write("Primer Parcial");
                Console.SetCursorPosition(30, 8); Console.Write("Segundo Parcial");
                Console.SetCursorPosition(48, 8); Console.Write("Examen Final");
                Console.SetCursorPosition(65, 8); Console.Write("Definitiva");
                Console.SetCursorPosition(8, 9); Console.Write("-----------------------------------------------------------------");
                Console.SetCursorPosition(8, 10 + i); Console.Write(item.Nombre);
                Console.SetCursorPosition(18, 10 + i); Console.Write(item.Nota1);
                Console.SetCursorPosition(39, 10 + i); Console.Write(item.Nota2);
                Console.SetCursorPosition(54, 10 + i); Console.Write(item.Nota3);
                Console.SetCursorPosition(70, 10 + i); Console.Write(item.CalcularDefinitiva());

                i++;
                //Console.SetCursorPosition(28, 12); Console.Write(EstadoEstudiante());

            }
            Console.SetCursorPosition(8, 11 + i); Console.Write("-----------------------------------------------------------------");
        }

        public void BuscarEstudiante()
        {
            Console.Clear();
            int id;
            Console.WriteLine("Digite el ID del estudiante a buscar: ");
            id = int.Parse(Console.ReadLine());
            Console.Clear();
            Console.SetCursorPosition(10, 5); Console.Write("INFORMACION DEL ESTUDIANTE: ");
            foreach (var item in ServicioEstudiante.ConsultarTodos())
            {
                if (item.Id == id)
                {
                    Console.SetCursorPosition(8, 8); Console.Write("Nombre");
                    Console.SetCursorPosition(15, 8); Console.Write("Primer Parcial");
                    Console.SetCursorPosition(30, 8); Console.Write("Segundo Parcial");
                    Console.SetCursorPosition(48, 8); Console.Write("Examen Final");
                    Console.SetCursorPosition(65, 8); Console.Write("Definitiva");
                    Console.SetCursorPosition(8, 9); Console.Write("-----------------------------------------------------------------");
                    Console.SetCursorPosition(8, 10); Console.Write(item.Nombre);
                    Console.SetCursorPosition(18, 10); Console.Write(item.Nota1);
                    Console.SetCursorPosition(39, 10); Console.Write(item.Nota2);
                    Console.SetCursorPosition(54, 10); Console.Write(item.Nota3);
                    Console.SetCursorPosition(70, 10); Console.Write(item.CalcularDefinitiva());
                    break;
                }
            }
            Console.SetCursorPosition(8, 12); Console.Write("-----------------------------------------------------------------");
        }
         Estudiante BuscarEstudiante(int id) { 
            Estudiante estudiante = new Estudiante();
            foreach (var item in ServicioEstudiante.ConsultarTodos())
            {
                if (item.Id == id)
                {
                    estudiante = item;
                    return estudiante;
                }

            }
            return null;
        }
        public void ActualizarEstudiante()
        {
           

            Console.Clear();
            Console.SetCursorPosition(10, 5); Console.Write("ACTUALIZAR ESTUDIANTE");
            Console.SetCursorPosition(8, 8); Console.Write("Digite el ID del estudiante a actualizar: ");
            int id = int.Parse(Console.ReadLine());
            var EstudianteEncontrado = BuscarEstudiante(id );
            if (EstudianteEncontrado != null)
            {
                
                Console.SetCursorPosition(8, 10); Console.Write("Nombre: ");
                EstudianteEncontrado.Nombre = Console.ReadLine();
                Console.SetCursorPosition(8, 12); Console.Write("Sexo: ");
                EstudianteEncontrado.Sexo = Console.ReadLine();
                Console.SetCursorPosition(8, 14); Console.Write("Nota 1: ");
                EstudianteEncontrado.Nota1 = float.Parse(Console.ReadLine());
                Console.SetCursorPosition(8, 16); Console.Write("Nota 2: ");
                EstudianteEncontrado.Nota2 = float.Parse(Console.ReadLine());
                Console.SetCursorPosition(8, 18); Console.Write("Nota 3: ");
                EstudianteEncontrado.Nota3 = float.Parse(Console.ReadLine());
                Console.SetCursorPosition(8, 20); Console.Write("Estudiante actualizado");
            }
            else
            {
                Console.SetCursorPosition(8, 10); Console.WriteLine("El estudiante no existe");
            }
        }
        public void EliminarEstudiante()
        {
            Console.Clear();
            Console.SetCursorPosition(10, 5); Console.Write("ELIMINAR ESTUDIANTE");
            Console.SetCursorPosition(8, 8); Console.Write("DIGITE LA ID DEL ESTUDIANTE: ");
            int id = int.Parse(Console.ReadLine());
            var EstudianteEncontrado = BuscarEstudiante(id);
            if (EstudianteEncontrado != null)
            {
               
                Console.SetCursorPosition(8, 10); Console.Write($"ESTUDIANTE {EstudianteEncontrado.Nombre.ToUpper()} ELIMINADO");
                ServicioEstudiante.ConsultarTodos().Remove(EstudianteEncontrado);
            }
            else
            {
                Console.SetCursorPosition(8, 10); Console.WriteLine("EL ESTUDIANTE NO EXISTE");
            }
        }



    }
}
