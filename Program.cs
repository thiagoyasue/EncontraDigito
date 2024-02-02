int h = 0;
int i;
int j = 0;
int k = 0;
int l = 0;
int m = 0;
int n = 0;
int lado = 0;
int escolhe = 0;
bool isInicio = true;
int inputNumber = 0;

while (isInicio)
{
    Console.Write("Digite um numero (max. 6 digitos): ");
    inputNumber = int.Parse(Console.ReadLine());//usuário entra com o valor
    if (inputNumber > 999999 || inputNumber < 0)
    {
        Console.Clear();
        Console.Write("Digite um numero com menos de 7 digitos!\nPressione qualquer tecla para continuar...");
        Console.ReadKey();
    }
    else
    {
        isInicio = false;
    }
    Console.Clear();
}


for (i = 1; i <= inputNumber; i++)
{
    if (i < 10)
    {
        h++;
    }

    if (i > 9 && i <= 189)
    {
        if (lado == 0)
        {
            h++;
            lado = 1;

            escolhe = 1;
        }
        else
        {
            lado = 0;
            escolhe = 0;
        }
    }

    if (i > 189 && i <= 2889)
    {
        switch (lado)
        {
            case 0:
                h++;
                lado = 1;
                escolhe = 2;
                break;
            case 1:
                lado = 2;
                escolhe = 1;
                break;
            case 2:
                lado = 0;
                escolhe = 0;
                break;
        }
    }

    if (i > 2889 && i <= 38889)
    {
        switch (lado)
        {
            case 0:
                h++;
                lado = 1;
                escolhe = 3;
                break;
            case 1:
                lado = 2;
                escolhe = 2;
                break;
            case 2:
                lado = 3;
                escolhe = 1;
                break;
            case 3:
                lado = 0;
                escolhe = 0;
                break;
        }
    }

    if (i > 38889 && i <= 488889)
    {
        switch (lado)
        {
            case 0:
                h++;
                escolhe = 4;
                lado = 1;
                break;
            case 1:
                lado = 2;
                escolhe = 3;
                break;
            case 2:
                lado = 3;
                escolhe = 2;
                break;
            case 3:
                lado = 4;
                escolhe = 1;
                break;
            case 4:
                lado = 0;
                escolhe = 0;
                break;
        }
    }

    if (i > 488889)
    {
        switch (lado)
        {
            case 0:
                h++;
                lado = 1;
                escolhe = 5;
                break;
            case 1:
                lado = 2;
                escolhe = 4;
                break;
            case 2:
                lado = 3;
                escolhe = 3;
                break;
            case 3:
                lado = 4;
                escolhe = 2;
                break;
            case 4:
                lado = 5;
                escolhe = 1;
                break;
            case 5:
                lado = 0;
                escolhe = 0;
                break;
        }
    }

    if (h == 10)
    {
        h = 0;
        j++;
    }

    if(j == 10)
    {
        j = 0;
        k++;
    }

    if(k == 10)
    {
        k = 0;
        l++;
    }

    if(l == 10)
    {
        l = 0;
        m++;
    }

    if(m == 10)
    {
        m = 0;
        n++;
    }

    if(n == 10)
    {
        n = 0;
    }
    
    Console.WriteLine("i = {0}, {1}{2}{3}{4}{5}{6}",i,n,m,l,k,j,h);

}

int fim;
fim = escolhe switch
{
    0 => h,//Console.WriteLine(h);
    1 => j,//Console.WriteLine(j);
    2 => k,//Console.WriteLine(k);
    3 => l,//Console.WriteLine(l);
    4 => m,//Console.WriteLine(m);
    _ => n,//Console.WriteLine(n);
};

Console.WriteLine("O termo e' {0}", fim);
Console.Read();
