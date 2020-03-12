using System;

namespace _6LabTask_second
{
    class Program
    {
        static int InsertInt()
        {
            int num;
            bool ok;

            do
            {
                ok = int.TryParse(Console.ReadLine(), out num);
                if (!ok)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Неверный ввод! Введите заново.");
                    Console.WriteLine(" ");
                }
            } while (ok == false);
            return num;
        }
        static void MenuChooseAction()
        {
            Console.WriteLine(@"Выберите действие:
1. Создать строку.
2. Поменять местами первое и последнее слова в строке.
3. Выход.
 ");
        }
        static void MenuStringFilling()
        {
            Console.WriteLine(@"Выберите способ создания строки:
1. Ввод с клавиатуры.
2. Выбор из предложенных строк.
3. Назад.
");
        }
        static void MenuChooseString()
        {
            Console.WriteLine(@"Выберите строку:
1. если долго смотреть на прокисшее молоко, оно начнет смотреть на тебя.
2. hello boy, how are you?
3. ,.!
4.  
5. 123 abc.
6. Назад.
");
        }
        static void ChooseAction()
        {
            int check;
            string text = "";
            do
            {
                MenuChooseAction();
                check = InsertInt();
                switch (check)
                {
                    case 1:
                        {
                            ChooseFilling(ref text);
                            break;
                        }
                    case 2:
                        {
                            if (String.IsNullOrEmpty(text))
                            {
                                Console.WriteLine("Пустая строка.");
                            }
                            else
                            {
                                ReverseFirstLastWord(ref text);
                            }
                            break;
                        }
                    case 3: break;
                    default:
                        Console.WriteLine("Нет такого пункта меню");
                        break;
                }
                Console.WriteLine(" ");
            } while (check != 3);
        }
        static void ChooseFilling(ref string text)
        {
            int bullean;
            do
            {
                MenuStringFilling();
                bullean = InsertInt();
                switch (bullean)
                {
                    case 1:
                        {
                            ReadText(ref text);
                            break;
                        }
                    case 2:
                        {
                            bool check = true;
                            do
                            {
                                MenuChooseString();
                                ChooseString(ref text);
                                CheckText(text, ref check);
                            } while (check == false);
                            break;
                        }
                    case 3: break;
                    default:
                        Console.WriteLine("Нет такого пункта меню");
                        break;
                }
                Console.WriteLine(" ");
            } while (bullean != 3);
        }
        static void ChooseString(ref string text)
        {
            int check;
            do
            {
                check = InsertInt();
                switch (check)
                {
                    case 1:
                        {
                            text = "если долго смотреть на прокисшее молоко, оно начнет смотреть на тебя.";
                            Console.WriteLine("если долго смотреть на прокисшее молоко, оно начнет смотреть на тебя.");
                            check = 6;
                            break;
                        }
                    case 2:
                        {
                            text = "hello boy, how are you?";
                            Console.WriteLine("hello boy, how are you?");
                            check = 6;
                            break;
                        }
                    case 3:
                        {
                            text = ",.!";
                            Console.WriteLine(",.!");
                            check = 6;
                            break;
                        }
                    case 4:
                        {
                            text = " ";
                            Console.WriteLine(" ");
                            check = 6;
                            break;
                        }
                    case 5:
                        {
                            text = "123 abc.";
                            Console.WriteLine("123 abc.");
                            check = 6;
                            break;
                        }
                    case 6: break;
                    default:
                        Console.WriteLine("Нет такого пункта меню");
                        Console.WriteLine(" ");
                        break;
                }
                Console.WriteLine(" ");
            } while (check != 6);
        }
        static void InputText(ref string text)
        {
            Console.WriteLine("Введите текст:");
            text = Console.ReadLine();
            Console.WriteLine(" ");
        }
        static void CheckText(string text, ref bool check)
        {
            foreach (char ch in text)
            {
                if (!(Char.IsDigit(ch) || Char.IsLetter(ch) || IsSep(ch) || CheckDoubleSeps(text)))
                {
                    check = false;
                    break;
                }
                else
                {
                    check = true;
                }
            }
            if (check == false)
            {
                Console.WriteLine("Неправильно введена строка!");
            }
            string[] a = text.Split(" ");
            if (a.Length <= 1 || text.Length <= 1)
            {
                Console.WriteLine("Строка должна содержать более 1 слова.");
                Console.WriteLine(" ");
                check = false;
            }
        }
        static string ReadText(ref string text)
        {
            bool check = true;
            do
            {
                InputText(ref text);
                CheckText(text, ref check);
            } while (check == false);
            return text;
        }
        static bool IsSep(char ch)
        {
            string seps = ".,;:?! ";
            return seps.Contains(ch);
        }
        static bool IsEndSep(char ch)
        {
            string seps = ".?!";
            return seps.Contains(ch);
        }
        static bool CheckDoubleSeps(string text)
        {
            for (int i = 0; i < text.Length - 1; i++)
            {
                if (IsEndSep(text[i]) && IsEndSep(text[i + 1]))
                    return true;
            }
            return true;
        }
        static void RememberSep(string last, ref char[] sep, ref char[] noSep, ref string text, string[] a)
        {
            try
            {
                int i = 0;
                foreach (char ch in last)
                {
                    if (IsEndSep(ch))
                    {
                        sep[0] = ch;
                    }
                    else
                    {
                        noSep[i] = ch;
                        i++;
                    }
                }
            }
            catch
            {
                int i = 0;
                noSep = new char[last.Length];
                foreach (char ch in last)
                {
                    noSep[i] = ch;
                    i++;
                }
            }
        }
        static void ReverseFirstLastWord(ref string text)
        {
            string[] a = text.Split(" ");
            string first = a[0];
            string last = a[a.Length - 1];

            char[] noSep = new char[last.Length - 1];
            char[] sep = new char[1];

            RememberSep(last, ref sep, ref noSep, ref text, a);

            string temp = String.Concat<char>(noSep);
            string dot = String.Concat<char>(sep);
            a[0] = temp;
            a[a.Length - 1] = first + dot;
            text = String.Join(" ", a);
            Console.WriteLine(text);
        }
        static void Main(string[] args)
        {
            ChooseAction();
        }
    }
}
