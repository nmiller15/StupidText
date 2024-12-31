Console.WriteLine("Input the text you would like to stupidify... ");

string? input = Console.ReadLine();

string result = String.Empty;
bool isUpper = false;

for (int i = 0; i < input.Length; i++)
{
    if (isUpper)
    {
        result = result + input[i].ToString().ToUpper();
    }
    else
    {
        result = result + input[i].ToString().ToLower();
    }
    
    isUpper = !isUpper;
}

Console.WriteLine(result);
Console.ReadLine();