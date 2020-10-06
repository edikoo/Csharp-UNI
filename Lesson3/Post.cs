using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
    class Post
    {
        public void SendMessage(User user, Message message)
        {
            Console.WriteLine($"\nTqven gaugzavnet werili {user._name} {user._lastname} - s");
            user.GetMessage(message);
            Console.WriteLine("Werili warmatebit gaigzavna");
        }
    }
}
