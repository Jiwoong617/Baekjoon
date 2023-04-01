static void Main(string[] args)
{
    StreamReader sr = new StreamReader(Console.OpenStandardInput());
    while (true)
    {
        if (sr.EndOfStream)
            break;
        Console.WriteLine(Array.ConvertAll(sr.ReadLine().Split(), int.Parse).Sum());
    }
}
