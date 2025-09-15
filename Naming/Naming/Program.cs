namespace Naming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = 8; //counter değişkeni...
            int i = 0;
            int ii = -1;

            var d = 0; //Müşterinin db'ye kayıt olduğu günden bugüne geçen gün sayısı.


            //1. anlamlı isimler kullanın!
            int daysSinceCustomerCreatedOnDatabase = 365;
            //int musterininKaydindanBuYanaGecenGunSayisi = 255;

            // bool banuAlkan = false;

            //2. kafa karışıklığına sebep olabilecek kısaltma kullanmayın
            var hp = 25;
            //horse power
            //healthPoint
            //hp bilgsayar sayısı.
            //hit points


            //3. Değişken isimleri okunduğunda tipleri tahmin edilebilsin.
            bool isApproved = false;
            bool wasSend = true;
            bool hasAnItem = false;


            var countOfStudents = 20;
            var averageAgeOfStudents = 40;



            //4. Bazı durumlarda, kararsız kalınması çok normal. Bu durumda en azından ekip içi bir standart oluşturulmalı.

            string name = "Ad";
            var products = new List<string>();
            var productList = new List<string>();

            foreach (var product in productList)
            {
                
            }


            List<int[]> cellsOnABoard = new List<int[]>();

            List<int[]> getFlaggedCells()
            {
                var flaggedCells = new List<int[]>();
                foreach (var cell in cellsOnABoard)
                {
                    if (cell[0] == CellInfo.Flagged)
                    {
                        flaggedCells.Add(cell);
                    }
                }

                return flaggedCells;
            }














        }
    }

    public class CellInfo
    {
        public const int Empty = 0;
        public const int Tip = 1;
        public const int Exploded = 2;
        public const int Flagged = 4;
    }
}
