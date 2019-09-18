using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Sides
{
    class Triceritots
    {
        public class Triceritot : Side
        {
            private Size size;
            public override Size Size
            {
                set
                {
                    size = value;
                    switch (size)
                    {
                        case Size.small:
                            price = 0.99;
                            Calories = 352;
                            break;
                        case Size.Medium:
                            price = 1.45;
                            Calories = 410;
                            break;
                        case Size.large:
                            price = 1.95;
                            Calories = 590;
                            break;

                    }
                }
                get { return Size; }
            }

        }
    }
}
