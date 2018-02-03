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
            String input = File.ReadAllText(@"C:\Users\User\Desktop\text.txt.txt.txt");
            String[] lines = input.Split('\n');
            List<int> pos = new List<int> { };
           
            
            for (int i = 0; i < lines.Length; i++)
            {
                pos.Clear();
                int meh = 0;
                bool lp = false;
                bool rp = false;
                bool lb = false;
                bool rb = false;
                bool lc = false;
                bool rc = false;

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


                if (lb == true && rb == false)
                {

                    for (int j = 0; j < line.Length; j++)
                    {
                        if (line.IndexOf(")") < j && line.IndexOf("}") + 1 > j)
                        {
                            if (("+-/*}".Contains(line.Substring(j, 1))))
                            {
                                pos.Add(j + 1);
                                

                            }

                        }
                    }
                }

                if (lp == true && rp == false)
                {

                    for (int j = 0; j < line.Length; j++)
                    {

                        if (line.IndexOf("(") < j && line.IndexOf("]") + 1 > j)
                        {
                            if ("+-/*]".Contains(line.Substring(j, 1)))
                            {
                                meh++;
                            }

                            if (("+-/*]".Contains(line.Substring(j, 1))) && meh > 1)
                            {

                                pos.Add(j + 1);
                                
                            }

                        }
                    }
                }

                if (lc == true && rc == false)
                {
                    for (int j = 0; j < line.Length; j++)
                    {
                        if (line.IndexOf("]") < j)
                        {
                            if (("+-/*}".Contains(line.Substring(j, 1))))
                            {
                                pos.Add(j + 1);
                                
                            }

                        }
                    }

                    pos.Add(line.Length);

                }

                if (lp == false && rp == true)
                {
                    for (int j = line.Length; j >= 0; j--)
                    {
                        if (j >= line.IndexOf("[") && j < line.IndexOf(")") )
                        {
                            

                            if (("+-/*[".Contains(line.Substring(j -1, 1))) && meh > 0)
                            {
                                pos.Add(j + 1);
                              
                            }

                            if ("+-/*[".Contains(line.Substring(j - 1, 1)))
                            {
                                meh++;
                            }


                        }


                    }

             
                }

                if (lb == false && rb == true)
                {
                    for (int j = line.Length - 1; j >= 0; j--)
                    {
                        if (line.IndexOf("(")+1 > j && j> line.IndexOf("{") )
                        {
                            if ("+-/*{".Contains(line.Substring(j, 1)))
                            {
                                meh++;
                            }



                            if ( j !=0 && ("+-/*{".Contains(line.Substring(j-1 , 1))) && meh > 0)
                            {
                                pos.Add(j + 1);
                            }

                           

                        }
                        if((line.IndexOf("]") > j && line.IndexOf(")") < j))
                        {
                            if ("+-/*(".Contains(line.Substring(j, 1)))
                            {
                                meh++;
                            }



                            if (j != 0 && ("+-/*(".Contains(line.Substring(j - 1, 1))) && meh > 0)
                            {
                                pos.Add(j + 1);
                            }
                        }

                    }
                }

                if (lc == false && rc == true)
                {
                    for (int j = line.Length; j >= 0; j--)
                    {
                        if (j < line.IndexOf("[") + 1)
                        {
                            if ((j != 0 && "+-/*[".Contains(line.Substring(j - 1 , 1))) )
                            {
                                pos.Add(j + 1);
                            }

                            
                        }
                    }
                    pos.Add(1);
                }

                    pos.Sort();

                for (int j = 0; j < pos.Count  ; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(pos[j]);
                    }
                    else
                    {
                        Console.Write(", " +pos[j] );
                    }
                }
                Console.WriteLine();

                
                

           }

        }
    }
}
