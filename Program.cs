namespace list
{
    internal class Program
    {
        //Перевірка чи список порожній
        public static bool IsEmpty<T>(List<T> list) => list.Count == 0;
        
        public static void Main(string[] args)
        {
            var list = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(IsEmpty(list)); // False
            list.Clear();
            Console.WriteLine(IsEmpty(list)); // True
        }
    }
}
