using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    /*
     * Standart -> %5
     * Silver -> %10
     * Gold -> %15
     */


    //public enum CardType
    //{
    //    Standard,
    //    Silver,
    //    Gold,
    //    Premium
    //}

    public abstract class CardType
    {
        public abstract decimal DiscountPrice(decimal amount);

       
    }

    public class Standard : CardType
    {
        public override decimal DiscountPrice(decimal amount)
        {
            return amount * .95m;
        }
    }

    public class Silver : CardType
    {
        public override decimal DiscountPrice(decimal amount)
        {
            return amount * .9m;
        }
    }

    public class Gold : CardType
    {
        public override decimal DiscountPrice(decimal amount)
        {
            return amount * .85m;
        }
    }

    public class Premium : CardType
    {
        public override decimal DiscountPrice(decimal amount)
        {
            return amount * .80m;
        }
    }

    public class Customer
    {
        public string Name { get; set; }
        public CardType Card { get; set; }
    }

    public class OrderManager
    {
        public Customer Customer { get; set; }

        public decimal GetTotalPrice(decimal amount)
        {
            return Customer.Card.DiscountPrice(amount);
        }
    }
}
