using System;
/* Task 1:

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
}

int a1 = 11;
int b1 = 2111;
int c1 = 31;
int a2 = 12;
int b2 = 22;
int c2 = 3211;
int a3 = 13;
int b3 = 23;
int c3 = 33;

//1) int max1 = Max(a1, b1, c1);
// int max2 = Max(a2, b2, c2);      Можно делать так;
// int max3 = Max(a3, b3, c3);
// int max = Max(max1, max2, max3);
//2) int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3)); можно делать так

//3) if (b1 > max) max = b1;
// if (c1 > max) max = c1;

// if (a2 > max) max = a2;
// if (b2 > max) max = b2;   Можно делать так;
// if (c2 > max) max = c2;

// if (a3 > max) max = a3;
// if (b3 > max) max = b3;
// if (c3 > max) max = c3;

Console.WriteLine("Maximum number is: " + max); */

/* Task 2:

int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2 > result) result = arg2;
    if(arg3 > result) result = arg3;
    return result;
} 
//              0    1   2   3   4   5   6   7   8
int[] array = {11, 211, 31, 41, 15, 61, 17, 18, 19};

int result = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));
Console.WriteLine("Maximum array number is: " + result); */

/* Task 3:

int[] array = {1, 54, 74, 5, 105, 99, 21, 11, 105};

int num = array.Length;
int find = 105;
int index = 0;

while(index < num)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // Прерви
    }

    index++;
} */

/* Task 4:

void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int[] array = new int[10];

FillArray(array);
PrintArray(array); */

/* Task 5:

void FillArray(int[] collection)
{
    int Length = collection.Length;
    int index = 0;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;

}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos); */
