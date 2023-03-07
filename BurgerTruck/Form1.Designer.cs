namespace BurgerTruck
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
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.additionLabel = new System.Windows.Forms.Label();
            this.avocadoCheckBox = new System.Windows.Forms.CheckBox();
            this.baconCheckBox = new System.Windows.Forms.CheckBox();
            this.friedEggCheckBox = new System.Windows.Forms.CheckBox();
            this.cheeseCheckBox = new System.Windows.Forms.CheckBox();
            this.wellDoneChoiceButton = new System.Windows.Forms.RadioButton();
            this.mediumChoiceButton = new System.Windows.Forms.RadioButton();
            this.rareChoiceButton = new System.Windows.Forms.RadioButton();
            this.friesGroupBox = new System.Windows.Forms.GroupBox();
            this.friesNoButton = new System.Windows.Forms.RadioButton();
            this.friesYesButton = new System.Windows.Forms.RadioButton();
            this.paymentGroupBox = new System.Windows.Forms.GroupBox();
            this.creditPaymentButton = new System.Windows.Forms.RadioButton();
            this.cashPaymentButton = new System.Windows.Forms.RadioButton();
            this.totalButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.totalOutputLabel = new System.Windows.Forms.Label();
            this.optionsGroupBox.SuspendLayout();
            this.friesGroupBox.SuspendLayout();
            this.paymentGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.optionsGroupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.optionsGroupBox.Controls.Add(this.additionLabel);
            this.optionsGroupBox.Controls.Add(this.avocadoCheckBox);
            this.optionsGroupBox.Controls.Add(this.baconCheckBox);
            this.optionsGroupBox.Controls.Add(this.friedEggCheckBox);
            this.optionsGroupBox.Controls.Add(this.cheeseCheckBox);
            this.optionsGroupBox.Controls.Add(this.wellDoneChoiceButton);
            this.optionsGroupBox.Controls.Add(this.mediumChoiceButton);
            this.optionsGroupBox.Controls.Add(this.rareChoiceButton);
            this.optionsGroupBox.Location = new System.Drawing.Point(91, 53);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(328, 185);
            this.optionsGroupBox.TabIndex = 0;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Order Options";
            // 
            // additionLabel
            // 
            this.additionLabel.AutoSize = true;
            this.additionLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.additionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.additionLabel.Location = new System.Drawing.Point(93, 133);
            this.additionLabel.Name = "additionLabel";
            this.additionLabel.Size = new System.Drawing.Size(0, 31);
            this.additionLabel.TabIndex = 7;
            this.additionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // avocadoCheckBox
            // 
            this.avocadoCheckBox.AutoSize = true;
            this.avocadoCheckBox.Location = new System.Drawing.Point(174, 99);
            this.avocadoCheckBox.Name = "avocadoCheckBox";
            this.avocadoCheckBox.Size = new System.Drawing.Size(104, 17);
            this.avocadoCheckBox.TabIndex = 6;
            this.avocadoCheckBox.Text = "avocado (+$.99)";
            this.avocadoCheckBox.UseVisualStyleBackColor = true;
            this.avocadoCheckBox.CheckedChanged += new System.EventHandler(this.avocadoCheckBox_CheckedChanged);
            // 
            // baconCheckBox
            // 
            this.baconCheckBox.AutoSize = true;
            this.baconCheckBox.Location = new System.Drawing.Point(19, 99);
            this.baconCheckBox.Name = "baconCheckBox";
            this.baconCheckBox.Size = new System.Drawing.Size(98, 17);
            this.baconCheckBox.TabIndex = 5;
            this.baconCheckBox.Text = "bacon (+$1.99)";
            this.baconCheckBox.UseVisualStyleBackColor = true;
            this.baconCheckBox.CheckedChanged += new System.EventHandler(this.baconCheckBox_CheckedChanged);
            // 
            // friedEggCheckBox
            // 
            this.friedEggCheckBox.AutoSize = true;
            this.friedEggCheckBox.Location = new System.Drawing.Point(174, 56);
            this.friedEggCheckBox.Name = "friedEggCheckBox";
            this.friedEggCheckBox.Size = new System.Drawing.Size(109, 17);
            this.friedEggCheckBox.TabIndex = 4;
            this.friedEggCheckBox.Text = "fried egg (+$1.99)";
            this.friedEggCheckBox.UseVisualStyleBackColor = true;
            this.friedEggCheckBox.CheckedChanged += new System.EventHandler(this.friedEggCheckBox_CheckedChanged);
            // 
            // cheeseCheckBox
            // 
            this.cheeseCheckBox.AutoSize = true;
            this.cheeseCheckBox.Location = new System.Drawing.Point(19, 56);
            this.cheeseCheckBox.Name = "cheeseCheckBox";
            this.cheeseCheckBox.Size = new System.Drawing.Size(97, 17);
            this.cheeseCheckBox.TabIndex = 3;
            this.cheeseCheckBox.Text = "cheese (+$.99)";
            this.cheeseCheckBox.UseVisualStyleBackColor = true;
            this.cheeseCheckBox.CheckedChanged += new System.EventHandler(this.cheeseCheckBox_CheckedChanged);
            // 
            // wellDoneChoiceButton
            // 
            this.wellDoneChoiceButton.AutoSize = true;
            this.wellDoneChoiceButton.Location = new System.Drawing.Point(237, 19);
            this.wellDoneChoiceButton.Name = "wellDoneChoiceButton";
            this.wellDoneChoiceButton.Size = new System.Drawing.Size(70, 17);
            this.wellDoneChoiceButton.TabIndex = 2;
            this.wellDoneChoiceButton.TabStop = true;
            this.wellDoneChoiceButton.Text = "well done";
            this.wellDoneChoiceButton.UseVisualStyleBackColor = true;
            // 
            // mediumChoiceButton
            // 
            this.mediumChoiceButton.AutoSize = true;
            this.mediumChoiceButton.Location = new System.Drawing.Point(121, 19);
            this.mediumChoiceButton.Name = "mediumChoiceButton";
            this.mediumChoiceButton.Size = new System.Drawing.Size(61, 17);
            this.mediumChoiceButton.TabIndex = 1;
            this.mediumChoiceButton.TabStop = true;
            this.mediumChoiceButton.Text = "medium";
            this.mediumChoiceButton.UseVisualStyleBackColor = true;
            // 
            // rareChoiceButton
            // 
            this.rareChoiceButton.AutoSize = true;
            this.rareChoiceButton.Location = new System.Drawing.Point(6, 19);
            this.rareChoiceButton.Name = "rareChoiceButton";
            this.rareChoiceButton.Size = new System.Drawing.Size(43, 17);
            this.rareChoiceButton.TabIndex = 0;
            this.rareChoiceButton.TabStop = true;
            this.rareChoiceButton.Text = "rare";
            this.rareChoiceButton.UseVisualStyleBackColor = true;
            // 
            // friesGroupBox
            // 
            this.friesGroupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.friesGroupBox.Controls.Add(this.friesNoButton);
            this.friesGroupBox.Controls.Add(this.friesYesButton);
            this.friesGroupBox.Location = new System.Drawing.Point(91, 253);
            this.friesGroupBox.Name = "friesGroupBox";
            this.friesGroupBox.Size = new System.Drawing.Size(328, 46);
            this.friesGroupBox.TabIndex = 1;
            this.friesGroupBox.TabStop = false;
            this.friesGroupBox.Text = "add fries?";
            // 
            // friesNoButton
            // 
            this.friesNoButton.AutoSize = true;
            this.friesNoButton.Location = new System.Drawing.Point(250, 19);
            this.friesNoButton.Name = "friesNoButton";
            this.friesNoButton.Size = new System.Drawing.Size(37, 17);
            this.friesNoButton.TabIndex = 1;
            this.friesNoButton.TabStop = true;
            this.friesNoButton.Text = "no";
            this.friesNoButton.UseVisualStyleBackColor = true;
            // 
            // friesYesButton
            // 
            this.friesYesButton.AutoSize = true;
            this.friesYesButton.Location = new System.Drawing.Point(93, 19);
            this.friesYesButton.Name = "friesYesButton";
            this.friesYesButton.Size = new System.Drawing.Size(83, 17);
            this.friesYesButton.TabIndex = 0;
            this.friesYesButton.TabStop = true;
            this.friesYesButton.Text = "yes (+$2.99)";
            this.friesYesButton.UseVisualStyleBackColor = true;
            this.friesYesButton.CheckedChanged += new System.EventHandler(this.friesYesButton_CheckedChanged);
            // 
            // paymentGroupBox
            // 
            this.paymentGroupBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.paymentGroupBox.Controls.Add(this.creditPaymentButton);
            this.paymentGroupBox.Controls.Add(this.cashPaymentButton);
            this.paymentGroupBox.Location = new System.Drawing.Point(91, 324);
            this.paymentGroupBox.Name = "paymentGroupBox";
            this.paymentGroupBox.Size = new System.Drawing.Size(328, 45);
            this.paymentGroupBox.TabIndex = 2;
            this.paymentGroupBox.TabStop = false;
            this.paymentGroupBox.Text = "payment type?";
            // 
            // creditPaymentButton
            // 
            this.creditPaymentButton.AutoSize = true;
            this.creditPaymentButton.Location = new System.Drawing.Point(250, 20);
            this.creditPaymentButton.Name = "creditPaymentButton";
            this.creditPaymentButton.Size = new System.Drawing.Size(51, 17);
            this.creditPaymentButton.TabIndex = 1;
            this.creditPaymentButton.TabStop = true;
            this.creditPaymentButton.Text = "credit";
            this.creditPaymentButton.UseVisualStyleBackColor = true;
            // 
            // cashPaymentButton
            // 
            this.cashPaymentButton.AutoSize = true;
            this.cashPaymentButton.Location = new System.Drawing.Point(93, 19);
            this.cashPaymentButton.Name = "cashPaymentButton";
            this.cashPaymentButton.Size = new System.Drawing.Size(120, 17);
            this.cashPaymentButton.TabIndex = 0;
            this.cashPaymentButton.TabStop = true;
            this.cashPaymentButton.Text = "cash (10% discount)";
            this.cashPaymentButton.UseVisualStyleBackColor = true;
            // 
            // totalButton
            // 
            this.totalButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalButton.Location = new System.Drawing.Point(91, 408);
            this.totalButton.Name = "totalButton";
            this.totalButton.Size = new System.Drawing.Size(75, 23);
            this.totalButton.TabIndex = 3;
            this.totalButton.Text = "total";
            this.totalButton.UseVisualStyleBackColor = false;
            this.totalButton.Click += new System.EventHandler(this.totalButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.clearButton.Location = new System.Drawing.Point(91, 459);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // totalOutputLabel
            // 
            this.totalOutputLabel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.totalOutputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalOutputLabel.Location = new System.Drawing.Point(212, 408);
            this.totalOutputLabel.Name = "totalOutputLabel";
            this.totalOutputLabel.Size = new System.Drawing.Size(61, 23);
            this.totalOutputLabel.TabIndex = 5;
            this.totalOutputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(510, 587);
            this.Controls.Add(this.totalOutputLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.totalButton);
            this.Controls.Add(this.paymentGroupBox);
            this.Controls.Add(this.friesGroupBox);
            this.Controls.Add(this.optionsGroupBox);
            this.Name = "Form1";
            this.Text = "BurgerTruck POS";
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            this.friesGroupBox.ResumeLayout(false);
            this.friesGroupBox.PerformLayout();
            this.paymentGroupBox.ResumeLayout(false);
            this.paymentGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.CheckBox avocadoCheckBox;
        private System.Windows.Forms.CheckBox baconCheckBox;
        private System.Windows.Forms.CheckBox friedEggCheckBox;
        private System.Windows.Forms.CheckBox cheeseCheckBox;
        private System.Windows.Forms.RadioButton wellDoneChoiceButton;
        private System.Windows.Forms.RadioButton mediumChoiceButton;
        private System.Windows.Forms.RadioButton rareChoiceButton;
        private System.Windows.Forms.GroupBox friesGroupBox;
        private System.Windows.Forms.RadioButton friesNoButton;
        private System.Windows.Forms.RadioButton friesYesButton;
        private System.Windows.Forms.GroupBox paymentGroupBox;
        private System.Windows.Forms.RadioButton creditPaymentButton;
        private System.Windows.Forms.RadioButton cashPaymentButton;
        private System.Windows.Forms.Button totalButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label totalOutputLabel;
        private System.Windows.Forms.Label additionLabel;
    }
}

