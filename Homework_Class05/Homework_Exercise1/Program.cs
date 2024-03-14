
using System.Data;

#region Exercise_requirements!

//Make a method called AgeCalculator
//The method will have one input parameter, your birthday date
//The method should return your age
//Show the age of a user after he inputs a date

#endregion




Console.WriteLine("Please enter your birthday date(dd/MM/yyyy) :");
string date = Console.ReadLine();

if (date.Length > 0)
{

   AgeCalculate(date);
}
else
{
    Console.WriteLine("Invalid input");
}

string AgeCalculate(string birthDate) {

    DateTime currentDate = DateTime.Now;
    DateTime bDay = DateTime.Parse(birthDate);
    var result = currentDate.Year - bDay.Year;
    
    string birthdayString = result.ToString();
    Console.WriteLine($"You are {birthdayString} years old.");
    return birthdayString;




}




