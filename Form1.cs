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
            test();
        }
        private void test()
        {
            ServerUrlTextField.Text = "localhost";
            ServerUserNameTextField.Text = "root";
            ServerPasswordTextField.Text = "953624187";
            ServerDatabaseTextField.Text = "world";
        }
        private void ServerConnectButton_Click(object sender, EventArgs e)
        {
            string ServerUrl = ServerUrlTextField.Text;
            string ServerUser = ServerUserNameTextField.Text;
            string ServerPassword = ServerPasswordTextField.Text;
            string ServerDatabase = ServerDatabaseTextField.Text;
            Sql = new MySql(new MySqlCredentials(ServerUrl,ServerUser,ServerPassword,ServerDatabase));
            FillTableNamesComboBox();
        }
        private void FillTableNamesComboBox()
        {
            List<string> TableNames = Sql.GetTables();
            TableNamesComboBox.Items.Clear();
            foreach(string name in TableNames)
            {
                TableNamesComboBox.Items.Add(name);
            }
            if(TableNames.Count > 1)
            {
                this.TableNamesComboBox.Enabled = true;
                this.TableNamesComboBox.Text = TableNames[0];
            }
        }
        private void ConvertToCsvButton_Click(object sender, EventArgs e)
        {
            if (TableNamesComboBox.Enabled)
            {
                List<string> ColumnNames = Sql.GetColumns(TableNamesComboBox.Text);
                List<List<string>> Data = Sql.GetData(TableNamesComboBox.Text);
                CreateCsvFile NewFile = new CreateCsvFile(Data);
            }
        }
    }
}
