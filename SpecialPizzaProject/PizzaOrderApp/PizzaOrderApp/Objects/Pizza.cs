using System;
using System.Collections.Generic;

namespace PizzaOrderApp.Objects
{
    enum Size
    {
        small = 6,
        medium = 8,
        large = 10
    }

    public class Pizza
    {
        public List<string> Toppings { get; set; }
        public List<string> Crust { get; set; }
        public Size PizzaSize { get; set; }

        /// <summary>
        /// Default Constructor
        /// Defaults include: large size
        /// </summary>
        public Pizza()
        {
            Size = Size.large;
        }


    }

}