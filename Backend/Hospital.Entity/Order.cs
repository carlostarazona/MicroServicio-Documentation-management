

using System;

namespace Hospital.Entity
{
    public class Order
    {
        public int Id{get;set;}
        public int Priority {get;set;}
        public string Datee {get;set;} 
        public int  Idmedicalequipment{get;set;}
        public string Nombremedicalequipment{get;set;}
        public string  Description{get;set;}

        
    }
}