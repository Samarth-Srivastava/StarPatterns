//driver code
using System;
using System.IO;

namespace StarPatterns{
	public class Program{
		public static void Main(string[] args){
			Driver d = new Driver();

			d.Options();
		}
	}

	public class Driver{
		Solution s = new Solution();

		public void Options(){
			System.Console.WriteLine("Rectangle Pattern: Press 1");
			System.Console.WriteLine("Hollowed Rectangle Pattern: Press 2");
			System.Console.WriteLine("Square Pattern: Press 3");
			System.Console.WriteLine("Hollowed Square Pattern: Press 4");
			System.Console.WriteLine("Triangle Pattern: Press 5");
			System.Console.WriteLine("Hollowed Triangle Pattern: Press 6");
			System.Console.WriteLine("Diamond Pattern: Press 7");
			System.Console.WriteLine("Hollowed Diamond Pattern: Press 8");


			string? input = Console.ReadLine();
			if(!string.IsNullOrEmpty(input)){
				switch (input)
				{
					case "1":
						CallRectanglePattern();
						break;
					case "2":
						CallHollowedRectanglePattern();
						break;
					case "3":
						CallSquarePattern();
						break;
					case "4":
						CallHollowedSquarePattern();
						break;
					case "5":
						CallTrianglePattern();
						break;
					case "6":
						CallHollowedTrianglePattern();
						break;
					case "7":
						CallDiamondPattern();
						break;
					case "8":
						CallHollowedDiamondPattern();
						break;
					default:
						Console.Clear();
						break;
				}
			}
		}

		void CallRectanglePattern(){
			Console.Clear();
			System.Console.WriteLine("Enter length");
			int l = Convert.ToInt32(Console.ReadLine());

			System.Console.WriteLine("Enter width");
			int w = Convert.ToInt32(Console.ReadLine());

			Console.Clear();
			s.PrintRectangle(l, w);
		}

		void CallHollowedRectanglePattern(){
			Console.Clear();
			System.Console.WriteLine("Enter length");
			int l = Convert.ToInt32(Console.ReadLine());

			System.Console.WriteLine("Enter width");
			int w = Convert.ToInt32(Console.ReadLine());

			Console.Clear();
			s.PrintHollwedRectangle(l, w);
		}

		void CallSquarePattern(){
			Console.Clear();
			System.Console.WriteLine("Enter side");
			int l = Convert.ToInt32(Console.ReadLine());

			Console.Clear();
			s.PrintSquare(l);
		}

		void CallHollowedSquarePattern(){
			Console.Clear();
			System.Console.WriteLine("Enter side");
			int l = Convert.ToInt32(Console.ReadLine());

			Console.Clear();
			s.PrintHollwedSquare(l);
		}

		void CallTrianglePattern(){
			Console.Clear();
			System.Console.WriteLine("Enter no of rows");
			int l = Convert.ToInt32(Console.ReadLine());
			
			Console.Clear();
			s.PrintTriangle(l);
		}

		void CallHollowedTrianglePattern(){
			Console.Clear();
			System.Console.WriteLine("Enter no of rows");
			int l = Convert.ToInt32(Console.ReadLine());

			Console.Clear();
			s.PrintHollwedTriangle(l);
		}

		void CallDiamondPattern(){
			Console.Clear();
			System.Console.WriteLine("Enter no of rows");
			int l = Convert.ToInt32(Console.ReadLine());

			Console.Clear();
			s.PrintDiamond(l);
		}

		void CallHollowedDiamondPattern(){
			Console.Clear();
			System.Console.WriteLine("Enter no of rows");
			int l = Convert.ToInt32(Console.ReadLine());

			Console.Clear();
			s.PrintHollwedDiamond(l);
		}
	}
}
