using System;

namespace ftm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task1. String IndexOf methodunun 3 overloading-ni
            //(1-tek string qebul eden,
            //2-bir string ve index qebul eden,
            //3-bir string ,index ve count qebul eden) yazin.
            Console.WriteLine(IndexOf("codeacademy", 'l',3,4));
        }
        #region First overloading
        static int IndexOf(string word, char letter)
        {

            
            int index = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == letter)
                {
                    index += i;
                    break;
                }
            }
            return index;
            #endregion

            #region Second overloading

            static int IndexOf(string word, char letter, int index)
            {
                int araliq = 0;
                for (int i = index; i < word.Length; i++)
                {
                    if (word[i] == letter)
                    {
                        araliq = i - index;

                        break;
                    }
                }
                return araliq;

            }


            #endregion

            #region Third overloading

            static int IndexOf(string word, char letter, int index,int count)
            {


                for (int i = index; i < word.Length; i++)
                {
                    int step = 0;
                    if (word[i] == letter)
                    {
                        step = count + index;

                        
                    }
                    return step;
                }


                
            }
            
            #endregion

        }


    }
}
