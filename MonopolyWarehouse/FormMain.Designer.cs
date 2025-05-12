namespace MonopolyWarehouse
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeViewGrouped = new TreeView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            label1 = new Label();
            richTextBoxNodeInfo = new RichTextBox();
            tabPage2 = new TabPage();
            richTextBoxBoxesFromPallet = new RichTextBox();
            richTextBoxPalletFromTop3 = new RichTextBox();
            label3 = new Label();
            dataGridViewTop3Pallets = new DataGridView();
            richTextBoxConsole = new RichTextBox();
            buttonRecreate = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTop3Pallets).BeginInit();
            SuspendLayout();
            // 
            // treeViewGrouped
            // 
            treeViewGrouped.Location = new Point(6, 39);
            treeViewGrouped.Name = "treeViewGrouped";
            treeViewGrouped.Size = new Size(441, 366);
            treeViewGrouped.TabIndex = 0;
            treeViewGrouped.AfterSelect += treeViewGrouped_AfterSelect;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 134);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(663, 439);
            tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(richTextBoxNodeInfo);
            tabPage1.Controls.Add(treeViewGrouped);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(655, 411);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Сгруппированные паллеты";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(501, 6);
            label2.Name = "label2";
            label2.Size = new Size(148, 30);
            label2.TabIndex = 3;
            label2.Text = "Информация о паллете и\r\nо коробках в ней";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 6);
            label1.Name = "label1";
            label1.Size = new Size(439, 30);
            label1.TabIndex = 2;
            label1.Text = "Группы паллет по датам сроков годности. Сортировка групп по возрастанию.\r\nСортировка в группе по весу по возрастанию.";
            // 
            // richTextBoxNodeInfo
            // 
            richTextBoxNodeInfo.Location = new Point(453, 39);
            richTextBoxNodeInfo.Name = "richTextBoxNodeInfo";
            richTextBoxNodeInfo.Size = new Size(196, 366);
            richTextBoxNodeInfo.TabIndex = 1;
            richTextBoxNodeInfo.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(richTextBoxBoxesFromPallet);
            tabPage2.Controls.Add(richTextBoxPalletFromTop3);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(dataGridViewTop3Pallets);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(655, 411);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Топ 3 паллеты";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // richTextBoxBoxesFromPallet
            // 
            richTextBoxBoxesFromPallet.Location = new Point(289, 154);
            richTextBoxBoxesFromPallet.Name = "richTextBoxBoxesFromPallet";
            richTextBoxBoxesFromPallet.Size = new Size(277, 251);
            richTextBoxBoxesFromPallet.TabIndex = 3;
            richTextBoxBoxesFromPallet.Text = "";
            // 
            // richTextBoxPalletFromTop3
            // 
            richTextBoxPalletFromTop3.Location = new Point(6, 154);
            richTextBoxPalletFromTop3.Name = "richTextBoxPalletFromTop3";
            richTextBoxPalletFromTop3.Size = new Size(277, 251);
            richTextBoxPalletFromTop3.TabIndex = 2;
            richTextBoxPalletFromTop3.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 6);
            label3.Name = "label3";
            label3.Size = new Size(416, 30);
            label3.TabIndex = 1;
            label3.Text = "Топ 3 паллеты, содержащие коробки с максимальным сроком годности. \r\nНажмите на паллету, чтобы получить больше инфомрации.";
            // 
            // dataGridViewTop3Pallets
            // 
            dataGridViewTop3Pallets.AllowUserToAddRows = false;
            dataGridViewTop3Pallets.AllowUserToDeleteRows = false;
            dataGridViewTop3Pallets.AllowUserToResizeColumns = false;
            dataGridViewTop3Pallets.AllowUserToResizeRows = false;
            dataGridViewTop3Pallets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTop3Pallets.Location = new Point(6, 39);
            dataGridViewTop3Pallets.Name = "dataGridViewTop3Pallets";
            dataGridViewTop3Pallets.RowHeadersVisible = false;
            dataGridViewTop3Pallets.Size = new Size(643, 109);
            dataGridViewTop3Pallets.TabIndex = 0;
            dataGridViewTop3Pallets.CellClick += dataGridViewTop3Pallets_CellClick;
            // 
            // richTextBoxConsole
            // 
            richTextBoxConsole.Location = new Point(12, 12);
            richTextBoxConsole.Name = "richTextBoxConsole";
            richTextBoxConsole.Size = new Size(549, 116);
            richTextBoxConsole.TabIndex = 2;
            richTextBoxConsole.Text = "";
            // 
            // buttonRecreate
            // 
            buttonRecreate.Location = new Point(567, 12);
            buttonRecreate.Name = "buttonRecreate";
            buttonRecreate.Size = new Size(98, 23);
            buttonRecreate.TabIndex = 3;
            buttonRecreate.Text = "Пересоздать";
            buttonRecreate.UseVisualStyleBackColor = true;
            buttonRecreate.Click += buttonRecreate_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(687, 585);
            Controls.Add(buttonRecreate);
            Controls.Add(richTextBoxConsole);
            Controls.Add(tabControl1);
            Name = "FormMain";
            Text = "Склад";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTop3Pallets).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeViewGrouped;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private RichTextBox richTextBoxConsole;
        private RichTextBox richTextBoxNodeInfo;
        private Label label2;
        private Label label1;
        private DataGridView dataGridViewTop3Pallets;
        private Label label3;
        private RichTextBox richTextBoxPalletFromTop3;
        private RichTextBox richTextBoxBoxesFromPallet;
        private Button buttonRecreate;
    }
}
