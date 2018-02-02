using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Acsl
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = File.ReadAllText(@"C:\Users\eahscs\Desktop\text.txt.txt");
            String[] lines = input.Split('\n');
            int[] pos;
            bool lp = false, rp = false, lb = false, rb = false, lc = false, rc = false;
            for(int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Replace(" ", "");
                if (lines[i].Contains("("))
                {
                    lp = true;
                }
                if (lines[i].Contains(")"))
                {
                    rp = true;
                }
                if (lines[i].Contains("["))
                {
                    lb = true;
                }
                if (lines[i].Contains("]"))
                {
                    rb = true;
                }
                if (lines[i].Contains("{"))
                {
                    lc = true;
                }
                if (lines[i].Contains("}"))
                {
                    rc = true;
                }


            

                for(int j = 0; j < pos.Length - 1; j++)
                {
                    Console.Write(pos[i] + ", ");
                
                }
                Console.WriteLine(pos[pos.Length]);
               
            }
            

        }
    }
}
