namespace Kursavaya2Kurs.Model
{

    public class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsWeighable { get; set; }

        public decimal GetTotalPrice(decimal quantityOrWeight)
        {
            return Price * quantityOrWeight;
        }
    }
}