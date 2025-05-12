using Xunit;

namespace UnitTestApp.Tests
{
    public class PalletTest
    {
        [Fact]
        public void AddBox_ShouldAddBox()
        {
            var pallet = new Pallet(10, 10, 5);
            var box = new Box(2, 2, 2, 5, DateOnly.FromDateTime(DateTime.Today));
            pallet.AddBox(box);
            Assert.Contains(box, pallet.Boxes);
        }

        [Fact]
        public void AddBox_TooBig_ShouldThrow()
        {
            var pallet = new Pallet(2, 2, 2);
            var bigBox = new Box(3, 3, 3, 5, DateOnly.FromDateTime(DateTime.Today));
            Assert.Throws<ArgumentException>(() => pallet.AddBox(bigBox));
        }

        [Fact]
        public void Weight_ShouldIncludeBaseWeightAndBoxWeight()
        {
            var pallet = new Pallet(5, 5, 5);
            var box1 = new Box(1, 1, 1, 10, DateOnly.FromDateTime(DateTime.Today));
            var box2 = new Box(1, 1, 1, 5, DateOnly.FromDateTime(DateTime.Today));
            pallet.AddBox(box1);
            pallet.AddBox(box2);
            Assert.Equal(45, pallet.Weight); // 30 + 10 + 5
        }

        [Fact]
        public void ExpirationDate_ShouldBeEarliestAmongBoxes()
        {
            var pallet = new Pallet(10, 10, 10);
            var box1 = new Box(1, 1, 1, 1, new DateOnly(2025, 1, 1));
            var box2 = new Box(1, 1, 1, 1, new DateOnly(2025, 2, 1));
            pallet.AddBox(box1);
            pallet.AddBox(box2);
            Assert.Equal(box1.ExpirationDate, pallet.ExpirationDate);
        }

        [Fact]
        public void ExpirationDate_ShouldBeNullIfNoBoxes()
        {
            var pallet = new Pallet(1, 1, 1);
            Assert.Null(pallet.ExpirationDate);
        }
    }

    public class Pallet : WarehouseItem
    {
        public List<Box> Boxes = new List<Box>();
        public const double PalletBaseWeight = 30;
        public override double Weight
        {
            get
            {
                double sum = PalletBaseWeight;
                foreach (Box box in Boxes)
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
                if (Boxes.Count == 0) return null;
                return Boxes.Min(b => b.ExpirationDate);
            }
        }

        public override double Volume => base.Volume + Boxes.Sum(b => b.Volume);

        public Pallet(double Width, double Depth, double Height) : base(Width, Depth, Height, PalletBaseWeight)
        {
        }

        public void AddBox(Box box)
        {
            if (box.Width > Width || box.Depth > Depth)
            {
                throw new ArgumentException("Box is too big for the pallet");
            }
            Boxes.Add(box);
        }

        public void RemoveBox(Box box)
        {
            Boxes.Remove(box);
        }

        public override string ToString()
        {
            return base.ToString() + $"Expiration date :\t{ExpirationDate}\n";
        }
    }
}
