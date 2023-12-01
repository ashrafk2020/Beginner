
using System.Diagnostics;
using System.Net.Mime;
using System.Net;
using System.IO;
using System.Security.Cryptography;
using System.Data;
using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Collections.Immutable;
using System.Text;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using CsharpFundamentals;

namespace Learn
{
    class Car
    {
        string model = "";
        public Car(string model)
        {
            this.model = model;
        }
    }

     public class Person
        {
            public int age;
            public void ShowAge()
            {
                System.Console.WriteLine($"my age is {age}");
            }

        }
    
    public enum ShippingMethode
    {
        RegularAirMail,
        RegisteredAirMail,
        Express
    }       

    public enum Seasons
    {
        Spring,
        Summer,
        Automn,
        Winter
    } 


    class Program
    {
        static void Main(string[] args)
        {
            #region lecture 1
            // var nubmer = 255;

            // // Boolean bool =  false;
            // for (int i = 0; i < 5; i++)
            // {
            //      Console.WriteLine($"int value{nubmer}");

            //     // checked
            //     // {
            //     //     nubmer++;
            //     // }
            //      Console.WriteLine("Hello World!");
            //     //  intShort++;
            //      Console.WriteLine($"int value{nubmer}");
            //      System.Console.WriteLine("HHHHelo World");
            // }


            #endregion
            #region Variables and Constants
            // System.Console.WriteLine("{0} {1}",byte.MinValue, byte.MaxValue);
            // System.Console.WriteLine("{0} {1}",float.MinValue, float.MaxValue);
            // const Pi = 3.14f;
            #endregion
            #region  Conversion           

            // string  text = "15";
            // int newValue = int.Parse(text);
            // Console.WriteLine($"{newValue}");

            // byte b = 2;
            // int a = (int) b;
            // System.Console.WriteLine(a);
            // try
            // {
            //    int d = 12222;

            //    byte f = Convert.ToByte(d);

            //    System.Console.WriteLine(f);
            // }
            // catch (System.Exception)
            // {
            //     System.Console.WriteLine("value is to large to be saves!");
            // }

            // var newNumber = "12345";
            // int i = Convert.ToInt32(newNumber);
            // System.Console.WriteLine(i);
            // try
            // {
            //      string st = "false";
            //     bool bb = Convert.ToBoolean(st);
            //     bool state = false;
            //     bool outbool = bb==true?true:false;
            //     System.Console.WriteLine(outbool);
            // }
            // catch (System.Exception)
            // {

            //    System.Console.WriteLine("can not expliacitly convert the value");
            // }

            #endregion
            #region  Operators
            // int a = 7 ;
            // int b = 3;
            // int c = 9;
            // System.Console.WriteLine(!(a!=b));
            // System.Console.WriteLine(c > b && c==a);
            #endregion
            #region  Classed
            // Person ahmed = new Person("ahmed kamal");
            // Person omar = new Person("omar ashraf mostafa");
            // Person khaled = new Person("Khaled ghandour");
            // ahmed.Introduce();
            // omar.Introduce();
            // khaled.Introduce();
            // System.Console.WriteLine(Person.nationality);
            // Person.nationality = "American";
            // System.Console.WriteLine(Person.nationality);
            // System.Console.WriteLine(Calculator.Add(20 , 50));
            #endregion  , 
            #region  Struct

            //struct is value type and class is a refrence type

            // var slotData = new SlotData(37 , 15);
            // slotData.PrintSlotData();
            // ModifySlotData(out slotData , 7 , 5);
            // slotData.PrintSlotData();


            // var classSlotData = new ClassSlotData(37 , 15);
            // classSlotData.PrintClassSlotData();
            // ModifyClassSlotData(classSlotData , 7 , 5);
            // classSlotData.PrintClassSlotData();
            // ModifyClassSlotData(classSlotData , 555 , 1115);
            // classSlotData.PrintClassSlotData();

            #endregion
            #region  Array
            // int[] numbers = new int[3]{1,2,3};
            // numbers[0] = 3;
            // numbers[1] = 6;
            // numbers[2] = 9;
            // for (int i = 0; i < 3; i++)
            // {
            //      System.Console.WriteLine($"{ numbers[i]}");
            // }
            // bool[] flags = new bool[5];
            // for (int i = 0; i < 5; i++)
            // {
            //     System.Console.WriteLine(flags[i]);
            // }

            #endregion
            #region  String
            //             string firstName = "ashraf";
            //             string lastName = "Kamal";
            //             string name = string.Format("{0} {1}", firstName , lastName);
            //             System.Console.WriteLine(name);

            //             var numbers = new int[3]{1,2,4};
            //             string list = string.Join(",",numbers);
            //             System.Console.WriteLine(list);
            //             string text = @"name:ashraf Mostafa Kamal
            // AGE : 37
            // Adress: Zaher Galal- Marsa Matrouh";
            //             System.Console.WriteLine(text);


            #endregion
            #region  Enum
            // ShippingMethode methode  = ShippingMethode.Express;
            //cast enum to int
            // Console.WriteLine((int)methode);
            /*    int methodeID = 1;
                //Get enum value from an index
                System.Console.WriteLine((ShippingMethode) methodeID);
                // Convert enum   to string
                // System.Console.WriteLine(methode.ToString());
                // How to convert string to ENUM
                string methodeName = "Express";
                var methode = (ShippingMethode) Enum.Parse(typeof(ShippingMethode) , methodeName);
                System.Console.WriteLine(methode);
             */
            #endregion
            #region  Refrence type and value type
            /*
            int firstNumber = 5;
            int secondNumber = firstNumber;
            secondNumber = 8;
            System.Console.WriteLine(string.Format("firstNumber {0} , secondNumber {1} ",firstNumber , secondNumber));

            int[] firstArray = new int[3]{5,6,7};
            var secondArray = firstArray;
            secondArray[1] = 999 ;
            System.Console.WriteLine($"firstArray indexxx {firstArray[1]} , secondArray indexxx {secondArray[1]}");
           */
            /*   Person person = new Person(){age = 10};
                MakeOld(person);
                person.ShowAge();
    */
            #endregion
            #region  Conditional statmeent
            #region  if statement
            // int hour = 19;
            // if(hour > 0 && hour < 12)
            // {
            //     System.Console.WriteLine("its morning");
            // }
            // else if(hour >12 && hour < 18)
            // {
            //     System.Console.WriteLine("its afternoon");
            // }
            // else
            // {
            //     System.Console.WriteLine("its evening");
            // }

            // bool isGoldenCustomer = true;
            // float price = 0;
            // if(isGoldenCustomer)
            // {
            //     price = 19.9f;
            // }
            // else
            // {
            //     price = 29.9f;
            // }
            // price = isGoldenCustomer == false ? 19.9f : 29.9f;
            // System.Console.WriteLine($"Price is {price}");
            #endregion
            #region  switch statement
            // Seasons[] seasonArray = new Seasons[4]{Seasons.Automn , Seasons.Summer , Seasons.Spring , Seasons.Winter};
            // int randomIndex = 3;
            // Seasons season = seasonArray[randomIndex];
            // switch (season)
            // {
            //     case Seasons.Automn:
            //     System.Console.WriteLine("its automn and a beautiful season");
            //     break;
            //     case Seasons.Summer:
            //          System.Console.WriteLine("its perfect to go to beach");
            //       break;
            //        case Seasons.Spring:
            //          System.Console.WriteLine("its wonderful today , take some flowers");
            //       break;
            //        case Seasons.Winter:
            //          System.Console.WriteLine("its rainy out there take cover");
            //       break;
            //     default:
            //     break;

            // }
            //     System.Console.WriteLine(season.ToString());

            #endregion
            #endregion
            #region iteration statment

            #region for  loop
            // for (int i = 10; i >0 ; i--)
            // {
            //     if(i%2 == 0)
            //     {
            //         System.Console.WriteLine(i);
            //     }
            // }
            // for (int i = 0; i <10 ; i++)
            // {
            //     if(i%2 != 0)
            //     {
            //         System.Console.WriteLine(i);
            //     }
            // }



            #endregion
            #region foreach loop

            // var  name = "Ashraf Mostafa Kamal Mohammed Abdallah Elhammahmy";
            // int lettersCount = 0;
            // foreach (char letter in name)
            // {
            //     // if(letter !=' ')
            //     // {
            //         lettersCount++;
            //         System.Console.WriteLine(letter);

            //     // }

            // }
            // for (int i = 0; i < name.Length; i++)
            // {
            //     System.Console.WriteLine(name[i]);
            // }

            // // System.Console.WriteLine($"letters Count is {lettersCount}");
            // int[] numbers = new int[]{1,2,3,4};

            // foreach (int number in numbers)
            // {
            //     System.Console.WriteLine(number);
            // }


            #endregion
            #region while loop

            // int counter = 0;
            // while (counter < 10)
            // {
            //     if(counter%2==0)
            //     {
            //         System.Console.WriteLine(counter);
            //     }
            //     counter++;
            // }
            // do
            // {
            //      if(counter%2==0)
            //     {
            //         System.Console.WriteLine(counter);
            //     }
            //     counter--;
            // } while (counter>0);

            // while (true)
            // {
            //     System.Console.Write("Type your name ");
            //     var name =  Console.ReadLine();
            //     if(!string.IsNullOrWhiteSpace(name))
            //     {
            //         System.Console.WriteLine($"Hello {name}");
            //         continue;
            //     }
            //     break;

            // }


            #endregion

            #endregion
            #region  Random Class

            //generate random password
            //Get random length
            // make the password hard with random letters A ,a , ! ,2

            // Character[] characterType = new Character[]{Character.Capital , Character.Small , Character.Number,
            //                                             Character.Symbole};


            // Random random = new Random();
            // Random randomCharacterIndex = new Random();
            // const int passwordLenght = 10;
            // char[] buffer = new char[passwordLenght];

            // for (int i = 0; i < passwordLenght; i++)
            // {
            //     var index = randomCharacterIndex.Next(0 , 4);

            //     Character charChosen = characterType[index];
            //     // char randomLetter  =' ';
            //     switch (charChosen)
            //     {
            //         case Character.Capital:
            //         buffer[i] = (char)random.Next(65 , 90);

            //         break;

            //         case Character.Small :
            //           buffer[i] = (char)('a'+ random.Next(0 , 26));
            //         break;

            //         case Character.Number:
            //          buffer[i] = (char)random.Next(48 , 57);

            //         break;

            //         case Character.Symbole:
            //             buffer[i] = (char)random.Next(33 , 47);

            //         break;

            //         default:
            //         break;
            //     }

            //     //  System.Console.Write(randomLetter);

            // }
            // var password = new string(buffer);
            // System.Console.WriteLine(password);
            // System.Console.WriteLine();


            #endregion

            /* #region  excersice #1
             int counter = 0;
             int[] numbersArray = new int[100];
             for (int i = 1; i < 100; i++)
             {
                 if(i%3 == 0)
                 {
                     numbersArray[counter] = i;
                     counter++;
                 } 
             }      
             System.Console.WriteLine($"numbers dividable to 3 count are :{counter}");
             for (int i = 0; i < counter; i++)
             {
                  System.Console.Write(numbersArray[i]);
               System.Console.Write(" ");
             }

             #endregion */

            /*  #region  excersice #2
              int numbersSum = 0;
              while(true)
              {
                  System.Console.WriteLine("Enter a Number");
                  string enteredNumber = Console.ReadLine();
                  if(enteredNumber == "ok")
                  {
                      break;
                  }
                  numbersSum +=Convert.ToInt32(enteredNumber);
                  System.Console.WriteLine($"sum is  {numbersSum}");
              }
              #endregion*/
            /*
           #region  excersice #3

           System.Console.WriteLine("enter a number");
           int number = Convert.ToInt32(System.Console.Read()) - 48;
           System.Console.WriteLine($"entered number is{number}");
           int[] numbersList = new int[number];
           for (int i = number; i > 0; i--)
           {
               numbersList[i-1] = i;
           }
             int factorial = 1;
           foreach (var item in numbersList)
           {
              factorial *= item;
           }
           System.Console.WriteLine($"{number}! = {factorial}");


           #endregion
 */
            /* #region  excersice #4
              int randomNumber;
              Random random = new Random();
              randomNumber = random.Next(1,10);
              int numOfTries = 0;
              int maxTries =4; 
              while (true)
              {
                  System.Console.WriteLine($"You Have {maxTries-numOfTries} of tries");
                  System.Console.WriteLine($"{randomNumber} Pick A number between 1 , 10");
                  int gussedNumber = Convert.ToInt32(System.Console.ReadLine());
                  if(gussedNumber != randomNumber)
                  {
                      numOfTries ++;
                      if(numOfTries >= maxTries)
                      {
                          System.Console.WriteLine("YouLost");
                          break;
                      }

                  }
                  else
                  {
                      System.Console.WriteLine("You Win");
                       break;
                  }
              }

              #endregion
               */
            /*  #region  Excersice #5
              System.Console.WriteLine("Write a series of numbers separated by a comma");
              string series = Console.ReadLine();
              int[] numbersList = new int[10];
              int numberIndex = 0;
              Dictionary <int , int> dictionary = new Dictionary<int , int>{};
              int[] numberListReference = new int[10]{48,49,50,51,52,53,54,55,56,57};
              for (int i = 0; i < 10; i++)
              {
                  dictionary[numberListReference[i]] = i;
              }

              foreach (char character in series)
              {
                  if((int)character == 44) continue;
                  // numbersList[numberIndex] = dictionary[Convert.ToInt16(character)];
                  numbersList[numberIndex] = Convert.ToInt16(character)- 48;

                  numberIndex++;
              }

              int maxValue = int.MinValue;
              foreach (var number in numbersList)
              {
                  System.Console.Write(number);
                  System.Console.Write(" ");
                  if(number > maxValue)
                  {
                      maxValue = number;
                  }
              }


              System.Console.WriteLine($"Max value is {maxValue}");

             #endregion */

            //  old other exercises
            #region Exercises Write a program and ask the user to enter a number. The number should be between 1 to 10. 
            // while (true)
            // {
            //     System.Console.WriteLine("Enter a valid number between 1 , 10 ");
            //     string valueEntered = Console.ReadLine();
            //     int number = Convert.ToInt32(valueEntered);
            //     if (number < 1 || number >10 )
            //     {
            //         System.Console.WriteLine("Invalid");
            //         break;
            //     }
            //     else
            //     {
            //         System.Console.WriteLine("Valid");
            //          break;
            //     }
            // }


            #endregion

            #region Exercise Write a program which takes two numbers from the console and displays the maximum of the two.

            // while (true)
            // {
            //     System.Console.WriteLine("Enter First number");
            //     string firstNumber = Console.ReadLine();
            //     System.Console.WriteLine("Enter Second number");
            //     string secondNumber = Console.ReadLine();

            //     if(int.Parse(firstNumber) > int.Parse(secondNumber))
            //     {
            //         System.Console.WriteLine($"biggest number is {firstNumber}");
            //     }
            //     else if(int.Parse(secondNumber)> int.Parse(firstNumber))
            //     {
            //         System.Console.WriteLine($"biggest number is {secondNumber}");
            //     }
            //     else
            //     {
            //         System.Console.WriteLine("Both numbered are rqualed!");
            //     }
            //     break;

            // }
            #endregion



            #region  Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.
            // while (true)
            // {
            //     System.Console.WriteLine("Enter the width of Image");
            //     string width = Console.ReadLine();
            //     System.Console.WriteLine("Enter height of image");
            //     string heigh = Console.ReadLine();

            //     if (int.Parse(width) > int.Parse(heigh))
            //     {
            //         System.Console.WriteLine($"the image is landscape");
            //     }

            //     else
            //     {
            //         System.Console.WriteLine($"the image is Portrait");

            //     }
            //     break;

            // }


            #endregion

            #region write a program for a speed camera

            //    bool licenceSuspended = false;

            //     while (!licenceSuspended)
            //     {
            //         System.Console.WriteLine("Enter the speed limit");
            //         string speedLimit = Console.ReadLine();
            //         int speedLimitInt = int.Parse(speedLimit);
            //         System.Console.WriteLine("Enter the speed of the car");
            //         string carSpeed = Console.ReadLine();
            //         int carSpeedInt = int.Parse(carSpeed);

            //         System.Console.WriteLine($"{speedLimitInt} {carSpeedInt}");
            //         if (carSpeedInt < speedLimitInt)
            //         {
            //             System.Console.WriteLine("OK");
            //         }
            //         else
            //         {
            //             licenceSuspended = CalculateDemeritPoints(carSpeedInt, speedLimitInt);

            //         }
            //     }



            #endregion

            #region  array

            // var numbers = new[] {3,7,9,2,14,6};
            // var names = new[]{"ashraf" , "Omar" , "Assem" , "Kamal" , "Mohammed"};
            // //length property
            // System.Console.WriteLine(numbers.Length);
            // // IndexOf()
            // System.Console.WriteLine(Array.IndexOf(numbers,9));
            // System.Console.WriteLine(Array.IndexOf(names,2));
            // // Clear()
            // Array.Clear(numbers, 0, 2);
            // // foreach (var number in numbers)
            // // {
            // //     System.Console.WriteLine($"Value is {number}");
            // // }

            // System.Console.WriteLine(" -------------------");

            // foreach (var name in names)
            // {
            //     System.Console.WriteLine($"Name is {name}");

            // }

            // System.Console.WriteLine(" -------------------");

            // Array.Clear(names, 0, 3);
            // foreach (var name in names)
            // {
            //     if(String.IsNullOrEmpty(name)) continue;
            //     System.Console.WriteLine($"Name is {name}");

            // }
            // //Copy
            // var anotherArray = new[]{0,1,2};
            // Array.Copy(numbers, anotherArray , 3);
            // System.Console.WriteLine(" Copy-------------------");

            // foreach (var n in anotherArray)
            // {
            //     System.Console.WriteLine(n);
            // }

            // System.Console.WriteLine("Sort -------------------");
            // Array.Sort(numbers);
            // foreach (var n in numbers)
            // {
            //     System.Console.WriteLine(n);

            // }

            // Array.Reverse(numbers);
            // System.Console.WriteLine("Reverse -------------------");

            // foreach (var n in numbers)
            // {
            //     System.Console.WriteLine(n);

            // }

            #endregion
            #region  Lists
            // List<int> numbers = new List<int>(){1,2,3,4};
            // numbers.Add(1);
            // numbers.AddRange(new int[3]{5,6,7});

            // foreach (int number in numbers)
            // {
            //     System.Console.WriteLine(number);
            // }

            // System.Console.WriteLine(numbers.LastIndexOf(1));
            // System.Console.WriteLine(numbers.Count);
            // // numbers.Remove(1);

            // System.Console.WriteLine("---------------------");
            // List<int> iteration = new List<int>(numbers);
            // foreach (var number in iteration)
            // {
            //     if(number == 1)
            //     {
            //         numbers.Remove(number);
            //     }

            // }

            // System.Console.WriteLine("remover some values---------------------");

            // foreach (var item in numbers)
            // {
            //     System.Console.WriteLine(item);
            // }

            // //can use for loop to achieve same results

            // numbers.Clear();
            // System.Console.WriteLine("list count is " + numbers.Count);
            #endregion
            // exercise on lists #1
            #region exercise on lists #1
            // List<string> names = new List<string>();
            // while (true)
            // {
            //     System.Console.WriteLine("Enter Name");
            //     string name = Console.ReadLine();
            //     if(string.IsNullOrWhiteSpace(name))
            //     {
            //         break;
            //     }
            //     names.Add(name);
            // }
            // DisplayLikesInformation(names);
            #endregion
            #region exercise 2

            // System.Console.WriteLine("Enter your name");
            // string name = Console.ReadLine();
            // char[] charArray =  name.ToCharArray();
            // Array.Reverse(charArray);

            // string newName = new string(charArray);
            // System.Console.WriteLine(newName);





            #endregion
            #region  EX 3

            // List<int> numbersList = new List<int>();
            // while (numbersList.Count <5)
            // {   
            //     System.Console.WriteLine("Enter Number");
            //     int number = int.Parse(System.Console.ReadLine());
            //     if(numbersList.Contains(number))
            //     {
            //         System.Console.WriteLine("Error , retry");
            //     }
            //     else
            //     {
            //         numbersList.Add(number);


            //     }
            // }

            // numbersList.Sort();
            // foreach (var nubmer in numbersList)
            // {
            //      System.Console.Write(nubmer);
            //       System.Console.Write(" ");
            // }
            #endregion
            #region  EX 4 filter numbers inputs

            // List<int> numbersList = new List<int>();
            // while (true)
            // {   
            //     System.Console.WriteLine("Enter Number or Quit");
            //     string enteredData = Console.ReadLine();
            //     if(enteredData =="Quit") break;
            //     if(int.TryParse(enteredData , out int  number))
            //     {


            //         numbersList.Add(number);


            //     }
            //     else
            //     {
            //         Console.WriteLine("Invalid input. Please enter a valid number or type 'Quit' to exit.");
            //     }

            // }

            // foreach (var item in numbersList)
            // {
            //     System.Console.Write(" ");    

            //     System.Console.Write(item);
            // }
            // System.Console.WriteLine("   ");

            // System.Console.WriteLine("filtered --------- ");

            // List<int> filteredListNumbers = new List<int>();


            // foreach (int number in numbersList)
            // {
            //     int counter = 0;

            //     for (int i = 0; i < numbersList.Count; i++)
            //     {
            //         if (number == numbersList[i])
            //         {
            //             counter++;
            //         }

            //     }
            //     if (counter < 2)
            //     {
            //         filteredListNumbers.Add(number);
            //     }
            // }



            // System.Console.WriteLine("   ");
            // foreach (var item in filteredListNumbers)
            // {
            //     System.Console.Write(" ");    

            //     System.Console.Write(item);    
            // }



            #endregion
            #region  EX 5 Comma seperate numbers sequence
            // List<int> numbersList = new List<int>();
            // while (true)
            // {
            //     System.Console.WriteLine("Enter a list of comma separate numbers");
            //     string userInput = Console.ReadLine();
            //     List<int> convertedDecimil = new List<int>();

            //     foreach (var character in userInput)
            //     {
            //         if(character !=44)
            //         {
            //             convertedDecimil.Add(Convert.ToInt32(character)-48);
            //         }
            //         else
            //         {
            //             int numberDigits = convertedDecimil.Count;
            //             switch (numberDigits)
            //             {
            //                 case 1:
            //                 numbersList.Add(convertedDecimil[0]);
            //                 break;

            //                 case 2:
            //                 numbersList.Add(convertedDecimil[0] * 10 + convertedDecimil[1] * 1);
            //                 break;

            //                 case 3:
            //                 numbersList.Add(convertedDecimil[0] * 100 + convertedDecimil[1] + 10 * convertedDecimil[2]);
            //                 break;

            //                 case 4:
            //                 numbersList.Add(convertedDecimil[0] * 1000 + convertedDecimil[1] * 100 + convertedDecimil[2] * 10 + convertedDecimil[3]  * 1);
            //                 break;


            //             }
            //             convertedDecimil.Clear();


            //         }

            //     }
            //     if(numbersList.Count < 5 || numbersList == null)
            //     {
            //         System.Console.WriteLine("Invalid List");
            //         numbersList.Clear();
            //     }
            //     else
            //     {
            //         break;
            //     }

            // }
            // numbersList.Sort();
            // for (int i = 0; i < numbersList.Count; i++)
            // {
            //     System.Console.WriteLine(numbersList[i]);
            // }

            //chat solution

            // Console.Write("Enter a list of comma-separated numbers (e.g., 5,1,9,2,10): ");
            // string input = "12,13,15,16,17,18,19,20,33";

            // // Split the input string into an array of strings, using ',' as the delimiter.
            // string[] numberStrings = input.Split(',');

            // // Check if there are at least 5 numbers in the input.
            // if (numberStrings.Length < 5)
            // {
            //     Console.WriteLine("Invalid List: Please enter at least 5 numbers separated by commas.");
            //     return;
            // }

            // int[] numbers = new int[numberStrings.Length];

            // for (int i = 0; i < numberStrings.Length; i++)
            // {
            //     if (int.TryParse(numberStrings[i], out int number))
            //     {
            //         numbers[i] = number;
            //     }
            //     else
            //     {
            //         Console.WriteLine($"Invalid input: '{numberStrings[i]}' is not a valid number.");
            //         return;
            //     }
            // }

            // // Find the 3 smallest numbers using LINQ and display them.
            // var smallestNumbers = numbers.OrderBy(n => n).Take(3);

            // Console.WriteLine("\nThe 3 smallest numbers in the list are:");
            // foreach (int num in smallestNumbers)
            // {
            //     Console.WriteLine(num);
            // }
            #endregion
            #region  Dates and Time
            // DateTime date = new DateTime(2023 , 10 , 25);
            // var now =  DateTime.Now;
            // var today = DateTime.Today;
            // System.Console.WriteLine(now.Hour);
            // System.Console.WriteLine(now.Minute);

            // var tommorow = now.AddDays(1);
            // System.Console.WriteLine("tommorow " + tommorow);
            // System.Console.WriteLine(now.ToLongDateString());
            // System.Console.WriteLine(now.ToShortDateString());
            // System.Console.WriteLine(now.ToLongTimeString());
            // System.Console.WriteLine(now.ToShortTimeString());
            // System.Console.WriteLine(now.ToString("t"));

            

            // time span

            // var timeSpan = new TimeSpan(1 , 30 , 1);
            // var timeSpan2 = new TimeSpan(1 , 30 , 1);
            // var timeSpan3 = TimeSpan.FromHours(1);
            // System.Console.WriteLine(timeSpan.Minutes);
            // System.Console.WriteLine(timeSpan.TotalMinutes);

            // // System.Console.WriteLine(timeSpan);
            // //properties
            // var start = DateTime.Now;
            // var end = start.AddMinutes(2);
            // var duration = end - start;
            // // System.Console.WriteLine("duration :" + duration );

            // //Add
            // System.Console.WriteLine(timeSpan.Add(TimeSpan.FromMinutes(10)));
            // System.Console.WriteLine(timeSpan.Subtract(TimeSpan.FromMinutes(3)));

            // // To String

            // System.Console.WriteLine(timeSpan.ToString());

            // //convert from string to timeSpan
            // System.Console.WriteLine("Parse: " +TimeSpan.Parse("01:02:03"));

            #endregion
            #region  strings   Trim , SubString , IndexOf , ToUpper , Split , Replace , ToString("C")
            // var  fullname = "Ashraf Kamal ";
            //         System.Console.WriteLine("Trim '{0}'",fullname.Trim());
            //         System.Console.WriteLine("Trim '{0}'",fullname.Trim().ToUpper());

            // var index = fullname.IndexOf(' ');
            // var firstName = fullname.Substring(0 , index);
            // var lastName = fullname.Substring(index + 1);
            // System.Console.WriteLine("First Name'{0}'" , firstName);
            // System.Console.WriteLine("First Name'{0}'" , lastName);

            // var splittedNames = fullname.Split(' ');

            // for (int i = 0; i < 2; i++)
            // {
            //      System.Console.WriteLine("Name'{0}'" , splittedNames[i]);
                
            // }

            //  System.Console.WriteLine(fullname.Replace("Kamal" , "Mostafa Kamal"));

            // var massage = String.IsNullOrWhiteSpace(" ") ? "null" : "accepted";
            //  massage = String.IsNullOrEmpty(" ") ? "null" : "accepted";
            // System.Console.WriteLine(massage);

            // var myMoney = 29.95f;
            // var price = myMoney.ToString("C1");
            // System.Console.WriteLine(price);





            #endregion
            #region string builder
            // var builder = new StringBuilder();
            // builder.Append('-',10)
            //        .AppendLine()
            //        .Append("Header")
            //        .AppendLine()
            //        .Append('-' , 10)
            //        .Replace('-' , '+')
            //        .Remove(0,10)
            //        .Insert(0 , new string('-',10));
            // System.Console.WriteLine("first Character"+ builder[0]);
            // System.Console.WriteLine(builder);
            #endregion

            #region  Ex 1 

            // System.Console.WriteLine("Enter few numbers sepatated by ','");
            // var enteredNumbers = Console.ReadLine();

            // var numbersList = enteredNumbers.Split(',');
            // List<int> numbers = new List<int>();
            // foreach (var number in numbersList)
            // {
            //     numbers.Add(int.Parse(number));
            // }

            // int listCount = 0;
            // for (int i = numbers.Count -1 ; i > 0; i--)
            // {
            //     if(i == 0) break;
            //      if(numbers[i] - numbers[i-1] == 1 || numbers[i] - numbers[i-1] == -1)
            //      {
            //         listCount++;
            //         continue;
            //      }
            //     else
            //     {
            //         System.Console.WriteLine("non consective");
            //         break;
            //     }
                
            // }
            // if(listCount == numbers.Count -1)
            //     System.Console.WriteLine("consective");
             
             



            #endregion
            #region  EX2
        //    List<int> numbersList = new List<int>();
        
        //     System.Console.WriteLine("Enter few numbers sepatated by ','");
        //     var enteredNumbers = Console.ReadLine(); 
        //     if(String.IsNullOrEmpty(enteredNumbers))   
        //          return;
        //     var numbers = enteredNumbers.Split(',');

        //     foreach (var number in numbers)
        //     {
        //         if(int.TryParse(number , out int numberInt))
        //         {
        //             if(numbersList.Contains(numberInt)) 
        //             {
        //                 System.Console.WriteLine("Duplicate");
        //                 return;
        //             }
        //             numbersList.Add(numberInt);
        //         }
                 
        //     }
        //     System.Console.WriteLine("non - Duplicate");
            #endregion
            #region  EX4
            
            // System.Console.WriteLine("Enter few words separated by a space");
            // var massage = Console.ReadLine();
            // var lowerCase = massage.ToLower();
            // var words = lowerCase.Split(' ');
            // List<string> newConverted = new List<string>();
            // StringBuilder builder = new StringBuilder();
            // foreach (var word in words)
            // {
            //     char newChar =(char) (Convert.ToInt16(word[0]) - 32);
            //     builder.Append(newChar);

            //     for (int i = 1; i < word.Length; i++)
            //     {
            //         builder.Append(word[i]);
          
            //     }
          
            // }
            //  System.Console.WriteLine(builder);
            
            #endregion
         
            #region work with File and FileInfo  File.Copy(from , to , bool) File.Delete(path) , File.Exsists(path) , File.ReadAllText(path)
            // var path = @"c:\someFile.jpg";
            // File.Copy(@"c:\temp\myFiels.jpg",@"f:\temp\myFile.jpg", true);
            // File.Delete(path);
            // if(File.Exsists(path))
            // {
            //     // Do some code here
            // }

            // var content = File.ReadAllText(path);


            // var fileInfo = new FileInfo(path);
            // fileInfo.CopyTo("....");
            // fileInfo.Delete();
            // if(fileInfo.Exsists)
            // {
            //     // do some code here
            // }



            #endregion

            #region  Directory CreateDirectory(path) , Directory.GetFiles(path , "*.extension* , SearthOption.AllDirectories)
                    // Directory.GetDirectories(path)
           
            // Directory.CreateDirectory(@"E:\TestDirectory");
            // var filesNames = Directory.GetFiles(@"E:\work","*.jpg*" , SearchOption.AllDirectories);
            // foreach (string file in filesNames)
            // {
            //     System.Console.WriteLine(file);
            // }
            // var directories = Directory.GetDirectories(@"E:\work");
            // foreach (string directory in directories)
            // {
            //     System.Console.WriteLine(directory);
            // }

            // var directoryInfo = new DirectoryInfo(@"E:\work");
            // directoryInfo.GetFiles();
            // directoryInfo.GetDirectories()

            #endregion
            #region  Path   Path.GetExtension(path) , Path.GetFileName(path) , Path.GetFileNameWithoutExtension(path) , Path.GetDirectoryName(path)
            var path = @"E:\TestDirectory\textFile.txt";


            var text = File.ReadAllText(path);
            var words = text.Split(" ");
            System.Console.WriteLine(words.Length);

            var longestWord = words[0];
           

            for (int i = 0; i < words.Length; i++)
            {
                if(words[i].Length > longestWord.Length)
                {
                    longestWord = words[i];
                }
            }
            System.Console.WriteLine(longestWord);

            
            #endregion
        }

