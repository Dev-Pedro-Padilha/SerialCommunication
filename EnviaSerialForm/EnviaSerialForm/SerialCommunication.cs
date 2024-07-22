using System;
using System.IO.Ports;
using System.Text;
using System.Threading;

public class SerialCommunication
{
    private SerialPort _serialPort;

    public SerialCommunication(string port, int baudRate)
    {
        _serialPort = new SerialPort(port)
        {
            BaudRate = baudRate,
            DataBits = 8,
            Parity = Parity.None,
            StopBits = StopBits.One
        };
    }

    public void OpenConnection()
    {
        if (!_serialPort.IsOpen)
        {
            _serialPort.Open();
            Thread.Sleep(500); // Aguarda um pouco para garantir que a porta foi aberta corretamente
            Console.WriteLine("Porta serial aberta com sucesso.");
        }
    }

    public void CloseConnection()
    {
        if (_serialPort.IsOpen)
        {
            _serialPort.Close();
            Console.WriteLine("Porta serial fechada.");
        }
    }
    //Envia dados em formato hexadecimal pela porta serial.
    public void SendHexString(string hexString)
    {
        //Calcula o bcc e envia o comando+bcc
        byte[] bytesToSend = HexStringToByteArray(hexString);
        byte bcc = CalculateBCC(bytesToSend);

        byte[] comando = new byte[bytesToSend.Length + 1];
        Array.Copy(bytesToSend, comando, bytesToSend.Length);
        comando[bytesToSend.Length] = bcc;

        if (_serialPort.IsOpen)
        {
            _serialPort.Write(comando, 0, comando.Length);
            Console.WriteLine("Dados enviados.");
        }
        else
        {
            Console.WriteLine("Porta serial não está aberta.");
        }
    }

    public string ReadResponse()
    {
        if (_serialPort.IsOpen)
        {
            Thread.Sleep(100); // Aguarda um pouco para garantir que todos os dados foram recebidos
            string response = _serialPort.ReadExisting();
            Console.WriteLine("Resposta: " + response);
            return response;
        }
        else
        {
            Console.WriteLine("Porta serial não está aberta.");
            return null;
        }
    }
    // Converte uma string hexadecimal em um array de bytes hexadecimal.
    private byte[] HexStringToByteArray(string hex)
    {
        int numberChars = hex.Length;
        byte[] bytes = new byte[numberChars / 2];
        for (int i = 0; i < numberChars; i += 2)
        {
            bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
        }
        return bytes;
    }
    //Recebe o comando e calcula o BCC
    public static byte CalculateBCC(byte[] data)
    {
        byte bcc = 0x00;

        foreach (byte b in data)
        {
            bcc ^= b;
        }
        return bcc;
    }
    //Converte string ASCII para string Hex
    public static string StringToHex(string asciiString)
    {
        byte[] bytes = Encoding.ASCII.GetBytes(asciiString);
        string hex = BitConverter.ToString(bytes).Replace("-", "");
        return hex;
    }



}
