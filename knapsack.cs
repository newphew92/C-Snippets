using System;
using System.Collections;
public class knapsack{
	static void Main(string[]args){
		int itemno;
		int weight;
		itemno=3;
		weight=5;
		Tuple<int,int>[] items={
			new Tuple<int,int>(5,3),
			new Tuple<int,int>(3,2),
			new Tuple<int,int>(4,1)
		};
		int[,] value= new int[itemno+1,weight+1];	
		int[,] keep=new int[itemno+1,weight+1];
		for (int i=0;i<weight;i++){
			value[0,i]=0;
		}
		for (int i=1;i<=itemno;i++){
			for (int j=0;j<=weight;j++){
				// Console.WriteLine(j-items[i-1].Item2);
				if (items[i-1].Item2<=j){
					value[i,j]=Math.Max (value[i-1,j],(items[i-1].Item1+value[i-1,j-items[i-1].Item2]));
					if (value[i,j]!=value[i-1,j]){keep[i,j]=1;}
				}
				else{
					value[i,j]=value[i-1,j];
				}
			}
		}
		printTable(value);
		printTable(keep);
		backtrack(items,keep);
		Console.WriteLine(value[2,1]);
	}
	static void printTable(int[,]table){
		for (int i=0;i<table.GetLength(0);i++){
			for (int j=0;j<table.GetLength(1);j++){
				Console.Write(table[i,j]+", ");
			}
			Console.WriteLine();
		}
	}

	static void backtrack(Tuple<int,int>[] itemList, int[,]keepTable){
		// number of items taken
		int i=keepTable.GetLength(0)-1;
		//weight you can carry
		int w=keepTable.GetLength(1)-1;
		ArrayList itemTaken=new ArrayList();
		Console.Write(i+" "+w);
		while (i>=0){
		if (keepTable[i,w]==1){
			itemTaken.Add(i);
			w-=itemList[i-1].Item2;
		}	
		i--;
		
		}
		foreach (int k in itemTaken){
			Console.Write(k+", ");
		}
	
	}


// V ----Weights Available----
// |
// |
// item#
// |
// |
// |

	

}