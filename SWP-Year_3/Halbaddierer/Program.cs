int x = 1;
int y = 1;
int ANDtop = 0;
int ANDmid = 0;
int ANDbot = 0;
int S = 0;
int C = 0;

switch(x + y)
{
    case 0:
        break;
    case 1:
        if (x == 0)
        {
            ANDtop += 1;
        }
        else
        {
            ANDmid += 1;
        }
        break;
    case 2:
        ANDbot += 2;
        break;
}

if (ANDmid == 1 || ANDtop == 1)
{
    S += 1;
}
else if (ANDbot == 2)
{
    C += 1;
}

Console.WriteLine($"Die Ergebnisse lauten für S {S} und für C {C}");