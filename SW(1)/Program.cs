internal class Program // 1.1 - variable changes
{
    public static void Main()
    {
        String Line;
        String cnts;

        // Read the existing contents of the file
        StreamReader sr = new StreamReader("C:\\Users\\admin\\Desktop\\Sample.txt");
        Line = sr.ReadToEnd();
        sr.Close();

        Console.WriteLine("Current contents of the file:");
        Console.WriteLine(Line);

        // Append new contents to the file
        StreamWriter sw = new StreamWriter("C:\\Users\\admin\\Desktop\\Sample.txt", append: true);

        Console.Write("Please enter the contents you want to add to your text file: ");
        cnts = Console.ReadLine();

        sw.WriteLine(cnts);

        sw.Close();

        Console.WriteLine("Process done! Check your text file to see the changes.");
        Console.ReadLine();
    }
}
