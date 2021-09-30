using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	public class Class1
	{
		/// <summary>
		/// 
		/// </summary>
		/// <param name="k"></param>
		/// <param name="str"></param>
		/// <param name="sum"></param>
		/// <param name="kol"></param>
		public static void Start(int k, out string str, out int sum, out int kol)
		{
			str = ""; // строка с генерирированнными числами
			sum = 0; //Сумма 
			kol = 0; //Количество
			int zn = 0; // число
			Random rnd = new Random();

			while (sum < k)
			{
				//диапазон от 2 до 10 
				zn = rnd.Next(2, 10);
				kol++; //увеличиваем счетчик
				sum = sum + zn; //вычисление суммы
				str += Convert.ToString(zn) + " , "; //заполнение строки с геннерированными числами
			}
		}
	}
}
