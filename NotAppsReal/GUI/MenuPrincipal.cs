using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotAppsReal.GUI
{
    class MenuPrincipal
    {
        MenuEstudiantes menuEstudiantes = new MenuEstudiantes();
        PalpitacionesGUI palpitacionesGUI = new PalpitacionesGUI();
        public void Menu()
        {

            int op;
            do
            {
                Console.Clear();
                Console.SetCursorPosition(10, 5); Console.Write(" M E N U  E J E R C I C I O S");

                Console.SetCursorPosition(8, 8); Console.Write("1. REGISTRO DE ESTUDIANTES ");
                Console.SetCursorPosition(8, 10); Console.Write("2. PALPITACIONES");
                Console.SetCursorPosition(8, 12); Console.Write("3. ------");
                Console.SetCursorPosition(8, 16); Console.Write("4. salir");
                Console.SetCursorPosition(8, 18); Console.Write("Seleccione una opcion: ");

                Console.SetCursorPosition(31, 18); op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:

                        menuEstudiantes.Menu();
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.Clear();
                       
                        palpitacionesGUI.MostrarPalpitaciones();
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Clear();
                      
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("GRACIAS POR VISITARNOS");
                        Console.ReadKey();
                        break;

                }

            } while (op != 4);

        }
    }
}
