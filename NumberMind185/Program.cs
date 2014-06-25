using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberMind185
{
	public class pair<T1, T2>
	{
		public T1 v1;
		public T2 v2;
	}
	public class NumberMind
	{
		public List<pair<byte[], int>> guesses = new List<pair<byte[],int>>();

		public List<List<byte[]>> possibles = new List<List<byte[]>>();

	}
	class Program
	{
		static void Main(string[] args)
		{
		}
	}
}
