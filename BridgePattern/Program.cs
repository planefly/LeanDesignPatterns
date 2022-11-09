﻿namespace BridgePattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Display d1 = new Display(new StringDisplayImpl("Hello, China."));
            CountDisplay d2 = new CountDisplay(new StringDisplayImpl("Hello, World."));
            CountDisplay d3 = new CountDisplay(new StringDisplayImpl("Hello, Universe."));

            d1.Show();
            d2.Show();
            d3.Show();

            d3.MultiDisplay(5);
        }
    }
}
