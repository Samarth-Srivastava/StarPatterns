namespace StarPatterns
{
	public class Solution{
		public void solve(){

		}

        internal void PrintRectangle(int l, int w)
        {
            for (int i = 0; i < w; i++)
			{
				for (int j = 0; j < l; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
        }

		internal void PrintHollwedRectangle(int l, int w){
			for (int i = 0; i < w; i++)
			{
				for (int j = 0; j < l; j++)
				{
					if(i == 0 || i == w-1 || j == 0 || j == l-1){
						Console.Write("*");
					}
					else{
						Console.Write(" ");
					}
				}
				Console.WriteLine();
			}
		}
    
		internal void PrintSquare(int n){
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}

		internal void PrintHollwedSquare(int n){
			for (int i = 0; i < n; i++)
			{
				for (int j = 0; j < n; j++)
				{
					if(i == 0 || i == n-1 || j == 0 || j == n-1){
						Console.Write("*");
					}
					else{
						Console.Write(" ");
					}
				}
				Console.WriteLine();
			}
		}

		internal void PrintTriangle(int n){
			int N = (2*n)-1;
			for (int i = 0; i < n; i++) //no of rows
			{
				for (int j = 0; j < N; j++) //no of characters per row
				{
					if(j >= (N/2)-i && j <= (N/2)+i){
						Console.Write("*");
					}
					else{
						Console.Write(" ");
					}
				}
				Console.WriteLine();
			}
		}
		internal void PrintHollwedTriangle(int n){
			int N = (2*n)-1;
			for (int i = 0; i < n; i++) //no of rows
			{
				for (int j = 0; j < N; j++) //no of characters per row
				{
					// if(i == 0 || i == n-1 || j == 0 || j == N-1){
					// 	Console.Write("*");
					// }
					// else 
					if(j >= (N/2)-i && j <= (N/2)+i){
						Console.Write(" ");
					}
					else{
						Console.Write("*");
					}
				}
				Console.WriteLine();
			}
		}

		internal void PrintDiamond(int n){
			int N = (2*n)-1;
			for (int i = 0; i < n; i++) //no of rows
			{
				for (int j = 0; j < N; j++) //no of characters per row
				{
					if(j >= (N/2)-i && j <= (N/2)+i){
						Console.Write("*");
					}
					else{
						Console.Write(" ");
					}
				}
				Console.WriteLine();
			}
			for (int i = n-1; i >= 0; i--) //no of rows
			{
				for (int j = N-1; j >= 0; j--) //no of characters per row
				{
					if(j >= (N/2)-i && j <= (N/2)+i){
						Console.Write("*");
					}
					else{
						Console.Write(" ");
					}
				}
				Console.WriteLine();
			}
		}

		internal void PrintHollwedDiamond(int n){
			int N = (2*n)-1;
			for (int i = 0; i < n; i++) //no of rows
			{
				for (int j = 0; j < N; j++) //no of characters per row
				{
					if(j >= (N/2)-i && j <= (N/2)+i){
						Console.Write(" ");
					}
					else{
						Console.Write("*");
					}
				}
				Console.WriteLine();
			}
			for (int i = n-1; i >= 0; i--) //no of rows
			{
				for (int j = N-1; j >= 0; j--) //no of characters per row
				{
					if(j >= (N/2)-i && j <= (N/2)+i){
						Console.Write(" ");
					}
					else{
						Console.Write("*");
					}
				}
				Console.WriteLine();
			}
		}
	}
}
