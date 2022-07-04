Console.Clear();

// Задача: Написать программу, которая из имеющегося массива строк 
// формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] array = {"London", "Kiev", "Mos", "War", "Nep", "NY", "Vienn"};
int count = AnswerArrayLength(array);
string[] answerArray = FillArray(array, count);
PrintArray(answerArray);


int AnswerArrayLength (string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<=3)
        {
            count++;
        }
    }
    return count;
}

string[] FillArray(string[] array, int count)
{
    string[] answerArray = new string[count];
    int newCount=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length<=3)
        {
           answerArray[newCount]=array[i];
           newCount++;
        }
    }
    return answerArray;
}

void PrintArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        Console.Write(", ");
    }
}