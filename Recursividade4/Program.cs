class Program
{
    public static void Main(string[] args)
    {
        int[] vet = new int[] { -1, -3, 5, 6, -3 };
        int qntdNeg = 0;
        recursivoNegativo(vet, qntdNeg);
        for (int i = 0; i < vet.Length; i++)
            Console.Write(" " + vet[i]);
    }

    public static int[] recursivoNegativo(int[] vet, int qntdNeg, int i = 0)
    {
        if (i >= vet.Length)
        {
            Console.WriteLine($"Quantidade de Numeros Negativos : {qntdNeg}");
            return vet;
        }

        if (vet[i] < 0)
        {
            vet[i] = vet[i] * -1; // ERRO: Acessando vet[1] em vez de vet[i]
            qntdNeg++;

        }
        return recursivoNegativo(vet, qntdNeg, i + 1); // ERRO: Faltando qntdNeg como parâmetro
    }
}
