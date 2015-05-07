using System;
public class knapsack{
	static void Main(string[]args){
		int itemno;
		int weight;
		itemno=4;
		weight=5;
		Tuple<int,int>[] items={
			new Tuple<int,int>(5,3),
			new Tuple<int,int>(3,2),
			new Tuple<int,int>(4,1)
		};
		int[,] value= new int[itemno,weight+1];	

		for (int i=0;i<weight;i++){
			value[0,i]=0;
		}
		for (int i=1;i<itemno;i++){
			for (int j=0;j<=weight;j++){
				// Console.WriteLine(j-items[i-1].Item2);
				if (items[i-1].Item2<=j){
					value[i,j]=Math.Max (value[i-1,j],(items[i-1].Item1+value[i-1,j-items[i-1].Item2]));
				}
				else{
					value[i,j]=value[i-1,j];
				}
			}
		}
		
		for (int i=0;i<itemno;i++){
			for (int j=0;j<=weight;j++){
				Console.Write(value[i,j]+", ");
			}
			Console.WriteLine();
		}

		Console.WriteLine(value[2,1]);
	}

// V ----Weights Available----
// |
// |
// item#
// |
// |
// |

	

}