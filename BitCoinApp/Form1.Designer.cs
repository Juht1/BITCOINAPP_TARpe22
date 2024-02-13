namespace BitCoinApp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CurrencyCombo = new System.Windows.Forms.ComboBox();
            this.btnGetRates = new System.Windows.Forms.Button();
            this.AmountOfCoinBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultlabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CurrencyCombo
            // 
            this.CurrencyCombo.FormattingEnabled = true;
            this.CurrencyCombo.Items.AddRange(new object[] {
            "EUR",
            "USD"});
            this.CurrencyCombo.Location = new System.Drawing.Point(87, 61);
            this.CurrencyCombo.Name = "CurrencyCombo";
            this.CurrencyCombo.Size = new System.Drawing.Size(121, 21);
            this.CurrencyCombo.TabIndex = 2;
            this.CurrencyCombo.Text = "Select Currency";
            // 
            // btnGetRates
            // 
            this.btnGetRates.Location = new System.Drawing.Point(250, 61);
            this.btnGetRates.Name = "btnGetRates";
            this.btnGetRates.Size = new System.Drawing.Size(75, 23);
            this.btnGetRates.TabIndex = 3;
            this.btnGetRates.Text = "Get Rates";
            this.btnGetRates.UseVisualStyleBackColor = true;
            // 
            // AmountOfCoinBox
            // 
            this.AmountOfCoinBox.Location = new System.Drawing.Point(87, 134);
            this.AmountOfCoinBox.Name = "AmountOfCoinBox";
            this.AmountOfCoinBox.Size = new System.Drawing.Size(100, 20);
            this.AmountOfCoinBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(84, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Amounto of Bitcoins";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // resultlabel
            // 
            this.resultlabel.AutoSize = true;
            this.resultlabel.BackColor = System.Drawing.Color.Transparent;
            this.resultlabel.ForeColor = System.Drawing.SystemColors.Control;
            this.resultlabel.Location = new System.Drawing.Point(84, 233);
            this.resultlabel.Name = "resultlabel";
            this.resultlabel.Size = new System.Drawing.Size(37, 13);
            this.resultlabel.TabIndex = 6;
            this.resultlabel.Text = "Result";
            this.resultlabel.Visible = false;
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(87, 249);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(100, 20);
            this.resultTextBox.TabIndex = 7;
            this.resultTextBox.UseWaitCursor = true;
            this.resultTextBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.resultlabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AmountOfCoinBox);
            this.Controls.Add(this.btnGetRates);
            this.Controls.Add(this.CurrencyCombo);
            this.Name = "Form1";
            this.Text = "BitCoin Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CurrencyCombo;
        private System.Windows.Forms.Button btnGetRates;
        private System.Windows.Forms.TextBox AmountOfCoinBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultlabel;
        private System.Windows.Forms.TextBox resultTextBox;
    }
}

