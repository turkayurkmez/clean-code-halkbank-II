using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public class ReportGenerator
    {
        private string excelFilePath;
        public ReportGenerator(string excelFilePath)
        {
            bool isValidFile = checkExcelFile(excelFilePath);

            if (!isValidFile)
            {

                throw new Exception("Dosya pronblemi söz konusu");

            }


            excelFilePath = excelFilePath.Trim();





        }

        private bool checkExcelFile(string excelFilePath)
        {
            ArgumentNullException.ThrowIfNullOrEmpty(excelFilePath);

            bool isValidFile = isFileExists(excelFilePath) && isExcelAvailable(excelFilePath);
            return isValidFile;
        }

        bool isFileExists(string filePath)
        {

            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"{filePath} adresinde dosya yok!");
            }

            return File.Exists(filePath);

        }


        //bool isEven(int number)
        //{
        //    return number % 2 == 0;
        //}

        bool isExcelAvailable(string excelFilePath)
        {

            //karmaşık excel denetimi var...


            return true;

        }
    }
}
