using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSanitaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Enfermero enf1 = new Enfermero("12498571L", "Mariano Retortillo", 1200.50, 25,"UCI");
            Enfermero enf2 = new Enfermero("12521761N", "Ana Maria Estevez", 1650.40, 40, "Planta");
            Enfermero enf3 = new Enfermero("31758571Q", "rosa Sanchez", 2300.10, 66, "Planta");
            Medico med1 = new Medico("12324721S", "Javier de la Calle", 1800.50, 26, "Cardiologo", 60);
            Medico med2 = new Medico("24858571M", "Camilo Jose Cela", 2200.10, 68, "Ginecologo", 50);

            List<Sanitario> cruces = new List<Sanitario>();
            cruces.Add(enf1);
            cruces.Add(enf2);
            cruces.Add(enf3);
            cruces.Add(med1);
            cruces.Add(med2);

            foreach (Sanitario x in cruces)
            {
                Console.WriteLine(x.Show());
                
                Console.WriteLine(x.Retire());
            }


            Console.ReadLine();
        }
    }
}
