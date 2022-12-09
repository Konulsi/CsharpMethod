#region Task1
//1) Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.

//IsDivideOrNot(21);

//static void IsDivideOrNot(int n)

//{
//    if (n % 3 == 0 && n % 7 == 0)
//    {
//        Console.WriteLine("bolunur");
//    }
//    else
//    {
//        Console.WriteLine("bolunmur");
//    }

//}
#endregion


#region Task2
//2) n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.

//GetSum(5, 10);

//static void GetSum( int n, int m)
//{
//    int sum = 0;
//    if (n % 2 == 0 && m % 2 == 0)
//    {
//        sum = n + m;
//        Console.WriteLine(sum);
//    }
//    else
//    {
//        Console.WriteLine("duzgun eded daxil edin");
//    }
//}
#endregion

#region Task3
//3) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.




//static int GetNumsSum(int n, int m)
//{
//    int sum = 0;
//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 == 1)
//        {
//            sum += i;
//        }
//    }
//    return sum;
//}

//int result = GetNumsSum(2, 8);
//Console.WriteLine(result);

#endregion

#region Task4
//4) Verilmish arrayin icindeki tek ededlerin cemini tapin.


//int[] num = { 1, 2, 3, 5, 8, 11, 15, 16 };

//int result = GetSumArr(num);
//Console.WriteLine(result);


//static int GetSumArr(int[] arr)
//{

//    int sum = 0;
//    foreach (int item in arr)
//    {
//        if (item % 2 == 1)
//        {
//            sum += item;
//        }
//    }
//    return sum;
//}

#endregion

#region Task5
//5) Verilmish arrayin icindeki cut ededlerin sayini tapin.


//int[] arr = { 1, 2, 3, 5, 8, 11, 15, 16 };

//int result = GetCount(arr);
//Console.WriteLine(result);


//static int GetCount(int[] arr)
//{
//    int count = 0;
//    foreach (int num in arr)
//    {
//        if (num % 2 == 0)
//        {
//            count++;
//        }
//    }
//    return count;
//}
#endregion

#region Task6
//6) Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin sayini tapin.


//int result = GetNumsCount(10, 20);
//Console.WriteLine(result);

//static int GetNumsCount(int n, int m)
//{
//    int count = 0;

//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 == 1)
//        {
//            count++;
//        }
//    }
//    return count;

//}
#endregion

#region Task7
//7) Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin cemini tapin.

//GetNumSum( 2,8);

//static void GetNumSum(int n, int m)
//{
//    int sum = 0;
//    for (int i = n; i <m; i++)
//    {
//        if (i % 2 == 0)
//        {
//            sum += i; 
//        }
//    }
//    Console.WriteLine(sum);
//}

#endregion

#region Task8
//8) Verilmis n ve m (n<m) ededleri arasindaki cut ededlerin sayini tapin.

//GetNumsCount(2,10);

//static void GetNumsCount(int n, int m)
//{
//    int count = 0;

//    for (int i = n; i < m; i++)
//    {
//        if (i % 2 == 0)
//        {
//            count++;
//        }
//    }
//    Console.WriteLine(count);
//}

#endregion

#region Task9
//9) Verilmis n tam ededinin sade ve ya murekkeb oldugunu tapin.



//IsPromiseOrComplex(8);

//static void IsPromiseOrComplex(int n)
//{
//    int count = 0;
//    if (n < 0)
//    {
//        Console.WriteLine("duzgun reqem daxil edin");
//    }
//    else if (n == 1)
//    {
//        Console.WriteLine("ne sadedir, ne murekkeb");
//    }
//    else
//    {
//        for (int i = 1; i <= n; i++)
//        {
//            if (n % i == 0)
//            {
//                count++;
//            }
//        }
//        if (count > 2)
//        {
//            Console.WriteLine("murekkeb ededdir");
//        }
//        else
//        {
//            Console.WriteLine("sade ededdir");
//        }
//    }

//}
#endregion

#region Task10
//10)n ededinin faktorialini hesablamaq.


//GetNumFactorial(6);

//static void GetNumFactorial(int n)
//{
//    int multiple = 1;
//    for (int i = 1; i <= n; i++)
//    {
//        multiple *= i;
//    }
//    Console.WriteLine(multiple);
//}
#endregion
