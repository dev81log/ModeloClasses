namespace Classes
{
    class Program
    {
        public static void Main(string[] args)
        {
            Produto p1 = new Produto();
            p1.SetCodito(1);
            p1.SetNome("Notebook");
            p1.SetPreco(2.500m);

            Console.WriteLine("Codigo: " + p1.GetCodito());
            Console.WriteLine("Nome..: " + p1.GetNome());
            Console.WriteLine("Preco.: " + p1.GetPreco());

            Console.Write("\n");

            Produto p2 = new Produto(2, "Smartphone", 4.500m);
            Console.WriteLine("Codigo: " + p2.GetCodito());
            Console.WriteLine("Nome..: " + p2.GetNome());
            Console.WriteLine("Preco.: " + p2.GetPreco());

        }
    }
}