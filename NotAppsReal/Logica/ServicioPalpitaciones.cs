using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotAppsReal.Logica
{
    class ServicioPalpitaciones
    {
       public void CapturarDatos()
        {
            Console.WriteLine("SISTEMA DE REGISTRO DE PALPITACIONES");
            Console.Write("INGRESE SU EDAD: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE SU SEXO");
            Console.WriteLine("1. Masculino");
            Console.WriteLine("2. Femenino");
            Console.Write("==");int sexo = int.Parse(Console.ReadLine());
        }
        public float CalcularPalpitaciones()
        {

        }
    }
}
