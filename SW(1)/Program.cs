internal class Program
{
    public static void Main()
    {

        String line;

        StreamReader sr = new StreamReader ("C:\\Users\\admin\\Desktop\\Sample.txt");

        line = sr.ReadLine();

        while (line != null)
        {
            Console.WriteLine(line);
            line = sr.ReadLine();
        }

        sr.Close(); 

        StreamWriter sw = new StreamWriter ("C:\\Users\\admin\\Desktop\\Sample.txt");

        sw.WriteLine("Hello World!");
        sw.WriteLine("Sample Text");
        sw.WriteLine("From StreamWriter!");

        sw.Close();

        Console.ReadLine();
    }
}