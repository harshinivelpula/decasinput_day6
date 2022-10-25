using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decasinputd6
{
    internal class swap
    {
		public static void main(String[] args)
		{
			AlgorithmUtility utility = new AlgorithmUtility();
			int decimalNumber, r;
			int decToBinary;
			int resultOfSwapNibbles;
			String x = "";

			Scanner scanner = new(System.in);
			Console.WriteLine("enter a number");
			decimalNumber = scanner.nextInt();
			decToBinary = decimalNumber;
			if (decimalNumber > 255)
			{
				Console.WriteLine("enter number between 1 to 150");
			}
			else
			{
				while (decimalNumber > 0)
				{
					r = decimalNumber % 2;
					x = r + "" + x;
					decimalNumber = decimalNumber / 2;
				}

				Console.WriteLine("binary is: " + x);

				resultOfSwapNibbles = utility.SwapNibbles(decToBinary);
				Console.WriteLine("result of swap nibbles of binary number: " + resultOfSwapNibbles);
			}
			scanner.close();
		}
	}

	internal class Scanner
	{
		public Scanner(object value1, in object value2)
		{
		}

		internal void close()
		{
			throw new NotImplementedException();
		}
		internal int nextInt()
		{
			throw new NotImplementedException();
		}
	}

	internal class AlgorithmUtility
	{
		internal int SwapNibbles(int decToBinary)
		{
			throw new NotImplementedException();
		}
	}
}
