using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Threading;
using TemperatureCalculator;

namespace projectone
{
    class Program
    {
          static void Main(string[] args)
        {
        #region Question1
            // List<(string name,int grade)> studentGrades = new List<(string, int)>(){
            // ("Ahmed",92),
            // ("Sayed",96),
            // ("Nayera",80),
            // ("Yasmine",89)};
            // var lowest = StudentMarksCalculator.StudentCalculator.GetLowestScore(studentGrades);    
            // var highest = StudentMarksCalculator.StudentCalculator.GetHighestScore(studentGrades);
            // var Average = StudentMarksCalculator.StudentCalculator.CalculateAverage(studentGrades);        
            //  System.Console.WriteLine($"{lowest.Name} is the student with the lowest grade: ({lowest.Grade})");
            //  System.Console.WriteLine($"{highest.Name} is the student with the highest grade: ({highest.Grade})");
            //  System.Console.WriteLine($"Avg grade of the whole students is : {Average}");
        #endregion

        #region question2

        // var questions = new List<(string Question, string[] Options, char CorrectAnswer)>
        // {
        //     ("What is the capital of Egypt?", new[] { "A) Alexandria", "B) Asyut", "C) Ismalia", "D) Cairo" }, 'D'),
        //     ("What is answer of 2 * 5?", new[] { "A) 4", "B) 4", "C) 10", "D) 4" }, 'C'),
        //     ("What is the opposite of 'remember' ?",new[]{"A) Forget","B) Update" , "C) Migrate", "D) Translate" },'A'),
        //     ("Who is the best footballer in history?", new[] { "A) Cristiano Ronaldo", "B) Lionel Messi", "C) Pele", "D) Maradona" }, 'A'),





        // };
        // int score = 0;
        // foreach(var (question ,options,correctanswer ) in questions){
        // Console.WriteLine(question);
        // foreach(var option in options){
        //     Console.WriteLine(option);
        // }
        // Console.Write("Choose your option from A/B/C/D:");
        // var ans = Console.ReadLine()?.ToUpper();
        // if(ans==correctanswer.ToString()){
        //     Console.WriteLine("Your answer is correct");
        // score++;
            
        // }
        // else{
        //     Console.WriteLine("You entered the wrong answer");
        // }

        // }

        // Console.WriteLine($"Your score = {score} out of {questions.Count}");

        #endregion

        #region question3

        //  List<string> transactions = new List<string>();
        // decimal totalIncome = 0m;
        // decimal totalExpenses = 0m;
        // string input;

        // Console.WriteLine("===> Try my Budget Tracker <===");

        // Console.WriteLine("\nEnter your incomes (type 'done when you're done'): ");
        // while(true){
        //     Console.Write("Write the income description you need (or 'done'): ");
        //     input=Console.ReadLine();
        //     if(input.ToLower()=="done") break;
            
        //     else{
        //         Console.Write("Amount:");
        //         if(decimal.TryParse(Console.ReadLine(),out decimal amount)&& amount>0){
        //             transactions.Add($"Income: {input } => {amount}");
        //             totalIncome+=amount;
        //         }
        //         else{
        //             System.Console.WriteLine("Invalid amount. please enter a positive number");
        //         }
        //     }
        // }
        // System.Console.WriteLine("\nEnter your expenses (type 'done' when you're done)");
        // while(true){
        //     Console.Write("Write the expenses description you need (or 'done')");
        //     input=Console.ReadLine();
        //     if(input.ToLower()=="done")break;

        //     else{
        //         Console.Write("Amount: ");
        //         if(decimal.TryParse(Console.ReadLine(),out decimal amount)&& amount>0){
        //             transactions.Add($"Expenses: {input} => {amount}");
        //             totalExpenses+=amount;
        //         }
        //         else{
        //             System.Console.WriteLine("Invalid amount. please enter a positive number");
        //         }
        //     }
        // }

       
     

        // decimal balance = totalIncome - totalExpenses;

        
        // Console.WriteLine("\n===> Summary <===");
        // Console.WriteLine($"Total Income: {totalIncome:C}");
        // Console.WriteLine($"Total Expenses: {totalExpenses:C}");
        // Console.WriteLine($"Current Balance: {balance:C}");

       
        //  string filePath = Path.Combine(Directory.GetCurrentDirectory(), "budget_report.txt");
        // using (StreamWriter writer = new StreamWriter(filePath))
        // {
        //     writer.WriteLine("===> Budget Report <===\n");
        //     foreach (var transaction in transactions)
        //     {
        //         writer.WriteLine(transaction);
        //     }
        //     writer.WriteLine("\n===> Summary <===");
        //     writer.WriteLine($"Total Income: {totalIncome:C}");
        //     writer.WriteLine($"Total Expenses: {totalExpenses:C}");
        //     writer.WriteLine($"Current Balance: {balance:C}");
        // }

        // Console.WriteLine($"\nData has been saved to {filePath}");
    

        #endregion

        #region question4
        
//         while(true){
//             System.Console.WriteLine("===> Tempreture Converter <===");
//             System.Console.WriteLine("1-Convert from Celsius to Fahrenheit");
//             System.Console.WriteLine("2-Convert from Celsius to Kelvin");
//             System.Console.WriteLine("3-Convert from Fahrenheit to Celsius");
//             System.Console.WriteLine("4-Convert from Fahrenheit to Kelvin");
//             System.Console.WriteLine("5-Convert from Kelvin to Celsius");
//             System.Console.WriteLine("6-Convert from Kelvin to Fahrenheit");
//             System.Console.WriteLine("7-Exit.");
//             System.Console.WriteLine("Choose your option from (1-7):");
//             string choice = Console.ReadLine();




//             switch(choice){
//                 case "1" : TemperatureCalculator.Calculator.ConvertAndDisplay("Celsius","Fahrenheit",TemperatureCalculator.Calculator.CelsiusToFahrenheit); break;
//                 case "2" : TemperatureCalculator.Calculator.ConvertAndDisplay("Celsius","Kelvin",TemperatureCalculator.Calculator.CelsiusToKelvin); break;
//                 case "3" : TemperatureCalculator.Calculator.ConvertAndDisplay("Fahrenheit","Celsius",TemperatureCalculator.Calculator.FahrenheitToCelsius); break;
//                 case "4" : TemperatureCalculator.Calculator.ConvertAndDisplay("Fahrenheit","Kelvin",TemperatureCalculator.Calculator.FahrenheitToKelvin); break;
//                 case "5" : TemperatureCalculator.Calculator.ConvertAndDisplay("Kelvin","Celsius",TemperatureCalculator.Calculator.KelvinToCelsius); break;
//                 case "6" : TemperatureCalculator.Calculator.ConvertAndDisplay("Kelvin","Fahrenheit",TemperatureCalculator.Calculator.KelvinToFahrenheit); break;
//                 case "7" : System.Console.WriteLine("Exiting goodbye! ...."); return;
//                 default: System.Console.WriteLine("You entered an invalid number");break;



//             }

// }


        #endregion

        #region bonusQuestion

        puzzle.puzzleSolver.InitializeBoard();
       puzzle.puzzleSolver.ShuffleBoard();

        while (true)
        {
            Console.Clear();
            puzzle.puzzleSolver.PrintBoard();

            if (puzzle.puzzleSolver.IsSolved())
            {
                Console.WriteLine("🎉 You solved the puzzle!");
                break;
            }

            Console.Write("Move (WASD): ");
            var key = Console.ReadKey().Key;
            puzzle.puzzleSolver.MoveBlank(key);
        }

        #endregion
        }
    
}
    }

