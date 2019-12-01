using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesars_Encryption
{
    class Decryption
    {
        public string Alphabet = "abcçdefgğhıijklmnoöprsştuüvyzwxq";
        public int i, j;
        //Şifre Çözme Metodu
        public string _Decryption(string Encrypted_Text, int Key)
        {
            string Decrypted_Text = "";
            int Alphabet_Index;

            for (i = 0; i < Encrypted_Text.Length; i++)
            {
                for (j = 0; j < Alphabet.Length; j++)
                {
                    if (Encrypted_Text[i] == Alphabet[j])
                    {
                        Alphabet_Index = j;                       
                        Key = Key % Alphabet.Length;
                        //Geriye doğru arama yerine kullanılacak formül
                        //Formul:
                        /*
                         * -----Ornegin harf=a, key=24 ise bize 'g' harfini vermesi lazım
                         * a indisi 0'dır. Alfabe uzunluğumuz 32 ve döngüde j=0
                         * çözüm= 
                         * 1-) 32-key(24)=8
                         * 2-) 8+j(0)=8
                         */
                        Alphabet_Index = Alphabet.Length - Key + j;
                        if (Alphabet_Index > Alphabet.Length - 1)
                        {
                            Alphabet_Index = Alphabet_Index - Alphabet.Length;
                            Decrypted_Text += Alphabet[Alphabet_Index];
                        }
                        else
                        {
                            Decrypted_Text += Alphabet[Alphabet_Index];
                        }
                    }
                }
            }
            return Decrypted_Text;

        }
    }
}
