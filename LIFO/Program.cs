namespace Exercise2
{
    internal class Program
    {
        static int[] stack = new int[50];
        static int pivot = -1;
        static void Main(string[] args)
        {
            int remove = Pop();

            Push(5);
            Push(6);
            Push(10);
            Push(3);

            remove = Pop();

            Console.WriteLine("First Pop:");
            PrintStack();

            Console.WriteLine("Second Pop:");
            remove = Pop();
            PrintStack();


            Console.WriteLine("Third Pop:");

            Push(30);
            Push(100);
            Push(200);

            remove = Pop();
            Push(150);
            Push(1343);
            PrintStack();

        


        }

        public static void Push(int num)
        {
            if (!IsFull())
            {
                pivot++;
                stack[pivot] = num;
            }
            
        }

        public static int Pop()
        {
            int removedNumber;
            if (!IsEmpty())
            {
                removedNumber = stack[pivot];
                stack[pivot] = 0;
                pivot--;

                return removedNumber;
            }
            return -1;
        }

        public static bool IsEmpty()
        {
            return (pivot == -1) ? true : false;
        }

        public static bool IsFull() 
        {
            return (pivot == stack.Length - 1) ? true : false;
        }

        public static void PrintStack()
        {
            for (int i=0; i <= pivot; i++)
            {
                Console.WriteLine(stack[i]);
            }
        }

     
    }
}