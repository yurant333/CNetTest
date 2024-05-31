public static class Program
{
    // Тема 1: Extension-методы
    public static class OrderExtensions
    {
        public static IEnumerable<Product> GetExpensiveProducts(this Order order, decimal price)
        {
        }
    }
    
    // Тема 2: yield return / yield break
    public static IEnumerable<Product> GetProductsByCategory(IEnumerable<Order> orders, string category)
    {
    }
    
    // Тема 3: Рефлексия
    public static class ReflectionUtils
    {
        public static void PrintProductProperties(Product product)
        {
        }
    
        public static void SetPrivateField<T>(T obj, string fieldName, object value)
        {
        }
    }
    
    // Тема 4: async/await
    public class ProductService
    {
        public async Task<List<Product>> LoadProductsAsync(CancellationToken cancellationToken)
        {
        }
    }
    
    // Классы для продуктов и заказов
    public record Product(string Name, string Category, decimal Price);
    
    public class Order
    {
        public List<Product> Products { get; set; } = new List<Product>();
    }
    
    public static async Task Main()
    {
        var order = new Order();
        order.Products.Add(new Product("Laptop", "Electronics", 1200m));
        order.Products.Add(new Product("Book", "Books", 15m));

        // Extension-методы

        // yield return / yield break

        // Рефлексия

        // async/await
    }
}