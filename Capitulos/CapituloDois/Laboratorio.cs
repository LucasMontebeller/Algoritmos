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
}