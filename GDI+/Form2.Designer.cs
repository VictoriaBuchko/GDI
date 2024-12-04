namespace GDI_
{
    partial class Form2
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
            if (disposing)
            {
                TextPreviewUpdated = null;
                SelectedFont?.Dispose();
                components?.Dispose();
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
            TextBoxText = new TextBox();
            numericUpDownX = new NumericUpDown();
            numericUpDownY = new NumericUpDown();
            LabelEnterText = new Label();
            labelX = new Label();
            labelY = new Label();
            labelXY = new Label();
            panel1 = new Panel();
            buttonAddText = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // TextBoxText
            // 
            TextBoxText.Location = new Point(35, 90);
            TextBoxText.Name = "TextBoxText";
            TextBoxText.Size = new Size(294, 27);
            TextBoxText.TabIndex = 0;
            TextBoxText.TextChanged += TextBoxText_TextChanged_1;
            // 
            // numericUpDownX
            // 
            numericUpDownX.Location = new Point(8, 49);
            numericUpDownX.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numericUpDownX.Name = "numericUpDownX";
            numericUpDownX.Size = new Size(150, 27);
            numericUpDownX.TabIndex = 1;
            numericUpDownX.ValueChanged += numericUpDownX_ValueChanged;
            // 
            // numericUpDownY
            // 
            numericUpDownY.Location = new Point(8, 131);
            numericUpDownY.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDownY.Name = "numericUpDownY";
            numericUpDownY.Size = new Size(150, 27);
            numericUpDownY.TabIndex = 2;
            numericUpDownY.ValueChanged += numericUpDownY_ValueChanged;
            // 
            // LabelEnterText
            // 
            LabelEnterText.AutoSize = true;
            LabelEnterText.Location = new Point(35, 46);
            LabelEnterText.Name = "LabelEnterText";
            LabelEnterText.Size = new Size(98, 20);
            LabelEnterText.TabIndex = 3;
            LabelEnterText.Text = "Введіть текст";
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Location = new Point(7, 8);
            labelX.Name = "labelX";
            labelX.Size = new Size(173, 20);
            labelX.TabIndex = 4;
            labelX.Text = "Введіть кординати по X";
            // 
            // labelY
            // 
            labelY.AutoSize = true;
            labelY.Location = new Point(8, 95);
            labelY.Name = "labelY";
            labelY.Size = new Size(172, 20);
            labelY.TabIndex = 5;
            labelY.Text = "Введіть кординати по Y";
            // 
            // labelXY
            // 
            labelXY.AutoSize = true;
            labelXY.Location = new Point(66, 146);
            labelXY.Name = "labelXY";
            labelXY.Size = new Size(212, 20);
            labelXY.TabIndex = 6;
            labelXY.Text = "Розташування тексту на фото";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(labelY);
            panel1.Controls.Add(labelX);
            panel1.Controls.Add(numericUpDownY);
            panel1.Controls.Add(numericUpDownX);
            panel1.Location = new Point(35, 180);
            panel1.Name = "panel1";
            panel1.Size = new Size(294, 183);
            panel1.TabIndex = 7;
            // 
            // buttonAddText
            // 
            buttonAddText.Location = new Point(107, 394);
            buttonAddText.Name = "buttonAddText";
            buttonAddText.Size = new Size(94, 29);
            buttonAddText.TabIndex = 8;
            buttonAddText.Text = "Add Text";
            buttonAddText.UseVisualStyleBackColor = true;
            buttonAddText.Click += buttonAddText_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(367, 439);
            Controls.Add(buttonAddText);
            Controls.Add(panel1);
            Controls.Add(labelXY);
            Controls.Add(LabelEnterText);
            Controls.Add(TextBoxText);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)numericUpDownX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownY).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TextBoxText;
        private NumericUpDown numericUpDownX;
        private NumericUpDown numericUpDownY;
        private Label LabelEnterText;
        private Label labelX;
        private Label labelY;
        private Label labelXY;
        private Panel panel1;
        private Button buttonAddText;
    }
}