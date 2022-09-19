/*Необходимо написать программу, которая из имеющегося массива строк формирует массив из строк, 
длина которых меньше либо равна 3 символа. 
*/ 

Console.Clear();

string[] FirstArray = new string[5] {"123", "23", "hello", "world", "res"};
string[] SecondArray = new string[FirstArray.Length];

{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(FirstArray[i].Length <= 3)
        {
        SecondArray[count] = FirstArray[i];
        count++;
        }
    }
}