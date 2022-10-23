using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exec_RemoveCollectionItems
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> collection = new List<int>();
			collection.Add(10);
			collection.Add(20);
			collection.Add(30);
			collection.Clear();
			collection.Add(40);
			collection.Add(50);
			collection.Add(60);
			collection.Add(70);

			Console.WriteLine("原來的List:");

			foreach (var i in collection)
			{
				Console.WriteLine(i);
			}

			Console.WriteLine("移除之後:");

			collection.Remove(50);
			collection.Remove(60);			

			foreach (var i in collection)
			{
				Console.WriteLine(i);
			}

		}
	}
}
