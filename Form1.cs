using System.Drawing;
using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Lab5
{
    public partial class Form1 : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 40;

            // create a rounded rectangle path using the form's size and radius
            path.AddArc(0, 0, radius, radius, 180, 90); // top-left corner
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90); // top-right corner
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90); // bottom-right corner
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90); // bottom-left corner

            // create a region with the rounded rectangle path and apply it to the form
            this.Region = new Region(path);
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                // check if the click was on the title bar
                if (e.Clicks == 1 && e.Y <= this.Height && e.Y >= 0)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFlatFigure.Checked)
            {
                comboBoxFigure.Items.Clear();
                comboBoxFigure.Items.AddRange(new object[] { "�����������", "�������", "�������������", "��������������", "����", "��������", "����������" });
            }
            else if (radioButtonVolumFigure.Checked)
            {
                comboBoxFigure.Items.Clear();
                comboBoxFigure.Items.AddRange(new object[] { "���", "�����", "��������������", "���", "�������", "��������" });
            }
            comboBoxFigure.SelectedIndex = -1;
        }

        private void ClearAllControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control.Name != "labelNazvn")
                {
                    if (control is TextBox)
                    {
                        ((TextBox)control).Text = "";
                    }
                    else if (control is Label)
                    {
                        ((Label)control).Text = "";
                    }
                    else if (control.HasChildren)
                    {
                        ClearAllControls(control.Controls);
                    }
                }
            }
        }

        private void comboBoxFigure_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFigure = comboBoxFigure.SelectedItem.ToString();
            switch (selectedFigure)
            {
                case "�����������":
                    ClearAllControls(this.Controls);
                    label1.Text = "������� ����� ������� a:";
                    label2.Text = "������� ����� ������� b:";
                    label3.Text = "������� ����� ������� c:";
                    label4.Text = "������� ����� ������ h, ��������� �� ������� a:";
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = false;
                    pictureBoxFigure.Image = Image.FromFile(@"..\..\..\image\treug-icon.png");
                    break;

                case "�������":
                    ClearAllControls(this.Controls);
                    label1.Text = "������� ����� ������� a:";
                    label1.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    pictureBoxFigure.Image = Image.FromFile(@"..\..\..\image\kvadrat-icon.png");
                    break;

                case "�������������":
                    ClearAllControls(this.Controls);
                    label1.Text = "������� ����� ������� a:";
                    label2.Text = "������� ����� ������� b:";
                    label1.Visible = true;
                    label2.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    pictureBoxFigure.Image = Image.FromFile(@"..\..\..\image\priamougolnik-icon.png");
                    break;

                case "��������������":
                    ClearAllControls(this.Controls);
                    label1.Text = "������� ����� ������� a:";
                    label2.Text = "������� ����� ������� b:";
                    label3.Text = "������� ����� ������ h:";
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    pictureBoxFigure.Image = Image.FromFile(@"..\..\..\image\parallelogram-icon.png");
                    break;

                case "����":
                    ClearAllControls(this.Controls);
                    label1.Text = "������� ����� ������� a:";
                    label2.Text = "������� ����� ������ h:";
                    label1.Visible = true;
                    label2.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    pictureBoxFigure.Image = Image.FromFile(@"..\..\..\image\rhombus-icon.png");
                    break;

                case "��������":
                    ClearAllControls(this.Controls);
                    label1.Text = "������� ����� ��������� a:";
                    label2.Text = "������� ����� ��������� b:";
                    label3.Text = "������� ����� ���. ���� c:";
                    label4.Text = "������� ����� ������� ������� d:";
                    label5.Text = "������� ����� ������ h:";
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    label5.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                    textBox5.Visible = true;
                    pictureBoxFigure.Image = Image.FromFile(@"..\..\..\image\trapezoid-icon.png");
                    break;

                case "����������":
                    ClearAllControls(this.Controls);
                    label1.Text = "������� ������ r:";
                    label1.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    pictureBoxFigure.Image = Image.FromFile(@"..\..\..\image\circle-icon.png");
                    break;

                case "���":
                    ClearAllControls(this.Controls);
                    label1.Text = "������� ������ r:";
                    label1.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    pictureBoxFigure.Image = Image.FromFile(@"..\..\..\image\sar-icon.png");
                    break;

                case "�����":
                    ClearAllControls(this.Controls);
                    label1.Text = "������� ������ R ������:";
                    label2.Text = "������� ����� ����������:";
                    label3.Text = "������� ����� ������ H:";
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    pictureBoxFigure.Image = Image.FromFile(@"..\..\..\image\konus-icon.png");
                    break;

                case "��������������":
                    ClearAllControls(this.Controls);
                    label1.Text = "������� ����� ������� a:";
                    label2.Text = "������� ����� ������� b:";
                    label3.Text = "������� ����� ������� c:";
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    pictureBoxFigure.Image = Image.FromFile(@"..\..\..\image\paralelepiped-icon.png");
                    break;

                case "���":
                    ClearAllControls(this.Controls);
                    label1.Text = "������� ����� ������� a:";
                    label1.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = false;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    pictureBoxFigure.Image = Image.FromFile(@"..\..\..\image\cube-icon.png");
                    break;

                case "�������":
                    ClearAllControls(this.Controls);
                    label1.Text = "������� ������ R ��������:";
                    label2.Text = "������� ����� ������ H:";
                    label1.Visible = true;
                    label2.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = false;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    pictureBoxFigure.Image = Image.FromFile(@"..\..\..\image\cylinder-icon.png");
                    break;

                case "��������":
                    ClearAllControls(this.Controls);
                    label1.Text = "������� ����� ������� a:";
                    label2.Text = "������� ����� ����������:";
                    label3.Text = "������� ����� ������ h:";
                    label1.Visible = true;
                    label2.Visible = true;
                    label3.Visible = true;
                    textBox1.Visible = true;
                    textBox2.Visible = true;
                    textBox3.Visible = true;
                    textBox4.Visible = false;
                    textBox5.Visible = false;
                    pictureBoxFigure.Image = Image.FromFile(@"..\..\..\image\piramida-icon.png");
                    break;

                default: break;
            }
        }

        private bool AreAllFieldsFilled()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox && control.Visible)
                {
                    TextBox textBox = (TextBox)control;
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            if (e.KeyChar == '.') e.KeyChar = ',';

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;

            // only allow one decimal point
            if (e.KeyChar == ',' && (sender as System.Windows.Forms.TextBox).Text.IndexOf(',') > -1)
                e.Handled = true;
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            Calculate();
        }

        private void Calculate()
        {
            string shape = comboBoxFigure.SelectedItem.ToString();

            double variable1, variable2, variable3, variable4, variable5;

            if (textBox1.Text.Length == 0)
                variable1 = 0;
            else variable1 = Convert.ToDouble(textBox1.Text);

            if (textBox2.Text.Length == 0)
                variable2 = 0;
            else variable2 = Convert.ToDouble(textBox2.Text);

            if (textBox3.Text.Length == 0)
                variable3 = 0;
            else variable3 = Convert.ToDouble(textBox3.Text);

            if (textBox4.Text.Length == 0)
                variable4 = 0;
            else variable4 = Convert.ToDouble(textBox4.Text);

            if (textBox5.Text.Length == 0)
                variable5 = 0;
            else variable5 = Convert.ToDouble(textBox5.Text);

            double P = 0, V = 0, A = 0, SPol = 0, SBok = 0;

            if (radioButtonFlatFigure.Checked)
            {
                switch (shape)
                {
                    case "�����������":
                        P = variable1 + variable2 + variable3;
                        A = (variable1 * variable4) / 2;
                        break;

                    case "�������":
                        P = 4 * variable1;
                        A = variable1 * variable1;
                        break;

                    case "�������������":
                        P = 2 * (variable1 + variable2);
                        A = variable1 * variable2;
                        break;

                    case "��������������":
                        P = 2 * (variable1 + variable2);
                        A = variable1 * variable3;
                        break;

                    case "����":
                        P = 4 * variable1;
                        A = variable1 * variable2;
                        break;

                    case "��������":
                        P = variable1 + variable2 + variable3 + variable4;
                        A = ((variable1 + variable2) / 2) * variable5;
                        break;

                    case "����������":
                        P = Math.Round(2 * Math.PI * variable1, 2);
                        A = Math.Round(Math.PI * (variable1 * variable1), 2);
                        break;

                    default: break;
                }

                MessageBox.Show($"{shape}: {textBoxFigurName.Text}\n��������: {P} ��\n�������: {A} ��\u00B2", "���������");
            }
            else if (radioButtonVolumFigure.Checked)
            {
                switch (shape)
                {
                    case "���":
                        V = Math.Round((4.0 / 3.0) * Math.PI * Math.Pow(variable1, 3), 2);
                        SPol = Math.Round(4 * Math.PI * Math.Pow(variable1, 2), 2);
                        break;

                    case "�����":
                        V = Math.Round((Math.PI * Math.Pow(variable1, 2) * variable3) / 3, 2);
                        SPol = Math.Round(Math.PI * variable1 * variable2 + Math.PI * Math.Pow(variable1, 2), 2);
                        SBok = Math.Round(Math.PI * variable1 * variable2, 2);
                        break;

                    case "��������������":
                        V = Math.Round(variable1 * variable2 * variable3, 2);
                        SPol = Math.Round(2 * (variable1 * variable2 + variable2 * variable3 + variable3 * variable1), 2);
                        SBok = Math.Round(2 * variable1 * (variable2 + variable3), 2);
                        break;

                    case "���":
                        V = Math.Round(Math.Pow(variable1, 3), 2);
                        SPol = Math.Round(6 * Math.Pow(variable1, 2), 2);
                        SBok = Math.Round(4 * Math.Pow(variable1, 2), 2);
                        break;

                    case "�������":
                        V = Math.Round(Math.PI * Math.Pow(variable1, 2) * variable2, 2);
                        SBok = Math.Round(2 * Math.PI * variable1 * variable2, 2);
                        SPol = Math.Round(2 * Math.PI * Math.Pow(variable1, 2) + SBok, 2);
                        break;

                    case "��������":
                        V = Math.Round((1.0 / 3.0) * Math.Pow(variable1, 2) * variable3, 2);
                        SBok = Math.Round(2 * variable1 * variable2, 2);
                        SPol = Math.Round(variable1 * (variable1 + 2 * variable2), 2);
                        break;

                    default: break;
                }

                MessageBox.Show($"{shape}: {textBoxFigurName.Text}\n�����: {V} ��\u00B3\n������� ������� �����������: {SBok} ��\u00B2\n������� ������ �����������: {SPol} ��\u00B2", "���������");
            }
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (AreAllFieldsFilled())
            {
                ButtonCalculate.Enabled = true;
                ButtonDesigFigure.Enabled = true;
            }
        }

        private void textBoxFigurName_Leave(object sender, EventArgs e)
        {
            string pattern = "";
            string selectedFigure = comboBoxFigure.SelectedItem.ToString();

            switch (selectedFigure)
            {
                case "�����������":
                    pattern = @"^[A-Z]{3}$";
                    break;
                case "�������":
                case "�������������":
                case "��������������":
                case "����":
                case "��������":
                    pattern = @"^[A-Z]{4}$";
                    break;
                case "����������":
                case "���":
                    pattern = @"^[A-Z]{1}$";
                    break;
                case "�����":
                case "�������":
                    pattern = @"^[A-Z]{2}$";
                    break;
                case "��������������":
                case "���":
                    pattern = @"^[A-Z]{8}$";
                    break;
                case "��������":
                    pattern = @"^[A-Z]{5}$";
                    break;
                default:
                    return;
            }

            string inputValue = textBoxFigurName.Text;
            if (!Regex.IsMatch(inputValue, pattern))
            {
                MessageBox.Show($"������������ ����������� ��� {selectedFigure}�. ����������, ������� ���������� �����������.", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxFigurName.Focus();
            }
        }

        private void pictureBoxExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonDesigFigure_Click(object sender, EventArgs e)
        {
            if (AreAllFieldsFilled())
            {
                string selectedFigure = comboBoxFigure.SelectedItem.ToString();

                DialogResult result = MessageBox.Show("������ �� �� ������� ����������� ������?", "������", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    labelFigurName.Text = $"������� ����������� ��� {selectedFigure}a: ";
                    labelFigurName.Visible = true;
                    textBoxFigurName.Visible = true;
                    textBoxFigurName.Focus();
                }
                else
                {
                    textBoxFigurName.Visible = false;
                    textBoxFigurName.Text = selectedFigure;
                    MessageBox.Show($"������: {textBoxFigurName.Text}", "�����", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            ClearControls(this.Controls);
        }

        private void ClearControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Text = "";
                    textBox.Visible = false; 
                }
                else if (control is Label label)
                {
                    label.Text = "";
                }
                else if (control is ComboBox comboBox)
                {
                    comboBox.Items.Clear();
                }
                if (control is PictureBox pictureBox && pictureBox.Name == "pictureBoxFigure")
                {
                    pictureBox.Image = null;
                }
                else if (control is GroupBox groupBox)
                {
                    ClearControls(groupBox.Controls);
                }
            }
            ButtonDesigFigure.Enabled = false;
            ButtonCalculate.Enabled = false;
        }
    }
}
