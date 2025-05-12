namespace MonopolyWarehouse
{
    partial class FormAddBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonClose = new Button();
            panel1 = new Panel();
            label5 = new Label();
            dateTimePickerProductionDate = new DateTimePicker();
            textBoxWeight = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxHeight = new TextBox();
            textBoxDepth = new TextBox();
            textBoxWidth = new TextBox();
            buttonAddPallet = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(8, 246);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(100, 23);
            buttonClose.TabIndex = 5;
            buttonClose.Text = "Отмена";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateTimePickerProductionDate);
            panel1.Controls.Add(textBoxWeight);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxHeight);
            panel1.Controls.Add(textBoxDepth);
            panel1.Controls.Add(textBoxWidth);
            panel1.Location = new Point(8, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 230);
            panel1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 176);
            label5.Name = "label5";
            label5.Size = new Size(110, 15);
            label5.TabIndex = 10;
            label5.Text = "Дата производства";
            // 
            // dateTimePickerProductionDate
            // 
            dateTimePickerProductionDate.Location = new Point(3, 194);
            dateTimePickerProductionDate.Name = "dateTimePickerProductionDate";
            dateTimePickerProductionDate.Size = new Size(200, 23);
            dateTimePickerProductionDate.TabIndex = 9;
            // 
            // textBoxWeight
            // 
            textBoxWeight.Location = new Point(3, 150);
            textBoxWeight.Name = "textBoxWeight";
            textBoxWeight.Size = new Size(146, 23);
            textBoxWeight.TabIndex = 8;
            textBoxWeight.Text = "2,0";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 132);
            label4.Name = "label4";
            label4.Size = new Size(26, 15);
            label4.TabIndex = 7;
            label4.Text = "Вес";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 88);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 6;
            label3.Text = "Высота";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 44);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 5;
            label2.Text = "Глубина";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 4;
            label1.Text = "Ширина";
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(3, 106);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(146, 23);
            textBoxHeight.TabIndex = 3;
            textBoxHeight.Text = "30,0";
            // 
            // textBoxDepth
            // 
            textBoxDepth.Location = new Point(3, 62);
            textBoxDepth.Name = "textBoxDepth";
            textBoxDepth.Size = new Size(146, 23);
            textBoxDepth.TabIndex = 2;
            textBoxDepth.Text = "30,0";
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(3, 18);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(146, 23);
            textBoxWidth.TabIndex = 0;
            textBoxWidth.Text = "30,0";
            // 
            // buttonAddPallet
            // 
            buttonAddPallet.Location = new Point(142, 246);
            buttonAddPallet.Name = "buttonAddPallet";
            buttonAddPallet.Size = new Size(100, 23);
            buttonAddPallet.TabIndex = 4;
            buttonAddPallet.Text = "Добавить";
            buttonAddPallet.UseVisualStyleBackColor = true;
            buttonAddPallet.Click += buttonAddPallet_Click;
            // 
            // FormAddBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(249, 275);
            Controls.Add(buttonClose);
            Controls.Add(panel1);
            Controls.Add(buttonAddPallet);
            Name = "FormAddBox";
            Text = "Добавление коробок";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonClose;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxHeight;
        private TextBox textBoxDepth;
        private TextBox textBoxWidth;
        private Button buttonAddPallet;
        private TextBox textBoxWeight;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePickerProductionDate;
    }
}