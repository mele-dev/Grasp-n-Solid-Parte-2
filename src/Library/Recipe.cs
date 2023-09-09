//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

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

        /* aca creo el metodo GetStepsArray() el cual me va a permitir obtener los
         * datos del ArrayList steps sin necesidad de retornarlo en si, esto lo hice
         * asi para poder mantener y respetar los principios de SRP, porque si hiciera
         * un GetSteps() que retornara directamente el ArrayList, seria lo mismo que
         * hacerlo public en vez de private, lo cual no es lo que queremos ya que steps
         * en realidad no deberia ser algo que podamos acceder desde fuera de la clase
         * para respetar lso principios */
        public Step[] GetStepsArray()
        {
            /* usamos steps y le decimos .ToArray(typeof(Step) lo cual indica que vamos
             * a convertir a tipo de dato Array a todo el contenido de steps que sea de
             * tipo Step y lo vamos a almacenar en el Step[] que estamos retornando */
            return (Step[])steps.ToArray(typeof(Step));
        }
    }
}