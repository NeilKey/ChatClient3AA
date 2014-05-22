using ChatClient3AA.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace ChatClient3AA
{
    class Connect
    {
        private Socket m_sock;
        private bool m_flConnected = false;

        delegate void SetMessage(String sNewMessage);
        delegate void CloseConnection(Socket sock);
        private event SetMessage m_SetMessage;
        private event CloseConnection m_CloseConnection;

        private byte[] m_receiveBuf = new byte[2048];

        private void connectClient()
        {
            try
            {
                int port = Convert.ToInt32(Settings.Default.Port);
                try
                {
                    // Chiudi il socket se è ancora aperto
                    if (m_sock != null && m_sock.Connected)
                    {
                        m_sock.Shutdown(SocketShutdown.Both);
                        m_sock.Close();
                    }
                    // Crea un oggetto socket
                    m_sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    try
                    {
                        // Tenta il parsing dell'indirizzo del server
                        IPAddress ia = IPAddress.Parse(Settings.Default.Hostname);
                        m_sock.Connect(ia, port);
                    }
                    catch (FormatException)
                    {
                        // Assumi il nome del server come hostname
                        m_sock.Connect(Settings.Default.Hostname, port);
                    }
                    try
                    {
                        // Imposta la ricezione dati tramite una callback
                        SetupReceiveCallback(m_sock);
                        m_flConnected = m_sock.Connected;
                    }
                    catch (Exception e)
                    {
                        //MessageBox.Show(this, e.Message, "Setup Receive Callback Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception e)
                {
                    //MessageBox.Show(this, e.Message, "Server Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                //MessageBox.Show(this, "Invalid Port number!", "Socket Client Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupReceiveCallback(Socket sock)
        {
            try
            {
                AsyncCallback receiveData = new AsyncCallback(OnReceivedData);
                sock.BeginReceive(m_receiveBuf, 0, m_receiveBuf.Length, SocketFlags.None,
                receiveData, sock);
            }
            catch (Exception) { }
        }

        public void OnReceivedData(IAsyncResult ar)
        {
            // Il socket sorgente è passato nell'oggetto ar
            Socket sock = (Socket) ar.AsyncState;
            if (!sock.Connected) return;
            // Controlla se sono stati ricevuti dei dati
            try
            {
                int nBytesRec = sock.EndReceive(ar);
                if (nBytesRec > 0)
                {
                    // Converti in stringa Unicode i dati dicevuti nel buffer di ricezione
                    String sReceived = Encoding.Unicode.GetString(m_receiveBuf, 0, nBytesRec);
                    // In questo punto la thread è quella di ricezione, non è possibile accedere alla
                    // GUI direttamente, invocare il delegate m_SetMessage che sarà eseguito dalla
                    // thread che ha creato this (il form)
                    this.Invoke(m_SetMessage, new String[] { sReceived });
                    // La connessione è ancora utilizzabile, ripristina la callback
                    SetupReceiveCallback(sock);
                }
                else
                {
                    // Se non sono stati ricevuti dei dati, la connessione è probabilmente chiusa
                    this.Invoke(m_CloseConnection, new Socket[] { sock });
                }
            }
            catch (SocketException e)
            {
                if (e.ErrorCode == 10054) this.Invoke(m_CloseConnection, new Socket[] { sock });
            }
            catch (Exception) { }
        }

        public void createNewAccount(String nick_name, String user_name, String password) 
        {
            String credentials = "Utente:" + nick_name + " " + user_name + " " + password;
            
            if (m_sock == null || !m_sock.Connected)
            {
                //MessageBox.Show(this, "Must be connected to Send a message!", "Socket Client Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Converti in byte array (UTF-16, little endian) e invia
                byte[] bufMsg = Encoding.Unicode.GetBytes(credentials + "\n");
                m_sock.Send(bufMsg, bufMsg.Length, 0);
            }
            catch (Exception e)
            {
                //MessageBox.Show(this, e.Message, "Send Message Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loginUser(String user_name, String password)
        {
            String credentials = "Utente:" + user_name + " " + password;

            if (m_sock == null || !m_sock.Connected)
            {
                //MessageBox.Show(this, "Must be connected to Send a message!", "Socket Client Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Converti in byte array (UTF-16, little endian) e invia
                byte[] bufMsg = Encoding.Unicode.GetBytes(credentials + "\n");
                m_sock.Send(bufMsg, bufMsg.Length, 0);
            }
            catch (Exception e)
            {
                //MessageBox.Show(this, e.Message, "Send Message Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
