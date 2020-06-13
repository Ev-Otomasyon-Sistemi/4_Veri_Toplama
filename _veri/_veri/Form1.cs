using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace _veri
{
    public partial class Form1 : Form
    {
        private SerialPort _port;  // Seri port nesnesi oluşturuyoruz

        private DateTime datetime;
        private string in_data;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _port = new SerialPort();
            _port.BaudRate = 9600; //Kullanacağımız seri port hızını 
            _port.PortName = textBox1.Text; //Kullanacağımız seri port adını
            _port.Parity = Parity.None; //  Gönderilen verinin doğruluğunu kontrol etmek 
            _port.DataBits = 8; //göndereceğimiz bilginin kaç bitten olduğu
            _port.StopBits = StopBits.One; //Stop bitinin kaç bit olacağını belirtir.
            _port.DataReceived += my_DataTecevied;
            try
            {
                _port.Open();
              textBox2.Text = "";
               // listBox1.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata Oluştu");

            }
        }
        void my_DataTecevied(object sender, SerialDataReceivedEventArgs e)
        {
            in_data = _port.ReadLine();
            //Veriler alınır

            this.Invoke(new EventHandler(displaydata_event));

        }
        private void displaydata_event(object sender, EventArgs e)
        {
            //Gelener verileri güncel zaman ile ekle
            datetime = DateTime.Now;
            string time = datetime.Hour + ":" + datetime.Minute + ":" + datetime.Second;
   
            textBox2.AppendText(time + "\t\t\t" + in_data + "\n");
         


        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string pathfile = @"C:\Users\USER\Desktop";
                string filename = "veri.txt";
                System.IO.File.WriteAllText(pathfile + filename, textBox2.Text);
                MessageBox.Show("Kayıt Edildi " + pathfile, "Bilgi");
            }
            catch (Exception ex3)
            {

                MessageBox.Show(ex3.Message, "Hata Oluştu");
            }
        }


       private void button2_Click(object sender, EventArgs e)
        {
            _port.Close(); //seri portu kapat

        }
    }
}
