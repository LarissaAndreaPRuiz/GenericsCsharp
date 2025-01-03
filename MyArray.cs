using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeSerializerNugetAttributes.Models
{
    public class MyArray<T>
    {
        private static int capacity = 10;
        private int contador = 0;
        private T[] array = new T[capacity];

        public void AddElementArray(T element){
            if (contador +1 < 11 ){
                array[contador] = element;
            }
            contador++;
        }
        public T this [int index]{
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
}
