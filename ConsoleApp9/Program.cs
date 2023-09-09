// task 1
//public interface IOutput
//{
//    void Show();
//    void Show(string info);
//}

//public class Array : IOutput
//{
//    private int[] elements;

//    public Array(int[] array)
//    {
//        elements = array;
//    }

//    public void Show()
//    {
//        Console.WriteLine("Array elements:");
//        foreach (int element in elements)
//        {
//            Console.Write($"{element} ");
//        }
//        Console.WriteLine();
//    }


//    public void Show(string info)
//    {
//        Console.WriteLine($"Information: {info}");
//        Console.WriteLine("Array elements:");
//        foreach (int element in elements)
//        {
//            Console.Write($"{element} ");
//        }
//        Console.WriteLine();
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] myArray = { 1, 2, 3, 4, 5 };

//        Array array = new Array(myArray);

//        array.Show();

//        Console.WriteLine();

//        array.Show("This is the message.");
//    }
//}


// task 2
//public interface IMath
//{
//    int Max();
//    int Min();
//    float Avg();
//    bool Search(int valueToSearch);
//}

//public class Array : IMath
//{
//    private int[] elements;

//    public Array(int[] array)
//    {
//        elements = array;
//    }

//    public int Max()
//    {
//        return elements.Max();
//    }

//    public int Min()
//    {
//        return elements.Min();
//    }

//    public float Avg()
//    {
//        return (float)elements.Sum() / elements.Length;
//    }

//    public bool Search(int valueToSearch)
//    {
//        return elements.Contains(valueToSearch);
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] myArray = { 1, 2, 3, 4, 5 };

//        Array array = new Array(myArray);

//        Console.WriteLine($"Max value: {array.Max()}");

//        Console.WriteLine($"Min value: {array.Min()}");

//        Console.WriteLine($"Average value: {array.Avg()}");

//        int valueToFind = 3;
//        Console.WriteLine($"Search for {valueToFind}: {array.Search(valueToFind)}");
//    }
//}


// task 3
//public interface ISort
//{
//    void SortAsc();
//    void SortDesc();
//    void SortByParam(bool isAsc);
//}

//public class MyArray : ISort
//{
//    private int[] elements;

//    public MyArray(int[] array)
//    {
//        elements = array;
//    }

//    public void SortAsc()
//    {
//        for (int i = 0; i < elements.Length - 1; i++)
//        {
//            for (int j = 0; j < elements.Length - i - 1; j++)
//            {
//                if (elements[j] > elements[j + 1])
//                {
//                    int temp = elements[j];
//                    elements[j] = elements[j + 1];
//                    elements[j + 1] = temp;
//                }
//            }
//        }
//    }

//    public void SortDesc()
//    {
//        for (int i = 0; i < elements.Length - 1; i++)
//        {
//            for (int j = 0; j < elements.Length - i - 1; j++)
//            {
//                if (elements[j] < elements[j + 1])
//                {
//                    int temp = elements[j];
//                    elements[j] = elements[j + 1];
//                    elements[j + 1] = temp;
//                }
//            }
//        }
//    }

//    public void SortByParam(bool isAsc)
//    {
//        if (isAsc)
//        {
//            SortAsc();
//        }
//        else
//        {
//            SortDesc();
//        }
//    }

//    public void DisplaySortedArray()
//    {
//        Console.WriteLine("Sorted Array:");
//        foreach (var element in elements)
//        {
//            Console.Write($"{element} ");
//        }
//        Console.WriteLine();
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        int[] myArray = { 5, 3, 1, 4, 2 };
//        MyArray array = new MyArray(myArray);

//        array.SortAsc();
//        array.DisplaySortedArray();

//        array.SortDesc();
//        array.DisplaySortedArray();

//        array.SortByParam(true);
//        array.DisplaySortedArray();

//        array.SortByParam(false);
//        array.DisplaySortedArray();
//    }
//}