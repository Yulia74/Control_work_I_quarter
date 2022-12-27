string[] array = { "C", "Новым", "2023", "годом", "!!!" }; 

PrintArray(array);  

Console.Write(" -> ");

int lengthNewArray = ArrLength(array);                     
                                                           
string[] resArray = NewArray(array);                       

PrintArray(resArray);                                    

Console.WriteLine();



void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
    }
    Console.Write(array[array.Length - 1]);
    Console.Write("]");
}


int ArrLength(string[] array)                              
{                                                          
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}


string[] NewArray(string[] array)                      
{
    int index = 0;
    
    string[] resArray = new string[lengthNewArray];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            resArray[index] = array[i];
            index++;
        }
    }
    return resArray;
}