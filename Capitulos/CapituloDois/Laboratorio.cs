namespace Capitulos.CapituloDois;

public class Laboratorio
{
    public static int[] SelectionSort(int[] list)
    {
        int i, j, lower;

        for(i = 0; i < list.Length; i++)
        {
            lower = list[i];

            for(j = i + 1; j < list.Length; j++)
            {
                if(list[j] < lower)
                {
                    list[i] = list[j];
                    list[j] = lower;
                }
            }
        }

        return list;
    }

    public static int[] BubbleSort(int[] list)
    {
        int i, lenght, element;

        lenght = list.Length;
        while(lenght > 1)
        {
            for(i = 0; i < lenght - 1; i++)
            {
                element = list[i];

                if(element > list[i + 1])
                {
                    list[i] = list[i + 1];
                    list[i + 1] = element;
                }
            }

            lenght--;
        }

        return list;
    }
}