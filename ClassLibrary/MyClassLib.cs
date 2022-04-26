namespace ClassLibrary
{
    public static class ArrayHandler
    {
        public static int[,] HandleArray(int[,] array)
        {
            var tempArray = array;
            int rows = tempArray.GetUpperBound(0) + 1;
            int columns = tempArray.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if(i == j)
                    {
                        tempArray[i, j] = 1;
                    }
                }
            }

            return tempArray;
        }
    }

    public static class IntCollectionHandler
    {
        public static List<int> SortAndReturnHalf(List<int> collection)
        {
            var tempCollection = collection;
            var middleOfCollection = Math.Ceiling((double)(collection.Count / 2));
            tempCollection.Sort();

            return tempCollection.Skip((int)middleOfCollection).Take(collection.Count).ToList();
        }

        public static List<int> SortDescAndSquare(List<int> collection)
        {
            var tempCollection = collection;
            return tempCollection.OrderByDescending(x => x).Select(x => x * x).ToList();
        }
    }

    public class EventClass
    {
        public delegate void EventHandler();
        public event EventHandler? Notify;

        int counter = 0;

        public void Increment()
        {
            counter++;
            if(counter >= 10 && Notify != null)
            {
                Notify();
            }
        }

        public void AddConsumer(EventHandler func)
        {
            Notify += func;
        }
    }

    public static class MathHandler
    {
        public static int Factorial(int number)
        {
            if (number == 1) return 1;

            return number * Factorial(number - 1);
        }

        public static int Exponentiate(int number, int exponente)
        {
            return (int)Math.Pow(number, exponente);
        }
    }
}
