using System;

namespace ProgramaDeVacunacion
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int vaccineSelection = 0;
            while (vaccineSelection == 0 || vaccineSelection == 1 || vaccineSelection == 2 || vaccineSelection == 3)
            {
                do
                {  
                    Console.WriteLine("<---------BIENVENIDO AL SISTEMA NACIONAL DE VACUNACION----------->");
                    Console.WriteLine("<------------------ESTADOS UNIDOS MEXICANOS-------------------->");
                    Console.WriteLine("<--En Mexico la vacuna es un derecho, es publica, gratuita y garantizada-->");
                    Console.WriteLine("Selecciona una opción: 1)Vacuna 2)Efectos secundarios 3)Salir");
                    var option = Console.ReadLine();
                    vaccineSelection = int.Parse(option);
                    switch (vaccineSelection) //Creacion de bloque selectivo switch
                    {
                        case 1 when (vaccineSelection == 1):
                           
                            var randomVaccine = new Random().Next(1,4); //Funcion random para dar la vacuna aleatoriamente
                            EFECTO sideEffect = new EFECTO(randomVaccine); 
                            sideEffect.ShowVaccine();
                            //Pfizer
                            if (randomVaccine == 1)
                            {
                                sideEffect.Information();
                                Console.WriteLine("Acepto que soy mentalmente competente y aceptorecibir la vacuna COVID-19.");
                                Console.WriteLine("Teclee la opcion adecuada: 1)Si 2)No");
                                var confirmation = Console.ReadLine();
                                if (confirmation == "1") //La confirmacion es numerica para evadir errores de escritura y ortografia 
                                {
                                    Console.WriteLine( "Teclea el numero la opcion adecuada para ti: 1)Aplicar primer dosis.  2)Aplicar segunda dosis.");
                                    var inoculationRound = Console.ReadLine();
                                    int dosesSelection = int.Parse(inoculationRound);
                                    sideEffect.Inoculate(dosesSelection, randomVaccine);
                                }
                                else if (confirmation == "2")
                                {
                                    Console.WriteLine("No aceptar recibir la vacuna COVID-19 implica la cancelacion de la inoculacion.");
                                }
                            }
                            else if (randomVaccine == 2)
                            {
                                sideEffect.Information();
                                Console.WriteLine("Acepto que soy mentalmente competente y aceptorecibir la vacuna COVID-19.");
                                Console.WriteLine("Teclee la opcion adecuada: 1)Si 2)No");
                                var confirmation = Console.ReadLine();
                                if (confirmation == "1")
                                {
                                    Console.WriteLine( "Teclea el numero la opcion adecuada para ti: 1)Aplicar primer dosis.  2)Aplicar segunda dosis.");
                                    var inoculationRound = Console.ReadLine();
                                    int dosesSelection = int.Parse(inoculationRound);
                                    string vacunaAztra = randomVaccine.ToString();
                                    sideEffect.Inoculate(dosesSelection, vacunaAztra);
                                }
                                else if (confirmation == "2")
                                {
                                    Console.WriteLine("No acepto recibir la vacuna y se que implica la cancelacion de la inoculacion.");
                                }
                            }
                            else if (randomVaccine == 3)
                            {
                                sideEffect.Information();
                                Console.WriteLine("Acepto que soy mentalmente competente y acepto recibir la vacuna COVID-19.");
                                Console.WriteLine("Teclee la opcion adecuada: 1)Si 2)No");
                                var confirmation = Console.ReadLine();
                                if (confirmation == "1")
                                {
                                    Console.WriteLine( "Teclea el numero la opcion adecuada para ti: 1)Aplicar primer dosis.  2)Aplicar segunda dosis.");
                                    var inoculationRound = Console.ReadLine();
                                    int dosesSelection = int.Parse(inoculationRound);
                                    string vacunaSputnik = randomVaccine.ToString();
                                    sideEffect.Inoculate(vacunaSputnik, dosesSelection);
                                }
                                else if (confirmation == "2")
                                {
                                    Console.WriteLine("No acepto recibir la vacuna y se que implica la cancelacion de la inoculacion.");
                                }

                            }
                            break;
                        case 2 when (vaccineSelection == 2):
                            var randomNumber = new Random().Next(1, 4);
                            EFECTO efectovacuna = new EFECTO(randomNumber);
                            if (randomNumber == 1)
                            {
                                efectovacuna.ShowVaccine();
                                efectovacuna.efectosPfizer();
                            }
                            else if (randomNumber == 2)
                            {
                                efectovacuna.ShowVaccine();
                                efectovacuna.efectosAztraZeneca();
                            }
                            else if (randomNumber == 3)
                            {
                             
                                efectovacuna.ShowVaccine();
                                efectovacuna.efectosSputnikV();
                            }
                            break;
                        case 3 when (vaccineSelection == 3):
                            Console.WriteLine("Adios");
                            Environment.Exit(0);
                            break;
                    }
                }
                while (vaccineSelection == 1 || vaccineSelection == 2 || vaccineSelection == 3);
            }
        }
    }
}
