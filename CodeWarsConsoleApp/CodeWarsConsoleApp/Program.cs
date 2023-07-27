// int SumMul(int n, int m)
//{
//	if(m > n && n > 0)
//	{
//        int sum = 0;
//        for (int i = n; i < m; i += n)
//        {
//            sum += i;
//        }
//        return sum;
//    }
//    throw new ArgumentException();
//}

//Console.WriteLine(SumMul(4, 1));
//int NoBoringZeros(int n)
//{
//    while (n % 10 == 0 && n != 0)
//    {
//            n /= 10;
//    }

//    return n;
//}


//List<int> ReverseList(List<int> list)
//{
//    List<int> newList = new();
//    for (int i = list.Count - 1; i >= 0; i--)
//    {
//        newList.Add(list[i]);
//    }
//    return newList;
//}


string Position(char alphabet)
{
    int n = alphabet;
    n-= 96;
    return n.ToString();
}

Console.WriteLine(Position('C'));

