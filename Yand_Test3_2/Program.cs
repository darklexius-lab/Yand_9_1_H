
/*
 string path = "input.txt";
 string InTxt;

System.IO.StreamReader reader = new System.IO.StreamReader(path);

{
    InTxt = reader.ReadLine();
    
}*/

/*string InTxt = Console.ReadLine();
InTxt = InTxt.Trim();
int InInt[] = Array.ConvertAll(InTxt.Split(' '), int.Parse);*/

string InTxt = Console.ReadLine();
int buffer;
InTxt = InTxt.Trim();
buffer = Int32.Parse(InTxt);
long A = buffer;

InTxt = Console.ReadLine();
InTxt = InTxt.Trim();
buffer = Int32.Parse(InTxt);
long B = buffer;

InTxt = Console.ReadLine();
InTxt = InTxt.Trim();
buffer = Int32.Parse(InTxt);
long C = buffer;

long X=0;
int caseCheck=0;

if (A == 0)
{
    if (B == C * C)
    {
        caseCheck = 1;
    }
    else
    {
        caseCheck = 3; 
    }
}
else 
{
    X = ((C * C) - B) / A;
    if ((X * A + B) == (C * C))
    {

        caseCheck = 2;

    }
    else
    {
        caseCheck = 3;
    }
}

if (C < 0) 
{
    caseCheck = 3;
}

switch (caseCheck)
{
    case 1:
        InTxt = "MANY SOLUTIONS";
        break;


    case 2:
        InTxt = "";    
        InTxt +=X;
        break;

    case 3:
        InTxt = "NO SOLUTION";
        break;
    default:
        InTxt = "NO SOLUTION";
        break;
}
Console.WriteLine(InTxt);