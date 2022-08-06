Console.WriteLine(MaxFromTwo(1,4));
Console.WriteLine(MaxFromThree(20, 20, 8));
Console.WriteLine(IsEven(10));
Console.WriteLine(IsEven(9));
Console.WriteLine(IsEven(-3));
Console.WriteLine(IsEven(-4));

foreach(var n in GetEvensTo(9)){
    System.Console.WriteLine(n);
}
foreach(var n in GetEvensTo(17)){
    System.Console.WriteLine(n);
}

static int MaxFromTwo (int numA, int numB) => numA > numB ? numA : numB;

static int MaxFromThree (int numA, int numB, int numC) 
{
    int temp = MaxFromTwo(numA, numB);
    return numC > temp ? numC : temp;
}

static bool IsEven (int num) => num % 2 == 0;

static IEnumerable<int> GetEvensTo (int num)
{
    int i = 0;
    while(i <= num) {
        if(i % 2 == 0) 
            yield return i;
        i++;
    }
    if(i > num) yield break;
}
