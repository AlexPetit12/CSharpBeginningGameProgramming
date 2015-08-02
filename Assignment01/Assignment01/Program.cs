using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assignment01
{
    class Program
    {
        static void Main(string[] args)
        {
            // print welcome message
            Console.WriteLine("Welcome!");
            Console.WriteLine();

            // gravity constant
            const float g = 9.8f;

            // get initial angle and initial speed values from user
            Console.WriteLine("Enter initial angle value: ");
            float initialAngle = float.Parse(Console.ReadLine()) * (float)Math.PI / 180; // convert from degrees to radiant

            Console.WriteLine("Enter initial speed value: ");
            float initialSpeed = float.Parse(Console.ReadLine());

            // calculate vox and voy
            float vox = initialSpeed * (float)Math.Cos(initialAngle);
            float voy = initialSpeed * (float)Math.Sin(initialAngle);

            // calculate t, h and dx
            float t = voy / g;
            float h = voy * voy / (2 * g);
            float dx = vox * 2 * t;

            // print results
            Console.WriteLine("Maxium shell height: " + h);
            Console.WriteLine("Horizontal distance: " + dx);
        }
    }
}
