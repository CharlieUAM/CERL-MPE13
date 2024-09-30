using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodo_de_burbuja.modelos
{
    internal class Bubble
    {
        public void Bsort(int[] array)
        {
            try {
                for(int i = 0; i  < array.Length; i++)
                {
                    for (int j = i+1; j < array.Length; j++)
                    {
                        if (array[j] < array[i])
                        {
                            int temp = array[j];
                            array[j] = array[i];
                            array[i] = temp;
                        }
                    }
                }
            } catch (Exception e) {
            
            }
        }
    }
}
