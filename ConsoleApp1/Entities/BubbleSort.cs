namespace ConsoleApp1.Entities
{
    public class BubbleSort
    {

        public void MakeSort(int[] numeros)
        {
            int tamanho = numeros.Length;

            for (int i = 0; i < tamanho - 1; i++)
            {
                for (int j = 0; j < tamanho - i - 1; j++)
                {
                    if (numeros[j] > numeros[j + 1])
                    {
                        int temp = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = temp;
                    }
                }
            }
        }
    }
}
