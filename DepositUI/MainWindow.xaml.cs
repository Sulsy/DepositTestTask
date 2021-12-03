using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TestTask;

namespace DepositUI
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ReplenishmentDepositCheckBox.DataContext = this;
            ReplenishmentDeposit.DataContext = this;
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
        }

        private void textBoxNumeric_TextChanged(object sender, TextChangedEventArgs e)
        {
            var textBox = sender as System.Windows.Controls.TextBox;
            Int32 selectionStart = textBox.SelectionStart;
            String newText = String.Empty;
            int count = 0;
            foreach (Char c in textBox.Text.ToCharArray())
            {
                if (Char.IsDigit(c) || Char.IsControl(c) || (c == '.' && count == 0))
                {
                    newText += c;
                    if (c == '.')
                        count += 1;
                }
            }
            textBox.Text = newText;
            textBox.SelectionStart = selectionStart <= textBox.Text.Length ? selectionStart : textBox.Text.Length;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public TypeCapitalEnum GetTypeCapital(string value) 
        {
            switch(value as string)
            {
                case "Monthly": return TypeCapitalEnum.Monthly;
                case "Quarterly": return TypeCapitalEnum.Quarterly;
                case "Daily": return TypeCapitalEnum.Daily;
                default: return TypeCapitalEnum.Unknown;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DepositData depisitData;

                if (ReplenishmentDepositCheckBox.IsChecked.Value)
                    depisitData = new DepositData(FirstDate.SelectedDate.Value,
                                                      LatestDate.SelectedDate.Value,
                                                      Convert.ToDouble(DepositSum.Text),
                                                      Convert.ToDouble(PercentSum.Text),
                                                      GetTypeCapital(TypeCapital.Text),
                                                      ReplenishmentDepositCheckBox.IsChecked.Value,
                                                      Convert.ToDouble(ReplenishmentDepositTextBox.Text));
                else
                {
                    depisitData = new DepositData(FirstDate.SelectedDate.Value,
                                                          LatestDate.SelectedDate.Value,
                                                          Convert.ToDouble(DepositSum.Text),
                                                          Convert.ToDouble(PercentSum.Text),
                                                          GetTypeCapital(TypeCapital.Text));
                }
                
                Ansver.Text = Math.Round(depisitData.CalculateDeposit,2).ToString();

                Ansver1.Text = depisitData.DepositTotalDays.ToString();
                Ansver2.Text = depisitData.SummaryDeposit.ToString();
            }
            catch (Exception ex) { System.Windows.MessageBox.Show(ex.Message, "Error!"); }
        }
    }
}

