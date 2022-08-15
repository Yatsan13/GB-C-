 int ReadInt(string message)
 {
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());

 }

 int number = ReadInt("Введите трехзначное число ");
 Console.WriteLine(DeleteSecondDigit(number));
 int DeleteSecondDigit(int number)
 {
    int first = number / 10;
    int second = first % 10;
    return second;
 }