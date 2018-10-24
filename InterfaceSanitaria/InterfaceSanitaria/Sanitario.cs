using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSanitaria
{
    class Sanitario : IPersonalLaboral
    {
        
        public string DNI { get; set; }
        public string Name { get; set; }
        public double SalaryBase { get; set; }
        public int Age { get; set; }

        public Sanitario()
        {

        }

        public Sanitario(string dni, string name, double salaryBase, int age)
        {
            DNI = dni;
            Name = name;
            SalaryBase = salaryBase;
            Age = age;
        }

        //********************* METODOS *************************
        //public bool Retire(int age)
        //{
        //    if(Age >= 65)
        //    {
        //        Console.WriteLine(" El sanitario " + Name + " esta jubilado.");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine(" El sanitario " + Name + " etiene muchos años que trabajar antes de jubilarse.");
        //        return false;
        //    }
        //}

        public virtual string Show()
        {
            return "El trabajador sanitario de DNI " + DNI + " cuyo nombre es " + Name + " con un salario base de " + SalaryBase + " euros, cuya edad es " + Age + " años, "; 
        }

        public bool Retire()
        {
            if (Age >= 65)
            {
                Console.WriteLine(" El sanitario " + Name + " esta jubilado.");
                return true;
            }
            else
            {
                Console.WriteLine(" El sanitario " + Name + " aun tiene muchos años que trabajar antes de jubilarse.");
                return false;
            }
        }

        public double CalculateSalary()
        {
            
            throw new NotImplementedException();
        }
    }
}
