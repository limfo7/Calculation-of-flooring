using System.Linq;

namespace Calculator.Wfa.DataLayer
{
    public class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.CoverageTypes.Any())
            {
                context.CoverageTypes.AddRange(
                    new CoverageType { Name = "CeramicTile" },
                    new CoverageType { Name = "Linoleum" },
                    new CoverageType { Name = "Parquet" },
                    new CoverageType { Name = "ParquetBoard" },
                    new CoverageType { Name = "Carpet" },
                    new CoverageType { Name = "Laminate" }
                );
            }
            if (!context.Manufacturers.Any())
            {
                context.Manufacturers.AddRange(
                    new Manufacturer { Name = "OOO 'EuroService'" },
                    new Manufacturer { Name = "SAVEWOOD" },
                    new Manufacturer { Name = "GM Composite" }
                );
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product { Name = "Parquet Black (The first class)", Coast1 = 500, CoastOpt = 400, CoverageTypeId = 3, MabufacturerId = 2 },
                    new Product { Name = "Linoleum Ultra", Coast1 = 100, CoastOpt = 85, CoverageTypeId = 2, MabufacturerId = 1 },
                    new Product { Name = "Mramor Ceramic Type", Coast1 = 350, CoastOpt = 325, CoverageTypeId = 1, MabufacturerId = 3 }
                );
            }

            if (!context.Orders.Any())
            {
                context.Orders.Add(new Order { OrderNumber = "aasdc1", ProductId = 1 });
            }

            context.SaveChanges();
        }
    }
}
