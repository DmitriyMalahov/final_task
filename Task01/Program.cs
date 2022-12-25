string[] array = new string[5] { "hello", "2", "world", ":-)", "bye" };

DecreaseArray(array);

void DecreaseArray(string[] arr)
{
    
    int temp = 0;
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arr[temp] = arr[i];
            temp++;

            Console.Write($"{arr[i]},");
        }
    }
    Console.Write("]");
}


