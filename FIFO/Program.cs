namespace Exercise2
{
    internal class Program
    {
        static int[] queue = new int[5];
        static int pivot = -1;

        static void Main(string[] args)
        {
            EnQueue(10);
            EnQueue(25);
            EnQueue(31);
            EnQueue(42);

            int removedNumber = DeQueue();
            Console.WriteLine("Removed:" + removedNumber);

            EnQueue(100);
            EnQueue(50);
            EnQueue(37);

            removedNumber = DeQueue();
            removedNumber = DeQueue();


            PrintQueue();
        }


        public static void EnQueue(int num)
        {
            if (!IsFull())
            {
                pivot++;
                queue[pivot] = num;
            }

        }

        public static int DeQueue()
        {
            if (!IsEmpty())
            {
                pivot--;
                int removedNumber = queue[0];
                for (int i = 0; i <= pivot; i++)
                {
                    queue[i] = queue[i + 1];
                }
                queue[pivot + 1] = 0;

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
            return (pivot == queue.Length - 1) ? true : false;
        }

        public static void PrintQueue()
        {
            for (int i = 0; i <= pivot; i++)
            {
                Console.WriteLine(queue[i]);
            }
        }


    }
}