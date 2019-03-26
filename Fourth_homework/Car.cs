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
	public partial class Car
	{
		const int DEFAULT_TAX = 10000;
		const int DEFAULT_WEIGHT = 2;
		const int DEFAULT_VELOCITY = 100;

		private int    _velocity;//скорость
		private double _weight;  //вес
		private string _brand;   //марка машины
		private char   _model;   //модель
		private bool   _key;     //пробег

		public static double volumeOfTank = 4.5;    //Объём бака
		public static string typeOfCar = "легковой";//тип машины

		//--конструкторы--
		public Car()
		{
			_velocity = 0;
			_weight = 0;
			_brand = null;
			_model = '\0';
			_key = false;			
		}
		public Car(string brand)
		{
			_brand = brand;
		}
		static Car()
		{
			WriteLine(" - статический конструктор - \n");
		}
		public Car(int velocity, double weight, string brand, char model)
		{
			_velocity = velocity;
			_weight = weight;
			_brand = brand;
			_model = model;
		}

		//--методы--
		public void Init()
		{
			Write("Введите название модели машины: ");
			_brand = ReadLine();

			Write("Введите класс модели машины (от A до Z): ");
			_model = ReadKey().KeyChar;
			//_model = (char)Console.Read();
			ReadLine();

			Write("Введите скорость машины (км/ч): ");
			_velocity = int.Parse(ReadLine());

			Write("Введите вес машины (тонны): ");
			_weight = double.Parse(ReadLine());

			Write("Машина с пробегом? (Да = 1/Нет = 0): ");
			_key = Convert.ToBoolean( Convert.ToInt32(Console.ReadLine()));
		}
		public void SecondInit(int velocity, double weight, string brand, char model)
		{
			_velocity = velocity;
			_weight = weight;
			_brand = brand;
			_model = model;
		}
		public void Print()
		{
			WriteLine($"Марки машины: {_brand}");

			WriteLine($"Класс модели машины: {_model}");

			WriteLine($"Скорость машины: {_velocity} км/ч");

			WriteLine($"Вес машины: {_weight} тонн");

			if (_key == false) { WriteLine("Машина без пробега"); }
			else { WriteLine("Машина с пробегом"); }
		}
		public void TaxOfCar()
		{
			int tax = DEFAULT_TAX; ;
			if (_weight >= DEFAULT_WEIGHT && _velocity >= DEFAULT_VELOCITY)
			{
				tax = DEFAULT_TAX * DEFAULT_WEIGHT;
				WriteLine($"\nНалог на машину {tax} тенге");
			}
			else { WriteLine($"\nНалог на машину {tax} тенге"); }
		}
		//--геттеры--
		public int GetSpeed()
		{
			return _velocity;
		}
		public double GetWeight()
		{
			return _weight;
		}
		public string GetBrand()
		{
			return _brand;
		}
		public char GetModel()
		{
			return _model;
		}
	}
}