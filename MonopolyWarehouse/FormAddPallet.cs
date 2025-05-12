using MonopolyWarehouse.WarehouseObjects;

namespace MonopolyWarehouse
{
    public partial class FormAddPallet : Form
    {
        private List<Pallet> pallets;
        public delegate void Notify();
        private Notify _method;
        public FormAddPallet(List<Pallet> pallets, Notify method)
        {
            InitializeComponent();
            this.pallets = pallets;
            _method = method;
        }
        public FormAddPallet(List<Pallet> pallets)
        {
            InitializeComponent();
            this.pallets = pallets;
        }

        private void buttonAddPallet_Click(object sender, EventArgs e)
        {
            double width;
            bool isWidth = double.TryParse(textBoxWidth.Text, out width);
            double depth;
            bool isDepth = double.TryParse(textBoxDepth.Text, out depth);
            double height;
            bool isHeight = double.TryParse(textBoxHeight.Text, out height);
            if (!isWidth || !isDepth || !isHeight)
            {
                MessageBox.Show("Please enter valid dimensions.");
                return;
            }
            Pallet pallet = new Pallet(width, depth, height);
            pallets.Add(pallet);
            if (_method != null) _method();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
