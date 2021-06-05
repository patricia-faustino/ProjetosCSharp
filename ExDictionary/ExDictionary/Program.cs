using System;
using System.Collections.Generic;

namespace ExDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();
            cookies["user"] = "Maria";
            cookies["email"] = "maria@email.com";
            cookies["phone"] = "7199565758";
            cookies["phone"] = "7125264867";

            Console.WriteLine(cookies["phone"]);
            Console.WriteLine(cookies["email"]);

            cookies.Remove("email");

            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key");
            }

            Console.WriteLine("Size: "+cookies.Count);

            Console.WriteLine("ALL COOKIES: ");

            //KeyValuePair<string,string> pode ser substituido por var
            foreach (KeyValuePair<string,string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
            
        }
    }
}
