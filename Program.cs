using System;
using System.Text;
using System.Diagnostics;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace lerner
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Comments
            // Написать игру, в которою могут играть два игрока.
            // При старте, игрокам предлагается ввести свои никнеймы.
            // Никнеймы хранятся до конца игры.
            // Программа загадывает случайное число gameNumber от 12 до 120 сообщая это число игрокам.
            // Игроки ходят по очереди(игра сообщает о ходе текущего игрока)
            // Игрок, ход которого указан вводит число userTry, которое может принимать значения 1, 2, 3 или 4,
            // введенное число вычитается из gameNumber
            // Новое значение gameNumber показывается игрокам на экране.
            // Выигрывает тот игрок, после чьего хода gameNumber обратилась в ноль.
            // Игра поздравляет победителя, предлагая сыграть реванш
            // 
            // * Бонус:
            // Подумать над возможностью реализации разных уровней сложности.
            // В качестве уровней сложности может выступать настраиваемое, в начале игры,
            // значение userTry, изменение диапазона gameNumber, или указание большего количества игроков (3, 4, 5...)

            // *** Сложный бонус
            // Подумать над возможностью реализации однопользовательской игры
            // т е игрок должен играть с компьютером


            // Демонстрация
            // Число: 12,
            // Ход User1: 3
            //
            // Число: 9
            // Ход User2: 4
            //
            // Число: 5
            // Ход User1: 2
            //
            // Число: 3
            // Ход User2: 3
            //
            // User2 победил!
            #endregion

            Random rand = new Random();
            #region command for Users
            Console.WriteLine("введите никнейм первого икгрока: ");
            string User_one = Console.ReadLine();
            Console.WriteLine("введите никнейм второго икгрока: ");
            string User_tho = Console.ReadLine();
            #endregion

            #region Game_Main
            int randge = rand.Next(12, 121);
            Debug.Write(randge);

            bool while_result = true;
            bool whileу = true;

            while (whileу)
            {
                while (while_result)
                {
                    Console.WriteLine("введите число от 1 до 4");
                    int userTry = int.Parse(Console.ReadLine());

                    if (userTry <= 4 && userTry >= 0)
                    {
                        Console.WriteLine($"игрок {User_one} ввел число {userTry}");
                        randge -= userTry;
                        Console.WriteLine("число отнялось");
                        Debug.Write($"теперь число {randge}");
                        if (randge < 0)
                        {
                            Console.WriteLine($"игра закончилась игрок: {User_one} WIn");
                            whileу = false;
                        }

                    }
                    else
                    {
                        Console.WriteLine("вы вышли за ограничения");
                        break;
                    }
                    break;
                }

                while (while_result)
                {
                    Console.WriteLine("введите число от 1 до 4");
                    int userTry = int.Parse(Console.ReadLine());

                    if (userTry <= 4 & userTry >= 0)
                    {
                        Console.WriteLine($"игрок {User_tho} ввел число {userTry}");
                        randge -= userTry;
                        Console.WriteLine("число отнялось");
                        Debug.Write($"теперь число {randge}");
                        if (randge < 0)
                        {
                            Console.WriteLine($"игра закончилась игрок: {User_one} WIn");
                            whileу = false;
                        }
                        break;
                    }
                    else
                    {
                        Console.WriteLine("вы вышли за ограничения");
                        break;
                    }
                }
            }

        }
            #endregion
    }
}



























































/*            while (while_result)
            {
                Console.WriteLine("введите число от 1 до 4");
                int userTry = int.Parse(Console.ReadLine());
                for (int i = randge; i == 0;)
                {
                    if (userTry > 4 & userTry < 0)
                    {
                        Console.WriteLine($"игрок {User_one} ввел число {userTry}");
                        int result = randge - userTry;
                        Console.WriteLine("число отнялось");
                        Debug.Write($"теперь число {result}");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("вы вышли за ограничения");
                        break;
                    }
                }
                #endregion
            }

            while (while_result)
            {
                Console.WriteLine("введите число от 1 до 4");
                int userTry = int.Parse(Console.ReadLine());
                for (int i = randge; i == 0;)
                {
                    if (userTry > 4 & userTry < 0)
                    {
                        Console.WriteLine($"игрок {User_one} ввел число {userTry}");
                        int result = randge - userTry;
                        Console.WriteLine("число отнялось");
                        Debug.Write($"теперь число {result}");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("вы вышли за ограничения");
                        break;
                    }
                }
            }*/