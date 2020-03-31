namespace DataToCSV
{
    partial class TablesComboBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        MySql Sql;
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ServerURLLabel = new System.Windows.Forms.Label();
            this.ServerUrlTextField = new System.Windows.Forms.TextBox();
            this.ServerPasswordTextField = new System.Windows.Forms.TextBox();
            this.ServerUserNameTextField = new System.Windows.Forms.TextBox();
            this.ServerUserName = new System.Windows.Forms.Label();
            this.ServerPassword = new System.Windows.Forms.Label();
            this.ServerConnectButton = new System.Windows.Forms.Button();
            this.ServerDatabaseLabel = new System.Windows.Forms.Label();
            this.ServerDatabaseTextField = new System.Windows.Forms.TextBox();
            this.TableNamesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ConvertToCsvButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ServerURLLabel
            // 
            this.ServerURLLabel.AutoSize = true;
            this.ServerURLLabel.Location = new System.Drawing.Point(76, 23);
            this.ServerURLLabel.Name = "ServerURLLabel";
            this.ServerURLLabel.Size = new System.Drawing.Size(96, 17);
            this.ServerURLLabel.TabIndex = 0;
            this.ServerURLLabel.Text = "SERVER URL";
            // 
            // ServerUrlTextField
            // 
            this.ServerUrlTextField.Location = new System.Drawing.Point(218, 20);
            this.ServerUrlTextField.Name = "ServerUrlTextField";
            this.ServerUrlTextField.Size = new System.Drawing.Size(256, 22);
            this.ServerUrlTextField.TabIndex = 0;
            // 
            // ServerPasswordTextField
            // 
            this.ServerPasswordTextField.Location = new System.Drawing.Point(218, 116);
            this.ServerPasswordTextField.Name = "ServerPasswordTextField";
            this.ServerPasswordTextField.Size = new System.Drawing.Size(256, 22);
            this.ServerPasswordTextField.TabIndex = 2;
            // 
            // ServerUserNameTextField
            // 
            this.ServerUserNameTextField.Location = new System.Drawing.Point(218, 66);
            this.ServerUserNameTextField.Name = "ServerUserNameTextField";
            this.ServerUserNameTextField.Size = new System.Drawing.Size(256, 22);
            this.ServerUserNameTextField.TabIndex = 1;
            // 
            // ServerUserName
            // 
            this.ServerUserName.AutoSize = true;
            this.ServerUserName.Location = new System.Drawing.Point(126, 69);
            this.ServerUserName.Name = "ServerUserName";
            this.ServerUserName.Size = new System.Drawing.Size(46, 17);
            this.ServerUserName.TabIndex = 4;
            this.ServerUserName.Text = "USER";
            // 
            // ServerPassword
            // 
            this.ServerPassword.AutoSize = true;
            this.ServerPassword.Location = new System.Drawing.Point(84, 119);
            this.ServerPassword.Name = "ServerPassword";
            this.ServerPassword.Size = new System.Drawing.Size(88, 17);
            this.ServerPassword.TabIndex = 5;
            this.ServerPassword.Text = "PASSWORD";
            // 
            // ServerConnectButton
            // 
            this.ServerConnectButton.Location = new System.Drawing.Point(284, 206);
            this.ServerConnectButton.Name = "ServerConnectButton";
            this.ServerConnectButton.Size = new System.Drawing.Size(138, 36);
            this.ServerConnectButton.TabIndex = 4;
            this.ServerConnectButton.Text = "Connect";
            this.ServerConnectButton.UseVisualStyleBackColor = true;
            this.ServerConnectButton.Click += new System.EventHandler(this.ServerConnectButton_Click);
            // 
            // ServerDatabaseLabel
            // 
            this.ServerDatabaseLabel.AutoSize = true;
            this.ServerDatabaseLabel.Location = new System.Drawing.Point(91, 166);
            this.ServerDatabaseLabel.Name = "ServerDatabaseLabel";
            this.ServerDatabaseLabel.Size = new System.Drawing.Size(81, 17);
            this.ServerDatabaseLabel.TabIndex = 7;
            this.ServerDatabaseLabel.Text = "DATABASE";
            // 
            // ServerDatabaseTextField
            // 
            this.ServerDatabaseTextField.Location = new System.Drawing.Point(218, 166);
            this.ServerDatabaseTextField.Name = "ServerDatabaseTextField";
            this.ServerDatabaseTextField.Size = new System.Drawing.Size(256, 22);
            this.ServerDatabaseTextField.TabIndex = 3;
            // 
            // TableNamesComboBox
            // 
            this.TableNamesComboBox.AllowDrop = true;
            this.TableNamesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TableNamesComboBox.Enabled = false;
            this.TableNamesComboBox.FormattingEnabled = true;
            this.TableNamesComboBox.Location = new System.Drawing.Point(218, 293);
            this.TableNamesComboBox.Name = "TableNamesComboBox";
            this.TableNamesComboBox.Size = new System.Drawing.Size(256, 24);
            this.TableNamesComboBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 296);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "PLEASE SELECT TABLE";
            // 
            // ConvertToCsvButton
            // 
            this.ConvertToCsvButton.Location = new System.Drawing.Point(284, 340);
            this.ConvertToCsvButton.Name = "ConvertToCsvButton";
            this.ConvertToCsvButton.Size = new System.Drawing.Size(138, 40);
            this.ConvertToCsvButton.TabIndex = 11;
            this.ConvertToCsvButton.Text = "CONVERT TO CSV";
            this.ConvertToCsvButton.UseVisualStyleBackColor = true;
            this.ConvertToCsvButton.Click += new System.EventHandler(this.ConvertToCsvButton_Click);
            // 
            // TablesComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 609);
            this.Controls.Add(this.ConvertToCsvButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TableNamesComboBox);
            this.Controls.Add(this.ServerDatabaseTextField);
            this.Controls.Add(this.ServerDatabaseLabel);
            this.Controls.Add(this.ServerConnectButton);
            this.Controls.Add(this.ServerPassword);
            this.Controls.Add(this.ServerUserName);
            this.Controls.Add(this.ServerUserNameTextField);
            this.Controls.Add(this.ServerPasswordTextField);
            this.Controls.Add(this.ServerUrlTextField);
            this.Controls.Add(this.ServerURLLabel);
            this.Name = "TablesComboBox";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ServerURLLabel;
        private System.Windows.Forms.TextBox ServerUrlTextField;
        private System.Windows.Forms.TextBox ServerPasswordTextField;
        private System.Windows.Forms.TextBox ServerUserNameTextField;
        private System.Windows.Forms.Label ServerUserName;
        private System.Windows.Forms.Label ServerPassword;
        private System.Windows.Forms.Button ServerConnectButton;
        private System.Windows.Forms.Label ServerDatabaseLabel;
        private System.Windows.Forms.TextBox ServerDatabaseTextField;
        private System.Windows.Forms.ComboBox TableNamesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ConvertToCsvButton;
    }
}

