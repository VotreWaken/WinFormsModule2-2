using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp20
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> mydict = new Dictionary<string, int>();
        Dictionary<string, int> Food = new Dictionary<string, int>();

        double totalMoneyPerDay;
        public Form1()
        {
            InitializeComponent();
            mydict.Add("92", 10);
            mydict.Add("95", 12);
            mydict.Add("97", 15);
            Food.Add("Хот-Дог", 4);
            Food.Add("Гамбургер", 6);
            Food.Add("Картопля-Фрi", 3);
            Food.Add("Кока-Кола", 5);
            CBHotDog.Text = Food.ElementAt(0).Key;
            CBHamburger.Text = Food.ElementAt(1).Key;
            CBPotato.Text = Food.ElementAt(2).Key;
            CBCola.Text = Food.ElementAt(3).Key;
            TBHotDogPrice.Text = Food.ElementAt(0).Value.ToString();
            TBHamburgerPrice.Text = Food.ElementAt(1).Value.ToString();
            TBPotatoPrice.Text = Food.ElementAt(2).Value.ToString();
            TBColaPrice.Text = Food.ElementAt(3).Value.ToString();
            CBFuel.Items.Add(mydict.ElementAt(0).Key);
            CBFuel.Items.Add(mydict.ElementAt(1).Key);
            CBFuel.Items.Add(mydict.ElementAt(2).Key);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            CBFuel.SelectedIndex = 0;
            RBCount.Checked = true;
        }

        private void CBFuel_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CBFuel.SelectedIndex == 0)
            {
                TBPrice.Text = mydict.ElementAt(0).Value.ToString();
            }
            else if (CBFuel.SelectedIndex == 1)
            {
                TBPrice.Text = mydict.ElementAt(1).Value.ToString();
            }
            else
                TBPrice.Text = mydict.ElementAt(2).Value.ToString();
        }
        private double CalculatePrice()
        {
            try
            {
                double toOpata = 0;
                if (RBCount.Checked)
                {
                    toOpata = double.Parse(TBPrice.Text) * double.Parse(TBCount.Text);
                }
                else if (RBSum.Checked)
                {
                    toOpata = double.Parse(TBSum.Text);
                    TBCount.Text = (double.Parse(TBSum.Text) / double.Parse(TBPrice.Text)).ToString("N2");
                }
                return toOpata;
            }
            catch (Exception a)
            {
                return 0;
            }
        }

        private void TBCount_TextChanged(object sender, EventArgs e)
        {
            FuelPrice.Text = CalculatePrice().ToString("N2");
        }

        private void RBCount_CheckedChanged(object sender, EventArgs e)
        {
            if (RBCount.Checked)
            {
                TBCount.ReadOnly = false;
                TBSum.ReadOnly = true;
                TBSum.Text = string.Empty;
            }
            else if (RBSum.Checked)
            {
                TBCount.ReadOnly = true;
                TBSum.ReadOnly = false;
                TBCount.Text = string.Empty;
            }
        }

        private void TBHotDogCount_TextChanged(object sender, EventArgs e)
        {
            CafePrice.Text = CalculateSum().ToString();
        }

        int CalculateSum()
        {
            try
            {
                if (TBHotDogCount.Text == string.Empty)
                    TBHotDogCount.Text = 0.ToString();
                if (TBHamburgerCount.Text == string.Empty)
                    TBHamburgerCount.Text = 0.ToString();
                if (TBPotatoCount.Text == string.Empty)
                    TBPotatoCount.Text = 0.ToString();
                if (TBColaCount.Text == string.Empty)
                    TBColaCount.Text = 0.ToString();
                return
                    int.Parse(TBHotDogCount.Text) * int.Parse(TBHotDogPrice.Text) +
                    int.Parse(TBHamburgerCount.Text) * int.Parse(TBHamburgerPrice.Text) +
                    int.Parse(TBPotatoCount.Text) * int.Parse(TBPotatoPrice.Text) +
                    int.Parse(TBColaCount.Text) * int.Parse(TBColaPrice.Text);
            }
            catch (Exception)
            {
                return 0;
            }
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            TotalPrice.Text = (double.Parse(CafePrice.Text) + double.Parse(FuelPrice.Text)).ToString();
            totalMoneyPerDay += (double.Parse(TotalPrice.Text));
            status = true;
            timer1.Start();
        }

        private void CBHotDog_CheckedChanged(object sender, EventArgs e)
        {
            if (CBHotDog.Checked)
            {
                TBHotDogCount.ReadOnly = false;
            }
            else
            {
                TBHotDogCount.ReadOnly = true;
            }
            if (CBHamburger.Checked)
            {
                TBHamburgerCount.ReadOnly = false;
            }
            else
            {
                TBHamburgerCount.ReadOnly = true;
            }
            if (CBPotato.Checked)
            {
                TBPotatoCount.ReadOnly = false;
            }
            else
            {
                TBPotatoCount.ReadOnly = true;
            }
            if (CBCola.Checked)
            {
                TBColaCount.ReadOnly = false;
            }
            else
            {
                TBColaCount.ReadOnly = true;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show($"Виторг за день склав: {totalMoneyPerDay}", "Виторг");
        }
        bool status;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (status == true)
            {
                DialogResult result = MessageBox.Show("Очитити форму?", "Запит", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    TBCount.Text = 0.ToString();
                    TBSum.Text = 0.ToString();
                    FuelPrice.Text = 0.ToString();
                    CafePrice.Text = 0.ToString();
                    TotalPrice.Text = 0.ToString();
                    TBHotDogCount.Text = 0.ToString();
                    TBHamburgerCount.Text = 0.ToString();
                    TBPotatoCount.Text = 0.ToString();
                    TBColaCount.Text = 0.ToString();
                    status = false;
                    timer1.Stop();
                }
                else if (result == DialogResult.Cancel)
                {
                    timer1.Start();
                    status = true;
                }
            }
        }
    }
}
