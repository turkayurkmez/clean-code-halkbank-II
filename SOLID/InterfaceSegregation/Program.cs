// See https://aka.ms/new-console-template for more information
using InterfaceSegregation;

Console.WriteLine("Hello, World!");
/*
 * Bir class, bir interface'i implemente ediyorsa; o interface'den gelen tüm fonksiyonları kullanmak, geliştirmek zorundadır.
 * 
 * Eğer kullanmayacağı bir fonksiyon varsa o fonksiyon o interface'de olmamalıdır.
 */
MathComponent mathComponent = new MathComponent();
mathComponent.A = 3;
mathComponent.B = 4;
mathComponent.GetPower(new ComplexMath());

