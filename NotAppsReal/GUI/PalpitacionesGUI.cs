using NotAppsReal.Logica;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotAppsReal.GUI
{
    class PalpitacionesGUI
    {
        ServicioPalpitaciones Palpitaciones = new ServicioPalpitaciones();
        public void MostrarPalpitaciones()
        {
            Console.WriteLine(Palpitaciones.CapturarDatos());
        }

    }
}
