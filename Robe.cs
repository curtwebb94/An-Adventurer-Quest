using System;
using System.Collections.Generic;

namespace Quest
{
    // Robe class representing a robe worn by the adventurer
    public class Robe
    {
        // Mutable property to hold the colors of the robe
        public List<string> Colors { get; set; }

        // Mutable property to describe the length of the robe in inches
        public int Length { get; set; }

        // Constructor to initialize the Colors and Length properties
        public Robe(List<string> colors, int length)
        {
            Colors = colors;
            Length = length;
        }

        // Method to return a description of the robe
        public string GetDescription()
        {
            string colors = string.Join(", ", Colors);
            return $"The robe is {Length} inches long and has the following colors: {colors}.";
        }
    }
}
