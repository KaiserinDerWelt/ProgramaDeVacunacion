using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaDeVacunacion
{
    abstract class Vacuna
    {
        //Declaración de datos miembro
        protected int vaccineOption;

        public static string PFZ = "Pfizer";
        public static string AZ = "AztraZeneca";
        public static string SPKV = "Sputnik V";
        //Método Vacuna con Parámetros
        public Vacuna(int VaccineOption)
        {
            vaccineOption = VaccineOption;
        }
        //MOSTRAR VACUNA
        public void ShowVaccine()
        {
            if (vaccineOption == 1)
            {
                Console.WriteLine("Vacuna: " + PFZ);
            }
            else if (vaccineOption == 2)
            {
                Console.WriteLine("Vacuna: " + AZ);
            }
            else if (vaccineOption == 3)
            {
                Console.WriteLine("Vacuna: " + SPKV);
            }
        }
        //Métodos abstractos
        public abstract string efectosPfizer();
        public abstract string efectosAztraZeneca();
        public abstract string efectosSputnikV();
        //Interfaz para vacuna asignada
        public int datoVacuna
        {
            get
            {
                return vaccineOption;
            }
            set
            {
                vaccineOption = value;
            }
        }
        //Destructor
        ~Vacuna()
        {
            vaccineOption = 0;
        }

    }
}
