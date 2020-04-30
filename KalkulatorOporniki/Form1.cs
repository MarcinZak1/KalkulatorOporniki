using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorOporniki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] wynik = new string[5];
        double result = 0.0, ohm=0.0, mOhm = 0.0;
        StringBuilder finalResult = new StringBuilder();


        private void btnReset_Click(object sender, EventArgs e)
        {
            rb4paski.Checked = false;
            rb5paskow.Checked = false;
            rbOhm.Checked = false;
            rbKohm.Checked = false;
            rbMohm.Checked = false;
            Reset();
        }
        private void Reset()
        {
            // przycisk reset czyści nam wszystkie wartości
            result = 0.0;
            finalResult.Clear();

            cbPasek1.SelectedIndex = -1;
            cbPasek2.SelectedIndex = -1;
            cbPasek3.SelectedIndex = -1;
            cbPasek4.SelectedIndex = -1;
            cbPasek5.SelectedIndex = -1;

            pasek1.BackColor = Color.Aqua;
            pasek2.BackColor = Color.Aqua;
            pasek3.BackColor = Color.Aqua;
            pasek4.BackColor = Color.Aqua;
            pasek5.BackColor = Color.Aqua;

            cbPasek1.Enabled = false;
            cbPasek2.Enabled = false;
            cbPasek3.Enabled = false;
            cbPasek4.Enabled = false;
            cbPasek5.Enabled = false;

            lblWynik.Text = string.Empty;
        }
        // Ustawiamy pierwsza liczbe
        private void cbPasek1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPasek1.SelectedIndex > -1)
            {

                switch (cbPasek1.SelectedIndex)
                {
                    case 0:
                        pasek1.BackColor = Color.Brown;
                        wynik[0] = "1";
                        break;
                    case 1:
                        pasek1.BackColor = Color.Red;
                        wynik[0] = "2";
                        break;
                    case 2:
                        pasek1.BackColor = Color.Orange;
                        wynik[0] = "3";
                        break;
                    case 3:
                        pasek1.BackColor = Color.Yellow;
                        wynik[0] = "4";
                        break;
                    case 4:
                        pasek1.BackColor = Color.Green;
                        wynik[0] = "5";
                        break;
                    case 5:
                        pasek1.BackColor = Color.Blue;
                        wynik[0] = "6";
                        break;
                    case 6:
                        pasek1.BackColor = Color.Violet;
                        wynik[0] = "7";
                        break;
                    case 7:
                        pasek1.BackColor = Color.Gray;
                        wynik[0] = "8";
                        break;
                    case 8:
                        pasek1.BackColor = Color.AntiqueWhite;
                        wynik[0] = "9";
                        break;
                    default:
                        break;
                }
                finalResult.Append(wynik[0]);
            }
            cbPasek1.Enabled = false;           //Po ustawieniu koloru paska nie można go zmienić
            cbPasek2.Enabled = true;            //Umożliwiamy zmianę kolory kolejnego paska
        }

        // Ustawiamy druga liczbe
        private void cbPasek2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPasek2.SelectedIndex > -1)
            {
                switch (cbPasek2.SelectedIndex)
                {
                    case 0:
                        pasek2.BackColor = Color.Black;
                        wynik[1] = "0";
                        break;
                    case 1:
                        pasek2.BackColor = Color.Brown;
                        wynik[1] = "1";
                        break;
                    case 2:
                        pasek2.BackColor = Color.Red;
                        wynik[1] = "2";
                        break;
                    case 3:
                        pasek2.BackColor = Color.Orange;
                        wynik[1] = "3";
                        break;
                    case 4:
                        pasek2.BackColor = Color.Yellow;
                        wynik[1] = "4";
                        break;
                    case 5:
                        pasek2.BackColor = Color.Green;
                        wynik[1] = "5";
                        break;
                    case 6:
                        pasek2.BackColor = Color.Blue;
                        wynik[1] = "6";
                        break;
                    case 7:
                        pasek2.BackColor = Color.Violet;
                        wynik[1] = "7";
                        break;
                    case 8:
                        pasek2.BackColor = Color.Gray;
                        wynik[1] = "8";
                        break;
                    case 9:
                        pasek2.BackColor = Color.AntiqueWhite;
                        wynik[1] = "9";
                        break;
                    default:
                        break;
                }
                finalResult.Append(wynik[1]);
            }
            cbPasek2.Enabled = false;  //Po ustawieniu koloru paska nie można go zmienić
            // Jesli wybralismy opcje z 4 paskami odblokowujemy pasek 4, jesli z 5 odblokowujemy pasek 3
            if (rb4paski.Checked)
            {
                cbPasek4.Enabled = true;
            }
            else
            {
                cbPasek3.Enabled = true;
            }
        }

        // Ustawiamy trzecia liczbe (ewentualnie)
        private void cbPasek3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPasek3.SelectedIndex > -1)
            {
                switch (cbPasek3.SelectedIndex)
                {
                    case 0:
                        pasek3.BackColor = Color.Black;
                        wynik[2] = "0";
                        break;
                    case 1:
                        pasek3.BackColor = Color.Brown;
                        wynik[2] = "1";
                        break;
                    case 2:
                        pasek3.BackColor = Color.Red;
                        wynik[2] = "2";
                        break;
                    case 3:
                        pasek3.BackColor = Color.Orange;
                        wynik[2] = "3";
                        break;
                    case 4:
                        pasek3.BackColor = Color.Yellow;
                        wynik[2] = "4";
                        break;
                    case 5:
                        pasek3.BackColor = Color.Green;
                        wynik[2] = "5";
                        break;
                    case 6:
                        pasek3.BackColor = Color.Blue;
                        wynik[2] = "6";
                        break;
                    case 7:
                        pasek3.BackColor = Color.Violet;
                        wynik[2] = "7";
                        break;
                    case 8:
                        pasek3.BackColor = Color.Gray;
                        wynik[2] = "8";
                        break;
                    case 9:
                        pasek3.BackColor = Color.AntiqueWhite;
                        wynik[2] = "9";
                        break;
                    default:
                        break;
                }
                finalResult.Append(wynik[2]);
            }
            cbPasek3.Enabled = false;       //Po ustawieniu koloru paska nie można go zmienić
            cbPasek4.Enabled = true;        //Mozemy ustawic kolejny pasek
        }
        // Ustawianie mnoznika 
        private void cbPasek4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPasek4.SelectedIndex > -1)
            {
                result = Convert.ToDouble(finalResult.ToString());
                switch (cbPasek4.SelectedIndex)
                {
                    case 0:
                        pasek4.BackColor = Color.Silver;
                        result /= 100000;
                        break;
                    case 1:
                        pasek4.BackColor = Color.Gold;
                        result /= 10000;
                        break;
                    case 2:
                        pasek4.BackColor = Color.Black;
                        result /= 1000;
                        break;
                    case 3:
                        pasek4.BackColor = Color.Brown;
                        result /= 100;
                        break;
                    case 4:
                        pasek4.BackColor = Color.Red;
                        result /= 10;
                        break;
                    case 5:
                        pasek4.BackColor = Color.Orange;
                        result *= 1;
                        break;
                    case 6:
                        pasek4.BackColor = Color.Yellow;
                        result *= 10;
                        break;
                    case 7:
                        pasek4.BackColor = Color.Green;
                        result *= 100;
                        break;
                    case 8:
                        pasek4.BackColor = Color.Blue;
                        result *= 1000;
                        break;
                    case 9:
                        pasek4.BackColor = Color.Violet;
                        result *= 10000;
                        break;
                    default:
                        break;
                }
                finalResult.Append(" KOhm");
            }
            cbPasek4.Enabled = false;           //Po ustawieniu koloru paska nie można go zmienić
            cbPasek5.Enabled = true;            //Mozemy ustawic kolejny pasek
        }

        // Ustawiamy tolerancje
        private void cbPasek5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPasek5.SelectedIndex > -1)
            {
                switch (cbPasek5.SelectedIndex)
                {
                    case 0:
                        pasek5.BackColor = Color.Silver;
                        wynik[4] = " +/- 10%";
                        break;
                    case 1:
                        pasek5.BackColor = Color.Gold;
                        wynik[4] = " +/- 5%";
                        break;
                    case 2:
                        pasek5.BackColor = Color.Brown;
                        wynik[4] = " +/- 1%";
                        break;
                    case 3:
                        pasek5.BackColor = Color.Red;
                        wynik[4] = " +/- 2%";
                        break;
                    case 4:
                        pasek5.BackColor = Color.Green;
                        wynik[4] = " +/- 0,5%";
                        break;
                    case 5:
                        pasek5.BackColor = Color.Blue;
                        wynik[4] = " +/- 0,25%";
                        break;
                    case 6:
                        pasek5.BackColor = Color.Violet;
                        wynik[4] = " +/- 0,1%";
                        break;
                    case 7:
                        pasek5.BackColor = Color.Gray;
                        wynik[4] = " +/- 0,05%";
                        break;
                    default:
                        break;
                }
            }
            if(rbOhm.Checked)
            {
                ohm = result * 1000;
                finalResult.Clear();
                finalResult.Append(ohm.ToString()).Append(" Ohm").Append(wynik[4]);
                lblWynik.Text = finalResult.ToString();
            }
            else if(rbKohm.Checked)
            {
                finalResult.Clear();
                finalResult.Append(result.ToString()).Append(" kOhm").Append(wynik[4]);
                lblWynik.Text = finalResult.ToString();
            }
            else if(rbMohm.Checked)
            {
                mOhm = result / 1000;
                finalResult.Clear();
                finalResult.Append(mOhm.ToString()).Append(" MOhm").Append(wynik[4]);
                lblWynik.Text = finalResult.ToString();
            }
            
            cbPasek5.Enabled = false;           //Po ustawieniu koloru paska nie można go zmienić
        }

        private void rb4paski_CheckedChanged(object sender, EventArgs e)
        {
            Reset();
            cbPasek1.Enabled = true;
            cbPasek3.Enabled = false;
            pasek3.Visible = false;

        }

        private void rb5paskow_CheckedChanged(object sender, EventArgs e)
        {
            Reset();
            cbPasek1.Enabled = true;
            pasek3.Visible = true;
        }

        private void rbOhm_CheckedChanged(object sender, EventArgs e)
        {
            if(rb4paski.Checked && cbPasek1.SelectedIndex > -1 && cbPasek2.SelectedIndex > -1 && 
                cbPasek4.SelectedIndex > -1 && cbPasek5.SelectedIndex > -1)
            {
                ohm = result * 1000;
                finalResult.Clear();
                finalResult.Append(ohm.ToString()).Append(" Ohm").Append(wynik[4]);
                lblWynik.Text = finalResult.ToString();
            }

            if (rb5paskow.Checked && cbPasek1.SelectedIndex > -1 && cbPasek2.SelectedIndex > -1 &&
                cbPasek4.SelectedIndex > -1 && cbPasek5.SelectedIndex > -1 && cbPasek3.SelectedIndex > -1)
            {
                ohm = result * 1000;
                finalResult.Clear();
                finalResult.Append(ohm.ToString()).Append(" Ohm").Append(wynik[4]);
                lblWynik.Text = finalResult.ToString();
            }
        }

        private void rbKohm_CheckedChanged(object sender, EventArgs e)
        {
            if (rb4paski.Checked && cbPasek1.SelectedIndex > -1 && cbPasek2.SelectedIndex > -1 &&
                cbPasek4.SelectedIndex > -1 && cbPasek5.SelectedIndex > -1)
            {
                finalResult.Clear();
                finalResult.Append(result.ToString()).Append(" kOhm").Append(wynik[4]);
                lblWynik.Text = finalResult.ToString();
            }

            if (rb5paskow.Checked && cbPasek1.SelectedIndex > -1 && cbPasek2.SelectedIndex > -1 &&
                cbPasek4.SelectedIndex > -1 && cbPasek5.SelectedIndex > -1 && cbPasek3.SelectedIndex > -1)
            {
                finalResult.Clear();
                finalResult.Append(result.ToString()).Append(" kOhm").Append(wynik[4]);
                lblWynik.Text = finalResult.ToString();
            }
            
        }

        private void rbMohm_CheckedChanged(object sender, EventArgs e)
        {
            if (rb4paski.Checked && cbPasek1.SelectedIndex > -1 && cbPasek2.SelectedIndex > -1 &&
                cbPasek4.SelectedIndex > -1 && cbPasek5.SelectedIndex > -1)
            {
                mOhm = result / 1000;
                finalResult.Clear();
                finalResult.Append(mOhm.ToString()).Append(" MOhm").Append(wynik[4]);
                lblWynik.Text = finalResult.ToString();
            }

            if (rb5paskow.Checked && cbPasek1.SelectedIndex > -1 && cbPasek2.SelectedIndex > -1 &&
                cbPasek4.SelectedIndex > -1 && cbPasek5.SelectedIndex > -1 && cbPasek3.SelectedIndex > -1)
            {
                mOhm = result / 1000;
                finalResult.Clear();
                finalResult.Append(mOhm.ToString()).Append(" MOhm").Append(wynik[4]);
                lblWynik.Text = finalResult.ToString();
            }
            
        }
       
    }

}









