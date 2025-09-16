namespace OpenClosed
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Bir nesne/sınıf ........gelişime....... AÇIK ........değişime....... KAPALI  
             */

            Customer customer = new Customer() { Card = new Premium(), Name = "Süleyman" };

            OrderManager orderManager = new OrderManager { Customer = customer };

            var price =  orderManager.GetTotalPrice(1000);
            Console.WriteLine(price);
        }
    }
}
