//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтоьы данные были не пустыми
if(inputLine!=null)
{
    //Парсим введенное выражение
    int inputNumber = int.Parse(inputLine);

    //Выводим остаток от деления
    int lastDigit = inputNumber % 10;

    //Выводим данные в консоль
    Console.WriteLine(lastDigit);  

}
