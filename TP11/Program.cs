using System;
using System.Linq;

namespace TP11
{
      class table {

            //declarer un tableau
            public table(int N)
            {
                int[] arr = new int[N];
            }
            //remplir un tableau
            static void array(int[] arr, int nbr)
            {
                int i;
                for (i = 0; i < arr.Length; i++)
                {
                    arr[i] = nbr;
                }
            }

            //rechercher un element dans le tableau

            static int Existe(int[] arr, int val)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (val == arr[i])
                        //retourner la position courante
                        return i;
                }
                return -1;//si il n'existe pas
            }
            //supprimer element
            static void supprimerEle(int[] arr,int valeur)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == valeur)
                    {
                        arr[i] = arr[i + 1];
                        break;
                    }
                }
            }

    
            //verifie si un tableau est vide ou non
            static int Vide(int[] arr)
            {

                if (arr.Length == 0)
                {
                    return 1;
                }
                return 0;

            }
            //verifie si un tableau est trie ou non
            static int Trie(int[] arr)
            {
                int i;
                for (i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < arr[i + 1])
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
            //renverser un tableau
            static int reverse(int[] arr) 
            {

                Array.Reverse(arr);
               



                
            }
        }
    }
}
