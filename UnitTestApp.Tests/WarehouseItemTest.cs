using Xunit;

namespace UnitTestApp.Tests
{
    public class WarehouseItemTest
    {
        [Fact]
        public void Constructor_ShouldSetPropertiesCorrectly()
        {
            var item = new WarehouseItemNotAbstract(10, 20, 30, 40);
            Assert.Equal(10, item.Width);
            Assert.Equal(20, item.Depth);
            Assert.Equal(30, item.Height);
            Assert.Equal(40, item.Weight);
            Assert.Equal(6000, item.Volume);
        }

        [Fact]
        public void SettingNegativeWeight_ShouldThrow()
        {
            var item = new WarehouseItemNotAbstract(10, 20, 30, 40);
            Assert.Throws<ArgumentException>(() => item.Weight = -10);
        }
    }

    public class WarehouseItemNotAbstract : WarehouseItem
    {
        public WarehouseItemNotAbstract(double Width, double Depth, double Height, double Weight) : base(Width, Depth, Height, Weight)
        {
        }
    }

    public abstract class WarehouseItem
    {
        private static int _id = 0;
        public int Id;
        protected double _width;
        protected double _depth;
        protected double _height;
        protected double _weight;

        public double Width
        {
            get => _width;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Width must be a positive number.");
                _width = value;
            }
        }
        public double Depth
        {
            get => _depth;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Depth must be a positive number.");
                _depth = value;
            }
        }
        public double Height
        {
            get => _height;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Height must be a positive number.");
                _height = value;
            }
        }
        public virtual double Weight
        {
            get => _weight;
            set
            {
                if (value < 0)
                    throw new ArgumentException("Weight cannot be negative.");
                _weight = value;
            }
        }

        public virtual double Volume => Width * Depth * Height;

        public WarehouseItem(double Width, double Depth, double Height, double Weight)
        {
            this.Depth = Depth;
            this.Width = Width;
            this.Height = Height;
            this.Weight = Weight;
            Id = _id++;
        }

        public override string ToString()
        {
            return $"ID :\t{Id}\nItem :\t{GetType().Name}\nWidth :\t{Width}\nDepth :\t{Depth}\nHeight :\t{Height}\nWeight :\t{Weight}\nVolume :\t{Volume}\n";
        }
    }
}
