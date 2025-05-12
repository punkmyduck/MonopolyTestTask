using MonopolyWarehouse.WarehouseData;
using MonopolyWarehouse.WarehouseObjects;

namespace MonopolyWarehouse
{
    internal class WarehouseService
    {
        private readonly IDataProvider _dataProvider;
        private List<Pallet> _pallets;

        public WarehouseService(IDataProvider DataProvider)
        {
            _dataProvider = DataProvider;
            _pallets = new List<Pallet>();
        }

        /// <summary>
        /// Загружает паллеты из источника данных.
        /// </summary>
        public void LoadData()
        {
            _pallets = _dataProvider.GetPallets();
        }

        /// <summary>
        /// Группирует паллеты по сроку годности, сортирует группы по сроку, а в группах по весу.
        /// </summary>
        /// <returns>Слоаврь с группами паллет по сроку годности</returns>
        public Dictionary<DateOnly, List<Pallet>> GroupPalletsByExpirationSorted()
        {
            return _pallets
                .Where(p => p.ExpirationDate != null)
                .GroupBy(p => p.ExpirationDate.Value)
                .OrderBy(g => g.Key)
                .ToDictionary(
                g => g.Key,
                g => g.OrderBy(p => p.Weight).ToList()
                );
        }

        /// <summary>
        /// Возвращает 3 паллеты с самым поздним сроком годности, отсортированные по объему.
        /// </summary>
        public List<Pallet> GetTop3PalletsByBoxExpirationSortedByVolume()
        {
            return _pallets
                .Where(p => p.GetBoxes().Any())
                .OrderByDescending(p => p.GetBoxes().Max(b => b.ExpirationDate))
                .ThenBy(p => p.Volume)
                .Take(3)
                .ToList();
        }

        /// <summary>
        /// Возвращает текущий список паллет.
        /// </summary>
        public List<Pallet> GetAllPallets()
        {
            return _pallets;
        }
    }
}
