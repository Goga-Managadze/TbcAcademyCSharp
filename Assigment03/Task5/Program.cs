// See https://aka.ms/new-console-template for more information

//5. დაწერეთ პროგრამა რომელსაც გადასცემთ რიცხვის დიაპაზონს (დიაპაზონის მინიმალური და მაქსიმალური რიცხვი)
//, პროგრამა დიაპაზონიდან დააგენერირებს შემთხვევით რიცხვს და შემოგთავაზებთ მის გამოცნობას მანამ სანამ არ გამოიცნობთ,
//და დაბეჭდავს რამდენ ცდაში გამოიცანით რიცხვი. გამოცნობის შემდეგ პროგრამა გვკითხოს გვსურს თუ არა გაგრძელება, Yes ან No
//შეყვანით, თანხმობის შემთხვევაში თავიდან შემოგვთავაზოს ახალი დიაპაზონის შეყვანას და რიცხვის გამოცნობას, უარის შემთხვევაში
//კონსოლი დაიხუროს.

Console.WriteLine("Min value");
int min = int.Parse(Console.ReadLine());
Console.WriteLine("Max value");
int max = int.Parse(Console.ReadLine());
Console.WriteLine("Enter number");
Random rand = new Random();
int diapazoni = rand.Next(min, max);
int cda = 0;
while (true)
{

    int input = int.Parse(Console.ReadLine());
    cda++;
    if (diapazoni == input)
    {
        Console.WriteLine("Guess");
        Console.WriteLine("cda: " + cda);
        Console.WriteLine("Do you want to continue? Enter yes or no");
        string text = Console.ReadLine();
        if (text == "yes")
        {
            Console.Clear();
            cda = 0;
            Console.WriteLine("Min value");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("Max value");
            max = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number");
        }
        else if (text == "no")
        {
            break;
        }
        else
        {
            Console.WriteLine("Your input wasn't yes or no");
            break;
        }
    }
}
