namespace Capitulos.CapituloDois;

public class Exercicios
{
    // 2.1-1
    public static int[] InsertionSort(int[] list)
    {
        int i, j, element;
        
        for(i = 1; i < list.Length; i++)
        {
            element = list[i];
            j = i - 1;

            while(j >= 0 && element < list[j])
            {
                list[j + 1] = list[j];
                j--;
            }

            list[j + 1] = element;
        }

        return list;
    }

}