// See https://aka.ms/new-console-template for more information
int[] BubbleSortArray = { 20, 65, 43, 54, 32 };
int temp;
for (int i = 0; i < BubbleSortArray.Length; i++)
{
    for (int j = 0; j < BubbleSortArray.Length - 1 - i; j++)
    {
        if (BubbleSortArray[j] > BubbleSortArray[j + 1])
        {
            temp = BubbleSortArray[j];
            BubbleSortArray[j] = BubbleSortArray[j + 1];
            BubbleSortArray[j + 1] = temp;
        }
    }
}
Console.WriteLine("Сортировка пузырьком ");
for (int i = 0; i < BubbleSortArray.Length; i++)
{
    Console.WriteLine(BubbleSortArray[i] + " ");
}
int[] SelectionSortArray = { 25, 36, 98, 745, 21, 6, 98 };
int temp1;
int MinValue;
for (int i = 0; i < SelectionSortArray.Length; i++)
{
    MinValue = i;
    for (int j = i + 1; j < SelectionSortArray.Length; j++)
    {
        if (SelectionSortArray[j] < SelectionSortArray[MinValue])
        {
            MinValue = j;
        }
    }
    temp1 = SelectionSortArray[MinValue];
    SelectionSortArray[MinValue] = SelectionSortArray[i];
    SelectionSortArray[i] = temp1;
}
Console.WriteLine("Сортировка выбором ");
for (int i = 0; i < SelectionSortArray.Length; i++)
{
    Console.WriteLine(SelectionSortArray[i] + " ");
}
int[] minArray = { 23, 12, 12, 6, 322, 345423, 13 };
int min = minArray[0];
int max = 0;
for (int i = 1; i < minArray.Length; i++)
{
    if (min > minArray[i])
    {
        min = minArray[i];
    }
    if (max < minArray[i])
    {
        max = minArray[i];
    }
}
Console.WriteLine($"{max} {min}");
int[] InsertionSortArray = { 32, 10, 320, 54, 453, 20, 65, 43, 54, 32 };
int a;
int b;
for (int i = 0; i < InsertionSortArray.Length; i++)
{
    a = i;
    b = InsertionSortArray[i];
    while (a > 0 && b < InsertionSortArray[a-1])
    {
        InsertionSortArray[a] = InsertionSortArray[a-1];
        a--;
    }
    InsertionSortArray[a] = b;
}
for (int i = 0; i < InsertionSortArray.Length; i++)
{
    Console.WriteLine(InsertionSortArray[i]);
}