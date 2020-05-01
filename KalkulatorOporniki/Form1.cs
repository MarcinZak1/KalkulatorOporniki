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
        string[] wynik = new string[5];                 // zapisujemy wartosci typu string dla poszczegolnych paskow
        double result = 0.0, kOhm = 0.0, mOhm = 0.0;        // zmienne sluzace do przechowywania wynikow
        StringBuilder finalResult = new StringBuilder();        //Przechowuje koncowy wynik

        // guzik Reset czyści wsztstkie wartosci oraz ustawia RadioButtons jako niewcisniete
        private void btnReset_Click(object sender, EventArgs e)
        {
            // metoda reset czyści nam wszystkie wartości
            result = 0.0;
            kOhm = 0.0;
            mOhm = 0.0;
            finalResult.Clear();

            // ustawia comboBoxy na wartości -1
            cbPasek1.SelectedIndex = -1;
            cbPasek2.SelectedIndex = -1;
            cbPasek3.SelectedIndex = -1;
            cbPasek4.SelectedIndex = -1;
            cbPasek5.SelectedIndex = -1;

            // ustawia paski na kolor, ktory zostal przyjety jako domyslny
            pasek1.BackColor = Color.Aqua;
            pasek2.BackColor = Color.Aqua;
            pasek3.BackColor = Color.Aqua;
            pasek4.BackColor = Color.Aqua;
            pasek5.BackColor = Color.Aqua;

            // odznacza przyciski
            rb4paski.Checked = false;
            rb5paskow.Checked = false;

            rbOhm.Checked = false;
            rbKohm.Checked = false;
            rbMohm.Checked = false;

            // Ustawia comboBoxy jako niedostepne
            cbPasek1.Enabled = false;
            cbPasek2.Enabled = false;
            cbPasek3.Enabled = false;
            cbPasek4.Enabled = false;
            cbPasek5.Enabled = false;

            // czyscimy nasz wynik
            lblWynik.Text = string.Empty;
        }

        // Wybieramy opornik z 4 paskami
        private void rb4paski_CheckedChanged(object sender, EventArgs e)
        {
            // czyszczenie pola wyświetlającego wynik
            lblWynik.Text = string.Empty;
            // ustawiamy ponizsze comboBoxy jako dostepne
            cbPasek1.Enabled = true;
            cbPasek2.Enabled = true;
            cbPasek4.Enabled = true;
            cbPasek5.Enabled = true;

            // ustawiamy comboBox oraz pasek 3 jako niedostepne
            cbPasek3.Enabled = false;
            pasek3.Visible = false;

            // warunek, ktory pozwala na ponowne wyliczenie wartosci w przypadku, gdy przy wypelnionych
            // comboBoxach zmieniamy z opornika z 5 paskami na opornik z 4 paskami
            if (condition4paski())
            {
                getResult();            // otrzymujemy nasza zmienna result
                CbPasek4();             // zaleznie od koloru 4 paska mnozymy zmienna result
                getFinalResult();       // otrzymujemy koncowa wartosc zalezna od wybranych jednostek
            }
        }
        // Wybieramy opornik z 5 paskami
        private void rb5paskow_CheckedChanged(object sender, EventArgs e)
        {
            // czyszczenie pola wyświetlającego wynik
            lblWynik.Text = string.Empty;
            // ustawiamy ponizsze comboBoxy jako dostepne
            cbPasek1.Enabled = true;
            cbPasek2.Enabled = true;
            cbPasek3.Enabled = true;
            cbPasek4.Enabled = true;
            cbPasek5.Enabled = true;

            // Ustawiamy pasek 3 jako widoczny
            pasek3.Visible = true;

            // warunek, ktory pozwala na ponowne wyliczenie wartosci w przypadku, gdy przy wypelnionych
            // comboBoxach zmieniamy z opornika z 4 paskami na opornik z 5 paskami
            if (condition5paskow())
            {
                getResult();            // otrzymujemy nasza zmienna result
                CbPasek4();             // zaleznie od koloru 4 paska mnozymy zmienna result
                getFinalResult();       // otrzymujemy koncowa wartosc zalezna od wybranych jednostek
            }
        }
        // guziki wyboru jednostki, zadzialaja, jesli wszystkie "paski" sa wybrane
        private void rbOhm_CheckedChanged(object sender, EventArgs e)
        {
            if (condition4paski())
            {
                ToOhm();
            }

            if (condition5paskow())
            {
                ToOhm();
            }
        }
        // guziki wyboru jednostki, zadzialaja, jesli wszystkie "paski" sa wybrane
        private void rbKohm_CheckedChanged(object sender, EventArgs e)
        {
            if (condition4paski())
            {
                TokOhm();
            }

            if (condition5paskow())
            {
                TokOhm();
            }

        }
        // guziki wyboru jednostki, zadzialaja, jesli wszystkie "paski" sa wybrane
        private void rbMohm_CheckedChanged(object sender, EventArgs e)
        {
            if (condition4paski())
            {
                ToMOhm();
            }

            if (condition5paskow())
            {
                ToMOhm();
            }
        }
        // zamiana z kOhm na ohm
        private void ToOhm()
        {
            finalResult.Clear();
            finalResult.Append(result.ToString()).Append(" Ohm").Append(wynik[4]);
            lblWynik.Text = finalResult.ToString();
        }
        // zamiana z kOhm na MOhm
        private void ToMOhm()
        {
            mOhm = result / 1000000;
            finalResult.Clear();
            finalResult.Append(mOhm.ToString()).Append(" MOhm").Append(wynik[4]);
            lblWynik.Text = finalResult.ToString();
        }
        private void TokOhm()
        {
            kOhm = result / 1000;
            finalResult.Clear();
            finalResult.Append(kOhm.ToString()).Append(" kOhm").Append(wynik[4]);
            lblWynik.Text = finalResult.ToString();
        }

        private void cbPaski_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            CbPasek1();             // Ustawiamy pierwsza liczbe
            
            CbPasek2();             // Ustawiamy druga liczbe
            
            CbPasek3();             // Ustawiamy trzecia liczbe (ewentualnie)

            getResult();            // otrzymujemy zmienna result
            
            CbPasek4();             // Ustawianie mnoznika 

            CbPasek5();             // Ustawiamy tolerancje

            getFinalResult();       // Wywołanie funkcji odpowiedzialnej za wyliczenie i wyswietlanie koncowego wyniku
        }

        // Warunek dla opornika z 4 paskami
        private bool condition4paski()
        {
            if (rb4paski.Checked && cbPasek1.SelectedIndex > -1 && cbPasek2.SelectedIndex > -1 &&
                cbPasek4.SelectedIndex > -1 && cbPasek5.SelectedIndex > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // Warunek dla opornika z 5 paskami
        private bool condition5paskow()
        {
            if (rb5paskow.Checked && cbPasek1.SelectedIndex > -1 && cbPasek2.SelectedIndex > -1 &&
                cbPasek4.SelectedIndex > -1 && cbPasek5.SelectedIndex > -1 && cbPasek3.SelectedIndex > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void getResult()
        {
            // jesli mamy 4 paski na oporniku result sklada sie z 2 liczb
            if (rb4paski.Checked)
            {
                result = Convert.ToDouble(wynik[0] + wynik[1]);
            }
            // jesli mamy 4 paski na oporniku result sklada sie z 3 liczb
            if (rb5paskow.Checked)
            {
                result = Convert.ToDouble(wynik[0] + wynik[1] + wynik[2]);
            }
        }
        private void getFinalResult()
        {
            // Gdy spełniony warunek dla opornika z 4 paskami i wybrane jednoski, wywoluje jedno z ponizszych metod
            if (condition4paski())
            {
                if (rbOhm.Checked)
                {
                    ToOhm();
                }
                else if (rbKohm.Checked)
                {
                    TokOhm();
                }
                else if (rbMohm.Checked)
                {
                    ToMOhm();
                }
            }
            // Gdy spełniony warunek dla opornika z 5 paskami i wybrane jednoski, wywoluje jedno z ponizszych metod
            if (condition5paskow())
            {
                if (rbOhm.Checked)
                {
                    ToOhm();
                }
                else if (rbKohm.Checked)
                {
                    TokOhm();
                }
                else if (rbMohm.Checked)
                {
                    ToMOhm();
                }
            }
        }
        // Ustawiamy liczbe pierwsza
        private void CbPasek1()
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
            }
        }
        // Ustawiamy liczbe druga
        private void CbPasek2()
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
            }
        }
        // Ustawiamy liczbe trzecia
        private void CbPasek3()
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
            }
        }
        // Ustawienie mnoznika
        private void CbPasek4()
        {
            if (cbPasek4.SelectedIndex > -1)
            {

                switch (cbPasek4.SelectedIndex)
                {
                    case 0:
                        pasek4.BackColor = Color.Silver;
                        result /= 100;
                        break;
                    case 1:
                        pasek4.BackColor = Color.Gold;
                        result /= 10;
                        break;
                    case 2:
                        pasek4.BackColor = Color.Black;
                        result *= 1;
                        break;
                    case 3:
                        pasek4.BackColor = Color.Brown;
                        result *= 10;
                        break;
                    case 4:
                        pasek4.BackColor = Color.Red;
                        result *= 100;
                        break;
                    case 5:
                        pasek4.BackColor = Color.Orange;
                        result *= 1000;
                        break;
                    case 6:
                        pasek4.BackColor = Color.Yellow;
                        result *= 10000;
                        break;
                    case 7:
                        pasek4.BackColor = Color.Green;
                        result *= 100000;
                        break;
                    case 8:
                        pasek4.BackColor = Color.Blue;
                        result *= 1000000;
                        break;
                    case 9:
                        pasek4.BackColor = Color.Violet;
                        result *= 10000000;
                        break;
                    default:
                        break;
                }
            }
        }
        // Ustawienie tolerancji
        private void CbPasek5()
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
        }
    }
}