namespace depi_day5
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                while (true)
                {
                    Console.Clear();

                    Console.WriteLine("--------------------------");
                    Console.WriteLine(" C# Tasks - Part 01 & 02");
                    Console.WriteLine("--------------------------");

                    Console.WriteLine("\n--- Part 01 ---");
                    Console.WriteLine("1. Divide Two Integers");
                    Console.WriteLine("2. Test Defensive Code");
                    Console.WriteLine("3. Nullable Integer");
                    Console.WriteLine("4. Array Out of Bounds");
                    Console.WriteLine("5. 3x3 Array - Row & Column Sum");
                    Console.WriteLine("6. Jagged Array");
                    Console.WriteLine("7. Nullable Reference Types");
                    Console.WriteLine("8. Boxing & Unboxing");
                    Console.WriteLine("9. SumAndMultiply - out");
                    Console.WriteLine("10. Optional & Named Parameters");
                    Console.WriteLine("11. Nullable Array & ?. ");
                    Console.WriteLine("12. Switch Expression");
                    Console.WriteLine("13. Params - SumArray");

                    Console.WriteLine("\n--- Part 02 ---");
                    Console.WriteLine("14. Print Numbers in Range");
                    Console.WriteLine("15. Multiplication Table");
                    Console.WriteLine("16. Even Numbers");
                    Console.WriteLine("17. Exponentiation");
                    Console.WriteLine("18. Reverse Text");
                    Console.WriteLine("19. Reverse Integer");
                    Console.WriteLine("20. Longest Distance Between Matching Elements");
                    Console.WriteLine("21. Reverse Words in Sentence");

                    Console.WriteLine("\n0. Exit");

                    Console.Write("\nChoose a problem: ");
                    string choice = Console.ReadLine();

                    Console.Clear();

                    switch (choice)
                    {
                        case "1":
                            DivideNumbers();
                            break;

                        case "2":
                            TestDefensiveCode();
                            break;

                        case "3":
                            NullableInteger();
                            break;

                        case "4":
                            ArrayOutOfBounds();
                            break;

                        case "5":
                            Array3x3();
                            break;

                        case "6":
                            JaggedArray();
                            break;

                        case "7":
                            NullableReferenceTypes();
                            break;

                        case "8":
                            BoxingUnboxing();
                            break;

                        case "9":
                            SumAndMultiply();
                            break;

                        case "10":
                            OptionalNamedParameters();
                            break;

                        case "11":
                            NullableArray();
                            break;

                        case "12":
                            SwitchExpression();
                            break;

                        case "13":
                            ParamsExample();
                            break;

                        case "14":
                            PrintNumbers();
                            break;

                        case "15":
                            MultiplicationTable();
                            break;

                        case "16":
                            EvenNumbers();
                            break;

                        case "17":
                            Exponentiation();
                            break;

                        case "18":
                            ReverseText();
                            break;

                        case "19":
                            ReverseInteger();
                            break;

                        case "20":
                            LongestDistance();
                            break;

                        case "21":
                            ReverseWords();
                            break;

                        case "0":
                            return;

                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }

                  
                    Console.WriteLine("\n\nPress any key to return to the menu...");
                    Console.ReadKey();
                }
            }


            
            // PART 01
           
            // 1. Divide Two Integers
            static void DivideNumbers()
            {
                Console.Write("Enter first integer: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Enter second integer: ");
                int y = int.Parse(Console.ReadLine());

                try
                {
                    int result = x / y;
                    Console.WriteLine("Result = " + result);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero.");
                }
                finally
                {
                    Console.WriteLine("Operation complete");
                }
            }


            // 2. Test Defensive Code
            static void TestDefensiveCode()
            {
                Console.Write("Enter X: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Enter Y: ");
                int y = int.Parse(Console.ReadLine());

                if (x <= 0)
                {
                    Console.WriteLine("X must be a positive integer.");
                    return;
                }

                if (y <= 1)
                {
                    Console.WriteLine("Y must be greater than 1.");
                    return;
                }

                Console.WriteLine("X = " + x);
                Console.WriteLine("Y = " + y);
                Console.WriteLine("The values are valid.");
            }


            // 3. Nullable Integer
            static void NullableInteger()
            {
                int? number = null;

                int result = number ?? 100;

                Console.WriteLine("Default value: " + result);

                if (number.HasValue)
                {
                    Console.WriteLine("Value exists: " + number.Value);
                }
                else
                {
                    Console.WriteLine("Number is null.");
                }

                number = 50;

                if (number.HasValue)
                {
                    Console.WriteLine("Value: " + number.Value);
                }
            }


            // 4. Array Out of Bounds
            static void ArrayOutOfBounds()
            {
                int[] numbers = new int[5];

                try
                {
                    numbers[5] = 10;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Index is out of range.");
                }
            }


            // 5. 3x3 Array
            static void Array3x3()
            {
                int[,] numbers = new int[3, 3];

                Console.WriteLine("Enter 9 values:");

                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    for (int j = 0; j < numbers.GetLength(1); j++)
                    {
                        Console.Write($"Element [{i},{j}]: ");
                        numbers[i, j] = int.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("\nRow sums:");

                for (int i = 0; i < numbers.GetLength(0); i++)
                {
                    int sum = 0;

                    for (int j = 0; j < numbers.GetLength(1); j++)
                    {
                        sum += numbers[i, j];
                    }

                    Console.WriteLine($"Row {i + 1} = {sum}");
                }

                Console.WriteLine("\nColumn sums:");

                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    int sum = 0;

                    for (int i = 0; i < numbers.GetLength(0); i++)
                    {
                        sum += numbers[i, j];
                    }

                    Console.WriteLine($"Column {j + 1} = {sum}");
                }
            }


            // 6. Jagged Array
            static void JaggedArray()
            {
                int[][] numbers = new int[3][];

                numbers[0] = new int[2];
                numbers[1] = new int[3];
                numbers[2] = new int[4];

                for (int i = 0; i < numbers.Length; i++)
                {
                    Console.WriteLine($"Enter values for row {i + 1}:");

                    for (int j = 0; j < numbers[i].Length; j++)
                    {
                        Console.Write($"Element [{i}][{j}]: ");
                        numbers[i][j] = int.Parse(Console.ReadLine());
                    }
                }

                Console.WriteLine("\nJagged Array:");

                
                for (int i = 0; i < numbers.Length; i++)
                {
                    for (int j = 0; j < numbers[i].Length; j++)
                    {
                        Console.Write(numbers[i][j] + " ");
                    }

                    Console.WriteLine();
                }
            }


            // 7. Nullable Reference Types
            static void NullableReferenceTypes()
            {
                string? name = null;

                Console.Write("Do you want to enter your name? (yes/no): ");
                string? answer = Console.ReadLine();

                if (answer == "yes")
                {
                    Console.Write("Enter your name: ");
                    name = Console.ReadLine();
                }

                if (name != null)
                {
                    Console.WriteLine("Hello, " + name);
                }
                else
                {
                    Console.WriteLine("No name was entered.");
                }

                string nameWithoutWarning = name!;

                Console.WriteLine("Name using !: " + nameWithoutWarning);
            }


            // 8. Boxing & Unboxing
            static void BoxingUnboxing()
            {
                int number = 100;

                // Boxing
                object obj = number;

                Console.WriteLine("Boxed value: " + obj);

                // Unboxing
                int value = (int)obj;

                Console.WriteLine("Unboxed value: " + value);

                try
                {
                    string text = (string)obj;
                }
                catch (InvalidCastException)
                {
                    Console.WriteLine("Invalid cast: Cannot cast int to string.");
                }
            }


            // 9. SumAndMultiply using out
            static void SumAndMultiply()
            {
                Console.Write("Enter first number: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                int y = int.Parse(Console.ReadLine());

                int sum;
                int product;

                Calculate(x, y, out sum, out product);

                Console.WriteLine("Sum = " + sum);
                Console.WriteLine("Product = " + product);
            }

            static void Calculate(int x, int y, out int sum, out int product)
            {
                sum = x + y;
                product = x * y;
            }


            // 10. Optional & Named Parameters
            static void OptionalNamedParameters()
            {
                PrintText(text: "Hello", times: 3);

                Console.WriteLine();

                PrintText(text: "C#");
            }

            static void PrintText(string text, int times = 5)
            {
                for (int i = 0; i < times; i++)
                {
                    Console.WriteLine(text);
                }
            }


            // 11. Nullable Array & Null Propagation
            static void NullableArray()
            {
                int[]? numbers = null;

                int? length = numbers?.Length;

                Console.WriteLine("Array length: " + length);

                numbers = new int[] { 10, 20, 30 };

                length = numbers?.Length;

                Console.WriteLine("Array length: " + length);
            }


            // 12. Switch Expression
            static void SwitchExpression()
            {
                Console.Write("Enter a day: ");
                string day = Console.ReadLine();

                int number = day.ToLower() switch
                {
                    "monday" => 1,
                    "tuesday" => 2,
                    "wednesday" => 3,
                    "thursday" => 4,
                    "friday" => 5,
                    "saturday" => 6,
                    "sunday" => 7,
                    _ => 0
                };

                if (number == 0)
                {
                    Console.WriteLine("Invalid day.");
                }
                else
                {
                    Console.WriteLine("Day number = " + number);
                }
            }


            // 13. Params
            static void ParamsExample()
            {
                int result1 = SumArray(1, 2, 3, 4, 5);

                Console.WriteLine("Sum of individual values = " + result1);

                int[] numbers = { 10, 20, 30 };

                int result2 = SumArray(numbers);

                Console.WriteLine("Sum of array = " + result2);
            }

            static int SumArray(params int[] numbers)
            {
                int sum = 0;

                foreach (int number in numbers)
                {
                    sum += number;
                }

                return sum;
            }


           
            // PART 02
         
           // 14. Print Numbers in Range
            static void PrintNumbers()
            {
                Console.Write("Enter a positive integer: ");
                int number = int.Parse(Console.ReadLine());

                for (int i = 1; i <= number; i++)
                {
                    Console.Write(i);

                    if (i < number)
                    {
                        Console.Write(", ");
                    }
                }
            }


            // 15. Multiplication Table
            static void MultiplicationTable()
            {
                Console.Write("Enter an integer: ");
                int number = int.Parse(Console.ReadLine());

                for (int i = 1; i <= 12; i++)
                {
                    Console.Write(number * i);

                    if (i < 12)
                    {
                        Console.Write(", ");
                    }
                }
            }


            // 16. Even Numbers
            static void EvenNumbers()
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                for (int i = 1; i <= number; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write(i + " ");
                    }
                }
            }


            // 17. Exponentiation
            static void Exponentiation()
            {
                Console.Write("Enter the base: ");
                int baseNumber = int.Parse(Console.ReadLine());

                Console.Write("Enter the exponent: ");
                int exponent = int.Parse(Console.ReadLine());

                int result = 1;

                for (int i = 1; i <= exponent; i++)
                {
                    result *= baseNumber;
                }

                Console.WriteLine("Result = " + result);
            }


            // 18. Reverse Text
            static void ReverseText()
            {
                Console.Write("Enter a string: ");
                string text = Console.ReadLine();

                string reversed = "";

                for (int i = text.Length - 1; i >= 0; i--)
                {
                    reversed += text[i];
                }

                Console.WriteLine("Reversed = " + reversed);
            }


            // 19. Reverse Integer
            static void ReverseInteger()
            {
                Console.Write("Enter an integer: ");
                int number = int.Parse(Console.ReadLine());

                int reversed = 0;

                while (number != 0)
                {
                    int digit = number % 10;
                    reversed = reversed * 10 + digit;
                    number /= 10;
                }

                Console.WriteLine("Reversed = " + reversed);
            }


            // 20. Longest Distance Between Matching Elements
            static void LongestDistance()
            {
                Console.Write("Enter array size: ");
                int n = int.Parse(Console.ReadLine());

                int[] numbers = new int[n];

                Console.WriteLine("Enter array elements:");

                for (int i = 0; i < n; i++)
                {
                    Console.Write($"Element {i + 1}: ");
                    numbers[i] = int.Parse(Console.ReadLine());
                }

                int maxDistance = 0;

                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (numbers[i] == numbers[j])
                        {
                            int distance = j - i - 1;

                            if (distance > maxDistance)
                            {
                                maxDistance = distance;
                            }
                        }
                    }
                }

                Console.WriteLine("Longest distance = " + maxDistance);
            }


            // 21. Reverse Words in Sentence
            static void ReverseWords()
            {
                Console.Write("Enter a sentence: ");
                string sentence = Console.ReadLine();

                string[] words = sentence.Split(' ');

                Array.Reverse(words);

                Console.WriteLine(string.Join(" ", words));
            }
        }
    }
    
