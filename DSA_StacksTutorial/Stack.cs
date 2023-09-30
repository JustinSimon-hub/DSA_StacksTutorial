using System;
namespace DSA_StacksTutorial
{
	public class Sttack
	{
		public int Max { get; set; }// max size property becasue it needs one to initilize an array

		public string[] stackArray { get; set; } // this is the property thats gonna hold the array

		public int Top { get; set; } //keeps track of where the actual top of the tack is

		public Sttack(int size)
		{
			this.Max = size;//this holds the constructor value
			this.stackArray = new string[Max];//this initializes the array with the max size
			this.Top = -1;//not set to 0 because then it will skip the first element in the array because arrays are zero indexed
		}
		//push pop peek are the main manipulating methods for stacks
		public void Push(string item)
		{
			/*
			 *If the array is full and goes to max size without ny error handling thenm it will give an aerror
			 */
			Top++;
			stackArray[Top] = item;

		}

		public string Pop()
		{
			//remoivng item from top of stack
			int old_top = Top;
			//decrements for each new top
			Top--;
			return stackArray[old_top];
		}

		public string Peek()
		{
			//returns item at top of stack
			return stackArray[Top];
		}


		public bool isEmpty()
		{
			return Top == 0;
		}
		public bool isFull()
		{
			return Max - 1 == Top;
			//will return true of the above statement is true, indicating tha thte stack is full 

		}
	}
}

