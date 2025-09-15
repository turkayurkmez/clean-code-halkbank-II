
using Functions;

Console.WriteLine("Hello, World!");


/*
 * 1. Birim zamanda sadece 1 iş yapar.
 * 2. Parametresi ne kadar az ise o kadar temizdir.
 * 3. Gövde kodu mümkün olduğunca az satırdan oluşmalı.
 */


string getRandomWordFrom(List<string> words)
{
    return "kelime";
}

string convertToPuzzle(string word, string? letter=null)
{
    return "------";
}

void showPuzzle(string puzzle)
{

}

string getLetterFromUser()
{
    return "e";
}

bool isWordIncludeLetter(string word, string letter)
{
    return true;
}

/*
 * Adam asmaca yazmak istiyorsunuz.
 *   1. Rastgele kelime listesi içinden bir kelime seç.
 *   2. Bu kelimenin karakterlerini "-" işaretine çevir
 *   3. Ekranda göster.
 *   4. Kullanıcıdan harf iste
 *   5. Kelimede harf olup olmadığına bak
 *       - varsa o pozisyondaki harfi aç 
 *       - yoksa hakkı bir azalt
 *   6. Kelimeyi tahmin etmesini iste.

 */


string selectedWord = getRandomWordFrom(new List<string>());
string puzzle = convertToPuzzle(selectedWord);
showPuzzle(puzzle);
string letter = getLetterFromUser();
if(isWordIncludeLetter(puzzle, letter))
{
    convertToPuzzle(selectedWord, letter);    
}

string path = "C:\\no.xlsx";
ReportGenerator reportGenerator = new ReportGenerator(path);
