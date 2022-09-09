// // 1 способ:
// int[] array = { 15, 22, 35, 42, 55, 654, 17, 42 };
// int n = array.Length; // определяет длину массива
// int find = 42;
// int index = 0;
// while (index<n)
// {
//     if(array[index]==find)
//     {
//         Console.WriteLine(index);
//         break; // прерывает алгоритм, если найдено нужное значение
//     }
//     index++;
// }

// // 2 способ - при помощи “Метода”
// void FillArray(int[] collection) // void - метод, который ничего не возвращет
// {
//     int length = collection.Length; // определяем длину массива
//     int index = 0;
//     while (index < length)
//     {
//         collection[index] = new Random().Next(1, 10);
//         index++;
//     }
// }

// void PrintArray(int[] col)
// {
//     int count = col.Length;
//     int position = 0;
//     while (position < count)
//     {
//         Console.WriteLine(col[position]);
//         position++;
//     }
// }

// int[] array = new int[10];

// FillArray(array); // Метод заполнения массива
// PrintArray(array); // Метод печати массива

// 3 способ - метод IndexOf
void FillArray(int[] collection) // void - метод, который ничего не возвращет
{
    int length = collection.Length; // определяем длину массива
    int index = 0;
    while (index < length)
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
    int count = collection.Length; // определяем количество элементов
    int index = 0;
    int position = -1;
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

FillArray(array); // Метод заполнения массива
array[4]=4; // принудительно добавили 4, можно убрать
array[6]=4;
PrintArray(array); // Метод печати массива
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);