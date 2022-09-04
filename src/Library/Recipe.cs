//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;
using System.Text;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();
        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public string PrintRecipe()
        {
            StringBuilder TicketReceta = new StringBuilder($"-------------\nReceta de {this.FinalProduct.Description}:\n"); //Hago un StringBuilder para ponder acoplar las items con un bucle
            //Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                TicketReceta.Append($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}\n"); //Voy agregando los pasos en un bucle
                //Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    //$"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            return TicketReceta.ToString(); //El método PrintRecipe devuelve un string que va a ser usado a posteriori por la clase responsable de imprimir
        }
    }
}