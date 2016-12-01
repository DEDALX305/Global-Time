using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;

namespace Global_Time
{
    public partial class Form1 : Form
    {
        public static string TextChangedv;
        public static string InputText;
        public static string userName;
        private const string host = "127.0.0.1";
        private const int port = 8888;
        static TcpClient client;
        public static NetworkStream stream;


        public string mesto;
        public string selectedCountry;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //foreach (TimeZoneInfo info in TimeZoneInfo.GetSystemTimeZones())
            //    listBox1.Items.Add(info);
        }

        public void main222()
        {

            client = new TcpClient();

            client.Connect(host, port); //подключение клиента
            stream = client.GetStream(); // получаем поток
            
         
            //string message = mesto;
            //byte[] data = Encoding.Unicode.GetBytes(message);
            //stream.Write(data, 0, data.Length);

            // запускаем новый поток для получения данных
            Thread receiveThread = new Thread(new ThreadStart(ReceiveMessage));
            receiveThread.Start(); //старт потока
                                   //Console.WriteLine("Добро пожаловать, {0}", userName);

            Console.WriteLine("main ok");
            // textBox3.Text = String.Format("Добро пожаловать, {0}", userName) ;
        }

        public void ReceiveMessage()
        {
            while (true)
            {
                try
                {
                    byte[] data = new byte[64]; // буфер для получаемых данных
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);

                    string message = builder.ToString();
                    //Console.WriteLine(message);//вывод сообщения
                    // WindowsFormsApplication1.Form1.textBox3_TextChanged = message;
                    //textBox3.Text = message;
                    //  TextBox textBox3 = new TextBox();

                    // textBox3.Text = String.Format(message);
                    //ListViewItem ListView1 = new ListViewItem();
                    //ListView1.Text = message;
                    textBox1.Text = (String.Format(message));
                    //listView1.Items.Add(message);
                }
                catch
                {
                    //TextBox textBox3 = new TextBox();
                    textBox1.Text = (String.Format("Подключение прервано!"));
                    // textBox3.Text = String.Format("Подключение прервано!");
                    //Console.WriteLine("Подключение прервано!"); //соединение было прервано
                    //Console.ReadLine();
                    Disconnect();
                }
            }
        }
        public static void Disconnect()
        {
            if (stream != null)
                stream.Close();//отключение потока
            if (client != null)
                client.Close();//отключение клиента
            Environment.Exit(0); //завершение процесса
        }

        public void TimeZoneInf()
        {
            TimeZoneInfo timeZoneInfo;
        DateTime dateTime;
        //Set the time zone information to US Mountain Standard Time 
        timeZoneInfo = TimeZoneInfo.FindSystemTimeZoneById(selectedCountry);
            //Get date and time in US Mountain Standard Time 
            dateTime = TimeZoneInfo.ConvertTime(DateTime.Now, timeZoneInfo);
            //Print out the date and time
            textBox1.Text = dateTime.ToString("yyyy-MM-dd HH-mm-ss");
            Console.WriteLine(dateTime.ToString("yyyy-MM-dd HH-mm-ss"));
            }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            textBox2.Text = listBox1.SelectedItem.ToString();
            selectedCountry = listBox1.SelectedItem.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TimeZoneInf();
            main222();

       
          
           

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mesto = listBox2.SelectedItem.ToString();
            Console.WriteLine(mesto);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.Unicode.GetBytes(mesto);
            stream.Write(data, 0, data.Length);
            Console.WriteLine(mesto);
        }
    }
}
