using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesars_Encryption
{
    public partial class MainPage : Form
    {      

        public string Input_Text, Encryption_Text,_Key;

        public int Key, i, j;

        public MainPage()
        {
            InitializeComponent();
        }

        //form load
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Minimize Buton
        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Exit Buton
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult ds;
            ds = MessageBox.Show("Are you sure you want to exit the application?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (ds == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //target panel gizleme
        private void textBox2_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        //target panel gizleme
        private void textBox1_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        //Input (Key value)'nin sadece rakamlardan (0-9) oluşması için kontrol
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        //Decrypt (Key value)'nin sadece rakamlardan (0-9) oluşması için kotrol
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        //Encrypt Butonu
        private void button1_Click(object sender, EventArgs e)
        {
            _Key = textBox4.Text;
            if(_Key == "" || _Key == null)
            {
                MessageBox.Show("Enter the key!");
            }
            else
            {
                textBox5.Clear();
                Encryption Call = new Encryption();
                textBox5.Text = Call._Encryption(textBox1.Text, Convert.ToInt32(textBox4.Text));
                panel3.Visible = true;
            }
            
        }

        //Decrypt Butonu
        private void button3_Click(object sender, EventArgs e)
        {
            _Key = textBox3.Text;
            if(_Key == "" || _Key == null)
            {
                MessageBox.Show("Enter the key!");
            }
            else
            {
                Decryption Call = new Decryption();
                textBox5.Clear();
                textBox5.Text = Call._Decryption(textBox2.Text, Convert.ToInt32(textBox3.Text));
                panel3.Visible = true;
            }
           
        }






    }
}
