string[] array = new string[11] {"hello", "2", "world", ":-)","123","15657", "-2","computer science","Russia","Denmark","Kazan"};
string[] newArray = new string[array.Length];
void Clean(string[] array, string[] newArray)
{
    int ind = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if(array[i].Length <= 3)
        {
        newArray[ind] = array[i];
        ind++;
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
Clean(array, newArray);
PrintArray(newArray);