using System;
using System.IO;

namespace Checkmates
{
    class Program
    {
        static void Main()
        {
            Shape per = new(1, 8, 8);
            Console.WriteLine(per.Perimeter);
            /*int[] parameters;
            int i = 0;

            //example of the INPUT file
            StreamWriter file = new StreamWriter("INPUT.txt");
            file.WriteLine("3");
            file.WriteLine("1 1");
            file.WriteLine("1 2");
            file.WriteLine("2 1");
            file.Close();

            StreamReader reader = new StreamReader("INPUT.txt");
            var line = reader.ReadLine();
            parameters = new int[Convert.ToInt32(line.ToString()) * 2];
            line = reader.ReadLine();
            while (line != null)
            {
                string text = line.ToString();

                parameters[i] = (int)(text[0] - '0');
                i++;
                parameters[i] = (int)(text[2] - '0');
                i++;

                line = reader.ReadLine();
            }
            reader.Close();

            Shape per = new(parameters.Length/2, parameters);

            StreamWriter writer = new StreamWriter("OUTPUT.txt");
            writer.WriteLine(per.Perimeter.ToString());
            writer.Close();*/
        }
    }
}