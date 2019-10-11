namespace CashRegisterSummative
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
            this.pandoraLabel = new System.Windows.Forms.Label();
            this.ringInput = new System.Windows.Forms.TextBox();
            this.charmInput = new System.Windows.Forms.TextBox();
            this.braceletInput = new System.Windows.Forms.TextBox();
            this.ringLabel = new System.Windows.Forms.Label();
            this.charmLabel = new System.Windows.Forms.Label();
            this.braceletLabel = new System.Windows.Forms.Label();
            this.calculateTotals = new System.Windows.Forms.Button();
            this.totalcostLabel = new System.Windows.Forms.Label();
            this.subLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.lineLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.change_Label = new System.Windows.Forms.Label();
            this.receieptButton = new System.Windows.Forms.Button();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxesOutput = new System.Windows.Forms.Label();
            this.totalcostOutput = new System.Windows.Forms.Label();
            this.changeOuput = new System.Windows.Forms.Label();
            this.tryLabel = new System.Windows.Forms.Label();
            this.new_orderButton = new System.Windows.Forms.Button();
            this.leftLabel = new System.Windows.Forms.Label();
            this.tryLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pandoraLabel
            // 
            this.pandoraLabel.BackColor = System.Drawing.Color.Pink;
            this.pandoraLabel.Font = new System.Drawing.Font("Optima Demi", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pandoraLabel.Location = new System.Drawing.Point(-89, -3);
            this.pandoraLabel.Name = "pandoraLabel";
            this.pandoraLabel.Size = new System.Drawing.Size(806, 57);
            this.pandoraLabel.TabIndex = 0;
            this.pandoraLabel.Text = "                             PANDORA";
            // 
            // ringInput
            // 
            this.ringInput.Location = new System.Drawing.Point(109, 76);
            this.ringInput.Name = "ringInput";
            this.ringInput.Size = new System.Drawing.Size(54, 20);
            this.ringInput.TabIndex = 2;
            // 
            // charmInput
            // 
            this.charmInput.Location = new System.Drawing.Point(109, 105);
            this.charmInput.Name = "charmInput";
            this.charmInput.Size = new System.Drawing.Size(54, 20);
            this.charmInput.TabIndex = 3;
            // 
            // braceletInput
            // 
            this.braceletInput.Location = new System.Drawing.Point(109, 134);
            this.braceletInput.Name = "braceletInput";
            this.braceletInput.Size = new System.Drawing.Size(54, 20);
            this.braceletInput.TabIndex = 4;
            // 
            // ringLabel
            // 
            this.ringLabel.AutoSize = true;
            this.ringLabel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ringLabel.Font = new System.Drawing.Font("Optima Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ringLabel.Location = new System.Drawing.Point(39, 75);
            this.ringLabel.Name = "ringLabel";
            this.ringLabel.Size = new System.Drawing.Size(47, 19);
            this.ringLabel.TabIndex = 5;
            this.ringLabel.Text = "Rings";
            // 
            // charmLabel
            // 
            this.charmLabel.AutoSize = true;
            this.charmLabel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.charmLabel.Font = new System.Drawing.Font("Optima Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charmLabel.Location = new System.Drawing.Point(30, 104);
            this.charmLabel.Name = "charmLabel";
            this.charmLabel.Size = new System.Drawing.Size(64, 19);
            this.charmLabel.TabIndex = 6;
            this.charmLabel.Text = "Charms";
            // 
            // braceletLabel
            // 
            this.braceletLabel.AutoSize = true;
            this.braceletLabel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.braceletLabel.Font = new System.Drawing.Font("Optima Demi", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.braceletLabel.Location = new System.Drawing.Point(30, 133);
            this.braceletLabel.Name = "braceletLabel";
            this.braceletLabel.Size = new System.Drawing.Size(74, 19);
            this.braceletLabel.TabIndex = 7;
            this.braceletLabel.Text = "Bracelets";
            // 
            // calculateTotals
            // 
            this.calculateTotals.BackColor = System.Drawing.Color.Pink;
            this.calculateTotals.Font = new System.Drawing.Font("Optima Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateTotals.Location = new System.Drawing.Point(52, 160);
            this.calculateTotals.Name = "calculateTotals";
            this.calculateTotals.Size = new System.Drawing.Size(158, 31);
            this.calculateTotals.TabIndex = 8;
            this.calculateTotals.Text = "Calculate Totals!";
            this.calculateTotals.UseVisualStyleBackColor = false;
            this.calculateTotals.Click += new System.EventHandler(this.calculateTotals_Click);
            // 
            // totalcostLabel
            // 
            this.totalcostLabel.AutoSize = true;
            this.totalcostLabel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.totalcostLabel.Font = new System.Drawing.Font("Optima Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalcostLabel.Location = new System.Drawing.Point(30, 275);
            this.totalcostLabel.Name = "totalcostLabel";
            this.totalcostLabel.Size = new System.Drawing.Size(44, 19);
            this.totalcostLabel.TabIndex = 10;
            this.totalcostLabel.Text = "Total";
            // 
            // subLabel
            // 
            this.subLabel.AutoSize = true;
            this.subLabel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.subLabel.Font = new System.Drawing.Font("Optima Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subLabel.Location = new System.Drawing.Point(19, 209);
            this.subLabel.Name = "subLabel";
            this.subLabel.Size = new System.Drawing.Size(78, 19);
            this.subLabel.TabIndex = 11;
            this.subLabel.Text = "Sub-Total";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.taxLabel.Font = new System.Drawing.Font("Optima Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(30, 240);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(34, 19);
            this.taxLabel.TabIndex = 12;
            this.taxLabel.Text = "Tax";
            // 
            // lineLabel
            // 
            this.lineLabel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lineLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineLabel.Location = new System.Drawing.Point(20, 307);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(216, 10);
            this.lineLabel.TabIndex = 16;
            this.lineLabel.Text = "_______________________________";
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tenderedLabel.Font = new System.Drawing.Font("Optima Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(19, 326);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(78, 19);
            this.tenderedLabel.TabIndex = 18;
            this.tenderedLabel.Text = "Tendered";
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(109, 327);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(54, 20);
            this.tenderedInput.TabIndex = 19;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Pink;
            this.changeButton.Font = new System.Drawing.Font("Optima Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.ForeColor = System.Drawing.Color.Black;
            this.changeButton.Location = new System.Drawing.Point(52, 368);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(158, 29);
            this.changeButton.TabIndex = 20;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // change_Label
            // 
            this.change_Label.AutoSize = true;
            this.change_Label.BackColor = System.Drawing.Color.AntiqueWhite;
            this.change_Label.Font = new System.Drawing.Font("Optima Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.change_Label.Location = new System.Drawing.Point(19, 406);
            this.change_Label.Name = "change_Label";
            this.change_Label.Size = new System.Drawing.Size(63, 19);
            this.change_Label.TabIndex = 21;
            this.change_Label.Text = "Change";
            // 
            // receieptButton
            // 
            this.receieptButton.BackColor = System.Drawing.Color.Pink;
            this.receieptButton.Font = new System.Drawing.Font("Optima Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receieptButton.Location = new System.Drawing.Point(52, 438);
            this.receieptButton.Name = "receieptButton";
            this.receieptButton.Size = new System.Drawing.Size(158, 29);
            this.receieptButton.TabIndex = 23;
            this.receieptButton.Text = "Print Receipt";
            this.receieptButton.UseVisualStyleBackColor = false;
            this.receieptButton.Click += new System.EventHandler(this.receieptButton_Click);
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.AutoSize = true;
            this.subtotalOutput.BackColor = System.Drawing.Color.AntiqueWhite;
            this.subtotalOutput.Font = new System.Drawing.Font("Optima Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.Location = new System.Drawing.Point(106, 209);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(44, 18);
            this.subtotalOutput.TabIndex = 24;
            this.subtotalOutput.Text = "$0.00";
            // 
            // taxesOutput
            // 
            this.taxesOutput.AutoSize = true;
            this.taxesOutput.BackColor = System.Drawing.Color.AntiqueWhite;
            this.taxesOutput.Font = new System.Drawing.Font("Optima Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxesOutput.Location = new System.Drawing.Point(106, 240);
            this.taxesOutput.Name = "taxesOutput";
            this.taxesOutput.Size = new System.Drawing.Size(44, 18);
            this.taxesOutput.TabIndex = 25;
            this.taxesOutput.Text = "$0.00";
            // 
            // totalcostOutput
            // 
            this.totalcostOutput.AutoSize = true;
            this.totalcostOutput.BackColor = System.Drawing.Color.AntiqueWhite;
            this.totalcostOutput.Font = new System.Drawing.Font("Optima Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalcostOutput.Location = new System.Drawing.Point(106, 276);
            this.totalcostOutput.Name = "totalcostOutput";
            this.totalcostOutput.Size = new System.Drawing.Size(44, 18);
            this.totalcostOutput.TabIndex = 26;
            this.totalcostOutput.Text = "$0.00";
            // 
            // changeOuput
            // 
            this.changeOuput.AutoSize = true;
            this.changeOuput.BackColor = System.Drawing.Color.AntiqueWhite;
            this.changeOuput.Font = new System.Drawing.Font("Optima Demi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOuput.Location = new System.Drawing.Point(106, 406);
            this.changeOuput.Name = "changeOuput";
            this.changeOuput.Size = new System.Drawing.Size(44, 18);
            this.changeOuput.TabIndex = 27;
            this.changeOuput.Text = "$0.00";
            // 
            // tryLabel
            // 
            this.tryLabel.AutoSize = true;
            this.tryLabel.BackColor = System.Drawing.Color.Pink;
            this.tryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryLabel.ForeColor = System.Drawing.Color.Black;
            this.tryLabel.Location = new System.Drawing.Point(106, 36);
            this.tryLabel.Name = "tryLabel";
            this.tryLabel.Size = new System.Drawing.Size(0, 13);
            this.tryLabel.TabIndex = 28;
            // 
            // new_orderButton
            // 
            this.new_orderButton.BackColor = System.Drawing.Color.Pink;
            this.new_orderButton.Font = new System.Drawing.Font("Optima Demi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.new_orderButton.Location = new System.Drawing.Point(359, 458);
            this.new_orderButton.Name = "new_orderButton";
            this.new_orderButton.Size = new System.Drawing.Size(158, 29);
            this.new_orderButton.TabIndex = 30;
            this.new_orderButton.Text = "New Order";
            this.new_orderButton.UseVisualStyleBackColor = false;
            this.new_orderButton.Click += new System.EventHandler(this.new_orderButton_Click);
            // 
            // leftLabel
            // 
            this.leftLabel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.leftLabel.Font = new System.Drawing.Font("Optima Demi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftLabel.Location = new System.Drawing.Point(12, 63);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(233, 414);
            this.leftLabel.TabIndex = 1;
            // 
            // tryLabel2
            // 
            this.tryLabel2.AutoSize = true;
            this.tryLabel2.BackColor = System.Drawing.Color.AntiqueWhite;
            this.tryLabel2.Location = new System.Drawing.Point(31, 356);
            this.tryLabel2.Name = "tryLabel2";
            this.tryLabel2.Size = new System.Drawing.Size(0, 13);
            this.tryLabel2.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(620, 499);
            this.Controls.Add(this.tryLabel2);
            this.Controls.Add(this.new_orderButton);
            this.Controls.Add(this.tryLabel);
            this.Controls.Add(this.changeOuput);
            this.Controls.Add(this.totalcostOutput);
            this.Controls.Add(this.taxesOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.receieptButton);
            this.Controls.Add(this.change_Label);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subLabel);
            this.Controls.Add(this.totalcostLabel);
            this.Controls.Add(this.calculateTotals);
            this.Controls.Add(this.braceletLabel);
            this.Controls.Add(this.charmLabel);
            this.Controls.Add(this.ringLabel);
            this.Controls.Add(this.braceletInput);
            this.Controls.Add(this.charmInput);
            this.Controls.Add(this.ringInput);
            this.Controls.Add(this.leftLabel);
            this.Controls.Add(this.pandoraLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pandoraLabel;
        private System.Windows.Forms.TextBox ringInput;
        private System.Windows.Forms.TextBox charmInput;
        private System.Windows.Forms.TextBox braceletInput;
        private System.Windows.Forms.Label ringLabel;
        private System.Windows.Forms.Label charmLabel;
        private System.Windows.Forms.Label braceletLabel;
        private System.Windows.Forms.Button calculateTotals;
        private System.Windows.Forms.Label totalcostLabel;
        private System.Windows.Forms.Label subLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label lineLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Label change_Label;
        private System.Windows.Forms.Button receieptButton;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxesOutput;
        private System.Windows.Forms.Label totalcostOutput;
        private System.Windows.Forms.Label changeOuput;
        private System.Windows.Forms.Label tryLabel;
        private System.Windows.Forms.Button new_orderButton;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label tryLabel2;
    }
}

