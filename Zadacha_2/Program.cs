Console.Write("Введите число дня недели ");
int NumberWeek = Convert.ToInt32(Console.ReadLine());
 if (NumberWeek == 1)
 {
    Console.Write("Понедельник");
 }
 if (NumberWeek == 2)
 {
    Console.Write("Вторник");
 }
 if (NumberWeek == 3)
 {
    Console.Write("Среда");
 }
 if (NumberWeek == 4)
 {
    Console.Write("Четверг");
 }
 if (NumberWeek == 5)
 {
    Console.Write("Пятница");
 }
 if (NumberWeek == 6)
 {
    Console.Write("Суббота");
 }
 if (NumberWeek == 7)
 {
    Console.Write("Воскресенье");
 }
 if (NumberWeek > 7)
 {
    Console.Write("В неделе 7 дней");
 }