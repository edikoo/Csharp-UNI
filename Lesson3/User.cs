using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson3
{
    class User
    {
        public string _id, _name, _lastname, _address;

        public User(string name, string lastname, string address)
        {
            _id = Guid.NewGuid().ToString("N");
            _name = name;
            _lastname = lastname;
            _address = address;
        }

        public void GetMessage(Message message)
        {
            Console.WriteLine($"Title: {message._title}");
            Console.WriteLine($"Text: {message._text}");
        }

    }
}
