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
            List<int> pos = new List<int> { };
            bool lp = false, rp = false, lb = false, rb = false, lc = false, rc = false;
            for(int i = 0; i < lines.Length; i++)
            {
                lines[i] = lines[i].Replace(" ", "");
                String line = lines[i];
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


                if(lb = true && rb == false)
                {
                    
                    for(int j = 0; j < line.Length; j++)
                    {
                        if(line.IndexOf(")") < j)
                        {
                            if (("+-/*}".Contains(line.Substring(j, 1))))
                            {
                                pos.Add(j + 1);
                            }

                        }
                    }
                }

                if(lp == false && rp == true)
                {

                }
            

                for(int j = 0; j < pos.Count - 1; j++)
                {
                    Console.Write(pos[j] + ", ");
                
                }
                Console.WriteLine(pos[pos.Count-1]);
               
            }
            

        }
    }
}
