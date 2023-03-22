using System;
namespace StackProject
{
	public class StackByLinkedList
	{
		public static void Main()
		{
			SimpleStack<int> stack = new SimpleStack<int>();
			stack.push(1);
			stack.push(2);
			stack.push(3);

			while (!stack.isEmpty())
			{
				Console.WriteLine(stack.pop());
			}
		}
	}

	class SimpleStack<T>
	{
		LinkedList<T> list = new LinkedList<T>();

		public void push(T data)
		{
			list.AddFirst(data);
		}

		public T pop()
		{
			if (list.Count == 0) return default(T);
			T returnData = list.First.Value;
			list.RemoveFirst();
			return returnData;
		}

		public bool isEmpty()
		{
			return list.Count == 0 ? true : false;
		}

	}
}

