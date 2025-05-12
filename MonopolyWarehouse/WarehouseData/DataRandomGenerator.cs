using MonopolyWarehouse.WarehouseObjects;

namespace MonopolyWarehouse.WarehouseData
{
    internal class DataRandomGenerator : IDataProvider
    {
        private Random rnd;
        public int minBoxesDimensions = 1;
        public int maxBoxesDimensions = 50;
        public int minPalletsDimensions = 75;
        public int maxPalletsDimensions = 100;
        public int boxesCount = 1000;
        public int palletsCount = 100;
        public DataRandomGenerator(int seed)
        {
            rnd = new Random(seed);
        }
        public DataRandomGenerator()
        {
            rnd = new Random();
        }
        public List<Pallet> GetPallets()
        {
            List<Box> boxes = GetBoxes();
            List<Pallet> pallets = new List<Pallet>();
            for (int i = 0; i < palletsCount; i++)
            {
                double width = Math.Round(rnd.NextDouble() * (maxPalletsDimensions - minPalletsDimensions) + minPalletsDimensions, 2);
                double depth = Math.Round(rnd.NextDouble() * (maxPalletsDimensions - minPalletsDimensions) + minPalletsDimensions, 2);
                double height = Math.Round(rnd.NextDouble() * (maxPalletsDimensions - minPalletsDimensions) + minPalletsDimensions, 2);
                pallets.Add(new Pallet(width, depth, height));
            }
            foreach (var b in boxes)
            {
                int palletIndex = rnd.Next(0, pallets.Count);
                pallets[palletIndex].AddBox(b);
            }
            return pallets;
        }
        public List<Box> GetBoxes()
        {
            List<Box> boxes = new List<Box>();
            for (int i = 0; i < boxesCount; i++)
            {
                double width = Math.Round(rnd.NextDouble() * (maxBoxesDimensions - minBoxesDimensions) + minBoxesDimensions, 2);
                double depth = Math.Round(rnd.NextDouble() * (maxBoxesDimensions - minBoxesDimensions) + minBoxesDimensions, 2);
                double height = Math.Round(rnd.NextDouble() * (maxBoxesDimensions - minBoxesDimensions) + minBoxesDimensions, 2);
                double weight = Math.Round(rnd.NextDouble() * (maxBoxesDimensions - minBoxesDimensions) + minBoxesDimensions, 2);
                DateOnly productionDate = DateOnly.FromDateTime(DateTime.Now.AddDays(rnd.Next(1, 5000)));
                boxes.Add(new Box(width, depth, height, weight, productionDate));
            }
            return boxes;
        }
    }
}
