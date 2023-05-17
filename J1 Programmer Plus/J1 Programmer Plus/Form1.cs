using System.IO.Ports;

namespace J1_Programmer_Plus
{
    public partial class Form1 : Form
    {

        string dataOUT1;
        string dataOUT2;
        string dataOUT3;
        string dataOUT4;
        string dataOUT5;
        string dataOUT6;
        string dataOUT7;
        string dataOUT8;

        string dataIN1;
        string dataIN2;
        string dataIN3;
        string dataIN4;
        string dataIN5;
        string dataIN6;
        string dataIN7;
        string dataIN8;

        string a = "AT+SMS=";
        string b = ",123456,";
        string caminho = "";
        string g = "";
        int i = 0;

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            ip1text.Text = Properties.Settings.Default.ip1text;
            port1text.Text = Properties.Settings.Default.port1text;
            ip2text.Text = Properties.Settings.Default.ip2text;
            port2text.Text = Properties.Settings.Default.port2text;
            apntext.Text = Properties.Settings.Default.apntext;
            usuariotext.Text = Properties.Settings.Default.usuariotext;
            senhatext.Text = Properties.Settings.Default.senhatext;
            accontext.Text = Properties.Settings.Default.accontext;
            accofftext.Text = Properties.Settings.Default.accofftext;
            angulotext.Text = Properties.Settings.Default.angulotext;
            comandotext.Text = Properties.Settings.Default.comandotext;

            string[] ports = SerialPort.GetPortNames();

            port1.Text = "Desconectado";
            port2.Text = "Desconectado";
            port3.Text = "Desconectado";
            port4.Text = "Desconectado";
            port5.Text = "Desconectado";
            port6.Text = "Desconectado";
            port7.Text = "Desconectado";
            port8.Text = "Desconectado";


            for (int i = 0; i < ports.Length; i++)
            {
                if (port1.Text == "Desconectado")
                {
                    port1.Text = ports[i];
                }

                else if (port2.Text == "Desconectado")
                {
                    port2.Text = ports[i];

                }

                else if (port3.Text == "Desconectado")
                {
                    port3.Text = ports[i];

                }

                else if (port4.Text == "Desconectado")
                {
                    port4.Text = ports[i];

                }

                else if (port5.Text == "Desconectado")
                {
                    port5.Text = ports[i];

                }

                else if (port6.Text == "Desconectado")
                {
                    port6.Text = ports[i];

                }

                else if (port7.Text == "Desconectado")
                {
                    port7.Text = ports[i];

                }

                else if (port8.Text == "Desconectado")
                {
                    port8.Text = ports[i];

                }

            }


        }

        private void todosbuton_Click(object sender, EventArgs e)
        {

            if (serialPort1.IsOpen)
            {

                dataOUT1 = a + "ip" + b + ip1text.Text + "," + port1text.Text;
                serialPort1.WriteLine(dataOUT1);
                logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");



            }
            if (serialPort2.IsOpen)
            {


                dataOUT2 = a + "ip" + b + ip1text.Text + "," + port1text.Text;
                serialPort2.WriteLine(dataOUT2);
                logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");



            }

            if (serialPort3.IsOpen)
            {

                dataOUT3 = a + "ip" + b + ip1text.Text + "," + port1text.Text;
                serialPort3.WriteLine(dataOUT3);
                logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");



            }
            if (serialPort4.IsOpen)
            {

                dataOUT4 = a + "ip" + b + ip1text.Text + "," + port1text.Text;
                serialPort4.WriteLine(dataOUT4);
                logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");


            }
            if (serialPort5.IsOpen)
            {


                dataOUT5 = a + "ip" + b + ip1text.Text + "," + port1text.Text;
                serialPort5.WriteLine(dataOUT5);
                logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");



            }
            if (serialPort6.IsOpen)
            {


                dataOUT6 = a + "ip" + b + ip1text.Text + "," + port1text.Text;
                serialPort6.WriteLine(dataOUT6);
                logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");



            }
            if (serialPort7.IsOpen)
            {


                dataOUT7 = a + "ip" + b + ip1text.Text + "," + port1text.Text;
                serialPort7.WriteLine(dataOUT7);
                logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");


            }
            if (serialPort8.IsOpen)
            {


                dataOUT8 = a + "ip" + b + ip1text.Text + "," + port1text.Text;
                serialPort8.WriteLine(dataOUT8);
                logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");



            }

            int milliseconds = 200;
            Thread.Sleep(milliseconds);
            if (serialPort1.IsOpen)
            {
                dataOUT1 = a + "interval" + b + accontext.Text + "," + accofftext.Text;
                serialPort1.WriteLine(dataOUT1);
                logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
            }
            if (serialPort2.IsOpen)
            {
                dataOUT2 = a + "interval" + b + accontext.Text + "," + accofftext.Text;
                serialPort2.WriteLine(dataOUT2);
                logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
            }
            if (serialPort3.IsOpen)
            {
                dataOUT3 = a + "interval" + b + accontext.Text + "," + accofftext.Text;
                serialPort3.WriteLine(dataOUT3);
                logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
            }
            if (serialPort4.IsOpen)
            {
                dataOUT4 = a + "interval" + b + accontext.Text + "," + accofftext.Text;
                serialPort4.WriteLine(dataOUT4);
                logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
            }
            if (serialPort5.IsOpen)
            {
                dataOUT5 = a + "interval" + b + accontext.Text + "," + accofftext.Text;
                serialPort5.WriteLine(dataOUT5);
                logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
            }
            if (serialPort6.IsOpen)
            {
                dataOUT6 = a + "interval" + b + accontext.Text + "," + accofftext.Text;
                serialPort6.WriteLine(dataOUT6);
                logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
            }
            if (serialPort7.IsOpen)
            {
                dataOUT7 = a + "interval" + b + accontext.Text + "," + accofftext.Text;
                serialPort7.WriteLine(dataOUT7);
                logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
            }
            if (serialPort8.IsOpen)
            {
                dataOUT8 = a + "interval" + b + accontext.Text + "," + accofftext.Text;
                serialPort8.WriteLine(dataOUT8);
                logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
            }
            milliseconds = 200;
            Thread.Sleep(milliseconds);


            if (apntext.Text != "" && usuariotext.Text == "" && senhatext.Text == "")
            {

                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "apn" + b + apntext.Text;
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "apn" + b + apntext.Text;
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "apn" + b + apntext.Text;
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "apn" + b + apntext.Text;
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "apn" + b + apntext.Text;
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "apn" + b + apntext.Text;
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "apn" + b + apntext.Text;
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "apn" + b + apntext.Text;
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }


            }
            else if (apntext.Text != "" && usuariotext.Text != "" && senhatext.Text != "")
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "apn" + b + apntext.Text + "," + usuariotext.Text + "," + senhatext.Text;
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "apn" + b + apntext.Text + "," + usuariotext.Text + "," + senhatext.Text;
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "apn" + b + apntext.Text + "," + usuariotext.Text + "," + senhatext.Text;
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "apn" + b + apntext.Text + "," + usuariotext.Text + "," + senhatext.Text;
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "apn" + b + apntext.Text + "," + usuariotext.Text + "," + senhatext.Text;
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "apn" + b + apntext.Text + "," + usuariotext.Text + "," + senhatext.Text;
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "apn" + b + apntext.Text + "," + usuariotext.Text + "," + senhatext.Text;
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "apn" + b + apntext.Text + "," + usuariotext.Text + "," + senhatext.Text;
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
            milliseconds = 200;
            Thread.Sleep(milliseconds);

