namespace MonopolyWarehouse.WarehouseObjects
{
    public class Box : WarehouseItem
    {
        public DateOnly ProductionDate { get; set; }
        public DateOnly ExpirationDate
        {
            get
            {
                return ProductionDate.AddDays(100);
            }
            set
            {
                throw new NotSupportedException("Direct expiration date setting is not supported. Expiration date is calculated based on production date.");
            }
        }
        public Box(double Width, double Depth, double Height, double Weight, DateOnly ProductionDate) : base(Width, Depth, Height, Weight)
        {
            this.ProductionDate = ProductionDate;
        }

        public override string ToString()
        {
            return base.ToString() + $"Production date :\t{ProductionDate}\nExpiration date :\t{ExpirationDate}\n";
        }
    }
}
