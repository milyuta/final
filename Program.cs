
string [] CreateArray()
{
    Console.WriteLine("input the size of your array: "); 
    int n = Convert.ToInt32(Console.ReadLine());
    string [] array = new string [n];
    for(int i=0; i < n; i++)
    {
        Console.WriteLine($"input the {i+1} element of your array: "); 
        array[i] = new string(Console.ReadLine());
    } 
    return array;
}

void CheckArray(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] array = CreateArray();
string[] arrayNew = new string[array.Length];
CheckArray(array, arrayNew);
PrintArray(arrayNew);