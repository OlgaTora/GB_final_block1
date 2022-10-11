string [] ChangeArray(string inputString)
// Метод для выбора строк не более 2 символов
{
    var myArray = inputString.Split(' ');

    var newArray = new string[myArray.Length];
    var index = 0;
    foreach (var value in myArray)
    {
        if (value.Length < 3)
        {
            newArray[index] = value;
            index++;
        }
    }
    return newArray;
}

Console.WriteLine("Input your list with space");
string inputString = Console.ReadLine();