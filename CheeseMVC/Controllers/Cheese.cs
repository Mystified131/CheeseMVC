using System.Collections.Generic;

namespace CheeseMVC.Controllers
{
    public class Cheese
    {
        public int Id;
        public string name;
        public string description;

        public Cheese(string name, string description)
        {
            this.name = name;
            this.description = description;
    }
   
    }
}