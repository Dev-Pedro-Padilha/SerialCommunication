using System.IO.Ports;

namespace EnviaSerialForm
{
    public partial class Form1 : Form
    {

        public string serialPort;

        SerialCommunication serialComm;
        public Form1()
        {
            InitializeComponent();
            timerCOM.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SerialPort serialPort = new SerialPort();
        }

        private void atualizaListaCOMs()
        {
            int i;
            bool quantDiferente;    //flag para sinalizar que a quantidade de portas mudou

            i = 0;
            quantDiferente = false;

            //se a quantidade de portas mudou
            if (comboBox1.Items.Count == SerialPort.GetPortNames().Length)
            {
                foreach (string s in SerialPort.GetPortNames())
                {
                    if (comboBox1.Items[i++].Equals(s) == false)
                    {
                        quantDiferente = true;
                    }
                }
            }
            else
            {
                quantDiferente = true;
            }

            //Se não foi detectado diferença
            if (quantDiferente == false)
            {
                return;                     //retorna
            }

            //limpa comboBox
            comboBox1.Items.Clear();

            //adiciona todas as COM diponíveis na lista
            foreach (string s in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(s);
            }
            //seleciona a primeira posição da lista
            comboBox1.SelectedIndex = 0;
        }

        //Atualiza Portas Seriais
        private void timerCOM_Tick(object sender, EventArgs e)
        {
            atualizaListaCOMs();
        }

        private void bttnConect_Click(object sender, EventArgs e)
        {
            serialPort = comboBox1.Items[comboBox1.SelectedIndex].ToString();
            int baudRate = 115200;
            // Cria uma instância da classe SerialCommunication
            serialComm = new SerialCommunication(serialPort, baudRate);

            // Abre a conexão
            serialComm.OpenConnection();

            UpdateLED(true);


        }

        private void bttnEnviar_Click(object sender, EventArgs e)
        {
            //Pega protocolo e comando digitado pelo usuario
            string header = textBoxHeader.Text;
            string command = textBoxComando.Text;
            string trailer = textBoxTrailer.Text;
            //Converte comando ASCII para Hex
            string commandhex = SerialCommunication.StringToHex(command);

            //Concatena e monta comando
            string protocolcommand = header + commandhex + trailer;
            Console.WriteLine(protocolcommand);

            serialComm.SendHexString(protocolcommand);

            // Lê a resposta
            string response = serialComm.ReadResponse();
            Console.WriteLine("Resposta: " + response);
            textBoxResposta.Text = response;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Fecha a conexão
            serialComm.CloseConnection();
            UpdateLED(false);
        }

        private void UpdateLED(bool isConnected)
        {
            if (isConnected)
            {
                pictureBoxLED.Image = Image.FromFile("Resources/LedGreen.png");
            }
            else
            {
                pictureBoxLED.Image = Image.FromFile("Resources/LedRed.png");
            }
        }

    }
}