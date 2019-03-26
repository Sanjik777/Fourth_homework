using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
/*
1.	Разработать один из классов, в соответствии с полученным вариантом.
2.	Реализовать не менее пяти закрытых полей (различных типов),
представляющих основные характеристики рассматриваемого класса.
3.	Создать не менее трех методов управления классом и методы доступа к его закрытым полям. 
4.	Создать метод, в который передаются аргументы по ссылке. 
5.	Создать не менее двух статических полей (различных типов), 
представляющих общие характеристики объектов данного класса. 
6.	Обязательным требованием является реализация нескольких перегруженных конструкторов,
аргументы которых определяются студентом, исходя из специфики реализуемого класса, 
а так же реализация конструктора по умолчанию.
7.	Создать статический конструктор.
8.	Создать массив (не менее 5 элементов) объектов созданного класса.
9.	Создать дополнительный метод для данного класса в другом файле, используя ключевое слово partial. 
Варианты (по выбору):
   1. автомобиль;
   2. мотоцикл;
   3. самолет;
   4. Бытовая техника (на выбор);
   5. Продукты питания (на выбор);
   6. канцелярские товары (на выбор);
   7. мебель (на выбор);
   8. ракета;
   9. Поезд;
   10. зажигалка.
*/
namespace Fourth_homework
{
	class Program
	{
		static void Main(string[] args)
		{
			int amountOfCars = 5;
			
			Car car = new Car();
			car.Init();
			WriteLine("\n--------------Вывод-------------\n");
			car.Print();

			car.TaxOfCar();

			WriteLine("\n--------------Методы доступа-------------\n");
			string brand = car.GetBrand();
			WriteLine(brand);
			double speed = car.GetSpeed();
			WriteLine(speed);

			WriteLine("\n--------------Методы аргументы по ссылке-------------\n");
			car.SecondInit(240, 1.5, "Nissan", 'X');
			car.Print();

			WriteLine("\n--------------Статические поля-------------\n");
			//Car.volumeOfTank = 123;
			//Car.typeOfCar = "asd";
			WriteLine($"Объём бака  = { Car.volumeOfTank}");
			WriteLine($"Тип машины = { Car.typeOfCar}");
			
			WriteLine("\n--------------Массив объектов-------------\n");
			Car[] cars = new Car[amountOfCars];
			for (int i = 0; i < cars.Length; i++)
			{
				cars[i] = new Car();
			}
			foreach (Car auto in cars)
			{
				auto.Init();
				Console.WriteLine();
			}
			WriteLine("\n--------------Вывод массива объектов-------------\n");

			foreach (Car auto in cars)
			{
				auto.Print();
				Console.WriteLine();
			}
			WriteLine("\n--------------partial метод-------------");
			car.OurPartialMethod();
			ReadKey();
		}
	}
	public partial class Car
	{
		public void OurPartialMethod()
		{
			Console.WriteLine("какой-то метод");
		}
	}
}
