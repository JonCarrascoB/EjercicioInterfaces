using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSanitaria
{
    class Medico : Sanitario, IPersonalLaboral
    {
        public string Especiality { get; set; }
        public int NumberPac { get; set; }

        public Medico()
        {

        }

        public Medico(string DNI, string name, double salaryBase, int age, string especiality, int numberPac):base(DNI,name,salaryBase,age)
        {
            Especiality = especiality;
            NumberPac = numberPac;
        }

        //********************** METODOS ******************************
        public double CalculateSalary()
        {
            return (SalaryBase+(NumberPac*1.20));
        }

        public override string Show()
        {
            return base.Show() + " su especialidad es " + Especiality + " y ha recibido a " + NumberPac + " pacientes y su sueldo mensual es " + (CalculateSalary() +(CalculateSalary()*0.01)) + " euros";
        }

        



    }
}
