using System;

namespace _6º_exercise
{
    public class Cheque
    {
        int primeiro_cheque, ultimo_cheque;

        public Cheque(int primeiro_cheque, int ultimo_cheque)
        {
            this.primeiro_cheque = primeiro_cheque;
            this.ultimo_cheque = ultimo_cheque;
        }

        public void DevolveInfo()
        {
            Console.WriteLine("Primeiro Cheque: " + primeiro_cheque);
            Console.WriteLine("Último Cheque: " + ultimo_cheque);
        }
    }
}
