// See https://aka.ms/new-console-template for more information

Console.WriteLine("Please Enter Score 1");
int score = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter Score 2");
score += Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter Score 3");
score += Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter Score 4");
score += Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Please Enter Score 5");
score += Convert.ToInt32(Console.ReadLine());


var average = score / 5;

if (average >= 75)
{
    Console.WriteLine("PASSED!"); }
else
{
    Console.WriteLine("FAILED!");
}
