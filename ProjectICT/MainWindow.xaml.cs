using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Threading;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProjectICT
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SerialPort _serialPort;
        Leds _leds;

        private DispatcherTimer _timer;

        Brush filledBrush = Brushes.Yellow;
        Brush transparentBrush = Brushes.Transparent;

        public MainWindow()
        {
            InitializeComponent();

            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromMilliseconds(100);
            _timer.Tick += Timer_Tick;


            _serialPort = new SerialPort();
            _leds = new Leds();

            // Komt er data binnen? Ga verder naar de event handler.
            _serialPort.DataReceived += _serialPort_DataReceived;

            cbxComPorts.Items.Add("None");
            foreach (string s in SerialPort.GetPortNames())
                cbxComPorts.Items.Add(s);
        }

        private void _serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Lees alle tekst binnen tot er een new line passeert... (\n).
            string receivedText = _serialPort.ReadLine().Trim();

            //// Poging met error...
            //// Plaats de ontvangen dat op het Label.
            //lblReceivedData.Content = receivedText;

            // Geef de data door aan een thread van de GUI om zo 
            // het Label aan te passen.
            Dispatcher.Invoke(new Action<string>(Update), receivedText);
        }

        private void Update(string text)
        {
            _leds.ComData = Convert.ToInt32(text);

            if(_leds.Toggle1 == true) { _timer.Start(); }
            
            


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _leds.Aansturen();
            LedUpdate();
            if (_leds.Toggle1 == false && _leds.Led8 == true) { _timer.Stop(); _leds.Reset(); }
        }

        private void LedUpdate()
        {
            if (_leds.Led1 == true) { Cirkel1.Fill = filledBrush; }
            else { Cirkel1.Fill = transparentBrush; }

            if (_leds.Led2 == true) { Cirkel2.Fill = filledBrush; }
            else { Cirkel2.Fill = transparentBrush; }

            if (_leds.Led3 == true) { Cirkel3.Fill = filledBrush; }
            else { Cirkel3.Fill = transparentBrush; }

            if (_leds.Led4 == true) { Cirkel4.Fill = filledBrush; }
            else { Cirkel4.Fill = transparentBrush; }

            if (_leds.Led5 == true) { Cirkel5.Fill = filledBrush; }
            else { Cirkel5.Fill = transparentBrush; }

            if (_leds.Led6 == true) { Cirkel6.Fill = filledBrush; }
            else { Cirkel6.Fill = transparentBrush; }

            if (_leds.Led7 == true) { Cirkel7.Fill = filledBrush; }
            else { Cirkel7.Fill = transparentBrush; }

            if (_leds.Led8 == true) { Cirkel8.Fill = filledBrush; }
            else { Cirkel8.Fill = transparentBrush; }

            


        }

        

        private void cbxComPorts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (_serialPort != null)
            {
                if (_serialPort.IsOpen)
                    _serialPort.Close();

                if (cbxComPorts.SelectedItem.ToString() != "None")
                {
                    _serialPort.PortName = cbxComPorts.SelectedItem.ToString();
                    _serialPort.Open();
                }
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (_serialPort != null)
                _serialPort.Dispose();
        }
    }
}