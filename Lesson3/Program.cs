using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dictionary<string, string>> _userList = new List<Dictionary<string, string>>();

            _userList.Add(new Dictionary<string, string>(){
                                        {"name", "Giorgi"},
                                        {"lastname", "Vepkhvadze"},
                                        {"address", "Gori"} });
            _userList.Add(new Dictionary<string, string>(){
                                        {"name", "Edvard"},
                                        {"lastname", "Gogidze"},
                                        {"address", "Gori"} });
            _userList.Add(new Dictionary<string, string>(){
                                        {"name", "Avto"},
                                        {"lastname", "Maisuradze"},
                                        {"address", "Tbilisi"} });

            /*  ავტომატური გენერირება
            for (int i = 0; i < 3; i++)
            {
                _userList.Add(new Dictionary<string, string>(){
                                        {"name", Guid.NewGuid().ToString("N")},
                                        {"lastname", Guid.NewGuid().ToString("N")},
                                        {"address", Guid.NewGuid().ToString("N")} });
            };
            */

            int c = 1;
            Console.WriteLine("Gtxovt airchiot momxmarebeli: ");
            foreach (Dictionary<string, string> users in _userList)
            {
                Console.WriteLine($"{c}) {users["name"]}");
                c++;
            }

            int getInput = Convert.ToInt32(Console.ReadLine()) - 1;
 
            User selectedUser = new User(_userList[getInput]["name"], _userList[getInput]["lastname"], _userList[getInput]["address"]);

            Console.WriteLine($"Tqven airchiet {selectedUser._name}");

            Console.WriteLine("Enter The message Title: ");
            string messageTitle = Console.ReadLine();
            Console.WriteLine("Enter The message Text: ");
            string messageText = Console.ReadLine();

            Message message = new Message(messageTitle, messageText);

            Post post = new Post();
            post.SendMessage(selectedUser, message);
     
        }
    }
}
