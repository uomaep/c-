using System;
namespace StackProject
{
	public class StackByArr
	{
		public static void Main()
		{
			SimpleStack2<int> stack = new SimpleStack2<int>();
			stack.push(1);
			stack.push(2);
			stack.push(3);

			while(!stack.isEmpty())
			{
				Console.WriteLine(stack.pop());
            }
		}
	}

	class SimpleStack2<T>
	{
		T[] arr = new T[1];
		int MAXSIZE = 1;
		int top = -1;
		int size = 0;

		public void resize()
		{
			MAXSIZE *= 2;
			T[] newArr = new T[MAXSIZE];
			for (int i = 0; i < arr.Length; i++) newArr[i] = arr[i];
			arr = newArr;
		}

		public void push(T data)
		{
			if (top + 1 == MAXSIZE)
			{
				resize();
			}
			arr[++top] = data;
			size++;
		}

		public T pop()
		{
			if (size == 0) return default(T);
			T returnData = arr[top--];
			size--;
			return returnData;
        }

		public bool isEmpty()
		{
			return size == 0;
        }

		public override string ToString()
		{
			String v = "";
			for (int i = top; i >= 0; i--)
			{
				v += i != 0 ? arr[i] + ", " : arr[i];
			}
			return "[" + v + "]";
		}
	}
}

