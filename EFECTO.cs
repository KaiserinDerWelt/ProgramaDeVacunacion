using System;
using System.Collections.Generic;
using System.Text;

namespace ProgramaDeVacunacion
{
    class EFECTO : Vacuna
    {
        public static string sideEffectsDescription = "Posibles efectos secundarios:\n";
        public static string sideEffectsPZR = "Zona de administración: hinchazón, dolor.\n2.- Escalofrío.\n3.- Fiebre(Más elevada después de la 2da dosis).";
        public static string sideEffectsAZE = "**En zona de administración: Sensibilidad, dolor, calor, prurito, moratón.\n**Escalofríos, febrícula, malestar, fatiga, nauseas.\n3**Mialgia, artralgia.";
        public static string sideEffectsSPKV = "**Fiebre, cefalea y/o mialgias.\n**Dolor en zona de administración, hiperemia, hinchazón.\n**Síntomas gastrointestinales.";
        public static string infoPZR = "Origen: Estados Unidos y Alemania\nEfectividad: 95%\nCosto: 19USD\nCaracterística: El mensaje se codifica en una molécula de ARN que se encapsula en una membrana lipídica para que pueda entrar en las células.";
        public static string infoAZE = "Origen: Inglaterra y Suecia\nEfectividad: 70%\nCosto: 2.8USD\nCaracterística: El mensaje se codifica en un ADN, otro lenguaje genético, y se introduce en adenovirus del resfriado de los chimpancés.";
        public static string infoSPKV = "Origen: Rusia\nEfectividad: 92%\nCosto: 10USD\nCaracterística: El gen del adenovirus, se sustrae y en su lugar se inserta un gen con el código de la proteína de otro virus.";
        public static string firstInoculation = "Seleccion: Primera dosis.";
        public static string secondInoculation = "Seleccion: Segunda dosis.";
        public static string inoculationMechanismPZR = "Con esta vacuna el ARN entra en las células humanas y hace que fabriquen proteínas de la espícula del coronavirus.\nLa espícula del virus es localizada por las células dendríticas: Se genera la respuesta inmune y se producen dos tipos de glóbulos blancos:\nlinfocitos B: Crean anticuerpos que bloquean el virus\nlinfocitos T: Destruye las células infectadas)";
        public static string inoculationMechanismAZE = "Con esta vacuna el ADN se copia en un ARN en el núcleo, el cual migra al citoplasma en donde, a partir de este, se producen o se fabrican las proteínas virales. La espícula del virus es localizada por las células dendtríticas. : Se genera la respuesta inmune y se producen dos tipos de glóbulos blancos:\nlinfocitos B: Crean anticuerpos que bloquean el virus\nlinfocitos T: Destruye las células infectadas)";
        public static string inoculationMechanismSPKV= "El gen del adenovirus, se sustrae y en su lugar se inserta un gen con el código de la proteína de otro virus.";
        public static string firstInoculationSuccess = "La aplicación de la primera dosis se ha culminado exitosamente.";
        public static string secondInoculationSuccess = "La aplicación de la segunda dosis se ha culminado exitosamente.";
        public static string periodTO = "Aplicacion de segunda dosis dentro de 21 días.";
        public static string periodND = "Aplicacion de segunda dosis dentro de 90 días.";
        public static string followingAppointment = "Fecha de aplicación de la segunda dosis: \n";

        public EFECTO(int vacunaSeleccionadaAleatoria) : base(vacunaSeleccionadaAleatoria) { }

        public override string efectosPfizer()
        {
            if (vaccineOption == 1)
            {
                Console.WriteLine(sideEffectsDescription + "\n" + sideEffectsPZR + "\n");
            }
            return base.vaccineOption + "";
        }
        public override string efectosAztraZeneca()
        {
            if (vaccineOption == 2)
            {
                Console.WriteLine(sideEffectsDescription + "\n" + sideEffectsAZE + "\n");
            }
            return base.vaccineOption + "";
        }
        public override string efectosSputnikV()
        {
            if (vaccineOption == 3)
            {
                Console.WriteLine(sideEffectsDescription + "\n" + sideEffectsSPKV + "\n");
            }
            return base.vaccineOption + "";
        }

        public void Information()
        {
            if (vaccineOption == 1) { Console.WriteLine(infoPZR); }
            if (vaccineOption == 2) { Console.WriteLine(infoAZE); }
            if (vaccineOption == 3) { Console.WriteLine(infoSPKV); }
        }

        public int Inoculate(int dosesSelection, int vacunaPfizer)
        {
            if (dosesSelection == 1)
            {
                Console.WriteLine(firstInoculation + "\n" + inoculationMechanismPZR);
                Console.WriteLine(firstInoculationSuccess);
                Console.WriteLine(periodTO);
                var diasAgregados = DateTime.Now.AddDays(21);
                Console.WriteLine(followingAppointment + diasAgregados);
            }
            else if (dosesSelection == 2)
            {
                Console.WriteLine(secondInoculation + "\n" + inoculationMechanismPZR);
                Console.WriteLine(secondInoculationSuccess);
            }
            return dosesSelection;
        }
        public int Inoculate(int dosesSelection, string vacunaAztraZeneca)
        {
            if (dosesSelection == 1)
            {
                Console.WriteLine(firstInoculation + "\n" + inoculationMechanismAZE);
                Console.WriteLine(firstInoculationSuccess);
                Console.WriteLine(periodND);
                var diasAgregados = DateTime.Now.AddDays(90);
                Console.WriteLine(followingAppointment + diasAgregados);
            }
            else if (dosesSelection == 2)
            {
                Console.WriteLine(secondInoculation + "\n" + inoculationMechanismAZE);
                Console.WriteLine(secondInoculationSuccess);
            }
            return dosesSelection;
        }
        public int Inoculate(string vacunaSputnik, int dosesSelection)
        {
            if (dosesSelection == 1)
            {
                Console.WriteLine(firstInoculation + "\n" + inoculationMechanismSPKV);
                Console.WriteLine(firstInoculationSuccess);
                Console.WriteLine(periodTO);
                var diasAgregados = DateTime.Now.AddDays(21);
                Console.WriteLine(followingAppointment + diasAgregados);
            }
            else if (dosesSelection == 2)
            {
                Console.WriteLine(secondInoculation + "\n" + inoculationMechanismSPKV);
                Console.WriteLine(secondInoculationSuccess);
            }
            return dosesSelection;
        }
    }
}
