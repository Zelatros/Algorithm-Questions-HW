class Program
{
    static void Main(string[] args)
    {
        HwQuestions instance = new HwQuestions();
        instance.Q1();
        instance.Q2();
        instance.Q3();
        instance.Q4();
    }
}

public class HwQuestions
{
    public void Q1()
    {
        Console.Write("Please enter a positive number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Please enter {0} positive number: ", n);
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Even numbers that you entered: ");
        foreach (var item in arr)
        {
            if (item%2 == 0)
            {
                Console.WriteLine(item);
            }
        }
    }

    public void Q2()
    {
        Console.Write("Please enter 2 positive number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int m = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];

        Console.WriteLine("Please enter {0} positive number: ", n);
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("The numbers that can be divided by {0} : ",m);
        foreach (var item in arr)
        {
            if (item%m == 0)
            {
                Console.WriteLine(item);
            }
        }
    }

    public void Q3()
    {
        Console.Write("Please enter a positive number: ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr = new string[n];

        Console.WriteLine("Please enter {0} words: ", n);
        for (int i = 0; i < n; i++)
        {
            arr[i] = Console.ReadLine();
        }

        Console.WriteLine("The words you wrote (from last to first): ");
        for (int i = n-1; i >= 0; i--)
        {
            Console.WriteLine(arr[i]);
        }
    }

    public void Q4()
    {
        Console.Write("Please enter a sentence: ");
        string sentence = Console.ReadLine();
        int WordCount = 1;
        int LetterCount = sentence.Length;
        string Separators = ",.\'\"?!";

        for(int i = 0; i < sentence.Length; i++)
        {
            if (char.IsWhiteSpace(sentence[i]))
            {
                WordCount++;
            }
        }
        Console.WriteLine("Total number of words: " + WordCount);

        for(int i = 0; i < sentence.Length; i++)
        {
            if (char.IsWhiteSpace(sentence[i]))
            {
                LetterCount--;
            }
            if (Separators.Contains(sentence[i]))
            {
                LetterCount--;
            }
        }
        Console.WriteLine("Total number of letters: " + LetterCount);
                
    }
}