using System;
using System.Collections.Generic;
using System.Linq;

namespace p04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();

            var book = new Dictionary<string, Dictionary<string, int>>();
            List<string> counter = new List<string>();

            while (input[0] != "exam finished")
            {
                string name = input[0];

                if (input[1] == "banned")
                {
                    if (book.ContainsKey(name))
                    {
                        book.Remove(name);
                    }
                }

                else if (book.ContainsKey(name) == false)
                {
                    string language = input[1];
                    int points = int.Parse(input[2]);

                    book.Add(name, new Dictionary<string, int>());
                    if (book[name].ContainsKey(language) == false)
                    {
                        counter.Add(language);
                        book[name].Add(language, points);
                    }
                    else
                    {
                        counter.Add(language);
                        book[name].Add(language, points);
                    }
                }
                else if (book.ContainsKey(name))
                {
                    string language = input[1];
                    int points = int.Parse(input[2]);


                    if (book[name].ContainsKey(language) == false)
                    {
                        book[name].Add(language, points);
                        counter.Add(language);
                    }
                    else
                    {
                        counter.Add(language);
                        book[name].Remove(language);
                        book[name].Add(language, points);
                    }

                }


                input = Console.ReadLine().Split("-", StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            Console.WriteLine("Results:");
            foreach (var user in book.OrderByDescending(x => x.Value.Values.Sum()).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{user.Key} | {user.Value.Values.Sum()}");
            }
            Console.WriteLine("Submissions:");

            int counters = 1;
            Dictionary<string, int> lastList = new Dictionary<string, int>();

            counter.Sort();
            
            for (int i = 1; i < counter.Count; i++)
            {
                if (counter[i] == counter[i - 1])
                {
                    if (lastList.ContainsKey(counter[i]) == false)
                    {
                        counters++;
                        lastList.Add(counter[i], counters);
                    }
                    else
                    {
                        counters++;
                        lastList.Remove(counter[i]);
                        lastList.Add(counter[i], counters);
                    }
                }
                else
                {
                    
                    if (lastList.ContainsKey(counter[i]) == false)
                    {
                        counters = 0;
                        counters++;
                        lastList.Add(counter[i], counters);
                    }
                    else
                    {
                        counters= 0;
                        counters++;
                        lastList.Remove(counter[i]);
                        lastList.Add(counter[i], counters);
                    }
                }
            }

            foreach (var item in lastList.OrderByDescending(x=>x.Value))
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
            
        }
    }
}
