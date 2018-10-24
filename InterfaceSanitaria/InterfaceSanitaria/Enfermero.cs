using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSanitaria
{
    class Enfermero: Sanitario, IPersonalLaboral
    {
        public string Job { get; set; }
        

        public Enfermero()
        {

        }

        public Enfermero(string dni, string name, double salaryBase, int age, string job) : base(dni, name, salaryBase, age)
        {
            Job = job;
            
        }

        //********************** METODOS ******************************
        public double CalculateSalary()
        {
            if (Job == "UCI")
            {
                return (SalaryBase+200);
            }
            else if (Job == "Planta")
            {
                return SalaryBase;
            }
            else
            {
                return 0;
            }
        }


        public override string Show()
        {
            return base.Show() + " su puesto es " + Job+ " y su sueldo mensual es "+ (CalculateSalary() + (CalculateSalary() * 0.01)) + " euros";
        }


    }
}
