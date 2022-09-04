/*Напишите программу, которая заполнит спирально массив 4 на 4. 
( - необязательно)*/

int[,] array = new int [4,4];
int sideA = array.GetLength(0);
int sideB = array.GetLength(1);
int beginI = 0;
int finalI = 0;
int beginJ = 0; 
int finalJ = 0;
int sum = 1;
int i = 0;
int j = 0;

while(sum <= sideA * sideB)
{
    array[i,j] = sum;
    if(i == beginI && j < sideB - finalJ - 1)
    {
        j++;
    }
    else if(j == sideB - finalJ - 1 && i < sideA - finalI - 1)
    {
        i++;
    }
    else if(i == sideA- finalI -1 && j > beginJ)
    {
        j--;
    }
    else
    {
        i--;
    }
    if((i == beginI + 1) && (j == beginJ) && (beginJ != sideB - finalJ - 1))
    {
        beginI++;
        beginJ++;
        finalI++;
        finalJ++;
    }
    sum++;
}

PrintArray(array);

void PrintArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
