using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BamBot
{
    class Definitions
    {
        
    }

    public class Dog
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public Dog(string status, string message)
        {
            Status = status;
            Message = message;
        }
    }

    public class Cat
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public string[] Breeds { get; set; }
        public string[] Categories { get; set; }
        public Cat(string id, string url, string[] breeds, string[] categories)
        {
            Id = id;
            Url = url;
        }
    }

}
