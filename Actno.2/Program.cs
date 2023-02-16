// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please Enter Score 1");
int score1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter Score 2");
int score2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter Score 3");
int score3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter Score 4");
int score4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter Score 5");
int score5 = Convert.ToInt32(Console.ReadLine());

int score = score1 + score2 + score3 + score4 + score5;
int average = score / 5;

if (average >= 75)
{
    Console.WriteLine("PASSED!"); }
else
{
    Console.WriteLine("FAILED!");
}
