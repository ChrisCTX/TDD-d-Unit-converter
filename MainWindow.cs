using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class MainWindow : Form
    {
        Convert Converter = new Convert();
        double Amount = 0;
        bool MetToImp;
        string FromUnits;
        string ToUnits;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            SetDefaultValue();
        }


        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            if (inputTextBox.Text != "")
            {
                FromUnits = fromComboBox.SelectedItem.ToString();
                ToUnits = toComboBox.SelectedItem.ToString();
                Amount = double.Parse(inputTextBox.Text);

                if (MetToImp == true)
                    resultBox.Text = Converter.MetricToImperial(FromUnits, ToUnits, Amount).ToString("N3");
                else
                    resultBox.Text = Converter.ImperialToMetric(FromUnits, ToUnits, Amount).ToString("N3");
            }
            else
                resultBox.Clear();
            
        }

        private void inputTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                e.Handled = true;

            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
                e.Handled = true;
        }

        private void LengthChecked(object sender, EventArgs e)
        {
            SetValues();
        }

        private void VolumeChecked(object sender, EventArgs e)
        {
            SetValues();
        }

        private void MassChecked(object sender, EventArgs e)
        {
            SetValues();
        }

        private void MetricToImperialChecked(object sender, EventArgs e)
        {
            MetToImp = true;
            SetValues();
        }

        private void ImperialToMetricChecked(object sender, EventArgs e)
        {
            MetToImp = false;
            SetValues();
            
        }

        public void SetDefaultValue()
        {
            fromComboBox.SelectedIndex = 0;
            toComboBox.SelectedIndex = 0;
        }


        public void SetValues()
        {
            fromComboBox.Items.Clear();
            toComboBox.Items.Clear();
            resultBox.Clear();
            inputTextBox.Clear();

            string[] MetricLenght = { "Kilometers", "Meters", "Centimeters", "Milimeters" };
            string[] MetricMass = { "Kilograms", "Grams", "Miligrams" };
            string[] MetricVolume = { "Liters" , "Mililiters" };
            string[] ImperialLenght = { "Miles", "Feets", "Inches" };
            string[] ImperialMass = { "Pounds", "Ounces", "Stones" };
            string[] ImperialVolume = { "Quarts", "Pints" , "Gallons"};

            if (MetToImp == true)
            {
                if (LengthButton.Checked == true)
                {
                    fromComboBox.Items.AddRange(MetricLenght);
                    toComboBox.Items.AddRange(ImperialLenght);
                    SetDefaultValue();
                }
                else if (MassButton.Checked == true)
                {
                    fromComboBox.Items.AddRange(MetricMass);
                    toComboBox.Items.AddRange(ImperialMass);
                    SetDefaultValue();
                }
                else if (VolumeButton.Checked == true)
                {
                    fromComboBox.Items.AddRange(MetricVolume);
                    toComboBox.Items.AddRange(ImperialVolume);
                    SetDefaultValue();
                }
            }
            else if (MetToImp == false)
            {
                if (LengthButton.Checked == true)
                {
                    fromComboBox.Items.AddRange(ImperialLenght);
                    toComboBox.Items.AddRange(MetricLenght);
                    SetDefaultValue();
                }
                else if (MassButton.Checked == true)
                {
                    fromComboBox.Items.AddRange(ImperialMass);
                    toComboBox.Items.AddRange(MetricMass);
                    SetDefaultValue();
                }
                else if (VolumeButton.Checked == true)
                {
                    fromComboBox.Items.AddRange(ImperialVolume);
                    toComboBox.Items.AddRange(MetricVolume);
                    SetDefaultValue();
                }
            }
        }

        private void fromComboBoxChanged(object sender, EventArgs e)
        {
            inputTextBox.Clear();
        }

        private void toComboBoxChanged(object sender, EventArgs e)
        {
            inputTextBox.Clear();
        }
    }
}