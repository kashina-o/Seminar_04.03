int Input(string text) // Ввод данных пользователем 
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
