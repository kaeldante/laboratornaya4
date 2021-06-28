/*
 * Создано в SharpDevelop.
 * Пользователь: 123
 * Дата: 22.06.2021
 * Время: 19:32
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace pr4
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Лабораторная работа 4.Вариант 8 - Заменяет значения элементов на остаток от деления их на 10");
		 	Console.WriteLine("===============================");
		 	
		 	
			Console.Write("РАЗМЕР МАССИВА= " );
                var len = int.Parse(Console.ReadLine());
                var array = new int[len];
                
                for (int i = 0; i < array.Length; i++)
                	
                {
                    Console.Write("Элемент ("+i+") = ");
                    array[i] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine("===============================");
                Console.WriteLine("Остаток элементов от деления на 10");
                for (int i = 0; i < array.GetLength(0); i++)
                	
                	Console.WriteLine( array[i]%10);
          
                Console.WriteLine("===============================");
                Console.WriteLine("Для продолжения нажмите любую клавишу....");
                Console.ReadKey(true);
		}
	}
}