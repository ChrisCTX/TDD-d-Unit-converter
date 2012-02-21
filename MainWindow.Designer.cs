namespace UnitConverter
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.MetToImpRB = new System.Windows.Forms.RadioButton();
            this.ImpToMetRB = new System.Windows.Forms.RadioButton();
            this.fromComboBox = new System.Windows.Forms.ComboBox();
            this.toComboBox = new System.Windows.Forms.ComboBox();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MassButton = new System.Windows.Forms.RadioButton();
            this.LengthButton = new System.Windows.Forms.RadioButton();
            this.VolumeButton = new System.Windows.Forms.RadioButton();
            this.resultBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MetToImpRB
            // 
            this.MetToImpRB.AutoSize = true;
            this.MetToImpRB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetToImpRB.Location = new System.Drawing.Point(65, 19);
            this.MetToImpRB.Name = "MetToImpRB";
            this.MetToImpRB.Size = new System.Drawing.Size(145, 22);
            this.MetToImpRB.TabIndex = 0;
            this.MetToImpRB.TabStop = true;
            this.MetToImpRB.Text = "Metric to Imperial";
            this.MetToImpRB.UseVisualStyleBackColor = true;
            this.MetToImpRB.CheckedChanged += new System.EventHandler(this.MetricToImperialChecked);
            // 
            // ImpToMetRB
            // 
            this.ImpToMetRB.AutoSize = true;
            this.ImpToMetRB.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImpToMetRB.Location = new System.Drawing.Point(225, 19);
            this.ImpToMetRB.Name = "ImpToMetRB";
            this.ImpToMetRB.Size = new System.Drawing.Size(145, 22);
            this.ImpToMetRB.TabIndex = 1;
            this.ImpToMetRB.TabStop = true;
            this.ImpToMetRB.Text = "Imperial to Metric";
            this.ImpToMetRB.UseVisualStyleBackColor = true;
            this.ImpToMetRB.CheckedChanged += new System.EventHandler(this.ImperialToMetricChecked);
            // 
            // fromComboBox
            // 
            this.fromComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fromComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromComboBox.FormattingEnabled = true;
            this.fromComboBox.Items.AddRange(new object[] {
            "Kilometers",
            "Meters",
            "Centimeters",
            "Milimeters"});
            this.fromComboBox.Location = new System.Drawing.Point(153, 154);
            this.fromComboBox.Name = "fromComboBox";
            this.fromComboBox.Size = new System.Drawing.Size(121, 26);
            this.fromComboBox.TabIndex = 2;
            this.fromComboBox.Tag = "";
            this.fromComboBox.SelectedIndexChanged += new System.EventHandler(this.fromComboBoxChanged);
            // 
            // toComboBox
            // 
            this.toComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toComboBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toComboBox.FormattingEnabled = true;
            this.toComboBox.Items.AddRange(new object[] {
            "Miles",
            "Feet",
            "Inches"});
            this.toComboBox.Location = new System.Drawing.Point(291, 154);
            this.toComboBox.Name = "toComboBox";
            this.toComboBox.Size = new System.Drawing.Size(121, 26);
            this.toComboBox.TabIndex = 3;
            this.toComboBox.SelectedIndexChanged += new System.EventHandler(this.toComboBoxChanged);
            // 
            // inputTextBox
            // 
            this.inputTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputTextBox.Location = new System.Drawing.Point(153, 94);
            this.inputTextBox.MaxLength = 11;
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(109, 26);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.TextChanged += new System.EventHandler(this.inputTextBox_TextChanged);
            this.inputTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "To:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(150, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "From:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(150, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Quantity:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.MassButton);
            this.groupBox1.Controls.Add(this.LengthButton);
            this.groupBox1.Controls.Add(this.VolumeButton);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 178);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categories";
            // 
            // MassButton
            // 
            this.MassButton.AutoSize = true;
            this.MassButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MassButton.Location = new System.Drawing.Point(13, 67);
            this.MassButton.Name = "MassButton";
            this.MassButton.Size = new System.Drawing.Size(64, 22);
            this.MassButton.TabIndex = 13;
            this.MassButton.TabStop = true;
            this.MassButton.Text = "Mass";
            this.MassButton.UseVisualStyleBackColor = true;
            this.MassButton.CheckedChanged += new System.EventHandler(this.MassChecked);
            // 
            // LengthButton
            // 
            this.LengthButton.AutoSize = true;
            this.LengthButton.Checked = true;
            this.LengthButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LengthButton.Location = new System.Drawing.Point(13, 42);
            this.LengthButton.Name = "LengthButton";
            this.LengthButton.Size = new System.Drawing.Size(73, 22);
            this.LengthButton.TabIndex = 10;
            this.LengthButton.TabStop = true;
            this.LengthButton.Text = "Length";
            this.LengthButton.UseVisualStyleBackColor = true;
            this.LengthButton.CheckedChanged += new System.EventHandler(this.LengthChecked);
            // 
            // VolumeButton
            // 
            this.VolumeButton.AutoSize = true;
            this.VolumeButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VolumeButton.Location = new System.Drawing.Point(13, 93);
            this.VolumeButton.Name = "VolumeButton";
            this.VolumeButton.Size = new System.Drawing.Size(78, 22);
            this.VolumeButton.TabIndex = 12;
            this.VolumeButton.TabStop = true;
            this.VolumeButton.Text = "Volume";
            this.VolumeButton.UseVisualStyleBackColor = true;
            this.VolumeButton.CheckedChanged += new System.EventHandler(this.VolumeChecked);
            // 
            // resultBox
            // 
            this.resultBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resultBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultBox.Location = new System.Drawing.Point(168, 199);
            this.resultBox.Name = "resultBox";
            this.resultBox.ReadOnly = true;
            this.resultBox.Size = new System.Drawing.Size(202, 26);
            this.resultBox.TabIndex = 11;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 275);
            this.Controls.Add(this.resultBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.toComboBox);
            this.Controls.Add(this.fromComboBox);
            this.Controls.Add(this.ImpToMetRB);
            this.Controls.Add(this.MetToImpRB);
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Unit Converter";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton MetToImpRB;
        private System.Windows.Forms.RadioButton ImpToMetRB;
        private System.Windows.Forms.ComboBox fromComboBox;
        private System.Windows.Forms.ComboBox toComboBox;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton MassButton;
        private System.Windows.Forms.RadioButton LengthButton;
        private System.Windows.Forms.RadioButton VolumeButton;
        private System.Windows.Forms.TextBox resultBox;


    }
}

