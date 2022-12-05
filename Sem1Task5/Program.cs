//Считываем данные с консоли
string? inputLine = Console.ReadLine();

//Проверяем, чтоьы данные были не пустыми
if(inputLine!=null)
{

    //Парсим введенное выражение
    int inputNumber = int.Parse(inputLine);

    int startNumber = inputNumber*(-1);

    //Выводим значение
    string outLine = string.Empty;

    while(startNumber<inputNumber)
    {
        outLine = outLine + startNumber + ", ";
        startNumber++;
        //startNumber=startNumber+1;
    }
    //outLine = outLine + inputNumber;
    outLine = outLine + inputNumber;

    //Выводим данные в консоль
    Console.WriteLine(outLine);  


}
