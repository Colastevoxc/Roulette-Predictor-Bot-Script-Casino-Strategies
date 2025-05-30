using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
    public partial class FormMembresia : Form
    {
        Random random = new Random();
        int[] numbers = { 1, 2, 3, 4 };
        int[] numbers1 = { 1, 2, 3 };
        int[] numbers2 = { 1, 2 };
        int[] numbers3 = { 1, 2, 3 };
        int[] numbers4 = { 1, 2, 3, 4 };

        List<int> selectedNumbers = new List<int>();

        public FormMembresia()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FormListaClientes hijo = new FormListaClientes();
            AddOwnedForm(hijo);
            hijo.FormBorderStyle = FormBorderStyle.None;
            hijo.TopLevel = false;
            hijo.Dock = DockStyle.Fill;
            this.Controls.Add(hijo);
            this.Tag = hijo;
            hijo.BringToFront();

            hijo.Show();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox11.Text = comboBox2.Text;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved", "Alert!!", MessageBoxButtons.OK);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox2.SelectedIndex;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select a valid level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int count = selectedIndex + 1; 

            List.Items.Clear();

            for (int i = 0; i < count; i++)
            {
                double selectedNumber = Math.Round(random.NextDouble() * 35, 2); 
                List.Items.Add(selectedNumber.ToString("0")); 
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void FormMembresia_Load(object sender, EventArgs e)
        {

        }

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;

            if (selectedIndex == -1)
            {
                MessageBox.Show("Please select a valid level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int count = selectedIndex + 1;

            while (true)
            {
                List.Items.Clear(); // List olarak adlandırılan kontrolün adı doğru mu?
                for (int i = 0; i < count; i++)
                {
                    double selectedNumber = Math.Round(random.NextDouble() * 35, 2);
                    List.Items.Add(selectedNumber.ToString("0"));
                }

                await Task.Delay(2000); // 2 saniye bekle
            }
        }

        private async Task GenerateRandomNumbers(int[] selectedNumbersArray, int count)
        {
            
            for (int i = 0; i < count; i++)
            {
                int index = random.Next(selectedNumbersArray.Length);
                int selectedNumber = selectedNumbersArray[index];

               
                while (selectedNumbers.Contains(selectedNumber))
                {
                    index = random.Next(selectedNumbersArray.Length);
                    selectedNumber = selectedNumbersArray[index];
                }

                selectedNumbers.Add(selectedNumber);
                List.Items.Add(selectedNumber);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved", "Alert!!", MessageBoxButtons.OK);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved", "Alert!!", MessageBoxButtons.OK);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saved", "Alert!!", MessageBoxButtons.OK);
        }
    }
}
