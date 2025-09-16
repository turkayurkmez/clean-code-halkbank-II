// See https://aka.ms/new-console-template for more information
using LiskovSubstution;

Console.WriteLine("Hello, World!");

Geometry geometry = new Geometry();
var rect = geometry.GetRectangle(5);




Console.WriteLine(rect.GetArea());
 

/*
 * Bir sınıfın bir diğerine miras verebilmesi için bu iki sınıf birbiriyle yer değiştirilebilir olmalı.
 * Miras ilişkili iki nesnenin yer değiştirebilmesi için, miras alan (Square) miras verenin (Rectangle) özelliklerine müdahale etmemeli. Aynen korumalı!
 * 
 */

//public class Asci
//{
//    public void Pisir(Yemek yemek)
//    {
//        yemek.Pisir();
//    }

//    public Kofte SonYemek()
//    {
//        return new Yemek();
//    }
//}

//public class Yemek
//{
//    public void Pisir()
//    {

//    }

//}

//public class Kofte: Yemek
//{

//}