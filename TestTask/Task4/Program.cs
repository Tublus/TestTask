using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length >= 1)
            {  

                string fileContent;
                
                string filePath = args[0];
                try
                {
                    fileContent = File.ReadAllText(filePath);
                    string[] str = fileContent.Split('\n');
                    int q = 0;
                    int CheckNumber = AverageValue(str);
                    for (int i = 0; i < str.Length; i++)
                    {
                        int c = Convert.ToInt32(str[i]);
                        while (CheckNumber != c)
                        {
                            if (CheckNumber < c)
                            {
                                q++;
                                c--;
                            }
                            else
                            {
                                q++;
                                c++;
                            }
                        }


                    }
                    Console.WriteLine(q);
                   
                }
                catch (FileNotFoundException)
                {
                    Console.WriteLine("Указанный файл не найден.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Произошла ошибка при чтении файла.");
                }

            }
            else
            {
                Console.WriteLine("Произошла ошибка. Неверный формат ввода. Введите путь к файлв ");
                
            }
        }

        static int AverageValue(string [] str)
        {
            double q = 0;
            for (int i = 0; i < str.Length; i++)
            {
                q += Convert.ToInt32(str[i]);
             

            }
           return (int)Math.Round( q /str.Length, 0);

        }
    }
}
