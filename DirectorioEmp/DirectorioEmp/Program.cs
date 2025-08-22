using DirectorioEmp.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirectorioEmp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Persona empleado1 = new Persona(
               "0801-1990-12345",
               "Jose Carlos ",
               "Pérez Gómez",
               new DateTime(1990, 5, 15),
               "2234-5678",
               "9988-7766",
               "Honduras",
               "Tegucigalpa",
               "Colonia Kennedy, bloque 5, casa 10",
               "Ingeniero en Informatica"
            );

            Grado gradoUni = new Grado(1, "Superior", "UMH Honduras ", "Ingeniería en Sistemas", 
                new DateTime(2015, 1, 15), new DateTime(2020, 11, 30), "Universitario", 
                new DateTime(2025, 1, 1), "Honduras");
            Cargo cargo1 = new Cargo(1, "Supervisor de Mantenimiento.", new DateTime(2016, 2, 1), new DateTime(2018, 12, 31), false, "Empresa Ficticia S.A.", 22000.00m, "Mantenimiento de software legado.");
            Cargo cargo2 = new Cargo(2, "Programador Jr.", new DateTime(2019, 1, 15), new DateTime(9999, 1, 1), true, "Soluciones Tech", 40000.00m, "Desarrollo de nuevas aplicaciones en C#.");


            empleado1.AgregarGrado(gradoUni);
            empleado1.AgregarCargo(cargo1);
            empleado1.AgregarCargo(cargo2);

            empleado1.ImprimirFichas();



        }
    }
}
