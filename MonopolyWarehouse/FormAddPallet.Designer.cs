namespace MonopolyWarehouse
{
    partial class FormAddPallet
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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBoxHeight = new TextBox();
            textBoxDepth = new TextBox();
            textBoxWidth = new TextBox();
            buttonAddPallet = new Button();
            buttonClose = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBoxHeight);
            panel1.Controls.Add(textBoxDepth);
            panel1.Controls.Add(textBoxWidth);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(234, 143);
            panel1.TabIndex = 0;
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
            textBoxDepth.Text = "100,0";
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(3, 18);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(146, 23);
            textBoxWidth.TabIndex = 0;
            textBoxWidth.Text = "100,0";
            // 
            // buttonAddPallet
            // 
            buttonAddPallet.Location = new Point(146, 161);
            buttonAddPallet.Name = "buttonAddPallet";
            buttonAddPallet.Size = new Size(100, 23);
            buttonAddPallet.TabIndex = 1;
            buttonAddPallet.Text = "Добавить";
            buttonAddPallet.UseVisualStyleBackColor = true;
            buttonAddPallet.Click += buttonAddPallet_Click;
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(12, 161);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(100, 23);
            buttonClose.TabIndex = 2;
            buttonClose.Text = "Отмена";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // FormAddPallet
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(258, 190);
            Controls.Add(buttonClose);
            Controls.Add(panel1);
            Controls.Add(buttonAddPallet);
            Name = "FormAddPallet";
            Text = "FormAddPallet";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonAddPallet;
        private TextBox textBoxWidth;
        private TextBox textBoxHeight;
        private TextBox textBoxDepth;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonClose;
    }
}