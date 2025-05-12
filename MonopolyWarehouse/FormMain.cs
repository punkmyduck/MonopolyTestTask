using System.Text.RegularExpressions;
using MonopolyWarehouse.WarehouseData;

namespace MonopolyWarehouse
{
    public partial class FormMain : Form
    {
        WarehouseService service;
        public FormMain()
        {
            InitializeComponent();
            DataRandomGenerator provider = new DataRandomGenerator();
            service = new WarehouseService(provider);
            service.LoadData();
            richTextBoxConsole.AppendText($"Успешно сгенерированы и загружены случайные данные о паллетах ({provider.palletsCount}) и коробках ({provider.boxesCount}) на складе.");
        }

        private void buttonRecreate_Click(object sender, EventArgs e)
        {
            DataRandomGenerator provider = new DataRandomGenerator();
            service = new WarehouseService(provider);
            service.LoadData();
            richTextBoxConsole.Clear();
            richTextBoxConsole.AppendText($"Успешно сгенерированы и загружены случайные данные о паллетах ({provider.palletsCount}) и коробках ({provider.boxesCount}) на складе.");
            Form1_Load(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            treeViewGrouped.Nodes.Clear();

            var grouped = service.GroupPalletsByExpirationSorted();

            foreach (var group in grouped)
            {
                var groupNode = new TreeNode(group.Key.ToString());
                foreach (var pallet in group.Value)
                {
                    var nodeText = $"{pallet.ToString()}";
                    groupNode.Nodes.Add(new TreeNode(nodeText));
                }
                treeViewGrouped.Nodes.Add(groupNode);
            }

            var topPallets = service.GetTop3PalletsByBoxExpirationSortedByVolume();
            dataGridViewTop3Pallets.DataSource = topPallets.Select(p => new
            {
                ID = p.Id,
                MaxExpiration = p.GetBoxes().Max(b => b.ExpirationDate),
                Volume = $"{p.Volume:F2}",
                p.GetBoxes().Count
            }).ToList();
        }

        private void treeViewGrouped_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent == null) return;
            string text = e.Node.Text;
            richTextBoxNodeInfo.Clear();
            richTextBoxNodeInfo.AppendText("Получена информация о паллете:\n" + text);

            var match = Regex.Match(text, @"ID :\t(\d+)");
            if (match.Success)
            {
                int palletId = int.Parse(match.Groups[1].Value);
                var pallet = service.GetAllPallets().FirstOrDefault(p => p.Id == palletId);
                var boxes = pallet.GetBoxes();
                richTextBoxNodeInfo.AppendText("\nПолучена информация о коробках в паллете:\n");
                foreach (var box in boxes)
                {
                    richTextBoxNodeInfo.AppendText(box.ToString() + "\n");
                }
            }
        }

        private void dataGridViewTop3Pallets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int palletId = int.Parse(dataGridViewTop3Pallets.Rows[e.RowIndex].Cells[0].Value.ToString());
            var pallet = service.GetAllPallets().FirstOrDefault(p => p.Id == palletId);
            richTextBoxPalletFromTop3.Clear();
            richTextBoxPalletFromTop3.AppendText(pallet.ToString());
            richTextBoxBoxesFromPallet.Clear();
            foreach (var box in pallet.GetBoxes())
            {
                richTextBoxBoxesFromPallet.AppendText(box.ToString() + "\n");
            }
        }
    }
}
