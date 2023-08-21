// C# Basics Practice:

// 1. Display Hello World in the console window. 

//Console.WriteLine("Hello world.");
//Console.Read();

// 2. Declare and initialize a char variable. 

//char z = 'z';
//Console.WriteLine(z);
//Console.Read();

// 3. Declare and initialize a double variable. 

//double bigNum = 3.569713;
//Console.WriteLine(bigNum);
//Console.Read();

// 4. Declare and initialize a float variable.

//float z = 134.45f;
//Console.WriteLine(z);
//Console.Read();

// 5. Declare and initialize a string variable.

//string userName = "Zachypoo";
//Console.WriteLine(userName);
//Console.ReadLine();

// 6. Declare and initialize an int variable.

//int a = 29;
//Console.WriteLine(a);
//Console.ReadLine();

// 7. Use a built-in function to display the memory size a variable of type int takes in memory.

//Console.WriteLine(sizeof(int));

// 8. Use a built-in function to display the memory size a variable of type float takes in memory.

//Console.WriteLine(sizeof(float));

// 9. Use a built-in function to display the memory size a variable of type double takes in memory.

//Console.WriteLine(sizeof(double));

// 10. Use a built-in function to display the memory size a variable of type char takes in memory.

//Console.WriteLine(sizeof(char));

// 11. Declare and initialize two string variables and then declare and initialize a variable to concatenate the two strings. 

//string a = "Master";
//Console.WriteLine(a);
//string b = "Chief";
//Console.WriteLine(b);
//string c = "Master" + "Chief";
//Console.WriteLine(c);

// 12. Convert the value of a variable of type int to a bool data type. 

//int z = 1;
//bool w = Convert.ToBoolean(z);
//Console.WriteLine($"{w}");

// 13. Create an array of Days (ie: Monday, Tuesday, Wednesday...).
//      a. Declare a variable and assign it the first element of the array. 

//string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
//string fDay = days[0];
//Console.WriteLine(fDay);

// 14. Declare and initialze a variable of type int. Using implicit casting, convert the variable to a double data type.

//int z = 29;
//double b;
//b = z;
//Console.WriteLine(b);

// 15. Make the program display 45 in the console window after carrying out an arithmetic operation.

//int a = 40;
//int b = 5;
//int c = a + b;
//Console.WriteLine(c);

// 16. Declare and initialize a DateTime struct (hint - similar to data type / variable) and display 11/26/22 2:55:40 PM (hint - 24hr).

//var specificDate = new DateTime(2022, 11, 26, 14, 55, 40);
//Console.WriteLine(specificDate);

// 17. Create a method that converts user input into a variable "age."

//static int convertAge(int age)
//{
//    return age;
//}

//Console.WriteLine("Please enter a value to assign it to the variable 'age'.\n");
//int age = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();
//Console.WriteLine($"You have assigned the input {age} to the variable 'age.'");

// 18. Complete a try/catch statement to handle the exception "dividing by 0."

//Console.WriteLine("Please enter two numbers to be divided by one another:\n");
//Console.WriteLine("Please enter the first number.\n");
//int num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();
//Console.WriteLine("Please enter the second number.\n");
//int num2 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();

//try
//{
//    double div = num1 / num2;
//    Console.WriteLine($"The result of {num1} / {num2} is {div}.");
//}
//catch
//{
//    Console.WriteLine("Unfortunately, you cannot divide a number by zero. Please try again.");
//}

// 19. Create a conditional statement based on the details below: 
//     a. int a = 15;
//     b. int b = 27;
//         i. Display: a is equal to b
//        ii. Display: a is greater than b
//       iii. Display: a is less than b


//int a = 15;
//int b = 27;
//if (a == b)
//{
//    Console.WriteLine($"{a} equals {b}");
//}
//else if (a > b)
//{
//    Console.WriteLine($"{a} is greater than {b}");
//}
//else if (a < b)
//{
//    Console.WriteLine($"{a} is less than {b}");
//}


// 20. Declare and initialize a string variable "daysOfTheWeek" to Saturday. Create a switch statement to display a unique phrase for each day of the week. Make the switch statement display "Happy weekend!" when Saturday is evaluated.

//Console.WriteLine("Please enter a number between 1 - 7 to select a day of the week and receive a specific message: \n");

//string[] daysOfTheWeek = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

