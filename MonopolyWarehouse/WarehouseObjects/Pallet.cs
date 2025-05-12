namespace MonopolyWarehouse.WarehouseObjects
{
    public class Pallet : WarehouseItem
    {
        private List<Box> _boxes = new List<Box>();
        public const double PalletBaseWeight = 30;
        public override double Weight
        {
            get
            {
                double sum = PalletBaseWeight;
                foreach (Box box in _boxes)
                {
                    sum += box.Weight;
                }
                return sum;
            }
        }

        public DateOnly? ExpirationDate
        {
            get
            {
                if (_boxes.Count == 0) return null;
                return _boxes.Min(b => b.ExpirationDate);
            }
        }

        public override double Volume => base.Volume + _boxes.Sum(b => b.Volume);

        public Pallet(double Width, double Depth, double Height) : base(Width, Depth, Height, PalletBaseWeight)
        {
        }

        public void AddBox(Box box)
        {
            if (box.Width > Width || box.Depth > Depth)
            {
                throw new ArgumentException("Box is too big for the pallet");
            }
            _boxes.Add(box);
        }

        public void RemoveBox(Box box)
        {
            _boxes.Remove(box);
        }

        public List<Box> GetBoxes()
        {
            return _boxes;
        }

        public override string ToString()
        {
            return $"ID :\t{Id}\nItem :\t{GetType().Name}\nWidth :\t{Width}\nDepth :\t{Depth}\nHeight :\t{Height}\nWeight :\t{Weight:F2}\nVolume :\t{Volume:F2}\n" + $"Boxes count :\t{_boxes.Count}\nExpiration date :\t{ExpirationDate}\n";
        }
    }
}
