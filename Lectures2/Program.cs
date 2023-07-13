/* View 1.
void Method1()
{
    Console.WriteLine("Avtor...");
}
Method1();
*/

/* View 2.

void Method2(string msq)
{
    Console.WriteLine(msq);
}
Method2("Hello ...");

void Method21(string msq, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msq);
        i++;
    }
}
Method21(msq: "Hello", count: 4);
*/

/* View 3.

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
Console.WriteLine(year);
*/

/* View 4.

string Method4(int count, string Hello)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + Hello;
        i++;
    }
    return result;
}

string res = Method4(10, "Hello ");
Console.WriteLine(res);
*/

/* Task 1.

string Method41(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method41(10, "Hello ");
Console.WriteLine(res);
*/

/* Task 2. 

for (int i = 1; i <= 10; i++)
{
    for (int j = 1; j < 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j};");
    }
        Console.WriteLine( );
}
*/

/* Task 3. ===Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить черточками,
// маленькие быквы "к" заменить большими "К",
// а маленькие "с" заменить большими "С".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";
// string s = "qwerty"
//             012
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int Length = text.Length;
    for (int i = 0; i < Length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
//Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'с', 'С');
//Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
*/

/* Task 4. 

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition]; 
        array[minPosition] = temporary;
    }
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
*/
