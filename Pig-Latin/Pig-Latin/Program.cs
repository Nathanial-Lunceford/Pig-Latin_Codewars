// See https://aka.ms/new-console-template for more information
internal class Program
{

    public static string PigIt(string str)
    {
        // first, split str into multiple strings of only non-punctuation marks

        string[] strings = str.Split(" ");

        string finished = "";
        string s = "";

        for(int i = 0; i < strings.Length; i++)
        {
            if (!(strings[i].Length <= 1))
            {
                s = strings[i].Substring(1) + strings[i][0] + "ay";
            }
            else
            {
                s = strings[i];
            }
                
            finished = finished + " " + s;

        }
        return finished.Trim();
    }


    static void Main(string[] args)
    {
        string test = "Hello world !";
        Console.WriteLine(PigIt(test));
    }
}