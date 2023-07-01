int[] arr = { 5, 3, 7, -2, 0};

int[] ArraySort(int[]arr)
{
    for (int i = 0; i < arr.Length-1; i++)
    {
        for (int j = 0; j < arr.Length-(1+i); j++)
        {
            if (arr[j] > arr[j+1])
            {
                int temp = arr[j+1];
                arr[j + 1] = arr[j];
                arr[j] = temp;
            }
        }
    }
    return arr;
}

void FindSumAndCount()
{

    Console.Write("Ilk ededi daxil edin: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Ikinci ededi daxil edin: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int count = 0;
    int sum = 0;

    if (num1>=num2)
    {
        Console.WriteLine("1-ci eded kicik olmalidir");
    }
    else
    {
        for (int i = num1; i <= num2; i++)
        {
            if (i % 2 == 1)
            {
                count++;
                sum += i;
            }
        }

        Console.WriteLine("Cem : {0}, Say: {1} ", sum, count);
    }
}

double FindMedian(int[] arr)
{
    int[] sortedArr = ArraySort(arr);
    int middle = sortedArr.Length / 2;
    if (sortedArr.Length % 2 == 1)
    {
        return sortedArr[middle];
    }
    else
    {
        return (sortedArr[middle - 1] + sortedArr[middle]) / 2.0;
   }
}

int[] reverse(int[] a)
{
    int temp;
    for (int i = 0; i < a.Length / 2; i++)
    {
        temp = a[i];
        a[i] = a[a.Length - i - 1];
        a[a.Length - i - 1] = temp;
    }
    return a;
}

int[] ReverseArray(int[] arr)
{
    int start = 0;
    int end = arr.Length - 1;
    int[] newArr = new int[arr.Length];
    //while (start<end)
    //{
    //    int temp = arr[end];
    //    arr[end] = arr[start];
    //    arr[start] = temp;
    //    start += 1;
    //    end -=1;
    //}
    for (int i = 0; i <arr.Length; i++)
    {
        newArr[i] = arr[arr.Length-i-1];
    }
    return newArr;
}

int[] newArr=ReverseArray(arr);
foreach (int item in newArr)
{
    Console.Write(item + " ,");
}
/*
    arr = { 5, 3, 7, -2, 0};
    {0 3 7 -2 5}
    {0 -2 7 3 5}
    start:0 1 2 3
    end:4 3 2 1
    temp:0 -2 7
    arr[start]:0 -2 7
    arr[end]:5 3 7
 */







Console.ReadLine();
