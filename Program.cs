// Функция возвращает исходный массив. По выбору пользователя: или заданный программой, 
// или введенный с клавиатуры
string[] GetInputArray()
{
    Console.WriteLine("Хотите ввести массив вручную с клавиатуры(y/n)?");
    string userAnswer = Console.ReadLine();
    
    // Ввод исходного массива строк с клавиатуры
    if (userAnswer == "y") 
    {
        Console.WriteLine("Введите элементы массива через пробел:");
        string[] inputArr = Console.ReadLine().Split(' ');
        return inputArr;
    }
    // Задание исходного массива строк программой
    else if (userAnswer == "n")
    {
        string[] inputArr = {"Hello", "2", "world", ":-)"};
        return inputArr;
    }
    else 
    {
        Console.WriteLine("Неверный ввод!");
        return GetInputArray();
    }
}

//Функция получает на вход массив строк arr. Создаёт новый массив newArr из элементов arr, 
//длина которых <=3. Возвращает newArr
string[] GetNewArray(string[] arr)
{
    // Подсчет количества строк длиной <= 3 символам
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            count++;
        }
    }

    // Создание нового массива для хранения строк длиной <= 3 символам
    string[] newArr = new string[count];
    int newIndex = 0;

    // Заполнение нового массива строками длиной <= 3 символам
    if (count > 0){
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                newArr[newIndex] = arr[i];
                newIndex++;
            }
        }
    }
    return newArr;
}

// Процедура выводит на экран массив
void printArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) Console.Write(array[i]);
        else Console.Write($"{array[i]}, ");
    }
    Console.Write("]");
}

string[] inputArray = GetInputArray();
string[] newArray = GetNewArray(inputArray);

printArray(inputArray);
Console.Write(" -> ");
printArray(newArray);