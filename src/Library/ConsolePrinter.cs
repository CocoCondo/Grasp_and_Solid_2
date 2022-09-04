using System;

namespace Full_GRASP_And_SOLID.Library
{
    /*Crear clases con reponsabilidades únicas responde al principio SRP. Esta clase se encarga unicamente de imprimir como yo quiera*/
    public class ConsolePrinter //La clase responsable por imprimir las recetas
    {
        public static void PrintTicket(Recipe receta)
        {
            Console.WriteLine(receta.PrintRecipe()); //Imprimo como yo quiero lo que el método PrintRecipe del objeto me devuelve
        }
    }
}