using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotAppsReal.Logica
{
    class ServicioPalpitaciones
    {
       public String  CapturarDatos()
        {
            float pulsaciones;
            Console.WriteLine("SISTEMA DE REGISTRO DE PALPITACIONES");
            Console.Write("INGRESE SU EDAD: ");
            int edad = int.Parse(Console.ReadLine());
            Console.WriteLine("INGRESE SU SEXO");
            Console.WriteLine("1. Masculino");
            Console.WriteLine("2. Femenino");
            Console.Write("==");int sexo = int.Parse(Console.ReadLine());
            pulsaciones =CalcularPalpitaciones(sexo, edad);
            return $"sus pulsaciones son: {pulsaciones}";
        }
        public float CalcularPalpitaciones(int sexo, int edad)
        {
            if (sexo == 1)
            {
                return ((210-edad)/10);
            }
            else
            {
                return ((220 - edad) / 10);
            }
        }
    }
}
