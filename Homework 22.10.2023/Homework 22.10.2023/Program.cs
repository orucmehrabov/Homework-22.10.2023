using Homework_22._10._2023;
using Homework_22._10._2023.Helpers.Extentions;
using System.ComponentModel;

//int number = 100;
//number.ShowNum();

//int number1 = 6;
//number1.ShowNum();



//int num1 = 50;
//num1.ShowNum(30);



//int num1 = 6;
//int num2 = 100;
//int res = num1.SumOfNums(num2);
//Console.WriteLine(res);



//string str = "Salam ";
//var result = str.ShowText("Xos gorduk");
//Console.WriteLine(result);



//string text = "Salam5";
//var res = text.CheckDigitForStr();
//if (res)
//{
//    Console.WriteLine("Have digit");
//}
//else
//{
//    Console.WriteLine("Haven't digit");
//}



//string email = "Oruc97@gmail.com";
////Console.WriteLine(email.CheckStr("@"));
////Console.WriteLine(email.CheckStr(@"\d"));
//Console.WriteLine(email.CheckStr(@"[A-Z a-z]"));
//Person person = new("oruc@gmail.com");



//int num = 5;
//var res = num.FindFactorial();
//Console.WriteLine(res);



//Console.WriteLine("Add your email: ");
//Email:  string email = Console.ReadLine();

//if (!email.CheckEmailAndPassword("@"))
//{
//    Console.WriteLine("Email incorrect");
//    goto Email;
//}


//Console.WriteLine("Add your password: ");
//Password: string password = Console.ReadLine();

//if (!password.CheckEmailAndPassword(@"\W"))
//{
//    Console.WriteLine("Password incorrect");
//    goto Password;
//}

//Console.WriteLine("Login success");



//int a  = 20;
//Console.WriteLine(a.PowOfNum(3));



//string a = "100";
//Console.WriteLine(a.IsConvertStringToNumber());



//Car car = new Car();
//car.name = "Mercedes";
//Console.WriteLine(car.name);



//Car car;
//car.name = "Mercedes";
//Console.WriteLine(car.name);



//string name = null;
//if (name == null)
//{
//    Console.WriteLine("Not Found");
//}



//int? age = null;
//Console.WriteLine(age);



//static void CreateData(string name, string surname, int? age)
//{
//    if (name == null || surname == null || age == null)
//    {
//        Console.WriteLine("Please fill all inputs");
//        return;
//    }
//    Console.WriteLine(name + "-" + surname + "-" + age);
//}
//CreateData("Oruc", "Mehrabov", null);



static void Registr (User user)
{
    if (!string.IsNullOrEmpty(user.Email.Trim()) && !string.IsNullOrEmpty(user.FullName.Trim()) && !string.IsNullOrEmpty(user.Password.Trim()))
    {
        Console.WriteLine("Register success");
    }
    else
    {
        Console.WriteLine("Register failed");
    }
}

Registr(new User { Id = 1, FullName = "Oruc Mehrabov", Email = "oruc@gmail.com", Password = "Oruc123" });