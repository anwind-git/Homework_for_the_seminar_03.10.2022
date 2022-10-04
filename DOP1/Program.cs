// Написать перевод десятичного числа в двоичное, используя рекурсию.

void Rev(int number = 156, string result = "")
{
    if(number == 0) return;
    result = number % 2 + result;
    number = number / 2; 
    Rev(number);
    Console.Write(result);
}
Rev();