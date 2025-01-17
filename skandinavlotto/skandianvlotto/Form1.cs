using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace skandianvlotto
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Checkboxok = input;
            selectedNumbers = new int[maxlottoszam];
            CheckBox(Checkboxok);

        }


        int checkedCount = 0;
        int[] selectedNumbers;
        public int maxlottoszam =7;
        public int input = 35;
        int Checkboxok;
        int[] tomb;

  
        
        static Random r = new Random();
        public static int[] Lotto(int szam, int lottoszamok)
        {
            List<int> lottoLista = new List<int>();
            for (int i = 0; i < lottoszamok; i++)
            {
                lottoLista.Add(i + 1);


            }

            int[] tomb = new int[szam];

            for (int i = 0; i < szam; i++)
            {
                int j = r.Next(lottoLista.Count);
                tomb[i] = (lottoLista.ElementAt(j));
                lottoLista.RemoveAt(j);


            }
            Array.Sort(tomb);

            return tomb;




        }

        public static int Tombhasonlitas(int[] tomb, int[] jatekos, int szam)
        {
            int helyes = 0;


            for (int i = 0; i < tomb.Length; i++)
            {
                for (int j = 0; j < jatekos.Length; j++)
                {
                    if (tomb[i] == jatekos[j])
                    {
                        helyes = helyes + 1;
                    }

                }

            }

            return helyes;
        }

        public static string Veg(int szam, int helyes)
        {
            string veg = "";
            if (helyes == 0)
            {
                veg = ("Nem talált el egyet sem :(");
            }
            else if (helyes == szam)
            {
                veg = ($"Teli találat!!! :D");
            }
            else
            {
                veg = ($"{helyes} db helyes találat!");
            }
            return veg;
        }




        List<int> selectedValues = new List<int>();



        private void CheckBox(int Checkboxok)
        {
            int x = 10;
            int y = 10;

            int oszlopok = Math.Min(10, Checkboxok);



            for (int i = 0; i < Checkboxok; i++)
            {



                CheckBox checkbox = new CheckBox();
                checkbox.Text = $"{i + 1}";
                checkbox.Tag = i + 1;

                int sor = i / oszlopok;
                int oszlop = i % oszlopok;

                checkbox.Location = new Point(x + oszlop * (checkbox.Width), y + sor * (checkbox.Height + 5));
                panel1.Controls.Add(checkbox);


                checkbox.CheckedChanged += CheckBox_CheckedChanged;

                if (oszlop == oszlopok - 1)
                {
                    y += checkbox.Height + 10;
                }
            }

        }



        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;

            if (checkBox.Checked)
            {
                int number = (int)checkBox.Tag;

                selectedValues.Add(number);


                checkedCount++;
                if (checkedCount > maxlottoszam)
                {
                    checkBox.Checked = false;
                    MessageBox.Show($"Csak {maxlottoszam} db lottószámot választhat.");

                }

            }
            else
            {
                int number = (int)checkBox.Tag;


                selectedValues.Remove(number);

                checkedCount--;
            }
        }











        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      


        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            selectedNumbers = selectedValues.ToArray();
            Array.Sort(selectedNumbers);

            if (selectedNumbers.Length < maxlottoszam)
            {
                MessageBox.Show($"Válasszon {maxlottoszam} db lottószámot.");
            }
            else
            {

                tomb = Lotto(maxlottoszam, Checkboxok);

                string numbersString = "Kiválasztott számok: ";
                string tombString = "Lottószámok: ";
                foreach (int number in selectedNumbers)
                {
                    if (number != 0)
                    {
                        numbersString += $"{number}, ";
                    }
                }
                foreach (int j in tomb)
                {
                    if (j != 0)
                    {
                        tombString += $"{j}, ";
                    }
                }
                MessageBox.Show(tombString + "\n\n" + numbersString, "Lottószámok");

                int helyes = Tombhasonlitas(selectedNumbers, tomb, maxlottoszam);
                string result = Veg(maxlottoszam, helyes);
                MessageBox.Show(result, "Eredmény");
            }
        }
    }
}
