using System;
using System.Collections.Generic;
using System.Linq;

namespace p02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lessons = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<string> modify = new List<string>(lessons);
            List<string> newmod = new List<string>(modify);

            string input = Console.ReadLine();
            string info = "";
            string added = "";

            while (input != "course start")
            {
                string[] tockens = input.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string commands = tockens[0];

                if (commands == "Add")
                {
                    string titel = tockens[1];

                    if (modify.Contains(titel) == false)
                    {
                        modify.Add(titel);
                    }

                }
                else if (commands == "Insert")
                {
                    string titel = tockens[1];
                    int index = int.Parse(tockens[2]);

                    if (modify.Contains(titel) == false)
                    {
                        int curr = -1;

                        List<string> removed = new List<string>(modify);
                        modify = new List<string>();
                        for (int i = 0; i < removed.Count; i++)
                        {
                            curr++;
                            if (i == index && curr == i)
                            {
                                modify.Add(titel);

                                i--;
                            }
                            else
                            {
                                modify.Add(removed[i]);
                            }
                        }
                    }

                }
                else if (commands == "Remove")
                {
                    string titel = tockens[1];

                    if (modify.Contains(titel))
                    {
                        modify.Remove(titel);
                    }
                }
                else if (commands == "Swap")
                {
                    string titel = tockens[1];
                    string titel2 = tockens[2];
                    int curr = -1;
                    int index1 = 0;
                    int index2 = 0;




                    List<string> swapsed = new List<string>(modify);

                    if (modify.Contains(titel) && modify.Contains(titel2) && info == titel || info == titel2)
                    {
                        if (info == titel)
                        {
                            for (int i = 0; i < modify.Count; i++)
                            {
                                curr++;

                                if (modify[i] == titel)
                                {
                                    index1 = curr;
                                }
                                if (modify[i] == titel2)
                                {
                                    index2 = curr;
                                }
                            }
                            modify = new List<string>();
                            int current = -1;

                            for (int i = 0; i < swapsed.Count; i++)
                            {
                                current++;
                                if (swapsed[i] == swapsed[index1])
                                {
                                    modify.Add(titel2);

                                }
                                else if (swapsed[i] == swapsed[index2])
                                {
                                    modify.Add(titel);
                                    modify.Add(added);

                                }
                                else
                                {
                                    modify.Add(swapsed[i]);

                                }
                            }

                        }
                        else
                        {
                            int currente = 0;
                            for (int i = 0; i < modify.Count; i++)
                            {
                                curr++;

                                if (modify[i] == titel)
                                {
                                    index1 = curr;
                                }
                                if (modify[i] == titel2)
                                {
                                    index2 = curr;
                                }
                            }
                            modify = new List<string>();
                            int current = -1;

                            for (int i = 0; i < swapsed.Count; i++)
                            {
                                current++;
                                if (swapsed[i] == swapsed[index1])
                                {
                                    modify.Add(titel2);
                                    modify.Add(added);
                                }
                                else if (swapsed[i] == swapsed[index2])
                                {
                                    modify.Add(titel);

                                }
                                else
                                {
                                    modify.Add(swapsed[i]);

                                }
                            }

                        }
                        
                    }
                    else if (modify.Contains(titel) && modify.Contains(titel2))
                    {
                        for (int i = 0; i < modify.Count; i++)
                        {
                            curr++;

                            if (modify[i] == titel)
                            {
                                index1 = curr;
                            }
                            if (modify[i] == titel2)
                            {
                                index2 = curr;
                            }
                        }
                        modify = new List<string>();
                        int current = -1;

                        for (int i = 0; i < swapsed.Count; i++)
                        {
                            current++;
                            if (swapsed[i] == swapsed[index1])
                            {
                                modify.Add(titel2);

                            }
                            else if (swapsed[i] == swapsed[index2])
                            {
                                modify.Add(titel);
                            }
                            else
                            {
                                modify.Add(swapsed[i]);
                            }
                        }
                    }

                }
                else if (commands == "Exercise")
                {
                    string titel = tockens[1];



                    if (modify.Contains(titel) == false)
                    {
                        added = $"{commands}-{titel}";
                        modify.Add(titel);
                        modify.Add(added);
                        info = titel;
                    }

                }

                input = Console.ReadLine();
            }

            
            int count = 0;
            foreach (var lesson in modify)
            {
                count++;
                Console.Write(count + ".");
                Console.WriteLine(string.Join("", lesson));
            }
        }


    }
}
