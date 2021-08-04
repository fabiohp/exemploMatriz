using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Exibindo as notas:");
    matrizNotasAlunos();
  }
  //Cria nova funcao
  private static void matrizNotasAlunos()
  {
   float [ , ] matrizNotas = {{2.5F, 6.5F, 4.0F} , {4.5F, 3.5F, 7.0F}, {3.5F, 5.5F, 9.0F}, {9.5F, 8.5F, 6.0F}, { 5.0F, 7.5F, 6.5F}};

   int nLinhas = 5;
   int nColunas = 3;
   int i, j;
   for (i = 0; i < nLinhas; i++)
   {
     Console.WriteLine("Notas aluno " + (i+1));
     for (j = 0; j < nColunas; j++)
     {			  
	      Console.WriteLine(matrizNotas[i,j]);
     }
   }

    Console.WriteLine(matrizNotas.Length);
    
    //Usando foreach
    foreach (float notas in matrizNotas){                             Console.WriteLine("Nota = " + notas);
    }



  }
}