            if (serialPort1.IsOpen)
            {

                dataOUT1 = a + "backupserver" + b + "1," + ip2text.Text + "," + port2text.Text;
                serialPort1.WriteLine(dataOUT1);
                logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");



            }
            if (serialPort2.IsOpen)
            {


                dataOUT2 = a + "backupserver" + b + "1," + ip2text.Text + "," + port2text.Text;
                serialPort2.WriteLine(dataOUT2);
                logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");



            }
            if (serialPort3.IsOpen)
            {


                dataOUT3 = a + "backupserver" + b + "1," + ip2text.Text + "," + port2text.Text;
                serialPort3.WriteLine(dataOUT3);
                logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");


            }

            if (serialPort4.IsOpen)
            {

                dataOUT4 = a + "backupserver" + b + "1," + ip2text.Text + "," + port2text.Text;
                serialPort4.WriteLine(dataOUT4);
                logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");


            }
            if (serialPort5.IsOpen)
            {


                dataOUT5 = a + "backupserver" + b + "1," + ip2text.Text + "," + port2text.Text;
                serialPort5.WriteLine(dataOUT5);
                logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");



            }
            if (serialPort6.IsOpen)
            {


                dataOUT6 = a + "backupserver" + b + "1," + ip2text.Text + "," + port2text.Text;
                serialPort6.WriteLine(dataOUT6);
                logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");



            }
            if (serialPort7.IsOpen)
            {


                dataOUT7 = a + "backupserver" + b + "1," + ip2text.Text + "," + port2text.Text;
                serialPort7.WriteLine(dataOUT7);
                logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");


            }
            if (serialPort8.IsOpen)
            {


                dataOUT8 = a + "backupserver" + b + "1," + ip2text.Text + "," + port2text.Text;
                serialPort8.WriteLine(dataOUT8);
                logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");



            }
            milliseconds = 200;
            Thread.Sleep(milliseconds);
            if (serialPort1.IsOpen)
            {
                dataOUT1 = a + "tangle" + b + angulotext.Text;
                serialPort1.WriteLine(dataOUT1);
                logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
            }
            if (serialPort2.IsOpen)
            {
                dataOUT2 = a + "tangle" + b + angulotext.Text;
                serialPort2.WriteLine(dataOUT2);
                logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
            }
            if (serialPort3.IsOpen)
            {
                dataOUT3 = a + "tangle" + b + angulotext.Text;
                serialPort3.WriteLine(dataOUT3);
                logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
            }
            if (serialPort4.IsOpen)
            {
                dataOUT4 = a + "tangle" + b + angulotext.Text;
                serialPort4.WriteLine(dataOUT4);
                logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
            }
            if (serialPort5.IsOpen)
            {
                dataOUT5 = a + "tangle" + b + angulotext.Text;
                serialPort5.WriteLine(dataOUT5);
                logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
            }
            if (serialPort6.IsOpen)
            {
                dataOUT6 = a + "tangle" + b + angulotext.Text;
                serialPort6.WriteLine(dataOUT6);
                logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
            }
            if (serialPort7.IsOpen)
            {
                dataOUT7 = a + "tangle" + b + angulotext.Text;
                serialPort7.WriteLine(dataOUT7);
                logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
            }
            if (serialPort8.IsOpen)
            {
                dataOUT8 = a + "tangle" + b + angulotext.Text;
                serialPort8.WriteLine(dataOUT8);
                logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
            }
            milliseconds = 200;
            Thread.Sleep(milliseconds);
            if (radioButton2.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "autofly" + b + "1";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "autofly" + b + "1";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "autofly" + b + "1";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "autofly" + b + "1";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "autofly" + b + "1";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "autofly" + b + "1";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "autofly" + b + "1";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "autofly" + b + "1";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }

            }
            else if (radioButton1.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "autofly" + b + "0";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "autofly" + b + "0";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "autofly" + b + "0";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "autofly" + b + "0";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "autofly" + b + "0";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "autofly" + b + "0";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "autofly" + b + "0";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "autofly" + b + "0";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }

            }
            milliseconds = 200;
            Thread.Sleep(milliseconds);
            if (radioButton4.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "ipshift" + b + "1";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "ipshift" + b + "1";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "ipshift" + b + "1";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "ipshift" + b + "1";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "ipshift" + b + "1";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "ipshift" + b + "1";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "ipshift" + b + "1";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "ipshift" + b + "1";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
            else if (radioButton3.Checked == true)
            {

                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "ipshift" + b + "0";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "ipshift" + b + "0";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "ipshift" + b + "0";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "ipshift" + b + "0";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "ipshift" + b + "0";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "ipshift" + b + "0";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "ipshift" + b + "0";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "ipshift" + b + "0";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }

            }
            milliseconds = 200;
            Thread.Sleep(milliseconds);

            if (radioButton6.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "sat" + b + "1";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "sat" + b + "1";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "sat" + b + "1";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "sat" + b + "1";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "sat" + b + "1";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "sat" + b + "1";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "sat" + b + "1";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "sat" + b + "1";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
            else if (radioButton5.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "sat" + b + "0";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "sat" + b + "0";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "sat" + b + "0";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "sat" + b + "0";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "sat" + b + "0";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "sat" + b + "0";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "sat" + b + "0";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "sat" + b + "0";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }

            }
            milliseconds = 200;
            Thread.Sleep(milliseconds);
            if (radioButton8.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "gert" + b + "0";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "gert" + b + "0";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "gert" + b + "0";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "gert" + b + "0";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "gert" + b + "0";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "gert" + b + "0";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "gert" + b + "0";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "gert" + b + "0";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
            else if (radioButton7.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "gert" + b + "1";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "gert" + b + "1";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "gert" + b + "1";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "gert" + b + "1";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "gert" + b + "1";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "gert" + b + "1";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "gert" + b + "1";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "gert" + b + "1";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
            milliseconds = 200;
            Thread.Sleep(milliseconds);
            if (radioButton10.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "ignition" + b + "1";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "ignition" + b + "1";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "ignition" + b + "1";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "ignition" + b + "1";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "ignition" + b + "1";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "ignition" + b + "1";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "ignition" + b + "1";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "ignition" + b + "1";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
            else if (radioButton9.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "ignition" + b + "0";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "ignition" + b + "0";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "ignition" + b + "0";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "ignition" + b + "0";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "ignition" + b + "0";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "ignition" + b + "0";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "ignition" + b + "0";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "ignition" + b + "0";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
            milliseconds = 200;
            Thread.Sleep(milliseconds);
            if (radioButton12.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "gpsmileage" + b + "2";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "gpsmileage" + b + "2";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "gpsmileage" + b + "2";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "gpsmileage" + b + "2";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "gpsmileage" + b + "2";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "gpsmileage" + b + "2";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "gpsmileage" + b + "2";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "gpsmileage" + b + "2";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
            else if (radioButton11.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "gpsmileage" + b + "0";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "gpsmileage" + b + "0";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "gpsmileage" + b + "0";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "gpsmileage" + b + "0";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "gpsmileage" + b + "0";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "gpsmileage" + b + "0";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "gpsmileage" + b + "0";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "gpsmileage" + b + "0";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
            milliseconds = 200;
            Thread.Sleep(milliseconds);
            if (radioButton14.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "ativerg" + b + "1";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "ativerg" + b + "1";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "ativerg" + b + "1";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "ativerg" + b + "1";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "ativerg" + b + "1";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "ativerg" + b + "1";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "ativerg" + b + "1";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "ativerg" + b + "1";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
            else if (radioButton13.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "ativerg" + b + "0";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "ativerg" + b + "0";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "ativerg" + b + "0";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "ativerg" + b + "0";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "ativerg" + b + "0";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "ativerg" + b + "0";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "ativerg" + b + "0";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "ativerg" + b + "0";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
            milliseconds = 200;
            Thread.Sleep(milliseconds);
            if (radioButton16.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "protocol" + b + "E3";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "protocol" + b + "E3";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "protocol" + b + "E3";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "protocol" + b + "E3";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "protocol" + b + "E3";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "protocol" + b + "E3";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "protocol" + b + "E3";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "protocol" + b + "E3";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
            else if (radioButton15.Checked)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "protocol" + b + "gt06";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "protocol" + b + "gt06";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "protocol" + b + "gt06";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "protocol" + b + "gt06";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "protocol" + b + "gt06";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "protocol" + b + "gt06";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "protocol" + b + "gt06";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "protocol" + b + "gt06";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ipbutton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen || serialPort2.IsOpen || serialPort3.IsOpen || serialPort4.IsOpen || serialPort5.IsOpen || serialPort6.IsOpen || serialPort7.IsOpen || serialPort8.IsOpen)
            {
                if (ip1text.Text == "" || port1text.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos de IP e PORTA");
                }
                else
                {

                    if (serialPort1.IsOpen)
                    {

                        dataOUT1 = a + "ip" + b + ip1text.Text + "," + port1text.Text;
                        serialPort1.WriteLine(dataOUT1);
                        logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");



                    }
                    if (serialPort2.IsOpen)
                    {


                        dataOUT2 = a + "ip" + b + ip1text.Text + "," + port1text.Text;
                        serialPort2.WriteLine(dataOUT2);
                        logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");



                    }
                    if (serialPort3.IsOpen)
                    {


                        dataOUT3 = a + "ip" + b + ip1text.Text + "," + port1text.Text;
                        serialPort3.WriteLine(dataOUT3);
                        logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");


                    }

                    if (serialPort3.IsOpen)
                    {

                        dataOUT3 = a + "ip" + b + ip1text.Text + "," + port1text.Text;
                        serialPort3.WriteLine(dataOUT3);
                        logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");



                    }
                    if (serialPort4.IsOpen)
                    {

                        dataOUT4 = a + "ip" + b + ip1text.Text + "," + port1text.Text;
                        serialPort4.WriteLine(dataOUT4);
                        logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");


                    }
                    if (serialPort5.IsOpen)
                    {


                        dataOUT5 = a + "ip" + b + ip1text.Text + "," + port1text.Text;
                        serialPort5.WriteLine(dataOUT5);
                        logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");



                    }
                    if (serialPort6.IsOpen)
                    {


                        dataOUT6 = a + "ip" + b + ip1text.Text + "," + port1text.Text;
                        serialPort6.WriteLine(dataOUT6);
                        logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");



                    }
                    if (serialPort7.IsOpen)
                    {


                        dataOUT7 = a + "ip" + b + ip1text.Text + "," + port1text.Text;
                        serialPort7.WriteLine(dataOUT7);
                        logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");


                    }
                    if (serialPort8.IsOpen)
                    {


                        dataOUT8 = a + "ip" + b + ip1text.Text + "," + port1text.Text;
                        serialPort8.WriteLine(dataOUT8);
                        logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");



                    }

                }
            }

        }

        private void intervalbutton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen || serialPort2.IsOpen || serialPort3.IsOpen || serialPort4.IsOpen || serialPort5.IsOpen || serialPort6.IsOpen || serialPort7.IsOpen || serialPort8.IsOpen)
            {
                if (accontext.Text == "" || accofftext.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos de intervalo");
                }
                else
                {
                    if (serialPort1.IsOpen)
                    {
                        dataOUT1 = a + "interval" + b + accontext.Text + "," + accofftext.Text;
                        serialPort1.WriteLine(dataOUT1);
                        logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                    }
                    if (serialPort2.IsOpen)
                    {
                        dataOUT2 = a + "interval" + b + accontext.Text + "," + accofftext.Text;
                        serialPort2.WriteLine(dataOUT2);
                        logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                    }
                    if (serialPort3.IsOpen)
                    {
                        dataOUT3 = a + "interval" + b + accontext.Text + "," + accofftext.Text;
                        serialPort3.WriteLine(dataOUT3);
                        logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                    }
                    if (serialPort4.IsOpen)
                    {
                        dataOUT4 = a + "interval" + b + accontext.Text + "," + accofftext.Text;
                        serialPort4.WriteLine(dataOUT4);
                        logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                    }
                    if (serialPort5.IsOpen)
                    {
                        dataOUT5 = a + "interval" + b + accontext.Text + "," + accofftext.Text;
                        serialPort5.WriteLine(dataOUT5);
                        logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                    }
                    if (serialPort6.IsOpen)
                    {
                        dataOUT6 = a + "interval" + b + accontext.Text + "," + accofftext.Text;
                        serialPort6.WriteLine(dataOUT6);
                        logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                    }
                    if (serialPort7.IsOpen)
                    {
                        dataOUT7 = a + "interval" + b + accontext.Text + "," + accofftext.Text;
                        serialPort7.WriteLine(dataOUT7);
                        logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                    }
                    if (serialPort8.IsOpen)
                    {
                        dataOUT8 = a + "interval" + b + accontext.Text + "," + accofftext.Text;
                        serialPort8.WriteLine(dataOUT8);
                        logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                    }
                }
            }
        }

        private void apnbutton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen || serialPort2.IsOpen || serialPort3.IsOpen || serialPort4.IsOpen || serialPort5.IsOpen || serialPort6.IsOpen || serialPort7.IsOpen || serialPort8.IsOpen)
            {

                if (apntext.Text == "" && usuariotext.Text == "" && senhatext.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos ou apenas o de APN");
                }
                else if (apntext.Text != "" && usuariotext.Text == "" && senhatext.Text == "")
                {

                    if (serialPort1.IsOpen)
                    {
                        dataOUT1 = a + "apn" + b + apntext.Text;
                        serialPort1.WriteLine(dataOUT1);
                        logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                    }
                    if (serialPort2.IsOpen)
                    {
                        dataOUT2 = a + "apn" + b + apntext.Text;
                        serialPort2.WriteLine(dataOUT2);
                        logenvio.AppendText(port1.Text + ": " + dataOUT2 + "\r\n");
                    }
                    if (serialPort3.IsOpen)
                    {
                        dataOUT3 = a + "apn" + b + apntext.Text;
                        serialPort3.WriteLine(dataOUT3);
                        logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                    }
                    if (serialPort4.IsOpen)
                    {
                        dataOUT4 = a + "apn" + b + apntext.Text;
                        serialPort4.WriteLine(dataOUT4);
                        logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                    }
                    if (serialPort5.IsOpen)
                    {
                        dataOUT5 = a + "apn" + b + apntext.Text;
                        serialPort5.WriteLine(dataOUT5);
                        logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                    }
                    if (serialPort6.IsOpen)
                    {
                        dataOUT6 = a + "apn" + b + apntext.Text;
                        serialPort6.WriteLine(dataOUT6);
                        logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                    }
                    if (serialPort7.IsOpen)
                    {
                        dataOUT7 = a + "apn" + b + apntext.Text;
                        serialPort7.WriteLine(dataOUT7);
                        logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                    }
                    if (serialPort8.IsOpen)
                    {
                        dataOUT8 = a + "apn" + b + apntext.Text;
                        serialPort8.WriteLine(dataOUT8);
                        logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                    }


                }
                else if (apntext.Text != "" && usuariotext.Text != "" && senhatext.Text != "")
                {
                    if (serialPort1.IsOpen)
                    {
                        dataOUT1 = a + "apn" + b + apntext.Text + "," + usuariotext.Text + "," + senhatext.Text;
                        serialPort1.WriteLine(dataOUT1);
                        logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                    }
                    if (serialPort2.IsOpen)
                    {
                        dataOUT2 = a + "apn" + b + apntext.Text + "," + usuariotext.Text + "," + senhatext.Text;
                        serialPort2.WriteLine(dataOUT2);
                        logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                    }
                    if (serialPort3.IsOpen)
                    {
                        dataOUT3 = a + "apn" + b + apntext.Text + "," + usuariotext.Text + "," + senhatext.Text;
                        serialPort3.WriteLine(dataOUT3);
                        logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                    }
                    if (serialPort4.IsOpen)
                    {
                        dataOUT4 = a + "apn" + b + apntext.Text + "," + usuariotext.Text + "," + senhatext.Text;
                        serialPort4.WriteLine(dataOUT4);
                        logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                    }
                    if (serialPort5.IsOpen)
                    {
                        dataOUT5 = a + "apn" + b + apntext.Text + "," + usuariotext.Text + "," + senhatext.Text;
                        serialPort5.WriteLine(dataOUT5);
                        logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                    }
                    if (serialPort6.IsOpen)
                    {
                        dataOUT6 = a + "apn" + b + apntext.Text + "," + usuariotext.Text + "," + senhatext.Text;
                        serialPort6.WriteLine(dataOUT6);
                        logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                    }
                    if (serialPort7.IsOpen)
                    {
                        dataOUT7 = a + "apn" + b + apntext.Text + "," + usuariotext.Text + "," + senhatext.Text;
                        serialPort7.WriteLine(dataOUT7);
                        logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                    }
                    if (serialPort8.IsOpen)
                    {
                        dataOUT8 = a + "apn" + b + apntext.Text + "," + usuariotext.Text + "," + senhatext.Text;
                        serialPort8.WriteLine(dataOUT8);
                        logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                    }
                }

            }

        }

        private void ip2button_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen || serialPort2.IsOpen || serialPort3.IsOpen || serialPort4.IsOpen || serialPort5.IsOpen || serialPort6.IsOpen || serialPort7.IsOpen || serialPort8.IsOpen)
            {
                if (ip2text.Text == "" || port2text.Text == "")
                {
                    MessageBox.Show("Preencha todos os campos de IP2 e PORTA2");
                }
                else
                {

                    if (serialPort1.IsOpen)
                    {

                        dataOUT1 = a + "backupserver" + b + "1," + ip2text.Text + "," + port2text.Text;
                        serialPort1.WriteLine(dataOUT1);
                        logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");



                    }
                    if (serialPort2.IsOpen)
                    {


                        dataOUT2 = a + "backupserver" + b + "1," + ip2text.Text + "," + port2text.Text;
                        serialPort2.WriteLine(dataOUT2);
                        logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");



                    }
                    if (serialPort3.IsOpen)
                    {


                        dataOUT3 = a + "backupserver" + b + "1," + ip2text.Text + "," + port2text.Text;
                        serialPort3.WriteLine(dataOUT3);
                        logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");


                    }
                    if (serialPort4.IsOpen)
                    {

                        dataOUT4 = a + "backupserver" + b + "1," + ip2text.Text + "," + port2text.Text;
                        serialPort4.WriteLine(dataOUT4);
                        logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");


                    }
                    if (serialPort5.IsOpen)
                    {


                        dataOUT5 = a + "backupserver" + b + "1," + ip2text.Text + "," + port2text.Text;
                        serialPort5.WriteLine(dataOUT5);
                        logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");



                    }
                    if (serialPort6.IsOpen)
                    {


                        dataOUT6 = a + "backupserver" + b + "1," + ip2text.Text + "," + port2text.Text;
                        serialPort6.WriteLine(dataOUT6);
                        logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");



                    }
                    if (serialPort7.IsOpen)
                    {


                        dataOUT7 = a + "backupserver" + b + "1," + ip2text.Text + "," + port2text.Text;
                        serialPort7.WriteLine(dataOUT7);
                        logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");


                    }
                    if (serialPort8.IsOpen)
                    {


                        dataOUT8 = a + "backupserver" + b + "1," + ip2text.Text + "," + port2text.Text;
                        serialPort8.WriteLine(dataOUT8);
                        logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");



                    }

                }
            }
        }

        private void angulobutton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen || serialPort2.IsOpen || serialPort3.IsOpen || serialPort4.IsOpen || serialPort5.IsOpen || serialPort6.IsOpen || serialPort7.IsOpen || serialPort8.IsOpen)
            {
                if (angulotext.Text == "")
                {
                    MessageBox.Show("O campo de angulo está vazio");
                }
                else
                {
                    if (serialPort1.IsOpen)
                    {
                        dataOUT1 = a + "tangle" + b + angulotext.Text;
                        serialPort1.WriteLine(dataOUT1);
                        logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                    }
                    if (serialPort2.IsOpen)
                    {
                        dataOUT2 = a + "tangle" + b + angulotext.Text;
                        serialPort2.WriteLine(dataOUT2);
                        logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                    }
                    if (serialPort3.IsOpen)
                    {
                        dataOUT3 = a + "tangle" + b + angulotext.Text;
                        serialPort3.WriteLine(dataOUT3);
                        logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                    }
                    if (serialPort4.IsOpen)
                    {
                        dataOUT4 = a + "tangle" + b + angulotext.Text;
                        serialPort4.WriteLine(dataOUT1);
                        logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                    }
                    if (serialPort5.IsOpen)
                    {
                        dataOUT5 = a + "tangle" + b + angulotext.Text;
                        serialPort5.WriteLine(dataOUT5);
                        logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                    }
                    if (serialPort6.IsOpen)
                    {
                        dataOUT6 = a + "tangle" + b + angulotext.Text;
                        serialPort6.WriteLine(dataOUT6);
                        logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                    }
                    if (serialPort7.IsOpen)
                    {
                        dataOUT7 = a + "tangle" + b + angulotext.Text;
                        serialPort7.WriteLine(dataOUT7);
                        logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                    }
                    if (serialPort8.IsOpen)
                    {
                        dataOUT8 = a + "tangle" + b + angulotext.Text;
                        serialPort8.WriteLine(dataOUT8);
                        logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                    }
                }
            }
        }

        private void port7_CheckedChanged(object sender, EventArgs e)
        {
            if (port7.Checked == true && port7.Text != "Desconectado")
            {
                try
                {
                    serialPort7.PortName = port7.Text;
                    serialPort7.BaudRate = 115200;
                    serialPort7.DataBits = 8;
                    serialPort7.StopBits = StopBits.One;
                    serialPort7.Parity = Parity.None;
                    serialPort7.Open();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message + "\n Porta já está sendo utilizada por outro serviço.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    port7.Checked = false;
                }
            }
            else if (port7.Checked == false)
            {
                serialPort7.Close();
            }
            else
            {
                port7.Checked = false;
            }
        }

        private void port6_CheckedChanged(object sender, EventArgs e)
        {
            if (port6.Checked == true && port6.Text != "Desconectado")
            {
                try
                {
                    serialPort6.PortName = port6.Text;
                    serialPort6.BaudRate = 115200;
                    serialPort6.DataBits = 8;
                    serialPort6.StopBits = StopBits.One;
                    serialPort6.Parity = Parity.None;
                    serialPort6.Open();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message + "\n Porta já está sendo utilizada por outro serviço.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    port6.Checked = false;
                }
            }
            else if (port6.Checked == false)
            {
                serialPort6.Close();
            }
            else
            {
                port6.Checked = false;
            }
        }

        private void port5_CheckedChanged(object sender, EventArgs e)
        {
            if (port5.Checked == true && port5.Text != "Desconectado")
            {
                try
                {
                    serialPort5.PortName = port5.Text;
                    serialPort5.BaudRate = 115200;
                    serialPort5.DataBits = 8;
                    serialPort5.StopBits = StopBits.One;
                    serialPort5.Parity = Parity.None;
                    serialPort5.Open();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message + "\n Porta já está sendo utilizada por outro serviço.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    port5.Checked = false;
                }
            }
            else if (port5.Checked == false)
            {
                serialPort5.Close();
            }
            else
            {
                port5.Checked = false;
            }
        }

        private void port7log_TextChanged(object sender, EventArgs e)
        {

        }

        private void port6log_TextChanged(object sender, EventArgs e)
        {

        }

        private void port5log_TextChanged(object sender, EventArgs e)
        {

        }

        private void port1log_TextChanged(object sender, EventArgs e)
        {

        }

        private void port1_CheckedChanged(object sender, EventArgs e)
        {
            if (port1.Checked == true && port1.Text != "Desconectado")
            {
                try
                {
                    serialPort1.PortName = port1.Text;
                    serialPort1.BaudRate = 115200;
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Parity = Parity.None;
                    serialPort1.Open();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message + "\n Porta já está sendo utilizada por outro serviço.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    port1.Checked = false;
                }
            }
            else if (port1.Checked == false)
            {
                serialPort1.Close();
            }
            else
            {
                port1.Checked = false;
            }
        }

        private void port2_CheckedChanged(object sender, EventArgs e)
        {
            if (port2.Checked == true && port2.Text != "Desconectado")
            {
                try
                {
                    serialPort2.PortName = port2.Text;
                    serialPort2.BaudRate = 115200;
                    serialPort2.DataBits = 8;
                    serialPort2.StopBits = StopBits.One;
                    serialPort2.Parity = Parity.None;
                    serialPort2.Open();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message + "\n Porta já está sendo utilizada por outro serviço.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    port2.Checked = false;
                }
            }
            else if (port2.Checked == false)
            {
                serialPort2.Close();
            }
            else
            {
                port2.Checked = false;
            }
        }


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                if (port1.Checked == true)
                {

                    dataOUT1 = "AT+LOG=1";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");


                }
                if (port2.Checked == true)
                {

                    dataOUT2 = "AT+LOG=1";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");


                }
                if (port3.Checked == true)
                {

                    dataOUT3 = "AT+LOG=1";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");


                }
                if (port4.Checked == true)
                {
                    dataOUT4 = "AT+LOG=1";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");


                }
                if (port5.Checked == true)
                {

                    dataOUT5 = "AT+LOG=1";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");

                }
                if (port6.Checked == true)
                {

                    dataOUT6 = "AT+LOG=1";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");


                }
                if (port7.Checked == true)
                {

                    dataOUT7 = "AT+LOG=1";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");


                }
                if (port8.Checked == true)
                {
                    dataOUT8 = "AT+LOG=1";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");


                }
                return true;
            }
            else if (keyData == (Keys.Control | Keys.D))
            {
                if (port1.Checked == true)
                {

                    dataOUT1 = "AT+LOG=0";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");


                }
                if (port2.Checked == true)
                {

                    dataOUT2 = "AT+LOG=0";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");


                }
                if (port3.Checked == true)
                {

                    dataOUT3 = "AT+LOG=0";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");


                }
                if (port4.Checked == true)
                {
                    dataOUT4 = "AT+LOG=0";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");


                }
                if (port5.Checked == true)
                {

                    dataOUT5 = "AT+LOG=0";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");


                }
                if (port6.Checked == true)
                {

                    dataOUT6 = "AT+LOG=0";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");


                }
                if (port7.Checked == true)
                {

                    dataOUT7 = "AT+LOG=0";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");


                }
                if (port8.Checked == true)
                {
                    dataOUT8 = "AT+LOG=0";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");


                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void port2log_TextChanged(object sender, EventArgs e)
        {

        }

        private void port3_CheckedChanged(object sender, EventArgs e)
        {
            if (port3.Checked == true && port3.Text != "Desconectado")
            {
                try
                {
                    serialPort3.PortName = port3.Text;
                    serialPort3.BaudRate = 115200;
                    serialPort3.DataBits = 8;
                    serialPort3.StopBits = StopBits.One;
                    serialPort3.Parity = Parity.None;
                    serialPort3.Open();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message + "\n Porta já está sendo utilizada por outro serviço.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    port3.Checked = false;
                }
            }
            else if (port3.Checked == false)
            {
                serialPort3.Close();
            }
            else
            {
                port3.Checked = false;
            }
        }

        private void port3log_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void port4_CheckedChanged(object sender, EventArgs e)
        {

            if (port4.Checked == true && port4.Text != "Desconectado")
            {
                try
                {
                    serialPort4.PortName = port4.Text;
                    serialPort4.BaudRate = 115200;
                    serialPort4.DataBits = 8;
                    serialPort4.StopBits = StopBits.One;
                    serialPort4.Parity = Parity.None;
                    serialPort4.Open();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message + "\n Porta já está sendo utilizada por outro serviço.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    port4.Checked = false;
                }
            }
            else if (port4.Checked == false)
            {
                serialPort4.Close();
            }
            else
            {
                port4.Checked = false;
            }
        }

        private void port8log_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void accofftext_TextChanged(object sender, EventArgs e)
        {

        }

        private void accontext_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void angulotext_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            SaveFileDialog save = new SaveFileDialog();

            save.FileName = "Config.txt";

            save.Filter = "Text File | *.txt";

            save.InitialDirectory = "c:\\";
            if (save.ShowDialog() == DialogResult.OK)

            {

                StreamWriter writer = new StreamWriter(save.OpenFile());

                g = ip1text.Text + ';' + port1text.Text + ';' + ip2text.Text + ';' + port2text.Text + ';' + apntext.Text + ';' + usuariotext.Text + ';' + senhatext.Text + ';' + accontext.Text + ';' + accofftext.Text + ';' + angulotext.Text + ';' + radioButton1.Checked + ';' + radioButton2.Checked + ';' + radioButton3.Checked + ';' + radioButton4.Checked + ';' + radioButton5.Checked + ';' + radioButton6.Checked + ';' + radioButton7.Checked + ';' + radioButton8.Checked + ';' + radioButton9.Checked + ';' + radioButton10.Checked + ';' + radioButton11.Checked + ';' + radioButton12.Checked + ';' + radioButton13.Checked + ';' + radioButton14.Checked + ';' + radioButton15.Checked + ';' + radioButton16.Checked + ';';


                writer.WriteLine(g);

                writer.Dispose();

                writer.Close();

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ip1text.Clear();
            ip2text.Clear();
            port1text.Clear();
            port2text.Clear();
            apntext.Clear();
            usuariotext.Clear();
            senhatext.Clear();
            accontext.Clear();
            accofftext.Clear();
            angulotext.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            radioButton6.Checked = false;
            radioButton7.Checked = false;
            radioButton8.Checked = false;
            radioButton9.Checked = false;
            radioButton10.Checked = false;
            radioButton11.Checked = false;
            radioButton12.Checked = false;
            radioButton13.Checked = false;
            radioButton14.Checked = false;
            radioButton15.Checked = false;
            radioButton16.Checked = false;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.ip1text = ip1text.Text;
            Properties.Settings.Default.port1text = port1text.Text;
            Properties.Settings.Default.port2text = port2text.Text;
            Properties.Settings.Default.ip2text = ip2text.Text;
            Properties.Settings.Default.apntext = apntext.Text;
            Properties.Settings.Default.usuariotext = usuariotext.Text;
            Properties.Settings.Default.senhatext = senhatext.Text;
            Properties.Settings.Default.accontext = accontext.Text;
            Properties.Settings.Default.accofftext = accofftext.Text;
            Properties.Settings.Default.angulotext = angulotext.Text;
            Properties.Settings.Default.comandotext = comandotext.Text;
            Properties.Settings.Default.Save();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN1 = serialPort1.ReadExisting();
            port1log.AppendText(dataIN1 + "\n");
        }
        private void serialPort2_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN2 = serialPort2.ReadExisting();
            port2log.AppendText(dataIN2 + "\n");
        }
        private void serialPort3_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN3 = serialPort3.ReadExisting();
            port3log.AppendText(dataIN3 + "\n");
        }
        private void serialPort4_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN4 = serialPort4.ReadExisting();
            port4log.AppendText(dataIN4 + "\n");
        }
        private void serialPort5_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN5 = serialPort5.ReadExisting();
            port5log.AppendText(dataIN5 + "\n");
        }
        private void serialPort6_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN6 = serialPort6.ReadExisting();
            port6log.AppendText(dataIN6 + "\n");
        }
        private void serialPort7_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN7 = serialPort7.ReadExisting();
            port7log.AppendText(dataIN7 + "\n");
        }
        private void serialPort8_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            dataIN8 = serialPort8.ReadExisting();
            port8log.AppendText(dataIN8 + "\n");
        }

        private void port8_CheckedChanged(object sender, EventArgs e)
        {
            if (port8.Checked == true && port8.Text != "Desconectado")
            {
                try
                {
                    serialPort8.PortName = port8.Text;
                    serialPort8.BaudRate = 115200;
                    serialPort8.DataBits = 8;
                    serialPort8.StopBits = StopBits.One;
                    serialPort8.Parity = Parity.None;
                    serialPort8.Open();
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message + "\n Porta já está sendo utilizada por outro serviço.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    port8.Checked = false;
                }
            }
            else if (port8.Checked == false)
            {
                serialPort8.Close();
            }
            else
            {
                port8.Checked = false;
            }
        }

        private void checkall_CheckedChanged(object sender, EventArgs e)
        {
            if (checkall.Checked == true)
            {
                port1.Checked = true;
                port2.Checked = true;
                port3.Checked = true;
                port4.Checked = true;
                port5.Checked = true;
                port6.Checked = true;
                port7.Checked = true;
                port8.Checked = true;
            }
            else if (checkall.Checked == false)
            {
                port1.Checked = false;
                port2.Checked = false;
                port3.Checked = false;
                port4.Checked = false;
                port5.Checked = false;
                port6.Checked = false;
                port7.Checked = false;
                port8.Checked = false;
            }

        }

        private void testbutton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                dataOUT1 = "AT+TEST=1";
                serialPort1.WriteLine(dataOUT1);
                logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
            }
            if (serialPort2.IsOpen)
            {
                dataOUT2 = "AT+TEST=1";
                serialPort2.WriteLine(dataOUT2);
                logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
            }
            if (serialPort3.IsOpen)
            {
                dataOUT3 = "AT+TEST=1";
                serialPort3.WriteLine(dataOUT3);
                logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
            }
            if (serialPort4.IsOpen)
            {
                dataOUT4 = "AT+TEST=1";
                serialPort4.WriteLine(dataOUT4);
                logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
            }
            if (serialPort5.IsOpen)
            {
                dataOUT5 = "AT+TEST=1";
                serialPort5.WriteLine(dataOUT5);
                logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
            }
            if (serialPort6.IsOpen)
            {
                dataOUT6 = "AT+TEST=1";
                serialPort6.WriteLine(dataOUT6);
                logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
            }
            if (serialPort7.IsOpen)
            {
                dataOUT7 = "AT+TEST=1";
                serialPort7.WriteLine(dataOUT7);
                logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
            }
            if (serialPort8.IsOpen)
            {
                dataOUT8 = "AT+TEST=1";
                serialPort8.WriteLine(dataOUT8);
                logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"C:\",
                Title = "Carregar Configuração",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                caminho = openFileDialog1.FileName;
                string[] lines = File.ReadAllLines(caminho);

                g = "";
                foreach (string line in lines)
                {
                    g = g + line;

                }

                string[] words = g.Split(';');

                for (i = 0; i < words.Length; i++)
                {
                    if (i == 0)
                    {
                        ip1text.Text = words[i];
                    }
                    else if (i == 1)
                    {
                        port1text.Text = words[i];
                    }
                    else if (i == 2)
                    {
                        ip2text.Text = words[i];
                    }
                    else if (i == 3)
                    {
                        port2text.Text = words[i];
                    }
                    else if (i == 4)
                    {
                        apntext.Text = words[i];
                    }
                    else if (i == 5)
                    {
                        usuariotext.Text = words[i];
                    }
                    else if (i == 6)
                    {
                        senhatext.Text = words[i];
                    }
                    else if (i == 7)
                    {
                        accontext.Text = words[i];
                    }
                    else if (i == 8)
                    {
                        accofftext.Text = words[i];
                    }
                    else if (i == 9)
                    {
                        angulotext.Text = words[i];
                    }
                    else if (i == 10)
                    {
                        radioButton1.Checked = Convert.ToBoolean(words[i]);
                    }
                    else if (i == 11)
                    {
                        radioButton2.Checked = Convert.ToBoolean(words[i]);
                    }
                    else if (i == 12)
                    {
                        radioButton3.Checked = Convert.ToBoolean(words[i]);
                    }
                    else if (i == 13)
                    {
                        radioButton4.Checked = Convert.ToBoolean(words[i]);
                    }
                    else if (i == 14)
                    {
                        radioButton5.Checked = Convert.ToBoolean(words[i]);
                    }
                    else if (i == 15)
                    {
                        radioButton6.Checked = Convert.ToBoolean(words[i]);
                    }
                    else if (i == 16)
                    {
                        radioButton7.Checked = Convert.ToBoolean(words[i]);
                    }
                    else if (i == 17)
                    {
                        radioButton8.Checked = Convert.ToBoolean(words[i]);
                    }
                    else if (i == 18)
                    {
                        radioButton9.Checked = Convert.ToBoolean(words[i]);
                    }
                    else if (i == 19)
                    {
                        radioButton10.Checked = Convert.ToBoolean(words[i]);
                    }
                    else if (i == 20)
                    {
                        radioButton11.Checked = Convert.ToBoolean(words[i]);
                    }
                    else if (i == 21)
                    {
                        radioButton12.Checked = Convert.ToBoolean(words[i]);
                    }
                    else if (i == 22)
                    {
                        radioButton13.Checked = Convert.ToBoolean(words[i]);
                    }
                    else if (i == 23)
                    {
                        radioButton14.Checked = Convert.ToBoolean(words[i]);
                    }
                    else if (i == 24)
                    {
                        radioButton15.Checked = Convert.ToBoolean(words[i]);
                    }
                    else if (i == 25)
                    {
                        radioButton16.Checked = Convert.ToBoolean(words[i]);
                    }
                }


                logenvio.AppendText("Configuração Carregada \r\n");
            }


        }

        private void comandobutton_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen || serialPort2.IsOpen || serialPort3.IsOpen || serialPort4.IsOpen || serialPort5.IsOpen || serialPort6.IsOpen || serialPort7.IsOpen || serialPort8.IsOpen)
            {
                if (comandotext.Text == "")
                {
                    MessageBox.Show("O campo de comandos está vazio");
                }
                else
                {
                    if (serialPort1.IsOpen)
                    {
                        dataOUT1 = a + comandotext.Text;
                        serialPort1.WriteLine(dataOUT1);
                        logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                    }
                    if (serialPort2.IsOpen)
                    {
                        dataOUT2 = a + comandotext.Text;
                        serialPort2.WriteLine(dataOUT2);
                        logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                    }
                    if (serialPort3.IsOpen)
                    {
                        dataOUT3 = a + comandotext.Text;
                        serialPort3.WriteLine(dataOUT3);
                        logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                    }
                    if (serialPort4.IsOpen)
                    {
                        dataOUT4 = a + comandotext.Text;
                        serialPort4.WriteLine(dataOUT4);
                        logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                    }
                    if (serialPort5.IsOpen)
                    {
                        dataOUT5 = a + comandotext.Text;
                        serialPort5.WriteLine(dataOUT5);
                        logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                    }
                    if (serialPort6.IsOpen)
                    {
                        dataOUT6 = a + comandotext.Text;
                        serialPort6.WriteLine(dataOUT6);
                        logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                    }
                    if (serialPort7.IsOpen)
                    {
                        dataOUT7 = a + comandotext.Text;
                        serialPort7.WriteLine(dataOUT7);
                        logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                    }
                    if (serialPort8.IsOpen)
                    {
                        dataOUT8 = a + comandotext.Text;
                        serialPort8.WriteLine(dataOUT8);
                        logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                    }
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                port1log.Clear();
            }
            if (serialPort2.IsOpen)
            {
                port2log.Clear();
            }
            if (serialPort3.IsOpen)
            {
                port3log.Clear();
            }
            if (serialPort4.IsOpen)
            {
                port4log.Clear();
            }
            if (serialPort5.IsOpen)
            {
                port5log.Clear();
            }
            if (serialPort6.IsOpen)
            {
                port6log.Clear();
            }
            if (serialPort7.IsOpen)
            {
                port7log.Clear();
            }
            if (serialPort8.IsOpen)
            {
                port8log.Clear();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            logenvio.Clear();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Ajuda_Click(object sender, EventArgs e)
        {


            

        }

        private void button22_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();

            port1.Text = "Desconectado";
            port2.Text = "Desconectado";
            port3.Text = "Desconectado";
            port4.Text = "Desconectado";
            port5.Text = "Desconectado";
            port6.Text = "Desconectado";
            port7.Text = "Desconectado";
            port8.Text = "Desconectado";


            for (int i = 0; i < ports.Length; i++)
            {
                if (port1.Text == "Desconectado")
                {
                    port1.Text = ports[i];
                }

                else if (port2.Text == "Desconectado")
                {
                    port2.Text = ports[i];

                }

                else if (port3.Text == "Desconectado")
                {
                    port3.Text = ports[i];

                }

                else if (port4.Text == "Desconectado")
                {
                    port4.Text = ports[i];

                }

                else if (port5.Text == "Desconectado")
                {
                    port5.Text = ports[i];

                }

                else if (port6.Text == "Desconectado")
                {
                    port6.Text = ports[i];

                }

                else if (port7.Text == "Desconectado")
                {
                    port7.Text = ports[i];

                }

                else if (port8.Text == "Desconectado")
                {
                    port8.Text = ports[i];

                }

            }


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "autofly" + b + "1";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "autofly" + b + "1";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "autofly" + b + "1";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "autofly" + b + "1";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "autofly" + b + "1";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "autofly" + b + "1";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "autofly" + b + "1";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "autofly" + b + "1";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }

            }
            else if (radioButton1.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "autofly" + b + "0";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "autofly" + b + "0";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "autofly" + b + "0";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "autofly" + b + "0";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "autofly" + b + "0";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "autofly" + b + "0";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "autofly" + b + "0";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "autofly" + b + "0";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (radioButton4.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "ipshift" + b + "1";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "ipshift" + b + "1";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "ipshift" + b + "1";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "ipshift" + b + "1";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "ipshift" + b + "1";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "ipshift" + b + "1";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "ipshift" + b + "1";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "ipshift" + b + "1";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
            else if (radioButton3.Checked == true)
            {

                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "ipshift" + b + "0";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "ipshift" + b + "0";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "ipshift" + b + "0";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "ipshift" + b + "0";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "ipshift" + b + "0";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "ipshift" + b + "0";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "ipshift" + b + "0";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "ipshift" + b + "0";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

            if (radioButton6.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "sat" + b + "1";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "sat" + b + "1";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "sat" + b + "1";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "sat" + b + "1";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "sat" + b + "1";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "sat" + b + "1";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "sat" + b + "1";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "sat" + b + "1";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
            else if (radioButton5.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "sat" + b + "0";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "sat" + b + "0";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "sat" + b + "0";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "sat" + b + "0";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "sat" + b + "0";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "sat" + b + "0";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "sat" + b + "0";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "sat" + b + "0";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (radioButton8.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "gert" + b + "0";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "gert" + b + "0";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "gert" + b + "0";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "gert" + b + "0";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "gert" + b + "0";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "gert" + b + "0";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "gert" + b + "0";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "gert" + b + "0";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
            else if (radioButton7.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "gert" + b + "1";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "gert" + b + "1";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "gert" + b + "1";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "gert" + b + "1";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "gert" + b + "1";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "gert" + b + "1";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "gert" + b + "1";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "gert" + b + "1";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (radioButton10.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "ignition" + b + "1";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "ignition" + b + "1";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "ignition" + b + "1";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "ignition" + b + "1";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "ignition" + b + "1";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "ignition" + b + "1";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "ignition" + b + "1";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "ignition" + b + "1";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
            else if (radioButton9.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "ignition" + b + "0";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "ignition" + b + "0";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "ignition" + b + "0";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "ignition" + b + "0";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "ignition" + b + "0";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "ignition" + b + "0";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "ignition" + b + "0";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "ignition" + b + "0";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (radioButton12.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "gpsmileage" + b + "2";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "gpsmileage" + b + "2";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "gpsmileage" + b + "2";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "gpsmileage" + b + "2";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "gpsmileage" + b + "2";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "gpsmileage" + b + "2";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "gpsmileage" + b + "2";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "gpsmileage" + b + "2";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
            else if (radioButton11.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "gpsmileage" + b + "0";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "gpsmileage" + b + "0";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "gpsmileage" + b + "0";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "gpsmileage" + b + "0";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "gpsmileage" + b + "0";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "gpsmileage" + b + "0";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "gpsmileage" + b + "0";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "gpsmileage" + b + "0";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (radioButton14.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "ativerg" + b + "1";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "ativerg" + b + "1";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "ativerg" + b + "1";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "ativerg" + b + "1";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "ativerg" + b + "1";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "ativerg" + b + "1";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "ativerg" + b + "1";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "ativerg" + b + "1";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
            else if (radioButton13.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "ativerg" + b + "0";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "ativerg" + b + "0";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "ativerg" + b + "0";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "ativerg" + b + "0";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "ativerg" + b + "0";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "ativerg" + b + "0";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "ativerg" + b + "0";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "ativerg" + b + "0";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            if (radioButton16.Checked == true)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "protocol" + b + "E3";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "protocol" + b + "E3";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "protocol" + b + "E3";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "protocol" + b + "E3";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "protocol" + b + "E3";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "protocol" + b + "E3";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "protocol" + b + "E3";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "protocol" + b + "E3";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
            else if (radioButton15.Checked)
            {
                if (serialPort1.IsOpen)
                {
                    dataOUT1 = a + "protocol" + b + "gt06";
                    serialPort1.WriteLine(dataOUT1);
                    logenvio.AppendText(port1.Text + ": " + dataOUT1 + "\r\n");
                }
                if (serialPort2.IsOpen)
                {
                    dataOUT2 = a + "protocol" + b + "gt06";
                    serialPort2.WriteLine(dataOUT2);
                    logenvio.AppendText(port2.Text + ": " + dataOUT2 + "\r\n");
                }
                if (serialPort3.IsOpen)
                {
                    dataOUT3 = a + "protocol" + b + "gt06";
                    serialPort3.WriteLine(dataOUT3);
                    logenvio.AppendText(port3.Text + ": " + dataOUT3 + "\r\n");
                }
                if (serialPort4.IsOpen)
                {
                    dataOUT4 = a + "protocol" + b + "gt06";
                    serialPort4.WriteLine(dataOUT4);
                    logenvio.AppendText(port4.Text + ": " + dataOUT4 + "\r\n");
                }
                if (serialPort5.IsOpen)
                {
                    dataOUT5 = a + "protocol" + b + "gt06";
                    serialPort5.WriteLine(dataOUT5);
                    logenvio.AppendText(port5.Text + ": " + dataOUT5 + "\r\n");
                }
                if (serialPort6.IsOpen)
                {
                    dataOUT6 = a + "protocol" + b + "gt06";
                    serialPort6.WriteLine(dataOUT6);
                    logenvio.AppendText(port6.Text + ": " + dataOUT6 + "\r\n");
                }
                if (serialPort7.IsOpen)
                {
                    dataOUT7 = a + "protocol" + b + "gt06";
                    serialPort7.WriteLine(dataOUT7);
                    logenvio.AppendText(port7.Text + ": " + dataOUT7 + "\r\n");
                }
                if (serialPort8.IsOpen)
                {
                    dataOUT8 = a + "protocol" + b + "gt06";
                    serialPort8.WriteLine(dataOUT8);
                    logenvio.AppendText(port8.Text + ": " + dataOUT8 + "\r\n");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void port1log_MouseHover(object sender, EventArgs e)
        {
            port1log.Width = 300;
            port1log.Height = 315;
        }

        private void port1log_MouseLeave(object sender, EventArgs e)
        {
            port1log.Width = 150;
            port1log.Height = 315;
        }

        private void port2log_MouseHover(object sender, EventArgs e)
        {
            port2log.Width = 300;
            port2log.Height = 315;
        }

        private void port2log_MouseLeave(object sender, EventArgs e)
        {
            port2log.Width = 150;
            port2log.Height = 315;
        }

        private void port3log_MouseHover(object sender, EventArgs e)
        {
            port4log.SendToBack();
            port3log.Width = 300;
            port3log.Height = 315;
        }

        private void port3log_MouseLeave(object sender, EventArgs e)
        {
            port3log.Width = 150;
            port3log.Height = 315;
        }

        private void port4log_MouseHover(object sender, EventArgs e)
        {
            port4log.Location = new Point(700, 53);
            port3log.SendToBack();
            port4log.Width = 300;
            port4log.Height = 315;

        }

        private void port4log_MouseLeave(object sender, EventArgs e)
        {
            port4log.Location = new Point(855, 53);
            port4log.Width = 150;
            port4log.Height = 315;


        }

        private void port5log_MouseHover(object sender, EventArgs e)
        {
            port5log.Width = 300;
            port5log.Height = 315;
        }

        private void port5log_MouseLeave(object sender, EventArgs e)
        {
            port5log.Width = 150;
            port5log.Height = 315;
        }

        private void port6log_MouseHover(object sender, EventArgs e)
        {
            port6log.Width = 300;
            port6log.Height = 315;
        }

        private void port6log_MouseLeave(object sender, EventArgs e)
        {
            port6log.Width = 150;
            port6log.Height = 315;
        }

        private void port7log_MouseHover(object sender, EventArgs e)
        {
            port8log.SendToBack();
            port7log.Width = 300;
            port7log.Height = 315;
        }

        private void port7log_MouseLeave(object sender, EventArgs e)
        {
            port7log.Width = 150;
            port7log.Height = 315;
        }

        private void port8log_MouseHover(object sender, EventArgs e)
        {
            port7log.SendToBack();
            port8log.Location = new Point(700, 395);
            port8log.Width = 300;
            port8log.Height = 315;
        }

        private void port8log_MouseLeave(object sender, EventArgs e)
        {
            port8log.Location = new Point(855, 395);
            port8log.Width = 150;
            port8log.Height = 315;
        }
    }
}
