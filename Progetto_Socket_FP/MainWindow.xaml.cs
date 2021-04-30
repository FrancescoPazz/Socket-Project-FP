using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
//Added those libreries. 
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Progetto_Socket_FP
{
    /// <summary>
    /// Logic interaction for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void btnCreateSocket_Click(object sender, RoutedEventArgs e)
        {
            //Our IP Address find with ipconfig in CMD or Powershell with a random port of our choice.
            IPEndPoint sourceSocket = new IPEndPoint(IPAddress.Parse("10.73.0.16"),56000);
            //Create a thread that abilitate method 'SocketReceive'. Then we pass the parameter on start. 
            Thread receive = new Thread(new ParameterizedThreadStart(SocketReceive));
            receive.Start(sourceSocket);
        }
        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            string ipAddress = txtIP.Text;
            int port = int.Parse(txtPort.Text);

            SocketSend(IPAddress.Parse(ipAddress), port, txtMessage.Text);
        }
        public async void SocketReceive(object socketsource)
        {
            IPEndPoint ipendp = (IPEndPoint)socketsource;
            Socket t = new Socket(ipendp.AddressFamily, SocketType.Dgram, ProtocolType.Udp);
            t.Bind(ipendp);
            Byte[] bytereceived = new Byte[256]; //dimension of byte we can receive
            string message;
            int bytesCount = 0;

            await Task.Run(() =>
            {
                //when i am here, i don't block the interface. 
                while (true)
                {
                    //Verification if there's something on the socket. 
                    if (t.Available > 0)
                    {
                        message = "";
                        bytesCount = t.Receive(bytereceived, bytereceived.Length, 0);
                        message += Encoding.ASCII.GetString(bytereceived, 0, bytesCount);
                        this.Dispatcher.BeginInvoke(new Action(() => 
                        {
                            tbkReceive.Text = message;
                        }));
                        
                    }
                }
            });
            
        }
        public void SocketSend(IPAddress destination, int destinationPort, string message)
        {
            Byte[] bytesended = Encoding.ASCII.GetBytes(message);
            Socket s = new Socket(destination.AddressFamily, SocketType.Dgram, ProtocolType.Udp);
            IPEndPoint remote_endpoint = new IPEndPoint(destination, destinationPort);
            s.SendTo(bytesended, remote_endpoint);
        }
        //controls 
        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string ipAddress = txtIP.Text;
            string port = txtPort.Text;
            int countDot = 0;
            for (int i = 0; i < ipAddress.Length; i++)
            {
                if (ipAddress[i] == '.')
                    countDot++;
            }
            if (string.IsNullOrEmpty(ipAddress) && string.IsNullOrEmpty(port) && countDot == 3)
                btnSend.IsEnabled = true;
            else
                btnSend.IsEnabled = false;
        }
    }
}
