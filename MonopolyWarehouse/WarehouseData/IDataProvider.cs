using MonopolyWarehouse.WarehouseObjects;

namespace MonopolyWarehouse.WarehouseData
{
    internal interface IDataProvider
    {
        List<Pallet> GetPallets();
        List<Box> GetBoxes();
    }
}
