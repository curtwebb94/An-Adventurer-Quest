using System;

namespace Quest
{
    // Hat class representing a hat worn by the adventurer
    public class Hat
    {
        // Mutable property to indicate the shininess level of the hat
        public int ShininessLevel { get; set; }

        // Computed property to return a text description of the hat's shininess
        public string ShininessDescription
        {
            get
            {
                if (ShininessLevel < 2)
                {
                    return "dull";
                }
                else if (ShininessLevel >= 2 && ShininessLevel <= 5)
                {
                    return "noticeable";
                }
                else if (ShininessLevel >= 6 && ShininessLevel <= 9)
                {
                    return "bright";
                }
                else
                {
                    return "blinding";
                }
            }
        }
    }
}
