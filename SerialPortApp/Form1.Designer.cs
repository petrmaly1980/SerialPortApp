namespace SerialPortApp
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.buttonOpenPort = new System.Windows.Forms.Button();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.textBoxCommand = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDisconnect = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.souborToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.version11ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonUnlockCommand = new System.Windows.Forms.Button();
            this.buttonSpDiagnosticCommand = new System.Windows.Forms.Button();
            this.buttonCalibrateCommand = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonCalibration = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonOpenTempFolder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCDcommand = new System.Windows.Forms.Button();
            this.buttonUR5H44Command = new System.Windows.Forms.Button();
            this.button0_U0359Command = new System.Windows.Forms.Button();
            this.button1_U0359Command = new System.Windows.Forms.Button();
            this.button2_U0359Command = new System.Windows.Forms.Button();
            this.button3_U0359Command = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.comboBoxPorts.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(41, 42);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(139, 28);
            this.comboBoxPorts.TabIndex = 0;
            // 
            // buttonOpenPort
            // 
            this.buttonOpenPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOpenPort.Location = new System.Drawing.Point(186, 40);
            this.buttonOpenPort.Name = "buttonOpenPort";
            this.buttonOpenPort.Size = new System.Drawing.Size(75, 29);
            this.buttonOpenPort.TabIndex = 1;
            this.buttonOpenPort.Text = "OPEN";
            this.buttonOpenPort.UseVisualStyleBackColor = true;
            this.buttonOpenPort.Click += new System.EventHandler(this.buttonOpenPort_Click);
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.textBoxOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxOutput.Location = new System.Drawing.Point(41, 153);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxOutput.Size = new System.Drawing.Size(544, 226);
            this.textBoxOutput.TabIndex = 2;
            // 
            // textBoxCommand
            // 
            this.textBoxCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxCommand.Location = new System.Drawing.Point(41, 78);
            this.textBoxCommand.Name = "textBoxCommand";
            this.textBoxCommand.Size = new System.Drawing.Size(527, 26);
            this.textBoxCommand.TabIndex = 3;
            this.textBoxCommand.Text = "*SP";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(591, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Send Command";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "List of active ports";
            // 
            // buttonDisconnect
            // 
            this.buttonDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDisconnect.Location = new System.Drawing.Point(267, 40);
            this.buttonDisconnect.Name = "buttonDisconnect";
            this.buttonDisconnect.Size = new System.Drawing.Size(75, 29);
            this.buttonDisconnect.TabIndex = 6;
            this.buttonDisconnect.Text = "CLOSE";
            this.buttonDisconnect.UseVisualStyleBackColor = true;
            this.buttonDisconnect.Click += new System.EventHandler(this.buttonDisconnect_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(591, 40);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(201, 29);
            this.button3.TabIndex = 7;
            this.button3.Text = "Device Manager";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.buttonOpenDeviceManager_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(41, 119);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 28);
            this.button2.TabIndex = 9;
            this.button2.Text = "Clear Output Button";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.clearOutputButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.souborToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1160, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // souborToolStripMenuItem
            // 
            this.souborToolStripMenuItem.Name = "souborToolStripMenuItem";
            this.souborToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.souborToolStripMenuItem.Text = "Soubor";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.version11ToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // version11ToolStripMenuItem
            // 
            this.version11ToolStripMenuItem.Name = "version11ToolStripMenuItem";
            this.version11ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.version11ToolStripMenuItem.Text = "Version 1.1";
            // 
            // buttonUnlockCommand
            // 
            this.buttonUnlockCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUnlockCommand.Location = new System.Drawing.Point(591, 193);
            this.buttonUnlockCommand.Name = "buttonUnlockCommand";
            this.buttonUnlockCommand.Size = new System.Drawing.Size(201, 29);
            this.buttonUnlockCommand.TabIndex = 11;
            this.buttonUnlockCommand.Text = "Send Unlock Command *UC89C7";
            this.buttonUnlockCommand.UseVisualStyleBackColor = true;
            this.buttonUnlockCommand.Click += new System.EventHandler(this.buttonUnlockCommand_Click);
            // 
            // buttonSpDiagnosticCommand
            // 
            this.buttonSpDiagnosticCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSpDiagnosticCommand.Location = new System.Drawing.Point(591, 157);
            this.buttonSpDiagnosticCommand.Name = "buttonSpDiagnosticCommand";
            this.buttonSpDiagnosticCommand.Size = new System.Drawing.Size(201, 30);
            this.buttonSpDiagnosticCommand.TabIndex = 11;
            this.buttonSpDiagnosticCommand.Text = "Send SP Diagnostic Command *SP";
            this.buttonSpDiagnosticCommand.UseVisualStyleBackColor = true;
            this.buttonSpDiagnosticCommand.Click += new System.EventHandler(this.buttonSPdiagnostic_Click);
            // 
            // buttonCalibrateCommand
            // 
            this.buttonCalibrateCommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCalibrateCommand.Location = new System.Drawing.Point(591, 228);
            this.buttonCalibrateCommand.Name = "buttonCalibrateCommand";
            this.buttonCalibrateCommand.Size = new System.Drawing.Size(201, 30);
            this.buttonCalibrateCommand.TabIndex = 12;
            this.buttonCalibrateCommand.Text = "Send Calibrate Command *CR";
            this.buttonCalibrateCommand.UseVisualStyleBackColor = true;
            this.buttonCalibrateCommand.Click += new System.EventHandler(this.buttonCalibrateCommand_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "<-";
            // 
            // buttonCalibration
            // 
            this.buttonCalibration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCalibration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonCalibration.Location = new System.Drawing.Point(367, 40);
            this.buttonCalibration.Name = "buttonCalibration";
            this.buttonCalibration.Size = new System.Drawing.Size(201, 29);
            this.buttonCalibration.TabIndex = 14;
            this.buttonCalibration.Text = "Open Calibration Procedure PDF";
            this.buttonCalibration.UseVisualStyleBackColor = true;
            this.buttonCalibration.Click += new System.EventHandler(this.buttonCalibration_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(222, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(363, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Output is automaticaly saved to  the same C:\\temp";
            // 
            // buttonOpenTempFolder
            // 
            this.buttonOpenTempFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonOpenTempFolder.Location = new System.Drawing.Point(591, 119);
            this.buttonOpenTempFolder.Name = "buttonOpenTempFolder";
            this.buttonOpenTempFolder.Size = new System.Drawing.Size(112, 32);
            this.buttonOpenTempFolder.TabIndex = 16;
            this.buttonOpenTempFolder.Text = "OpenTempFolder";
            this.buttonOpenTempFolder.UseVisualStyleBackColor = true;
            this.buttonOpenTempFolder.Click += new System.EventHandler(this.buttonOpenTempFolder_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(41, 385);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1068, 150);
            this.dataGridView1.TabIndex = 17;
            // 
            // buttonCDcommand
            // 
            this.buttonCDcommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonCDcommand.Location = new System.Drawing.Point(591, 264);
            this.buttonCDcommand.Name = "buttonCDcommand";
            this.buttonCDcommand.Size = new System.Drawing.Size(201, 34);
            this.buttonCDcommand.TabIndex = 18;
            this.buttonCDcommand.Text = "Send Command *CD";
            this.buttonCDcommand.UseVisualStyleBackColor = true;
            this.buttonCDcommand.Click += new System.EventHandler(this.buttonCDcommand_Click);
            // 
            // buttonUR5H44Command
            // 
            this.buttonUR5H44Command.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUR5H44Command.Location = new System.Drawing.Point(591, 304);
            this.buttonUR5H44Command.Name = "buttonUR5H44Command";
            this.buttonUR5H44Command.Size = new System.Drawing.Size(201, 37);
            this.buttonUR5H44Command.TabIndex = 19;
            this.buttonUR5H44Command.Text = "Send *UR5H44";
            this.buttonUR5H44Command.UseVisualStyleBackColor = true;
            this.buttonUR5H44Command.Click += new System.EventHandler(this.buttonUR5H44Command_Click);
            // 
            // button0_U0359Command
            // 
            this.button0_U0359Command.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button0_U0359Command.Location = new System.Drawing.Point(591, 347);
            this.button0_U0359Command.Name = "button0_U0359Command";
            this.button0_U0359Command.Size = new System.Drawing.Size(125, 32);
            this.button0_U0359Command.TabIndex = 20;
            this.button0_U0359Command.Text = "Send 0*U0359";
            this.button0_U0359Command.UseVisualStyleBackColor = true;
            this.button0_U0359Command.Click += new System.EventHandler(this.button0_U0359Command_Click);
            // 
            // button1_U0359Command
            // 
            this.button1_U0359Command.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1_U0359Command.Location = new System.Drawing.Point(722, 347);
            this.button1_U0359Command.Name = "button1_U0359Command";
            this.button1_U0359Command.Size = new System.Drawing.Size(125, 32);
            this.button1_U0359Command.TabIndex = 20;
            this.button1_U0359Command.Text = "Send 1*U0359";
            this.button1_U0359Command.UseVisualStyleBackColor = true;
            this.button1_U0359Command.Click += new System.EventHandler(this.button1_U0359Command_Click);
            // 
            // button2_U0359Command
            // 
            this.button2_U0359Command.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2_U0359Command.Location = new System.Drawing.Point(853, 347);
            this.button2_U0359Command.Name = "button2_U0359Command";
            this.button2_U0359Command.Size = new System.Drawing.Size(125, 32);
            this.button2_U0359Command.TabIndex = 20;
            this.button2_U0359Command.Text = "Send 2*U0359";
            this.button2_U0359Command.UseVisualStyleBackColor = true;
            this.button2_U0359Command.Click += new System.EventHandler(this.button2_U0359Command_Click);
            // 
            // button3_U0359Command
            // 
            this.button3_U0359Command.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3_U0359Command.Location = new System.Drawing.Point(984, 347);
            this.button3_U0359Command.Name = "button3_U0359Command";
            this.button3_U0359Command.Size = new System.Drawing.Size(125, 32);
            this.button3_U0359Command.TabIndex = 20;
            this.button3_U0359Command.Text = "Send 3*U0359";
            this.button3_U0359Command.UseVisualStyleBackColor = true;
            this.button3_U0359Command.Click += new System.EventHandler(this.button3_U0359Command_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 547);
            this.Controls.Add(this.button3_U0359Command);
            this.Controls.Add(this.button2_U0359Command);
            this.Controls.Add(this.button1_U0359Command);
            this.Controls.Add(this.button0_U0359Command);
            this.Controls.Add(this.buttonUR5H44Command);
            this.Controls.Add(this.buttonCDcommand);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonOpenTempFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonCalibration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCalibrateCommand);
            this.Controls.Add(this.buttonSpDiagnosticCommand);
            this.Controls.Add(this.buttonUnlockCommand);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonDisconnect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxCommand);
            this.Controls.Add(this.textBoxOutput);
            this.Controls.Add(this.buttonOpenPort);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "SerialPortApp";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Button buttonOpenPort;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.TextBox textBoxCommand;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDisconnect;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem souborToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem version11ToolStripMenuItem;
        private System.Windows.Forms.Button buttonUnlockCommand;
        private System.Windows.Forms.Button buttonSpDiagnosticCommand;
        private System.Windows.Forms.Button buttonCalibrateCommand;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonCalibration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonOpenTempFolder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCDcommand;
        private System.Windows.Forms.Button buttonUR5H44Command;
        private System.Windows.Forms.Button button0_U0359Command;
        private System.Windows.Forms.Button button1_U0359Command;
        private System.Windows.Forms.Button button2_U0359Command;
        private System.Windows.Forms.Button button3_U0359Command;
    }
}

