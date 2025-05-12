using Xunit;

namespace UnitTestApp.Tests
{
    public class BoxTest
    {
        [Fact]
        public void ExpirationDate_ShouldBe100DaysAfterProduction()
        {
            var production = new DateOnly(2025, 1, 1);
            var box = new Box(1, 1, 1, 1, production);
            var expectedExpiration = production.AddDays(100);
            Assert.Equal(expectedExpiration, box.ExpirationDate);
        }

        [Fact]
        public void SettingExpirationDate_ShouldThrow()
        {
            var box = new Box(1, 1, 1, 1, DateOnly.FromDateTime(DateTime.Today));
            Assert.Throws<NotSupportedException>(() => box.ExpirationDate = DateOnly.FromDateTime(DateTime.Today.AddDays(50)));
        }
    }

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