//int userSelect = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();
//switch (userSelect)
//{
//    case 1:
//        if (userSelect == 1)
//        {
//            Console.WriteLine($"You have selected {daysOfTheWeek[0]}\n");
//            Console.WriteLine("Monday is honestly my least favorite day of the week.");
//        }
//        else
//        {
//            Console.WriteLine("That is not a valid entry. Please try again.");
//        }
//        break;
//    case 2:
//        if (userSelect == 2)
//        {
//            Console.WriteLine($"You have selected {daysOfTheWeek[1]}\n");
//            Console.WriteLine("Tuesday is 'snoozeday.'");
//        }
//        else
//        {
//            Console.WriteLine("That is not a valid entry. Please try again.");
//        }
//        break;
//    case 3:
//        if (userSelect == 3)
//        {
//            Console.WriteLine($"You have selected {daysOfTheWeek[2]}\n");
//            Console.WriteLine("Humpday!!");
//        }
//        else
//        {
//            Console.WriteLine("That is not a valid entry. Please try again.");
//        }
//        break;
//    case 4:
//        if (userSelect == 4)
//        {
//            Console.WriteLine($"You have selected {daysOfTheWeek[3]}\n");
//            Console.WriteLine("Its Fridayeve baby!");
//        }
//        else
//        {
//            Console.WriteLine("That is not a valid entry. Please try again.");
//        }
//        break;
//    case 5:
//        if (userSelect == 5)
//        {
//            Console.WriteLine($"You have selected {daysOfTheWeek[4]}\n");
//            Console.WriteLine("Honestly, I couldn't have held out much longer.");
//        }
//        else
//        {
//            Console.WriteLine("That is not a valid entry. Please try again.");
//        }
//        break;
//    case 6:
//        if (userSelect == 6)
//        {
//            Console.WriteLine($"You have selected {daysOfTheWeek[5]}\n");
//            Console.WriteLine("Happy first day of the weekend!");
//        }
//        else
//        {
//            Console.WriteLine("That is not a valid entry. Please try again.");
//        }
//        break;
//    case 7:
//        if (userSelect == 7)
//        {
//            Console.WriteLine($"You have selected {daysOfTheWeek[6]}\n");
//            Console.WriteLine("May you sleep in and may the Sunday spookies never reach you.");
//        }
//        else
//        {
//            Console.WriteLine("That is not a valid entry. Please try again.");
//        }
//        break;
//}

// 21. Declare and call a method "MyFirstMethod" and display "Woohoo!! My first method!"

//Console.WriteLine(MyFirstMethod());

//static string MyFirstMethod()
//{
//    string greeting = "Woohoo!! My first method!";
//    return greeting;
//}

// 22. Declare a method "MyFavQuote" that returns your favorite quote. Call and display the method for the quote.

//Console.WriteLine("My favorite quote is: \n");
//Console.WriteLine(MyFavQuote());
//static string MyFavQuote()
//{
//    string favQuote = "And whether or not it is clear to you, no doubt the universe is unfolding as it should. Therefore be at peace with God, whatever you conceive Him to be. And whatever your labors and aspirations, in the noisy confusion of life, keep peace in your soul. With all its sham, drudgery and broken dreams, it is still a beautiful world. Be cheerful. Strive to be happy.";
//    return favQuote;
//}

// 23. Declare an array of type string called "myFriends". Loop through the array.

//string[] myFriends = new string[4] { "Brynn", "Aaron", "Cameron", "Matt" };

//for (int a = 0; a < myFriends.Length; a++)
//{
//    Console.WriteLine(myFriends[a]);
//}

// 24. Declare and initialize an int variable "numberOfHearts" and set the value to 5. Declare a method "GetHeroStatus" that passes in the value of "numberOfHearts." Create a conditional within the method with unique displays for if number of hearts is less than 10, less than 3, and a default response. 

//int numberOfHearts = 5;
//Console.WriteLine("Your hero currently has '5' health points. Your teammate, a valiant and resplindant paladin has offered to heal you.\n");
//Console.WriteLine("How many points of health do you gain from the noble paladin's spell?\n");
//int hpVariable = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine();
//int hpOutcome = numberOfHearts + hpVariable;
//GetHeroStatus(hpOutcome);

//static void GetHeroStatus(int hpOutcome)
//{
//    if (hpOutcome > 10)
//    {
//        Console.WriteLine($"Your hero currently has {hpOutcome} health points.\n");
//        Console.WriteLine("You have been overhealed!");
//    }
//    else if (hpOutcome < 10 && hpOutcome >= 3)
//    {
//        Console.WriteLine($"Your hero currently has {hpOutcome} health points.\n");
//        Console.WriteLine("You have reached normal health levels.");
//    }
//    else if (hpOutcome < 3 && hpOutcome >= 1)
//    {
//        Console.WriteLine($"Your hero currently has {hpOutcome} health points.\n");
//        Console.WriteLine("You have reached critical health levels.");
//    }
//    else
//    {
//        Console.WriteLine($"Your hero currently has {hpOutcome} health points.\n");
//        Console.WriteLine("Your hero has died.\n");
//        Console.WriteLine("Darn, it would appear that the noble paladin was actually a necromancer in disguise.");

//    }
//    //return hpOutcome; -- This was removed when the method was changed to "static void" and "int" was removed, as the method is not returning anything.
//}

// 25. Create a loop so that (see below) is displayed to the console window. 

//      a. 1
//      b. 2
//      c. 3
//      d. 4
//      e. 5

//int[] numbers = new int[5] { 1, 2, 3, 4, 5, };

//for(int a = 0; a < numbers.Length; a++)
//{
//    Console.WriteLine(numbers[a]);
//}

// 26. Create a while loop to display "1,2,3,4,5."

//int a = 1;
//while (a < 6)
//{
//    Console.WriteLine(a);
//    a++;
//}

// 27. Create a foreach loop to display "1,2,3,4,5."

//int[] numbers = new int[5] {1, 2, 3, 4, 5};
//foreach (int a in numbers)
//{
//    Console.WriteLine(a);
//}

// 28. Create a do while loop to display "1,2,3,4,5."

//int a = 1;
//do
//{
//    Console.WriteLine(a);
//    a++;
//}
//while (a < 6);

// 29. Declare an array of integers starting with the number 12. Display the element for 12.

//int[] numbers = new int[12] {12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1};

//Console.WriteLine(numbers[0]);


