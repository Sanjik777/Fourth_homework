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
	public class Money
	{
		public int Banknote { get; set; }
		public int AmountOfMoney { get; set; }
		public int PriceOfGood { get; set; }

		public int SumMoney
		{
			get { return Banknote * AmountOfMoney; }
		}

		public Money(int banknote, int amountOfMoney, int priceOfGood)
		{
			Banknote = banknote;
			AmountOfMoney = amountOfMoney;
			PriceOfGood = priceOfGood;
		}
		public void GoodEquation()
		{
			Console.WriteLine($"\nТовар со стоимостью" +
				$" {PriceOfGood} тенге, можно купить {(AmountOfMoney*Banknote)/PriceOfGood} раз");
		}
		public void Print()
		{
			Console.WriteLine($"\nноминал      = {Banknote} тенге\nкол-во купюр = {AmountOfMoney}");
		}
	}
}
