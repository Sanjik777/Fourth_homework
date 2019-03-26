using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 Создать класс Money, разработав следующие элементы класса:
Поля:
- Номинал купюры
- Количество купюр
Конструктор:
- Позволяющий создать экземпляр класса с заданными значениям полей
Методы:
- Вывести номинал и количество купюр
- Определить, хватит ли денежных средств на покупку товара на сумму N тенге
	- Определить, сколько штук товара стоимости n тенге можно купить на имеющиеся денежные средства
Свойства:
	- Позволяющее получить-установить значение полей (доступное для чтения и записи)
	- Позволяющее расчитать сумму денег (доступное только для чтения)
*/
namespace Practical_work
{
	class Program
	{
		static void Main(string[] args)
		{
			Money moneys = new Money(500, 4, 1000);
			moneys.Print();
			moneys.GoodEquation();

			Console.WriteLine("\n----------Свойства---------\n");

			moneys.Banknote = 2000;
			int getBanknote = moneys.Banknote;
			Console.WriteLine($"номинал = {getBanknote}");


			Console.WriteLine($"кол-во купюр = {moneys.AmountOfMoney}");

			int getSum = moneys.SumMoney;
			Console.WriteLine($"Сумма денег = {getSum}");

			Console.ReadKey();
		}
	}
}
