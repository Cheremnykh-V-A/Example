int[] array = {14, 62, 23, 44, 68, 15, 566, 27, 68};

int n = array.Length;
int find = 68;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
