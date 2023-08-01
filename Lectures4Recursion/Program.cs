using System;
/* Task 1. Towers.

void Towers(string with  = "1", string on = "3", string some = "2", int count = 4)
{
    if(count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if(count > 1) Towers(some, on, with, count - 1);
}

Towers();*/

/* Task 2. 

string emp = String.Empty;
string[] tree = {emp, "/", "*", "10", "-", "+", emp, emp, "4", "2", "1", "3" };
//                0    1    2    3     4    5    6    7    8    9    10   11

void InOrderTravelsal(int pos = 1)
{
    if(pos < tree.Length)
    {
        int left = 2 * pos;
        int right = 2 * pos + 1;
        if(left < tree.Length && !String.IsNullOrEmpty(tree[left])) InOrderTravelsal(left);
        Console.WriteLine(tree[pos]);
        if(right < tree.Length && !String.IsNullOrEmpty(tree[right])) InOrderTravelsal(right);
    }
}
InOrderTravelsal();*/

// Task 3. Закрасить квадрат.

