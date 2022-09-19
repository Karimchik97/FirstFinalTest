/*Необходимо написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
*/ 


string[] FirstArray = new string[7] {"Friend", "678", "Cat", "world", "7886", "Dog", "Array"};
string[] SecondArray = new string[FirstArray.Length];

{
    int count = 0;
    for (int i = 0; i < FirstArray.Length; i++)
    {
    if(FirstArray[i].Length <= 3)
        {
        SecondArray[count] = FirstArray[i];
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

PrintArray(SecondArray);
