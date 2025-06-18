
#region
//Console.WriteLine(1 == 1);
//Console.WriteLine(2 == 1);
//Console.WriteLine(1 + 1);
//Console.WriteLine(2 - 1);
//Console.WriteLine(4 / 2);
//Console.WriteLine(5 * 5);

//Console.WriteLine("Enter a first number");
//byte numFirst = byte.Parse(Console.ReadLine());
//Console.WriteLine("Enter a second number");
//byte numSecond = byte.Parse(Console.ReadLine());

//Console.WriteLine($"Your first number is {numFirst} and your second number is {numSecond}");
//Console.WriteLine(numFirst + numSecond);
//Console.WriteLine(numFirst - numSecond);
//Console.WriteLine(numFirst / numSecond);
//Console.WriteLine(numFirst * numSecond);
//Console.WriteLine(numFirst == numSecond);

//int x = 2;
//Console.WriteLine(x *= 3);
//Console.WriteLine(x /= 4);

//Console.WriteLine("Enter first number:");
//byte numberFirst = byte.Parse(Console.ReadLine());
//Console.WriteLine("Enter second number:");
//byte secondNumber = byte.Parse(Console.ReadLine());

//if (numberFirst == secondNumber)
//{
//    Console.WriteLine("es ricxvebi tolia");
//} else if (numberFirst > secondNumber)
//{
//    Console.WriteLine("pirveli ricxvi metia meoreze");
//} else if (numberFirst < secondNumber)
//{
//    Console.WriteLine("meore ricxvi metia pirvelze");
//}

//Console.WriteLine("Enter number:");
//byte number = byte.Parse(Console.ReadLine());

//if (number > 5 && number < 10)
//{
//    Console.WriteLine("Ricxvi shualedshia");
//} else
//{
//    Console.WriteLine("Wrong number");
//}

//Console.WriteLine("Enter number:");
//byte ricxvi = byte.Parse(Console.ReadLine());

//if (ricxvi == 5 || ricxvi == 10)
//{
//    Console.WriteLine("Right number");
//} else
//{
//    Console.WriteLine("Wrong number");
//}

#endregion

#region

//Console.Write("First Number: ");
//int firstNumber = int.Parse(Console.ReadLine());

//Console.Write("Second Number: ");
//int secondNumber = int.Parse(Console.ReadLine());

//Console.Write("[+ - * /]");
//char operation = char.Parse(Console.ReadLine());


//switch (operation)
//{
//    case '+':
//        Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
//        break;
//    case '-':
//        Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
//        break;
//    case '*':
//        Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
//        break;
//    case '/':
//        Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
//        break;
//    default:
//        break;
//}


Console.WriteLine("Enter your email:");
string email = Console.ReadLine();

if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains(".") || email.StartsWith("@") || email.EndsWith("@"))
{
    Console.WriteLine("Wrong input");
    return;
} else
{
    Console.WriteLine("valid email");
}

Console.WriteLine("Enter your password:");
string password = Console.ReadLine();

if (!password.Any(char.IsUpper))
{
    Console.WriteLine("Password must contain at least one upper letter");
    return;
}
else if (!password.Any(ch => "!@#$%^&*()_+{}[]:;\"'<>,.?/\\|".Contains(ch)))
{
    Console.WriteLine("password must contain at least one symbol");
    return;
}
else if (!password.Any(char.IsDigit))
{
    Console.WriteLine("Passwored must contain at least one number");
}
else if (password.Length < 8)
{
    Console.WriteLine("password must be at least 8 character");
}
else
{
    Console.WriteLine("Password is valid!");
}

#endregion