        private static void DisplayLikesInformation(List<string> names)
        {
            int nameCount = names.Count;

            if(nameCount == 1)
            {
                    System.Console.WriteLine($"{names[0]} ,Likes your Post");

            }
            else if(nameCount== 2)
            {
                    System.Console.WriteLine($"{names[0]} and {names[1]} Like your Post");

            }
            else if(nameCount > 2)
            {
                System.Console.WriteLine($"{names[0]} and {names[1]}  and  {nameCount-2} others like your post");

            }

            
        }

        private static bool CalculateDemeritPoints(int carSpeedInt, int speedLimitInt)
        {
             
            int demeritPoint =  (carSpeedInt-speedLimitInt) / 5;
            System.Console.WriteLine(demeritPoint);
           
           
            if(demeritPoint >12)
            {
                System.Console.WriteLine("License Suspended");
                 return true;

            }
            return false;
            // System.Console.WriteLine($"Demerit Points = {demeritPoint}");

             
        }

        public static void MakeOld(Person person)
        {
            person.age += 20;
        }
        
        public static void ModifySlotData(out SlotData slot , int x , int y)
        {
            slot.xCord = x;
            slot.yCord = y;
        }
         public static void ModifyClassSlotData(ClassSlotData slot , int x , int y)
        {
            slot.xCord = x;
            slot.yCord = y;
        }

        
     
         public struct SlotData
            {
                public int xCord;
                public int yCord;

                public SlotData(int x , int y)
                {
                    this.xCord = x;
                    this.yCord = y;
                }
                public void PrintSlotData()
                {
                    System.Console.WriteLine($"x :{xCord} , y :{yCord}");
                }

            }


            public class ClassSlotData
            {
                public int xCord;
                public int yCord;

                public ClassSlotData(int x , int y)
                {
                    this.xCord = x;
                    this.yCord = y;
                }
                public void PrintClassSlotData()
                {
                    System.Console.WriteLine($"x :{xCord} , y :{yCord}");
                }


            }
       
                
    }
    public enum Character
        {
            Capital,
            Small,
            Number,
            Symbole
            
        }   
}

              
        