namespace EFCore;

using EFCore.Model;
using Microsoft.EntityFrameworkCore;

partial class Program {
    static void FilterAndSort() {
        SectionTitle("Filter And Sort");

        using Northwind db = new();
        DbSet<Product> allProducts = db.Products;
        IQueryable<Product> filteredProducts = allProducts.Where(product => product.Cost < 10);

        IOrderedQueryable<Product> sortedAndFilteredProducts = filteredProducts.OrderByDescending(product => product.Cost);

        foreach (Product p in sortedAndFilteredProducts)
        {
            WriteLine("{0}: {1} costs {2:$#,##0.00}", p.ProductId, p.ProductName, p.Cost);
        }

        WriteLine();
    }
}
