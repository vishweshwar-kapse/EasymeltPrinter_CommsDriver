using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Net.Sockets;

namespace EasymeltPrinter_CommsDriver
{
    public partial class Form1 : Form
    {
        private PrinterConfiguration CurrentConfiguration = new PrinterConfiguration();
        private static string ConfigFileName = "PrinterConfiguration.json";
        private TcpClient client = null;

        private BindingList<string> ComboBoxFileNames = new BindingList<string>();
        public Form1()
        {
            InitializeComponent();

            try
            {
                //trying to load the initial configurations
                CurrentConfiguration = JsonConvert.DeserializeObject<PrinterConfiguration>(File.ReadAllText(ConfigFileName));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);

            if (CurrentConfiguration != null)
            {
                txtIpAddress.Text = CurrentConfiguration.IpAddress;
                txtPort.Text = CurrentConfiguration.PortNumber.ToString();


                List<string> fileNameList = CurrentConfiguration.LabelFileCollection.Select(x => x.TxbFileName).ToList();

                foreach (var item in fileNameList)
                {
                    ComboBoxFileNames.Add(item);
                }
                if (CurrentConfiguration?.LabelFileCollection?.Count > 0)
                {
                    cbFilenames.DataSource = ComboBoxFileNames;
                }
            }
        }

        private void ClearGridview()
        {

        }

        private void btnAddFilename_Click(object sender, EventArgs e)
        {
            string currentFilename = cbFilenames.Text;
            if (string.IsNullOrWhiteSpace(currentFilename))
            {
                MessageBox.Show("Please add a filename to continue");
                return;
            }
            grdKeyValuePairs.DataSource = new BindingList<TxbFileConfiguration>();
            grdKeyValuePairs.Rows.Clear();
        }

        private void cbFilenames_TextChanged(object sender, EventArgs e)
        {
            string currentFilename = cbFilenames.Text;
            var currentConfig = CurrentConfiguration.GetConfigForFile(currentFilename);
            if (currentConfig != null)
            {
                btnAddFilename.Enabled = false;



                ClearGridview();



                grdKeyValuePairs.DataSource = currentConfig.FileConfiguration;
                grdKeyValuePairs.AllowUserToAddRows = true;

            }
            else
            {
                btnAddFilename.Enabled = true;
            }
        }

        private void btnSaveConfig_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(cbFilenames.Text))
                {
                    MessageBox.Show("Please enter a file name or select one of the file names from the Filename list");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtIpAddress.Text))
                {
                    MessageBox.Show("Please enter a valid IP address");
                    return;
                }
                if (!int.TryParse(txtPort.Text, out int portNumber) && portNumber > 0 && portNumber <= 65635)
                {
                    MessageBox.Show("please insert a valid port number");
                }
                else
                {
                    LableFileConfiguration config = new LableFileConfiguration();
                    config.TxbFileName = cbFilenames.Text;
                    CurrentConfiguration.IpAddress = txtIpAddress.Text;
                    CurrentConfiguration.PortNumber = portNumber;
                    for (int i = 0; i < grdKeyValuePairs.Rows.Count - 1; i++)
                    {
                        config.AddConfiguration(grdKeyValuePairs.Rows[i].Cells[0].Value?.ToString(), grdKeyValuePairs.Rows[i].Cells[1].Value?.ToString());
                    }

                    CurrentConfiguration.AddFileConfiguration(config);
                }

                string currentConfigSettings = JsonConvert.SerializeObject(CurrentConfiguration);

                File.WriteAllText(ConfigFileName, currentConfigSettings);

                if (!ComboBoxFileNames.Contains(cbFilenames.Text))
                {
                    ComboBoxFileNames.Add(cbFilenames.Text);
                    cbFilenames.Refresh();
                }

                MessageBox.Show("Saved Successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtIpAddress.Text))
                {
                    MessageBox.Show("Please enter valid IP address and port number");
                    return;
                }
                if (!int.TryParse(txtPort.Text, out int portNumber) && !(portNumber > 0 && portNumber <= 65365))
                {
                    MessageBox.Show("Please enter a valid port number");
                    return;
                }
                else
                {
                   
                    var currentObject = CurrentConfiguration.LabelFileCollection.Where(x => x.TxbFileName == cbFilenames.Text).FirstOrDefault();
                    if (currentObject == null)
                    {
                        MessageBox.Show("Please select a valid data set to send to the printer");
                        return;
                    }
                    else
                    {
                        SendMessageToPrinter(PrintMessageConstructor.GetMessageForFileNameToPrinter(currentObject.TxbFileName),portNumber);

                        SendMessageToPrinter(PrintMessageConstructor.GetMessageForKeyValuePairs(currentObject.FileConfiguration.ToList()),portNumber);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SendMessageToPrinter(string message,int portNumber)
        {
            if (client != null)
            {
                client.Close();
            }
            client = new TcpClient(txtIpAddress.Text, portNumber);
            NetworkStream stream = client.GetStream();

            byte[] dataFilename = Encoding.ASCII.GetBytes(message);

            stream.Write(dataFilename, 0, dataFilename.Length);
            txtMessageLog.AppendText(message + Environment.NewLine);

            stream.Close();
            stream.Dispose();

        }

        private void btnSendCommand_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIpAddress.Text))
            {
                MessageBox.Show("Please enter valid IP address and port number");
                return;
            }
            if (!int.TryParse(txtPort.Text, out int portNumber) && !(portNumber > 0 && portNumber <= 65365))
            {
                MessageBox.Show("Please enter a valid port number");
                return;
            }
            if (string.IsNullOrWhiteSpace(txtMessageContent.Text))
            {
                MessageBox.Show("Please enter valid command");
            }
            SendMessageToPrinter(txtMessageContent.Text, portNumber);
        }
    }
}
