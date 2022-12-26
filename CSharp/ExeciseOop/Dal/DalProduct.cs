namespace ExeciseOop
{
    internal class DalProduct : IProduct
    {   
        public List<Product> ListPro { get; set; } =  new();
        
        public void AddProduct() 
        {
            Console.WriteLine("Enter the number of product");
            var n = Validate<int>.CheckReadLine();

            for (int i = 0; i < n; i++)
            {
                Product pro = new();
                Console.WriteLine($"Product[{i+1}] => Enter id product: ");
                pro.Proid = Validate<string>.CheckReadLine();

                ListPro.Add(pro);
            }
        }
    }
}
