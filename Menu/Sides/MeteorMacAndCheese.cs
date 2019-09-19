﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    class MeteorMacAndCheese
    {
        public class MeteorMacAndCheeses : Side
        {

            private Size size;
            public override Size Size
            {
                set
                {
                    size = value;
                    switch (size)
                    {
                        case Size.Small:
                            Price = 0.99;
                            Calories = 420;
                            break;
                        case Size.Medium:
                            Price = 1.45;
                            Calories = 490;
                            break;
                        case Size.Large:
                            Price = 1.95;
                            Calories = 520;
                            break;

                    }
                }
                get { return Size; }
            }
            public MeteorMacAndCheeses()
            {
                Price = this.Price;
                Calories = this.Calories;
                Ingredients.Add("Macaroni Noodles");

                Ingredients.Add("Cheese Product");
                Ingredients.Add("Pork Sausage");

            }
        }
    }
}
