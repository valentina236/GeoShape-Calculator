namespace Lab5
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBoxViewFigure = new GroupBox();
            radioButtonVolumFigure = new RadioButton();
            radioButtonFlatFigure = new RadioButton();
            comboBoxFigure = new ComboBox();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            ButtonCalculate = new RJButton();
            textBoxFigurName = new TextBox();
            labelFigurName = new Label();
            panel1 = new Panel();
            pictureBoxExit = new PictureBox();
            panel2 = new Panel();
            pictureBox8 = new PictureBox();
            pictureBox7 = new PictureBox();
            labelNazvn = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ButtonDesigFigure = new RJButton();
            pictureBoxFigure = new PictureBox();
            ButtonClear = new RJButton();
            groupBoxViewFigure.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFigure).BeginInit();
            SuspendLayout();
            // 
            // groupBoxViewFigure
            // 
            groupBoxViewFigure.BackColor = Color.Aquamarine;
            groupBoxViewFigure.Controls.Add(radioButtonVolumFigure);
            groupBoxViewFigure.Controls.Add(radioButtonFlatFigure);
            groupBoxViewFigure.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBoxViewFigure.Location = new Point(115, 191);
            groupBoxViewFigure.Margin = new Padding(3, 4, 3, 4);
            groupBoxViewFigure.Name = "groupBoxViewFigure";
            groupBoxViewFigure.Padding = new Padding(3, 4, 3, 4);
            groupBoxViewFigure.Size = new Size(219, 125);
            groupBoxViewFigure.TabIndex = 4;
            groupBoxViewFigure.TabStop = false;
            groupBoxViewFigure.Text = "Вид фигуры";
            // 
            // radioButtonVolumFigure
            // 
            radioButtonVolumFigure.AutoSize = true;
            radioButtonVolumFigure.Location = new Point(19, 69);
            radioButtonVolumFigure.Margin = new Padding(3, 4, 3, 4);
            radioButtonVolumFigure.Name = "radioButtonVolumFigure";
            radioButtonVolumFigure.Size = new Size(180, 28);
            radioButtonVolumFigure.TabIndex = 1;
            radioButtonVolumFigure.TabStop = true;
            radioButtonVolumFigure.Text = "Объемная фигура";
            radioButtonVolumFigure.UseVisualStyleBackColor = true;
            radioButtonVolumFigure.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // radioButtonFlatFigure
            // 
            radioButtonFlatFigure.AutoSize = true;
            radioButtonFlatFigure.Location = new Point(19, 35);
            radioButtonFlatFigure.Margin = new Padding(3, 4, 3, 4);
            radioButtonFlatFigure.Name = "radioButtonFlatFigure";
            radioButtonFlatFigure.Size = new Size(167, 28);
            radioButtonFlatFigure.TabIndex = 0;
            radioButtonFlatFigure.TabStop = true;
            radioButtonFlatFigure.Text = "Плоская фигура";
            radioButtonFlatFigure.UseVisualStyleBackColor = true;
            radioButtonFlatFigure.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // comboBoxFigure
            // 
            comboBoxFigure.BackColor = SystemColors.Info;
            comboBoxFigure.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFigure.Font = new Font("Comic Sans MS", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            comboBoxFigure.ForeColor = SystemColors.ControlText;
            comboBoxFigure.FormattingEnabled = true;
            comboBoxFigure.Location = new Point(364, 222);
            comboBoxFigure.Margin = new Padding(3, 4, 3, 4);
            comboBoxFigure.MaxDropDownItems = 5;
            comboBoxFigure.Name = "comboBoxFigure";
            comboBoxFigure.Size = new Size(168, 32);
            comboBoxFigure.TabIndex = 5;
            comboBoxFigure.SelectedIndexChanged += comboBoxFigure_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(115, 352);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 6;
            label1.Text = "label1";
            label1.Visible = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.Font = new Font("Courier New", 10.2F);
            textBox1.Location = new Point(388, 345);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 7;
            textBox1.Visible = false;
            textBox1.TextChanged += TextBox_TextChanged;
            textBox1.KeyPress += textBox_KeyPress;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(224, 224, 224);
            textBox2.Font = new Font("Courier New", 10.2F);
            textBox2.Location = new Point(388, 399);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 9;
            textBox2.Visible = false;
            textBox2.TextChanged += TextBox_TextChanged;
            textBox2.KeyPress += textBox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(115, 406);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 8;
            label2.Text = "label2";
            label2.Visible = false;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(224, 224, 224);
            textBox3.Font = new Font("Courier New", 10.2F);
            textBox3.Location = new Point(388, 452);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 11;
            textBox3.Visible = false;
            textBox3.TextChanged += TextBox_TextChanged;
            textBox3.KeyPress += textBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Courier New", 10.2F);
            label3.Location = new Point(115, 459);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 10;
            label3.Text = "label3";
            label3.Visible = false;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(224, 224, 224);
            textBox4.Font = new Font("Courier New", 10.2F);
            textBox4.Location = new Point(609, 505);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 13;
            textBox4.Visible = false;
            textBox4.TextChanged += TextBox_TextChanged;
            textBox4.KeyPress += textBox_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 10.2F);
            label4.Location = new Point(115, 512);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 12;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.FromArgb(224, 224, 224);
            textBox5.Font = new Font("Courier New", 10.2F);
            textBox5.Location = new Point(388, 561);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(125, 27);
            textBox5.TabIndex = 15;
            textBox5.Visible = false;
            textBox5.TextChanged += TextBox_TextChanged;
            textBox5.KeyPress += textBox_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Courier New", 10.2F);
            label5.Location = new Point(115, 564);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 14;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // ButtonCalculate
            // 
            ButtonCalculate.BackColor = Color.SlateBlue;
            ButtonCalculate.BackgroundColor = Color.SlateBlue;
            ButtonCalculate.BorderColor = Color.PaleVioletRed;
            ButtonCalculate.BorderRadius = 26;
            ButtonCalculate.BorderSize = 0;
            ButtonCalculate.Enabled = false;
            ButtonCalculate.FlatAppearance.BorderSize = 0;
            ButtonCalculate.FlatAppearance.MouseDownBackColor = Color.Teal;
            ButtonCalculate.FlatAppearance.MouseOverBackColor = Color.Teal;
            ButtonCalculate.FlatStyle = FlatStyle.Flat;
            ButtonCalculate.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ButtonCalculate.ForeColor = Color.White;
            ButtonCalculate.Location = new Point(825, 649);
            ButtonCalculate.Name = "ButtonCalculate";
            ButtonCalculate.Size = new Size(188, 50);
            ButtonCalculate.TabIndex = 16;
            ButtonCalculate.Text = "Calculate";
            ButtonCalculate.TextColor = Color.White;
            ButtonCalculate.UseVisualStyleBackColor = false;
            ButtonCalculate.Click += ButtonCalculate_Click;
            // 
            // textBoxFigurName
            // 
            textBoxFigurName.BackColor = Color.FromArgb(224, 224, 224);
            textBoxFigurName.Font = new Font("Courier New", 10.2F);
            textBoxFigurName.Location = new Point(49, 663);
            textBoxFigurName.Name = "textBoxFigurName";
            textBoxFigurName.Size = new Size(125, 27);
            textBoxFigurName.TabIndex = 18;
            textBoxFigurName.Visible = false;
            textBoxFigurName.Leave += textBoxFigurName_Leave;
            // 
            // labelFigurName
            // 
            labelFigurName.AutoSize = true;
            labelFigurName.Font = new Font("Courier New", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelFigurName.Location = new Point(49, 622);
            labelFigurName.Name = "labelFigurName";
            labelFigurName.Size = new Size(69, 20);
            labelFigurName.TabIndex = 17;
            labelFigurName.Text = "label6";
            labelFigurName.Visible = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Turquoise;
            panel1.Controls.Add(pictureBoxExit);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1185, 41);
            panel1.TabIndex = 19;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // pictureBoxExit
            // 
            pictureBoxExit.Cursor = Cursors.Hand;
            pictureBoxExit.Dock = DockStyle.Right;
            pictureBoxExit.Image = Properties.Resources.close;
            pictureBoxExit.Location = new Point(1147, 0);
            pictureBoxExit.Name = "pictureBoxExit";
            pictureBoxExit.Size = new Size(38, 41);
            pictureBoxExit.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBoxExit.TabIndex = 27;
            pictureBoxExit.TabStop = false;
            pictureBoxExit.Click += pictureBoxExit_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.PaleTurquoise;
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(pictureBox7);
            panel2.Controls.Add(labelNazvn);
            panel2.Location = new Point(0, 40);
            panel2.Name = "panel2";
            panel2.Size = new Size(1183, 116);
            panel2.TabIndex = 20;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(1058, 0);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(106, 102);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 28;
            pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(12, 0);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(106, 102);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 27;
            pictureBox7.TabStop = false;
            // 
            // labelNazvn
            // 
            labelNazvn.AutoSize = true;
            labelNazvn.Font = new Font("Segoe Script", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelNazvn.Location = new Point(373, 33);
            labelNazvn.Name = "labelNazvn";
            labelNazvn.Size = new Size(403, 48);
            labelNazvn.TabIndex = 0;
            labelNazvn.Text = "Геометрические фигуры";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 260);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(88, 321);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(696, 730);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(192, 93);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1033, 681);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(152, 142);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 23;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(201, 730);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(192, 93);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 721);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(88, 102);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 25;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(1071, 226);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(114, 290);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 26;
            pictureBox6.TabStop = false;
            // 
            // ButtonDesigFigure
            // 
            ButtonDesigFigure.BackColor = Color.BlueViolet;
            ButtonDesigFigure.BackgroundColor = Color.BlueViolet;
            ButtonDesigFigure.BorderColor = Color.PaleVioletRed;
            ButtonDesigFigure.BorderRadius = 26;
            ButtonDesigFigure.BorderSize = 0;
            ButtonDesigFigure.Enabled = false;
            ButtonDesigFigure.FlatAppearance.BorderSize = 0;
            ButtonDesigFigure.FlatAppearance.MouseDownBackColor = Color.Teal;
            ButtonDesigFigure.FlatAppearance.MouseOverBackColor = Color.Teal;
            ButtonDesigFigure.FlatStyle = FlatStyle.Flat;
            ButtonDesigFigure.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ButtonDesigFigure.ForeColor = Color.White;
            ButtonDesigFigure.Location = new Point(577, 649);
            ButtonDesigFigure.Name = "ButtonDesigFigure";
            ButtonDesigFigure.Size = new Size(225, 50);
            ButtonDesigFigure.TabIndex = 27;
            ButtonDesigFigure.Text = "Designate a figure";
            ButtonDesigFigure.TextColor = Color.White;
            ButtonDesigFigure.UseVisualStyleBackColor = false;
            ButtonDesigFigure.Click += ButtonDesigFigure_Click;
            // 
            // pictureBoxFigure
            // 
            pictureBoxFigure.Location = new Point(763, 226);
            pictureBoxFigure.Name = "pictureBoxFigure";
            pictureBoxFigure.Size = new Size(302, 257);
            pictureBoxFigure.TabIndex = 28;
            pictureBoxFigure.TabStop = false;
            // 
            // ButtonClear
            // 
            ButtonClear.BackColor = Color.DodgerBlue;
            ButtonClear.BackgroundColor = Color.DodgerBlue;
            ButtonClear.BorderColor = Color.PaleVioletRed;
            ButtonClear.BorderRadius = 26;
            ButtonClear.BorderSize = 0;
            ButtonClear.FlatAppearance.BorderSize = 0;
            ButtonClear.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 0);
            ButtonClear.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 0);
            ButtonClear.FlatStyle = FlatStyle.Flat;
            ButtonClear.Font = new Font("Bookman Old Style", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            ButtonClear.ForeColor = Color.White;
            ButtonClear.Location = new Point(863, 580);
            ButtonClear.Name = "ButtonClear";
            ButtonClear.Size = new Size(136, 50);
            ButtonClear.TabIndex = 29;
            ButtonClear.Text = "Clear";
            ButtonClear.TextColor = Color.White;
            ButtonClear.UseVisualStyleBackColor = false;
            ButtonClear.Click += ButtonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Aquamarine;
            ClientSize = new Size(1185, 826);
            Controls.Add(ButtonClear);
            Controls.Add(pictureBoxFigure);
            Controls.Add(ButtonDesigFigure);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(textBoxFigurName);
            Controls.Add(labelFigurName);
            Controls.Add(ButtonCalculate);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(comboBoxFigure);
            Controls.Add(groupBoxViewFigure);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Figure";
            Load += Form1_Load;
            groupBoxViewFigure.ResumeLayout(false);
            groupBoxViewFigure.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxExit).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFigure).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBoxViewFigure;
        private RadioButton radioButtonVolumFigure;
        private RadioButton radioButtonFlatFigure;
        private ComboBox comboBoxFigure;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private RJButton ButtonCalculate;
        private TextBox textBoxFigurName;
        private Label labelFigurName;
        private Panel panel1;
        private Panel panel2;
        private Label labelNazvn;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBoxExit;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private RJButton ButtonDesigFigure;
        private PictureBox pictureBoxFigure;
        private RJButton ButtonClear;
    }
}
