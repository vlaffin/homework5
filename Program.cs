// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

//  void NewArray()
//   {
//   int count = 0;
//   Console.WriteLine("Это прога, которая посчитает кол-во чётных чисел с массиве, спасибо за тестирование программы, обязательно оставте отзыв, это важно для меня!");
//   Console.Write("Введите количество числел массива : ");
//   int number = int.Parse(Console.ReadLine());
//   int[] Array = new int[number];
//          Random rand = new Random();
//          Console.Write("это ваш массив: ");
//           for (int i = 0; i < Array.Length; i++)
//        {
//          Array[i] = rand.Next(100,1000);
//          Console.Write($"{Array[i]}, " );
//         if(Array[i] % 2 == 0)
//         {
//          count++;
//         }
//         }
//      System.Console.WriteLine();
//      Console.WriteLine ($"а количество чётных числел в нём: {count} ");
//   return;
//   }
//  NewArray();

// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// void NewArray()
//  {
//     System.Console.WriteLine("Здравствуйте, очень приятно видеть вас на второй задече, она покажет сумму элементов массива на нечетных позициях(но я сделал еще и для чётных) пусть будет");
//     System.Console.WriteLine("Не забудте пожалуйста после просмотра задачи оставить свой отзыв, для меня это важно!");
//     int result = 0;
//     int result2 = 0;
//      Console.Write("Введите количество числел массива, а мы посчитаем сумму чётных и нечётных элементов: ");
//  int number = int.Parse(Console.ReadLine());
//  int[] Array = new int[number];
//         Random rand = new Random();
//           Console.Write("это ваш массив: ");
//          for (int i = 0; i < Array.Length; i++)
//       {
//        Array[i] = rand.Next(1, 10); //цифры взяты для примера что бы удобнее было считать)))
//          Console.Write(Array[i] + "," );
//          if(i % 2 == 0)
//          {
//            result = result + Array[i];
//          }
//          if(i % 2 != 0)
//          {
//            result2 = result2 + Array[i];
//          }
//       }
// System.Console.WriteLine();
// System.Console.WriteLine($"сумма всех элементов на нечетных позициях: {result}");
// System.Console.WriteLine($"сумма всех элементов на чётных позициях: {result2}");
//       return;
//  }
//  NewArray();


// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// void NewArray()
//   {
//       Console.WriteLine("И снова здравствуйте! Вы дошли уже до третьей задачи(и пока надеюсь ошибок нет) надеюсь эта задача вам понравиться");
//       Console.WriteLine("в этой задаче возникали трудности, но главное что правильное решение вывелось, попробуйте сами))");
//       Console.WriteLine("Не забудте пожалуйста после просмотра задачи оставить свой отзыв, для меня это важно!");
//       Console.Write("Введите количество числел массива, а мы посчитаем разницу между максимальным значением и минимальным: ");
//  int number = int.Parse(Console.ReadLine());
//  double result = 0;
//   double[] Array = new double[number];
//          Random rand = new Random();
//            Console.Write("это ваш массив: ");//выведу вертикально для наглядности))
//           for (int i = 0; i < Array.Length; i++)
//        {
//         Array[i] = rand.NextDouble();
//           Console.WriteLine(Math.Round(Array[i],4));
//        }
// double MinNumber = Array[0];
//          for (int i = 0; i < Array.Length; i++){

//           if(Array[i] < MinNumber)
//           {
//             MinNumber = Array[i];
//           }
//          }
// double MaxNumber = Array[0];
//          for (int i = 0; i < Array.Length; i++){

//           if(Array[i] > MaxNumber)
//           {
//             MaxNumber = Array[i];
//           }
//          }
//          result = MaxNumber - MinNumber;
//        Console.WriteLine("разница между минимальным и максимальным значением:  " + Math.Round(result,4));// спасибо за помощь с Math.Round очень помогло)))
//        Console.WriteLine("не буду спорить что можно решить задачу легче и оптимальнее, но я так смог");
//   return;
//   }
//   NewArray();