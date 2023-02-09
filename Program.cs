using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            System.Console.WriteLine("Bienvenido, seleccione la opción que desee");
            string opcion;
            do
            {

                System.Console.WriteLine("1)Iniciar Diagnóstico");
                System.Console.WriteLine("2)Salir");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        p.SintomasGenerales();
                        break;
                    case "2":
                        return;
                }
            } while (opcion != "2");


        }

        public void SintomasGenerales()
        {
            Console.Clear();
            string respuesta;
            System.Console.WriteLine("¿Frecuentemente presenta alguna sensación de tener un objeto extraño en sus ojos?");
            System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
            respuesta = Console.ReadLine();

            if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
            {
                System.Console.WriteLine("¿Después de una alergia, la parte blanca de su ojo presenta enrojecimiento?");
                System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                respuesta = Console.ReadLine();

                if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                {
                    System.Console.WriteLine("¿Últimamente ha presentado costras en parpados o pestañas después de dormir un largo periodo)");
                    System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                    respuesta = Console.ReadLine();

                    if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                    {
                        System.Console.WriteLine("¿Usas lentes de contacto?");
                        System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                        respuesta = Console.ReadLine();

                        if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                        {
                            System.Console.WriteLine("¿Al usarlos, estos son incomodos?");
                            System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                            respuesta = Console.ReadLine();

                            if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                            {
                                System.Console.WriteLine("¿Te ha salpicado alguna sustancia química o entrado algún objeto extraño en el ojo?");
                                System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                                respuesta = Console.ReadLine();

                                if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                                {
                                    //manda a conjuntivitis por irritantes
                                    ConjuntivitisIrritantes();
                                }
                                else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                                {
                                    System.Console.WriteLine("¿Ha presentado secreción acuosa o espesa en los ojos?");
                                    System.Console.WriteLine("Seleccione una opción\n1) Espesa \n2) Acuosa\n3) Ninguna");
                                    respuesta = Console.ReadLine();
                                    if (respuesta == "1" || respuesta == "Espesa" || respuesta == "espesa" || respuesta == "ESPESA")
                                    {
                                        //manda a conjuntivitis bacteriana
                                        ConjuntivitisBacteriana();
                                    }
                                    else if (respuesta == "2" || respuesta == "Acuosa" || respuesta == "acuosa" || respuesta == "ACUOSA")
                                    {
                                        //manda a conjuntivitis viral
                                        ConjuntivitisViral();
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("¿Presenta irritación en ambos ojos?");
                                        System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                                        respuesta = Console.ReadLine();
                                        if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                                        {
                                            //manda a conjuntivitis alergica
                                            ConjuntivitisAlergica();
                                        }
                                        else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                                        {
                                            DiagnosticoNegativo();
                                        }
                                    }
                                }
                            }
                            else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                            {
                                System.Console.WriteLine("¿Te ha salpicado alguna sustancia química o entrado algún objeto extraño en el ojo?");
                                System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                                respuesta = Console.ReadLine();

                                if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                                {
                                    //manda a conjuntivitis por irritantes
                                    ConjuntivitisIrritantes();
                                }
                                else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                                {
                                    System.Console.WriteLine("¿Ha presentado secreción acuosa o espesa en los ojos?");
                                    System.Console.WriteLine("Seleccione una opción\n1) Espesa \n2) Acuosa\n3) Ninguna");
                                    respuesta = Console.ReadLine();
                                    if (respuesta == "1" || respuesta == "Espesa" || respuesta == "espesa" || respuesta == "ESPESA")
                                    {
                                        //manda a conjuntivitis bacteriana
                                        ConjuntivitisBacteriana();
                                    }
                                    else if (respuesta == "2" || respuesta == "Acuosa" || respuesta == "acuosa" || respuesta == "ACUOSA")
                                    {
                                        //manda a conjuntivitis viral
                                        ConjuntivitisViral();
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("¿Presenta irritación en ambos ojos?");
                                        System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                                        respuesta = Console.ReadLine();
                                        if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                                        {
                                            //manda a conjuntivitis alergica
                                            ConjuntivitisAlergica();
                                        }
                                        else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                                        {
                                            DiagnosticoNegativo();
                                        }
                                    }
                                }
                            }

                        }
                        else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                        {
                            System.Console.WriteLine("¿Te ha salpicado alguna sustancia química o entrado algún objeto extraño en el ojo?");
                            System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                            respuesta = Console.ReadLine();

                            if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                            {
                                //manda a conjuntivitis por irritantes
                                ConjuntivitisIrritantes();
                            }
                            else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                            {
                                System.Console.WriteLine("¿Ha presentado secreción acuosa o espesa en los ojos?");
                                System.Console.WriteLine("Seleccione una opción\n1) Espesa \n2) Acuosa\n3) Ninguna");
                                respuesta = Console.ReadLine();
                                if (respuesta == "1" || respuesta == "Espesa" || respuesta == "espesa" || respuesta == "ESPESA")
                                {
                                    //manda a conjuntivitis bacteriana
                                    ConjuntivitisBacteriana();
                                }
                                else if (respuesta == "2" || respuesta == "Acuosa" || respuesta == "acuosa" || respuesta == "ACUOSA")
                                {
                                    //manda a conjuntivitis viral
                                    ConjuntivitisViral();
                                }
                                else
                                {
                                    System.Console.WriteLine("¿Presenta irritación en ambos ojos?");
                                    System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                                    respuesta = Console.ReadLine();
                                    if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                                    {
                                        //manda a conjuntivitis alergica
                                        ConjuntivitisAlergica();
                                    }
                                    else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                                    {
                                        DiagnosticoNegativo();
                                    }
                                }
                            }
                        }
                    }
                    else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                    {
                        DiagnosticoNegativo();
                    }
                }
                else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                {
                    DiagnosticoNegativo();
                }

            }
            else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
            {
                //RESPUESTA NO A LA PRIMER PREGUNTA
                System.Console.WriteLine("¿Después de una alergia, la parte blanca de su ojo presenta enrojecimiento?");
                System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                respuesta = Console.ReadLine();

                if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                {
                    //SI EN LA PREGUNTA DE ENROJECIMIENTO EN LA PARTE ROJA DEL OJO ES SI
                      System.Console.WriteLine("¿Últimamente ha presentado costras en parpados o pestañas después de dormir un largo periodo)");
                        System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                        respuesta = Console.ReadLine();

                        if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                        {
                            System.Console.WriteLine("¿Usas lentes de contacto?");
                            System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                            respuesta = Console.ReadLine();

                            if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                            {
                                System.Console.WriteLine("¿Al usarlos, estos son incomodos?");
                                System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                                respuesta = Console.ReadLine();

                            if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                            {
                                System.Console.WriteLine("¿Te ha salpicado alguna sustancia química o entrado algún objeto extraño en el ojo?");
                                System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                                respuesta = Console.ReadLine();

                                if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                                {
                                    //manda a conjuntivitis por irritantes
                                    ConjuntivitisIrritantes();
                                }
                                else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                                {
                                    System.Console.WriteLine("¿Ha presentado secreción acuosa o espesa en los ojos?");
                                    System.Console.WriteLine("Seleccione una opción\n1) Espesa \n2) Acuosa\n3) Ninguna");
                                    respuesta = Console.ReadLine();
                                    if (respuesta == "1" || respuesta == "Espesa" || respuesta == "espesa" || respuesta == "ESPESA")
                                    {
                                        //manda a conjuntivitis bacteriana
                                        ConjuntivitisBacteriana();
                                    }
                                    else if (respuesta == "2" || respuesta == "Acuosa" || respuesta == "acuosa" || respuesta == "ACUOSA")
                                    {
                                        //manda a conjuntivitis viral
                                        ConjuntivitisViral();
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("¿Presenta irritación en ambos ojos?");
                                        System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                                        respuesta = Console.ReadLine();
                                        if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                                        {
                                            //manda a conjuntivitis alergica
                                            ConjuntivitisAlergica();
                                        }
                                        else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                                        {
                                            DiagnosticoNegativo();
                                        }
                                    }
                                }
                            }
                            else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                            {
                                System.Console.WriteLine("¿Te ha salpicado alguna sustancia química o entrado algún objeto extraño en el ojo?");
                                System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                                respuesta = Console.ReadLine();

                                if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                                {
                                    //manda a conjuntivitis por irritantes
                                    ConjuntivitisIrritantes();
                                }
                                else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                                {
                                    System.Console.WriteLine("¿Ha presentado secreción acuosa o espesa en los ojos?");
                                    System.Console.WriteLine("Seleccione una opción\n1) Espesa \n2) Acuosa\n3) Ninguna");
                                    respuesta = Console.ReadLine();
                                    if (respuesta == "1" || respuesta == "Espesa" || respuesta == "espesa" || respuesta == "ESPESA")
                                    {
                                        //manda a conjuntivitis bacteriana
                                        ConjuntivitisBacteriana();
                                    }
                                    else if (respuesta == "2" || respuesta == "Acuosa" || respuesta == "acuosa" || respuesta == "ACUOSA")
                                    {
                                        //manda a conjuntivitis viral
                                        ConjuntivitisViral();
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("¿Presenta irritación en ambos ojos?");
                                        System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                                        respuesta = Console.ReadLine();
                                        if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                                        {
                                            //manda a conjuntivitis alergica
                                            ConjuntivitisAlergica();
                                        }
                                        else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                                        {
                                            DiagnosticoNegativo();
                                        }
                                    }
                                }
                            }
                        }
                        }
                        else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                        {
                            DiagnosticoNegativo();
                        }

                }
                else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                {
                    System.Console.WriteLine("¿Últimamente ha presentado costras en parpados o pestañas después de dormir un largo periodo)");
                    System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                    respuesta = Console.ReadLine();

                    if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                    {
                            System.Console.WriteLine("¿Usas lentes de contacto?");
                            System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                            respuesta = Console.ReadLine();

                            if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                            {
                                System.Console.WriteLine("¿Al usarlos, estos son incomodos?");
                                System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                                respuesta = Console.ReadLine();

                                if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                                {
                                    System.Console.WriteLine("¿Te ha salpicado alguna sustancia química o entrado algún objeto extraño en el ojo?");
                                    System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                                    respuesta = Console.ReadLine();

                                    if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                                    {
                                        //manda a conjuntivitis por irritantes
                                        ConjuntivitisIrritantes();
                                    }
                                    else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                                    {
                                        System.Console.WriteLine("¿Ha presentado secreción acuosa o espesa en los ojos?");
                                        System.Console.WriteLine("Seleccione una opción\n1) Espesa \n2) Acuosa\n3) Ninguna");
                                        respuesta = Console.ReadLine();
                                        if (respuesta == "1" || respuesta == "Espesa" || respuesta == "espesa" || respuesta == "ESPESA")
                                        {
                                            //manda a conjuntivitis bacteriana
                                            ConjuntivitisBacteriana();
                                        }
                                        else if (respuesta == "2" || respuesta == "Acuosa" || respuesta == "acuosa" || respuesta == "ACUOSA")
                                        {
                                            //manda a conjuntivitis viral
                                            ConjuntivitisViral();
                                        }
                                        else
                                        {
                                            System.Console.WriteLine("¿Presenta irritación en ambos ojos?");
                                            System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                                            respuesta = Console.ReadLine();
                                            if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                                            {
                                                //manda a conjuntivitis alergica
                                                ConjuntivitisAlergica();
                                            }
                                            else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                                            {
                                                DiagnosticoNegativo();
                                            }
                                        }
                                    }
                                }
                                else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                                {
                                    System.Console.WriteLine("¿Te ha salpicado alguna sustancia química o entrado algún objeto extraño en el ojo?");
                                    System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                                    respuesta = Console.ReadLine();

                                    if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                                    {
                                        //manda a conjuntivitis por irritantes
                                        ConjuntivitisIrritantes();
                                    }
                                    else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                                    {
                                        System.Console.WriteLine("¿Ha presentado secreción acuosa o espesa en los ojos?");
                                        System.Console.WriteLine("Seleccione una opción\n1) Espesa \n2) Acuosa\n3) Ninguna");
                                        respuesta = Console.ReadLine();
                                        if (respuesta == "1" || respuesta == "Espesa" || respuesta == "espesa" || respuesta == "ESPESA")
                                        {
                                            //manda a conjuntivitis bacteriana
                                            ConjuntivitisBacteriana();
                                        }
                                        else if (respuesta == "2" || respuesta == "Acuosa" || respuesta == "acuosa" || respuesta == "ACUOSA")
                                        {
                                            //manda a conjuntivitis viral
                                            ConjuntivitisViral();
                                        }
                                        else
                                        {
                                            System.Console.WriteLine("¿Presenta irritación en ambos ojos?");
                                            System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                                            respuesta = Console.ReadLine();
                                            if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                                            {
                                                //manda a conjuntivitis alergica
                                                ConjuntivitisAlergica();
                                            }
                                            else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                                            {
                                                DiagnosticoNegativo();
                                            }
                                        }
                                    }
                                }

                            }
                            else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                            {
                                System.Console.WriteLine("¿Te ha salpicado alguna sustancia química o entrado algún objeto extraño en el ojo?");
                                System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                                respuesta = Console.ReadLine();

                                if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                                {
                                    //manda a conjuntivitis por irritantes
                                    ConjuntivitisIrritantes();
                                }
                                else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                                {
                                    System.Console.WriteLine("¿Ha presentado secreción acuosa o espesa en los ojos?");
                                    System.Console.WriteLine("Seleccione una opción\n1) Espesa \n2) Acuosa\n3) Ninguna");
                                    respuesta = Console.ReadLine();
                                    if (respuesta == "1" || respuesta == "Espesa" || respuesta == "espesa" || respuesta == "ESPESA")
                                    {
                                        //manda a conjuntivitis bacteriana
                                        ConjuntivitisBacteriana();
                                    }
                                    else if (respuesta == "2" || respuesta == "Acuosa" || respuesta == "acuosa" || respuesta == "ACUOSA")
                                    {
                                        //manda a conjuntivitis viral
                                        ConjuntivitisViral();
                                    }
                                    else
                                    {
                                        System.Console.WriteLine("¿Presenta irritación en ambos ojos?");
                                        System.Console.WriteLine("Seleccione una opción\n1) Si \n2) No");
                                        respuesta = Console.ReadLine();
                                        if (respuesta == "1" || respuesta == "si" || respuesta == "SI" || respuesta == "sI")
                                        {
                                            //manda a conjuntivitis alergica
                                            ConjuntivitisAlergica();
                                        }
                                        else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                                        {
                                            DiagnosticoNegativo();
                                        }
                                    }
                                }
                            }
                        
                    }
                    else if (respuesta == "2" || respuesta == "No" || respuesta == "NO" || respuesta == "nO")
                    {
                        DiagnosticoNegativo();
                    }


                }
            }
        }


        public void DiagnosticoNegativo()
        {
            System.Console.WriteLine("***************DIAGNÓSTICO PARA CONJUNTIVITIS***************\n" +
                           "\n" +
                           "Usted no presenta ningún tipo de Conjuntivitis\n" +
                           "\n\n" +
                           "               Consulte a su médico\n\n");
        }

        public void ConjuntivitisAlergica()
        {
            //Conjuntivitis alergica
            System.Console.WriteLine("***************DIAGNÓSTICO PARA CONJUNTIVITIS***************\n" +
                           "\n" +
                           "Usted presenta sintomas de conjuntivitis alergica\n" +
                           "\n\n" +
                           "               Consulte a su médico\n\n");

        }

        public void ConjuntivitisViral()
        {
            //Conjuntivitis viral
            System.Console.WriteLine("***************DIAGNÓSTICO PARA CONJUNTIVITIS***************\n" +
                           "\n" +
                           "Usted presenta sintomas de conjuntivitis viral\n" +
                           "\n\n" +
                           "               Consulte a su médico\n\n");
        }

        public void ConjuntivitisBacteriana()
        {
            //Conjuntivitis bacteriana
            System.Console.WriteLine("***************DIAGNÓSTICO PARA CONJUNTIVITIS***************\n" +
                           "\n" +
                           "Usted presenta sintomas de conjuntivitis bacteriana\n" +
                           "\n\n" +
                           "               Consulte a su médico\n\n");

        }

        public void ConjuntivitisIrritantes()
        {
            //Conjuntivitis irritantes
            System.Console.WriteLine("***************DIAGNÓSTICO PARA CONJUNTIVITIS***************\n" +
                           "\n" +
                           "Usted presenta sintomas de conjuntivitis causada por irritantes\n" +
                           "\n\n" +
                           "               Consulte a su médico\n\n");
        }
    }
}
