using FStoreAppLibrary.Models;

namespace FStoreAppLibrary.Data_Layer
{
    public class ProductDBContext
    {
        private static ProductDBContext instance = null;
        private static readonly object instanceLock = new object();
        private ProductDBContext() { }

        public static ProductDBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDBContext();
                    }
                    return instance;
                }
            }
        }

        public List<Product> GetProducts()
        {
            using (FStoreContext fStoreContext = new FStoreContext())
            {
                return fStoreContext.Products.ToList();
            }
        }

        public Product GetProductById(int producId)
        {
            using (FStoreContext fStoreContext = new FStoreContext())
            {
                Product product = fStoreContext.Products.Find(producId);
                return product;
            }
        }

        public Boolean Delete(int producId)
        {
            Product product = GetProductById(producId);

            if (product != null)
            {
                using (FStoreContext fStoreContext = new FStoreContext())
                {
                    fStoreContext.Products.Remove(product);
                    fStoreContext.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public Boolean Update(Product product)
        {
            Product product1 = GetProductById(product.ProductId);

            if (product1 != null)
            {
                using (FStoreContext fStoreContext = new FStoreContext())
                {
                    fStoreContext.Products.Attach(product);
                    fStoreContext.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    fStoreContext.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public Boolean Insert(Product product)
        {
            Product product1 = GetProductById(product.ProductId);

            if (product1 == null)
            {
                using (FStoreContext fStoreContext = new FStoreContext())
                {
                    fStoreContext.Products.Attach(product);
                    fStoreContext.Products.Add(product);
                    fStoreContext.SaveChanges();
                    return true;
                }
            }
            return false;
        }

    }
}
