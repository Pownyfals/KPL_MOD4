using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302204081
{
	public class SimpleDataBase<T> where T : struct
	{
		private LinkedList<T> storedData;
		private LinkedList<DateTime> inputDates;

		public SimpleDataBase()
		{
			storedData = new LinkedList<T>();
			inputDates = new LinkedList<DateTime>();
		}

		public void addNewData(T data)
		{
			this.storedData.AddLast(data);
			DateTime time = DateTime.UtcNow;
			inputDates.AddLast(time);
			
		}
		public void printAllData()
		{
			int i = 1;
			DateTime time = DateTime.UtcNow;
			DateTime[] myArr = new DateTime[storedData.Count];
			foreach (T data in storedData)
			{
				Console.WriteLine("Data "+i+" berisi "+data+" yang disimpan pada waktu UTC"+time);
				i++;
			}
		}
	}
}
