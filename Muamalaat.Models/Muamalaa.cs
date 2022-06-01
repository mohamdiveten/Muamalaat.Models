using System;

namespace Muamalaat.Models
{
    public abstract class Muamalaa
    {

        public  int Id { get; set; }

        public string Name { get; set; }

        public DateTime Date { get; set; }

        public int Amount { get; set; }

        public ICurrency Currency { get; set; }
    }


}
