using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NotAppsReal.GUI;
namespace NotAppsReal.GUI
{
    class MenuEstudiantes
    {


        ServicioEstudiante ServicioEstudiante = new ServicioEstudiante();
        EstudiantesGUI estudiantesGUI = new EstudiantesGUI();
        public void Menu()
        {

            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(10, 5); Console.Write(" M E N U   P R I N C I P A L");

                Console.SetCursorPosition(8, 8); Console.Write("1. Agregar Estudiante ");
                Console.SetCursorPosition(8, 10); Console.Write("2. Listado General de Estudiantes");
                Console.SetCursorPosition(8, 12); Console.Write("3. Buscar Estudiante");
                Console.SetCursorPosition(8, 14); Console.Write("4. Actualizar Estudiante");
                Console.SetCursorPosition(8, 16); Console.Write("5. Eliminar Estudiante");
                Console.SetCursorPosition(8, 20); Console.Write("9. salir");
                Console.SetCursorPosition(8, 22); Console.Write("Seleccione una opcion: ");

                Console.SetCursorPosition(31, 22); op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:

                        estudiantesGUI.CapturarNotas();

                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                        if(ServicioEstudiante.ConsultarTodos().Any())
                        {
                            Console.WriteLine("No hay estudiantes registrados");
                        }
                        else
                        {
                            estudiantesGUI.ImprimirResultados();
                            
                        }
                        Console.ReadKey();
                        break;
                    case 3:
         
                        Console.Clear();
                        if(ServicioEstudiante.ConsultarTodos().Any())
                        {
                            Console.WriteLine("No hay estudiantes registrados");
                        }
                        else
                        {
                            
                            //BUSCAR ESTUDIANTE
                            estudiantesGUI.BuscarEstudiante();
                            
                            
                        }
                        Console.ReadKey();

                        break;
                    case 4:
                        Console.Clear();
                        

                        if(ServicioEstudiante.ConsultarTodos().Any())
                        {
                            Console.WriteLine("No hay estudiantes registrados");
                        }
                        else
                        {
                            //ACTUALIZAR ESTUDIANTE
                            estudiantesGUI.ActualizarEstudiante();
                        }
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.Clear();




                        if (ServicioEstudiante.ConsultarTodos().Any())
                        {
                            Console.WriteLine("No hay estudiantes registrados");
                        }
                        else
                        {
                            //ELIMINAR ESTUDIANTE
                            estudiantesGUI.EliminarEstudiante();
                        }
                        
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.Clear();
                        Console.WriteLine("GRACIAS POR VISITARNOS");
                        Console.ReadKey();
                        break;

                }

            } while (op != 9);

        }







    }
}
