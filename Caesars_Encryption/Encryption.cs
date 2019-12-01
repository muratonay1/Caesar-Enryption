using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesars_Encryption
{
    class Encryption
    {
        public string Alphabet = "abcçdefgğhıijklmnoöprsştuüvyzwxq";
        public int i, j;
        //Şifreleme Metodu
        public string _Encryption(string Input_Text, int Key)
        {
            string Encrypted_Text = "";
            Input_Text = Input_Text.Trim();
            int Alphabet_Index;
            for (i = 0; i < Input_Text.Length; i++)
            {
                for (j = 0; j < Alphabet.Length; j++)
                {
                    if (Input_Text[i] == Alphabet[j])
                    {
                        //create an iterator
                        Alphabet_Index = j;
                        /*
                         * Girilen Key'in alfabe uzunluğuna göre modunu alıyoruz.
                         * Böylece key kaç girilse girilsin Örnek: 450 ve 614.631
                         * 450%32 = 2
                         * 614631%32 = 7
                         * Girilen Key'i sürekli Alfabe uzunluğu aralığına indirgemiş oluyoruz.
                         */
                        Key = Key % Alphabet.Length;
                        Alphabet_Index += Key;
                        if (Alphabet_Index > Alphabet.Length - 1)
                        {
                            /*
                             * Eğer Metin[i]+key indexi alfabe.length'i geçerse
                             * iteratörün alfabe başına dönmesi gerek.
                             */
                            Alphabet_Index = Alphabet_Index - Alphabet.Length;
                            Encrypted_Text += Alphabet[Alphabet_Index];
                        }
                        else
                        {
                            Encrypted_Text += Alphabet[Alphabet_Index];
                        }
                    }
                }
            }
            return Encrypted_Text;
        }
    }
}
