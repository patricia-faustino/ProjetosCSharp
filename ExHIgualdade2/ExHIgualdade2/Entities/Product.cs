namespace ExHIgualdade2.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        //Comparacao por conteudo 
        public override int GetHashCode()
        {
            return Name.GetHashCode()+Price.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            //Programacao defensiva
            if(!(obj is Product))
            {
                return false;
            }
            //DownCasting
            Product other = obj as Product;
            return Name.Equals(other.Name) && Price.Equals(other.Price);

        }
    }
}
