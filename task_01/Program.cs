Random rnd = new Random ();
int m = rnd.Next (4, 10);
int n = rnd.Next (4, 10);
int [,] matrix = new int [m,n];



void PrintArray(int [,] matr)
    {
    for (int i=0; i < matr.GetLength(0); i++)
    {
        for (int j=0; j< matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int [,] matr)
  {
   for (int i=0; i < matr.GetLength(0); i++)
    {
        for (int j=0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(0,10);
        }
    } 
}


void Sort (int [,] matr)
  {
   for (int i=0; i < matr.GetLength(0); i++)
    {
      for (int j=0; j < matr.GetLength(1); j++)
      {
        for (int k=0; k < matr.GetLength(1) - 1 ; k++)
        {
            if (matr [i , k] <= matr [ i , k + 1 ])
            {
                int tmp = matr[i, k + 1];
                matr[i, k + 1] = matr[i, k ];
                matr[i, k ] = tmp;
            }
           
        }
        
      }
            
    } 
}

FillArray(matrix);
Console.WriteLine("Массив: ");
PrintArray (matrix);
Console.WriteLine();
Console.WriteLine("Упорядочили строки по убыванию: ");
Sort(matrix);
PrintArray(matrix);