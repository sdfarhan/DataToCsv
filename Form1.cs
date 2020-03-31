using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataToCSV
{
    public partial class TablesComboBox : Form
    {
        public TablesComboBox()
        {
            InitializeComponent();
        }
        // for testing purpose
        private void test()
        {
            ServerUrlTextField.Text = "sql12.freemysqlhosting.net";
            ServerUserNameTextField.Text = "sql12330151";
            ServerPasswordTextField.Text = "HvMMvsAFvU";
            ServerDatabaseTextField.Text = "sql12330151";
        }
        private void ServerConnectButton_Click(object sender, EventArgs e)
        {
            ServerConnectButton.Enabled = false;
            string ServerUrl = ServerUrlTextField.Text;
            string ServerUser = ServerUserNameTextField.Text;
            string ServerPassword = ServerPasswordTextField.Text;
            string ServerDatabase = ServerDatabaseTextField.Text;
            try
            {
                Sql = new MySql(new MySqlCredentials(ServerUrl,ServerUser,ServerPassword,ServerDatabase));
                FillTableNamesComboBox();
            }
            catch(InvalidCredentialsException)
            {
                DisplayWarning();
            }
            ServerConnectButton.Enabled = true;
        }

        private void FillTableNamesComboBox()
        {
            List<string> TableNames = Sql.GetTables();
            TableNamesComboBox.Items.Clear();
            foreach(string name in TableNames)
            {
                TableNamesComboBox.Items.Add(name);
            }
            if(TableNames.Count > 0)
            {
                this.TableNamesComboBox.Enabled = true;
                this.TableNamesComboBox.Text = TableNames[0];
            }
        }
        private void ConvertToCsvButton_Click(object sender, EventArgs e)
        {
            if (TableNamesComboBox.Enabled)
            {
                ConvertToCsvButton.Enabled = false;
                //List<string> ColumnNames = Sql.GetColumns(TableNamesComboBox.Text);
                List<List<string>> Data = Sql.GetData(TableNamesComboBox.Text);
                CreateCsvFile NewFile = new CreateCsvFile(Data,TableNamesComboBox.Text);
                ShowFileCreatedMessage();
                ConvertToCsvButton.Enabled = true;
            }
        }
        private void ShowFileCreatedMessage()
        {
            SuccessMessageLabel.Text = "Your File Created";
            var t = new Timer();
            t.Interval = 3000; // it will Tick in 3 seconds
            t.Start();
            t.Tick += (s, en) =>
            {
                SuccessMessageLabel.Text = "";
                t.Stop();
            };
        }
        private void DisplayWarning()
        {
            ConnectionErrorLabel.Text = "Something went wrong, Try again!";
            var t = new Timer();
            t.Interval = 3000; // it will Tick in 3 seconds
            t.Start();
            t.Tick += (s, en) =>
            {
                ConnectionErrorLabel.Text = "";
                t.Stop();
            };
        }
    }
}
