using MonopolyWarehouse.WarehouseObjects;

namespace MonopolyWarehouse
{
    public partial class FormAddBox : Form
    {
        private List<Box> boxes;
        public delegate void Notify();
        private Notify _method;
        public FormAddBox(List<Box> boxes, Notify method)
        {
            InitializeComponent();
            this.boxes = boxes;
            _method = method;
        }
        public FormAddBox(List<Box> boxes)
        {
            InitializeComponent();
            this.boxes = boxes;
        }

        private void buttonAddPallet_Click(object sender, EventArgs e)
        {
            double width;
            bool isWidth = double.TryParse(textBoxWidth.Text, out width);
            double depth;
            bool isDepth = double.TryParse(textBoxDepth.Text, out depth);
            double height;
            bool isHeight = double.TryParse(textBoxHeight.Text, out height);
            double weight;
            bool isWeight = double.TryParse(textBoxWeight.Text, out weight);
            DateOnly productiondate = DateOnly.FromDateTime(dateTimePickerProductionDate.Value);
            if (!isWidth || !isDepth || !isHeight || !isWeight)
            {
                MessageBox.Show("Please enter valid dimensions.");
                return;
            }
            Box box = new Box(width, depth, height, weight, productiondate);
            boxes.Add(box);
            if (_method != null) _method();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
