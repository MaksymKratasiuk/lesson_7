namespace lessom_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array();
            array.Show();
            Console.WriteLine("\nEnter information -> ");
            string info = Console.ReadLine();
            array.ShowInfo(info);
        }
    }
}