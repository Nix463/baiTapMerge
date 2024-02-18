using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1
{
    internal class Product
    {

   
       
       public int Id {  get; set; }
        
        public string Name { get; set; }
        
        public string Condition { get; set; }
        
        public string Descibe { get; set; }
        
        public string PhoneNumber { get; set; }
        
        public DateTime DateAdd { get; set; }
       
        public string Email { get; set; }
       
        public Product(int id, string name, string condition, string descibe, DateTime date_add, string email, string phone_number)
        {
            Id = id;
            Name = name;
            Condition = condition;
            Descibe = descibe;
            DateAdd = date_add;
            Email = email;
            PhoneNumber = phone_number;
        }

    }
}
