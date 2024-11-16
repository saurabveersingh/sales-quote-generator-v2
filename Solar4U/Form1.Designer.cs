namespace Solar4U
{
    partial class Solar4UFormApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Solar4UFormApp));
            logoImage = new PictureBox();
            selectionPanel = new Panel();
            expInstallCheckBox = new CheckBox();
            quantityLabel = new Label();
            quantityInput = new TextBox();
            sizeLabel = new Label();
            effectLabel = new Label();
            brandPriceLabel = new Label();
            brandLabel = new Label();
            batterySelection = new GroupBox();
            battery20RadioButton = new RadioButton();
            battery10RadioButton = new RadioButton();
            battery5RadioButton = new RadioButton();
            sizeList = new ListBox();
            brandList = new ListBox();
            optionsPanel = new Panel();
            exitButton = new Button();
            summaryButton = new Button();
            orderButton = new Button();
            clearButton = new Button();
            quoteButton = new Button();
            summaryPanel = new Panel();
            installationDetails = new Label();
            invertorDetails = new Label();
            batteryDetails = new Label();
            panelDetails = new Label();
            noOfDiscounts = new Label();
            netValue = new Label();
            discountValue = new Label();
            noOfDiscountsLabel = new Label();
            netValueLabel = new Label();
            discountValueLabel = new Label();
            averageValue = new Label();
            grossValue = new Label();
            installationPercentage = new Label();
            installationCostValue = new Label();
            invertorsPercentage = new Label();
            invertorsCostValue = new Label();
            batteriesPercentage = new Label();
            batteriesCostValue = new Label();
            panelsPercentage = new Label();
            panelsCostValue = new Label();
            noOfOrders = new Label();
            summaryMidLine = new Panel();
            averageValueLabel = new Label();
            grossValueLabel = new Label();
            installationSummaryLabel = new Label();
            invertorSummaryLabel = new Label();
            batterySummaryLabel = new Label();
            panelsSummaryLabel = new Label();
            noOfOrdersLabel = new Label();
            summaryLabel = new Label();
            summaryHeadingLine = new Panel();
            toolTip = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)logoImage).BeginInit();
            selectionPanel.SuspendLayout();
            batterySelection.SuspendLayout();
            optionsPanel.SuspendLayout();
            summaryPanel.SuspendLayout();
            SuspendLayout();
            // 
            // logoImage
            // 
            logoImage.Image = (Image)resources.GetObject("logoImage.Image");
            logoImage.Location = new Point(830, 149);
            logoImage.Name = "logoImage";
            logoImage.Size = new Size(200, 200);
            logoImage.SizeMode = PictureBoxSizeMode.Zoom;
            logoImage.TabIndex = 18;
            logoImage.TabStop = false;
            // 
            // selectionPanel
            // 
            selectionPanel.BackColor = Color.Maroon;
            selectionPanel.Controls.Add(expInstallCheckBox);
            selectionPanel.Controls.Add(quantityLabel);
            selectionPanel.Controls.Add(quantityInput);
            selectionPanel.Controls.Add(sizeLabel);
            selectionPanel.Controls.Add(effectLabel);
            selectionPanel.Controls.Add(brandPriceLabel);
            selectionPanel.Controls.Add(brandLabel);
            selectionPanel.Controls.Add(batterySelection);
            selectionPanel.Controls.Add(sizeList);
            selectionPanel.Controls.Add(brandList);
            selectionPanel.Controls.Add(logoImage);
            selectionPanel.Location = new Point(50, 50);
            selectionPanel.Name = "selectionPanel";
            selectionPanel.Size = new Size(1425, 400);
            selectionPanel.TabIndex = 19;
            // 
            // expInstallCheckBox
            // 
            expInstallCheckBox.AutoSize = true;
            expInstallCheckBox.Font = new Font("Segoe UI", 12F);
            expInstallCheckBox.ForeColor = Color.FromArgb(255, 255, 192);
            expInstallCheckBox.Location = new Point(1030, 270);
            expInstallCheckBox.Name = "expInstallCheckBox";
            expInstallCheckBox.Size = new Size(383, 49);
            expInstallCheckBox.TabIndex = 7;
            expInstallCheckBox.Text = "Expedited Install ($299)";
            expInstallCheckBox.UseVisualStyleBackColor = true;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            quantityLabel.ForeColor = Color.FromArgb(255, 255, 192);
            quantityLabel.Location = new Point(855, 25);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(149, 45);
            quantityLabel.TabIndex = 17;
            quantityLabel.Text = "Quantity";
            // 
            // quantityInput
            // 
            quantityInput.BackColor = Color.FromArgb(192, 64, 0);
            quantityInput.Font = new Font("Segoe UI", 12F);
            quantityInput.ForeColor = Color.FromArgb(255, 255, 192);
            quantityInput.Location = new Point(855, 75);
            quantityInput.Name = "quantityInput";
            quantityInput.Size = new Size(150, 50);
            quantityInput.TabIndex = 2;
            quantityInput.Text = "0";
            quantityInput.TextAlign = HorizontalAlignment.Center;
            // 
            // sizeLabel
            // 
            sizeLabel.AutoSize = true;
            sizeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            sizeLabel.ForeColor = Color.FromArgb(255, 255, 192);
            sizeLabel.Location = new Point(495, 25);
            sizeLabel.Name = "sizeLabel";
            sizeLabel.Size = new Size(79, 45);
            sizeLabel.TabIndex = 15;
            sizeLabel.Text = "Size";
            // 
            // effectLabel
            // 
            effectLabel.AutoSize = true;
            effectLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            effectLabel.ForeColor = Color.FromArgb(255, 255, 192);
            effectLabel.Location = new Point(680, 25);
            effectLabel.Name = "effectLabel";
            effectLabel.Size = new Size(105, 45);
            effectLabel.TabIndex = 16;
            effectLabel.Text = "Effect";
            // 
            // brandPriceLabel
            // 
            brandPriceLabel.AutoSize = true;
            brandPriceLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            brandPriceLabel.ForeColor = Color.FromArgb(255, 255, 192);
            brandPriceLabel.Location = new Point(320, 25);
            brandPriceLabel.Name = "brandPriceLabel";
            brandPriceLabel.Size = new Size(94, 45);
            brandPriceLabel.TabIndex = 14;
            brandPriceLabel.Text = "Price";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            brandLabel.ForeColor = Color.FromArgb(255, 255, 192);
            brandLabel.Location = new Point(55, 25);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new Size(110, 45);
            brandLabel.TabIndex = 13;
            brandLabel.Text = "Brand";
            // 
            // batterySelection
            // 
            batterySelection.BackColor = Color.Maroon;
            batterySelection.Controls.Add(battery20RadioButton);
            batterySelection.Controls.Add(battery10RadioButton);
            batterySelection.Controls.Add(battery5RadioButton);
            batterySelection.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            batterySelection.ForeColor = Color.FromArgb(255, 255, 192);
            batterySelection.Location = new Point(1055, 25);
            batterySelection.Name = "batterySelection";
            batterySelection.Size = new Size(310, 215);
            batterySelection.TabIndex = 3;
            batterySelection.TabStop = false;
            batterySelection.Text = "Battery";
            // 
            // battery20RadioButton
            // 
            battery20RadioButton.AutoSize = true;
            battery20RadioButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            battery20RadioButton.ForeColor = Color.FromArgb(255, 255, 192);
            battery20RadioButton.Location = new Point(32, 159);
            battery20RadioButton.Name = "battery20RadioButton";
            battery20RadioButton.Size = new Size(274, 49);
            battery20RadioButton.TabIndex = 6;
            battery20RadioButton.TabStop = true;
            battery20RadioButton.Text = "20KWh ($9,500)";
            battery20RadioButton.UseVisualStyleBackColor = true;
            // 
            // battery10RadioButton
            // 
            battery10RadioButton.AutoSize = true;
            battery10RadioButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            battery10RadioButton.ForeColor = Color.FromArgb(255, 255, 192);
            battery10RadioButton.Location = new Point(32, 104);
            battery10RadioButton.Name = "battery10RadioButton";
            battery10RadioButton.Size = new Size(274, 49);
            battery10RadioButton.TabIndex = 5;
            battery10RadioButton.TabStop = true;
            battery10RadioButton.Text = "10KWh ($7,500)";
            battery10RadioButton.UseVisualStyleBackColor = true;
            // 
            // battery5RadioButton
            // 
            battery5RadioButton.AutoSize = true;
            battery5RadioButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            battery5RadioButton.ForeColor = Color.FromArgb(255, 255, 192);
            battery5RadioButton.Location = new Point(32, 49);
            battery5RadioButton.Name = "battery5RadioButton";
            battery5RadioButton.Size = new Size(257, 49);
            battery5RadioButton.TabIndex = 4;
            battery5RadioButton.TabStop = true;
            battery5RadioButton.Text = "5KWh ($4,500)";
            battery5RadioButton.UseVisualStyleBackColor = true;
            // 
            // sizeList
            // 
            sizeList.BackColor = Color.FromArgb(192, 64, 0);
            sizeList.Font = new Font("Segoe UI", 12F);
            sizeList.ForeColor = Color.FromArgb(255, 255, 192);
            sizeList.FormattingEnabled = true;
            sizeList.ItemHeight = 45;
            sizeList.Items.AddRange(new object[] { "30 - Cell\t        -25%", "48 - Cell\t        -15%", "60 - Cell\t        0%", "72 - Cell\t        15%", "84 - Cell\t        25%", "96 - Cell\t        40%" });
            sizeList.Location = new Point(480, 75);
            sizeList.Name = "sizeList";
            sizeList.Size = new Size(325, 274);
            sizeList.TabIndex = 1;
            // 
            // brandList
            // 
            brandList.BackColor = Color.FromArgb(192, 64, 0);
            brandList.Font = new Font("Segoe UI", 12F);
            brandList.ForeColor = Color.FromArgb(255, 255, 192);
            brandList.FormattingEnabled = true;
            brandList.ItemHeight = 45;
            brandList.Items.AddRange(new object[] { "LONGi Solar\t$129.50", "JinkoSolar\t$135", "Trina Solar\t$112.79", "CanadianSolar\t$149", "Q-Cells\t\t$131", "FirstSolar\t\t$119" });
            brandList.Location = new Point(30, 75);
            brandList.Name = "brandList";
            brandList.Size = new Size(410, 274);
            brandList.TabIndex = 0;
            // 
            // optionsPanel
            // 
            optionsPanel.BackColor = Color.Maroon;
            optionsPanel.Controls.Add(exitButton);
            optionsPanel.Controls.Add(summaryButton);
            optionsPanel.Controls.Add(orderButton);
            optionsPanel.Controls.Add(clearButton);
            optionsPanel.Controls.Add(quoteButton);
            optionsPanel.Location = new Point(1100, 500);
            optionsPanel.Name = "optionsPanel";
            optionsPanel.Size = new Size(375, 625);
            optionsPanel.TabIndex = 20;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.FromArgb(192, 64, 0);
            exitButton.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            exitButton.FlatAppearance.BorderSize = 5;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            exitButton.ForeColor = Color.FromArgb(255, 255, 192);
            exitButton.Location = new Point(90, 508);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(200, 52);
            exitButton.TabIndex = 12;
            exitButton.Text = "E&xit";
            toolTip.SetToolTip(exitButton, "Press to Quit the App");
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // summaryButton
            // 
            summaryButton.BackColor = Color.FromArgb(192, 64, 0);
            summaryButton.Enabled = false;
            summaryButton.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            summaryButton.FlatAppearance.BorderSize = 5;
            summaryButton.FlatStyle = FlatStyle.Flat;
            summaryButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            summaryButton.ForeColor = Color.FromArgb(255, 255, 192);
            summaryButton.Location = new Point(90, 396);
            summaryButton.Name = "summaryButton";
            summaryButton.Size = new Size(200, 52);
            summaryButton.TabIndex = 11;
            summaryButton.Text = "&Summary";
            toolTip.SetToolTip(summaryButton, "Press to view Summary of all quotations");
            summaryButton.UseVisualStyleBackColor = false;
            summaryButton.Click += summaryButton_Click;
            // 
            // orderButton
            // 
            orderButton.BackColor = Color.FromArgb(192, 64, 0);
            orderButton.Enabled = false;
            orderButton.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            orderButton.FlatAppearance.BorderSize = 5;
            orderButton.FlatStyle = FlatStyle.Flat;
            orderButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            orderButton.ForeColor = Color.FromArgb(255, 255, 192);
            orderButton.Location = new Point(90, 284);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(200, 52);
            orderButton.TabIndex = 10;
            orderButton.Text = "&Order";
            toolTip.SetToolTip(orderButton, "Press to confirm the order");
            orderButton.UseVisualStyleBackColor = false;
            orderButton.Click += orderButton_Click;
            // 
            // clearButton
            // 
            clearButton.BackColor = Color.FromArgb(192, 64, 0);
            clearButton.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            clearButton.FlatAppearance.BorderSize = 5;
            clearButton.FlatStyle = FlatStyle.Flat;
            clearButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            clearButton.ForeColor = Color.FromArgb(255, 255, 192);
            clearButton.Location = new Point(90, 172);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(200, 52);
            clearButton.TabIndex = 9;
            clearButton.Text = "&Clear";
            toolTip.SetToolTip(clearButton, "Press to reset the form");
            clearButton.UseVisualStyleBackColor = false;
            clearButton.Click += clearButton_Click;
            // 
            // quoteButton
            // 
            quoteButton.BackColor = Color.FromArgb(192, 64, 0);
            quoteButton.FlatAppearance.BorderColor = Color.FromArgb(255, 255, 192);
            quoteButton.FlatAppearance.BorderSize = 5;
            quoteButton.FlatStyle = FlatStyle.Flat;
            quoteButton.Font = new Font("Arial", 10F, FontStyle.Bold);
            quoteButton.ForeColor = Color.FromArgb(255, 255, 192);
            quoteButton.Location = new Point(90, 60);
            quoteButton.Name = "quoteButton";
            quoteButton.Size = new Size(200, 52);
            quoteButton.TabIndex = 8;
            quoteButton.Text = "&Quote";
            toolTip.SetToolTip(quoteButton, "Press to view quotation");
            quoteButton.UseVisualStyleBackColor = false;
            quoteButton.Click += quoteButton_Click;
            // 
            // summaryPanel
            // 
            summaryPanel.BackColor = Color.Maroon;
            summaryPanel.Controls.Add(installationDetails);
            summaryPanel.Controls.Add(invertorDetails);
            summaryPanel.Controls.Add(batteryDetails);
            summaryPanel.Controls.Add(panelDetails);
            summaryPanel.Controls.Add(noOfDiscounts);
            summaryPanel.Controls.Add(netValue);
            summaryPanel.Controls.Add(discountValue);
            summaryPanel.Controls.Add(noOfDiscountsLabel);
            summaryPanel.Controls.Add(netValueLabel);
            summaryPanel.Controls.Add(discountValueLabel);
            summaryPanel.Controls.Add(averageValue);
            summaryPanel.Controls.Add(grossValue);
            summaryPanel.Controls.Add(installationPercentage);
            summaryPanel.Controls.Add(installationCostValue);
            summaryPanel.Controls.Add(invertorsPercentage);
            summaryPanel.Controls.Add(invertorsCostValue);
            summaryPanel.Controls.Add(batteriesPercentage);
            summaryPanel.Controls.Add(batteriesCostValue);
            summaryPanel.Controls.Add(panelsPercentage);
            summaryPanel.Controls.Add(panelsCostValue);
            summaryPanel.Controls.Add(noOfOrders);
            summaryPanel.Controls.Add(summaryMidLine);
            summaryPanel.Controls.Add(averageValueLabel);
            summaryPanel.Controls.Add(grossValueLabel);
            summaryPanel.Controls.Add(installationSummaryLabel);
            summaryPanel.Controls.Add(invertorSummaryLabel);
            summaryPanel.Controls.Add(batterySummaryLabel);
            summaryPanel.Controls.Add(panelsSummaryLabel);
            summaryPanel.Controls.Add(noOfOrdersLabel);
            summaryPanel.Controls.Add(summaryLabel);
            summaryPanel.Controls.Add(summaryHeadingLine);
            summaryPanel.Location = new Point(50, 500);
            summaryPanel.Name = "summaryPanel";
            summaryPanel.Size = new Size(1000, 625);
            summaryPanel.TabIndex = 21;
            summaryPanel.Visible = false;
            // 
            // installationDetails
            // 
            installationDetails.Font = new Font("Arial", 9.5F);
            installationDetails.ForeColor = Color.White;
            installationDetails.Location = new Point(250, 260);
            installationDetails.Name = "installationDetails";
            installationDetails.Padding = new Padding(0, 4, 0, 4);
            installationDetails.Size = new Size(400, 43);
            installationDetails.TabIndex = 39;
            installationDetails.Text = "Expedited Install";
            installationDetails.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // invertorDetails
            // 
            invertorDetails.Font = new Font("Arial", 9.5F);
            invertorDetails.ForeColor = Color.White;
            invertorDetails.Location = new Point(250, 205);
            invertorDetails.Name = "invertorDetails";
            invertorDetails.Padding = new Padding(0, 4, 0, 4);
            invertorDetails.Size = new Size(400, 43);
            invertorDetails.TabIndex = 35;
            invertorDetails.Text = "Regular without Battery";
            invertorDetails.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // batteryDetails
            // 
            batteryDetails.Font = new Font("Arial", 9.5F);
            batteryDetails.ForeColor = Color.White;
            batteryDetails.Location = new Point(250, 150);
            batteryDetails.Name = "batteryDetails";
            batteryDetails.Padding = new Padding(0, 4, 0, 4);
            batteryDetails.Size = new Size(400, 43);
            batteryDetails.TabIndex = 31;
            batteryDetails.Text = "5KWh";
            batteryDetails.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelDetails
            // 
            panelDetails.Font = new Font("Arial", 9.5F);
            panelDetails.ForeColor = Color.White;
            panelDetails.Location = new Point(250, 95);
            panelDetails.Name = "panelDetails";
            panelDetails.Padding = new Padding(0, 4, 0, 4);
            panelDetails.Size = new Size(400, 43);
            panelDetails.TabIndex = 27;
            panelDetails.Text = "LONGi Solar 30-Cell x1";
            panelDetails.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // noOfDiscounts
            // 
            noOfDiscounts.BackColor = Color.White;
            noOfDiscounts.BorderStyle = BorderStyle.FixedSingle;
            noOfDiscounts.ForeColor = Color.Black;
            noOfDiscounts.Location = new Point(675, 565);
            noOfDiscounts.Margin = new Padding(0);
            noOfDiscounts.Name = "noOfDiscounts";
            noOfDiscounts.Size = new Size(160, 40);
            noOfDiscounts.TabIndex = 52;
            noOfDiscounts.Text = "0";
            noOfDiscounts.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // netValue
            // 
            netValue.BackColor = Color.White;
            netValue.BorderStyle = BorderStyle.FixedSingle;
            netValue.ForeColor = Color.Black;
            netValue.Location = new Point(675, 455);
            netValue.Margin = new Padding(0);
            netValue.Name = "netValue";
            netValue.Size = new Size(160, 40);
            netValue.TabIndex = 48;
            netValue.Text = "0";
            netValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // discountValue
            // 
            discountValue.BackColor = Color.White;
            discountValue.BorderStyle = BorderStyle.FixedSingle;
            discountValue.ForeColor = Color.Black;
            discountValue.Location = new Point(675, 400);
            discountValue.Margin = new Padding(0);
            discountValue.Name = "discountValue";
            discountValue.Size = new Size(160, 40);
            discountValue.TabIndex = 46;
            discountValue.Text = "0";
            discountValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // noOfDiscountsLabel
            // 
            noOfDiscountsLabel.AutoSize = true;
            noOfDiscountsLabel.Font = new Font("Arial", 11F, FontStyle.Bold);
            noOfDiscountsLabel.ForeColor = Color.White;
            noOfDiscountsLabel.Location = new Point(40, 565);
            noOfDiscountsLabel.Name = "noOfDiscountsLabel";
            noOfDiscountsLabel.Padding = new Padding(0, 4, 0, 4);
            noOfDiscountsLabel.Size = new Size(252, 43);
            noOfDiscountsLabel.TabIndex = 51;
            noOfDiscountsLabel.Text = "No. of Discounts";
            // 
            // netValueLabel
            // 
            netValueLabel.AutoSize = true;
            netValueLabel.Font = new Font("Arial", 11F, FontStyle.Bold);
            netValueLabel.ForeColor = Color.White;
            netValueLabel.Location = new Point(40, 455);
            netValueLabel.Name = "netValueLabel";
            netValueLabel.Padding = new Padding(0, 4, 0, 4);
            netValueLabel.Size = new Size(150, 43);
            netValueLabel.TabIndex = 47;
            netValueLabel.Text = "Net Value";
            // 
            // discountValueLabel
            // 
            discountValueLabel.AutoSize = true;
            discountValueLabel.Font = new Font("Arial", 11F, FontStyle.Bold);
            discountValueLabel.ForeColor = Color.White;
            discountValueLabel.Location = new Point(40, 400);
            discountValueLabel.Name = "discountValueLabel";
            discountValueLabel.Padding = new Padding(0, 4, 0, 4);
            discountValueLabel.Size = new Size(214, 43);
            discountValueLabel.TabIndex = 45;
            discountValueLabel.Text = "Discount (3%)";
            // 
            // averageValue
            // 
            averageValue.BackColor = Color.White;
            averageValue.BorderStyle = BorderStyle.FixedSingle;
            averageValue.ForeColor = Color.Black;
            averageValue.Location = new Point(675, 510);
            averageValue.Margin = new Padding(0);
            averageValue.Name = "averageValue";
            averageValue.Size = new Size(160, 40);
            averageValue.TabIndex = 50;
            averageValue.Text = "0";
            averageValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // grossValue
            // 
            grossValue.BackColor = Color.White;
            grossValue.BorderStyle = BorderStyle.FixedSingle;
            grossValue.ForeColor = Color.Black;
            grossValue.Location = new Point(675, 345);
            grossValue.Margin = new Padding(0);
            grossValue.Name = "grossValue";
            grossValue.Size = new Size(160, 40);
            grossValue.TabIndex = 44;
            grossValue.Text = "0";
            grossValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // installationPercentage
            // 
            installationPercentage.BackColor = Color.White;
            installationPercentage.BorderStyle = BorderStyle.FixedSingle;
            installationPercentage.ForeColor = Color.Black;
            installationPercentage.Location = new Point(850, 260);
            installationPercentage.Margin = new Padding(0);
            installationPercentage.Name = "installationPercentage";
            installationPercentage.Size = new Size(100, 40);
            installationPercentage.TabIndex = 41;
            installationPercentage.Text = "0";
            installationPercentage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // installationCostValue
            // 
            installationCostValue.BackColor = Color.White;
            installationCostValue.BorderStyle = BorderStyle.FixedSingle;
            installationCostValue.ForeColor = Color.Black;
            installationCostValue.Location = new Point(675, 260);
            installationCostValue.Margin = new Padding(0);
            installationCostValue.Name = "installationCostValue";
            installationCostValue.Size = new Size(160, 40);
            installationCostValue.TabIndex = 40;
            installationCostValue.Text = "0";
            installationCostValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // invertorsPercentage
            // 
            invertorsPercentage.BackColor = Color.White;
            invertorsPercentage.BorderStyle = BorderStyle.FixedSingle;
            invertorsPercentage.ForeColor = Color.Black;
            invertorsPercentage.Location = new Point(850, 205);
            invertorsPercentage.Margin = new Padding(0);
            invertorsPercentage.Name = "invertorsPercentage";
            invertorsPercentage.Size = new Size(100, 40);
            invertorsPercentage.TabIndex = 37;
            invertorsPercentage.Text = "0";
            invertorsPercentage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // invertorsCostValue
            // 
            invertorsCostValue.BackColor = Color.White;
            invertorsCostValue.BorderStyle = BorderStyle.FixedSingle;
            invertorsCostValue.ForeColor = Color.Black;
            invertorsCostValue.Location = new Point(675, 205);
            invertorsCostValue.Margin = new Padding(0);
            invertorsCostValue.Name = "invertorsCostValue";
            invertorsCostValue.Size = new Size(160, 40);
            invertorsCostValue.TabIndex = 36;
            invertorsCostValue.Text = "0";
            invertorsCostValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // batteriesPercentage
            // 
            batteriesPercentage.BackColor = Color.White;
            batteriesPercentage.BorderStyle = BorderStyle.FixedSingle;
            batteriesPercentage.ForeColor = Color.Black;
            batteriesPercentage.Location = new Point(850, 150);
            batteriesPercentage.Margin = new Padding(0);
            batteriesPercentage.Name = "batteriesPercentage";
            batteriesPercentage.Size = new Size(100, 40);
            batteriesPercentage.TabIndex = 33;
            batteriesPercentage.Text = "0";
            batteriesPercentage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // batteriesCostValue
            // 
            batteriesCostValue.BackColor = Color.White;
            batteriesCostValue.BorderStyle = BorderStyle.FixedSingle;
            batteriesCostValue.ForeColor = Color.Black;
            batteriesCostValue.Location = new Point(675, 150);
            batteriesCostValue.Margin = new Padding(0);
            batteriesCostValue.Name = "batteriesCostValue";
            batteriesCostValue.Size = new Size(160, 40);
            batteriesCostValue.TabIndex = 32;
            batteriesCostValue.Text = "0";
            batteriesCostValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelsPercentage
            // 
            panelsPercentage.BackColor = Color.White;
            panelsPercentage.BorderStyle = BorderStyle.FixedSingle;
            panelsPercentage.ForeColor = Color.Black;
            panelsPercentage.Location = new Point(850, 95);
            panelsPercentage.Margin = new Padding(0);
            panelsPercentage.Name = "panelsPercentage";
            panelsPercentage.Size = new Size(100, 40);
            panelsPercentage.TabIndex = 29;
            panelsPercentage.Text = "0";
            panelsPercentage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelsCostValue
            // 
            panelsCostValue.BackColor = Color.White;
            panelsCostValue.BorderStyle = BorderStyle.FixedSingle;
            panelsCostValue.ForeColor = Color.Black;
            panelsCostValue.Location = new Point(675, 95);
            panelsCostValue.Margin = new Padding(0);
            panelsCostValue.Name = "panelsCostValue";
            panelsCostValue.Size = new Size(160, 40);
            panelsCostValue.TabIndex = 28;
            panelsCostValue.Text = "0";
            panelsCostValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // noOfOrders
            // 
            noOfOrders.BackColor = Color.White;
            noOfOrders.BorderStyle = BorderStyle.FixedSingle;
            noOfOrders.ForeColor = Color.Black;
            noOfOrders.Location = new Point(675, 40);
            noOfOrders.Margin = new Padding(0);
            noOfOrders.Name = "noOfOrders";
            noOfOrders.Size = new Size(160, 40);
            noOfOrders.TabIndex = 25;
            noOfOrders.Text = "0";
            noOfOrders.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // summaryMidLine
            // 
            summaryMidLine.BackColor = Color.White;
            summaryMidLine.Location = new Point(60, 320);
            summaryMidLine.Name = "summaryMidLine";
            summaryMidLine.Size = new Size(880, 5);
            summaryMidLine.TabIndex = 42;
            // 
            // averageValueLabel
            // 
            averageValueLabel.AutoSize = true;
            averageValueLabel.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            averageValueLabel.ForeColor = Color.White;
            averageValueLabel.Location = new Point(40, 510);
            averageValueLabel.Name = "averageValueLabel";
            averageValueLabel.Padding = new Padding(0, 4, 0, 4);
            averageValueLabel.Size = new Size(235, 45);
            averageValueLabel.TabIndex = 49;
            averageValueLabel.Text = "Average Value";
            // 
            // grossValueLabel
            // 
            grossValueLabel.AutoSize = true;
            grossValueLabel.Font = new Font("Arial", 11F, FontStyle.Bold);
            grossValueLabel.ForeColor = Color.White;
            grossValueLabel.Location = new Point(40, 345);
            grossValueLabel.Name = "grossValueLabel";
            grossValueLabel.Padding = new Padding(0, 4, 0, 4);
            grossValueLabel.Size = new Size(188, 43);
            grossValueLabel.TabIndex = 43;
            grossValueLabel.Text = "Gross Value";
            // 
            // installationSummaryLabel
            // 
            installationSummaryLabel.AutoSize = true;
            installationSummaryLabel.Font = new Font("Arial", 11F, FontStyle.Bold);
            installationSummaryLabel.ForeColor = Color.White;
            installationSummaryLabel.Location = new Point(40, 260);
            installationSummaryLabel.Name = "installationSummaryLabel";
            installationSummaryLabel.Padding = new Padding(0, 4, 0, 4);
            installationSummaryLabel.Size = new Size(172, 43);
            installationSummaryLabel.TabIndex = 38;
            installationSummaryLabel.Text = "Installation";
            // 
            // invertorSummaryLabel
            // 
            invertorSummaryLabel.AutoSize = true;
            invertorSummaryLabel.Font = new Font("Arial", 11F, FontStyle.Bold);
            invertorSummaryLabel.ForeColor = Color.White;
            invertorSummaryLabel.Location = new Point(40, 205);
            invertorSummaryLabel.Name = "invertorSummaryLabel";
            invertorSummaryLabel.Padding = new Padding(0, 4, 0, 4);
            invertorSummaryLabel.Size = new Size(127, 43);
            invertorSummaryLabel.TabIndex = 34;
            invertorSummaryLabel.Text = "Invertor";
            // 
            // batterySummaryLabel
            // 
            batterySummaryLabel.AutoSize = true;
            batterySummaryLabel.Font = new Font("Arial", 11F, FontStyle.Bold);
            batterySummaryLabel.ForeColor = Color.White;
            batterySummaryLabel.Location = new Point(40, 150);
            batterySummaryLabel.Name = "batterySummaryLabel";
            batterySummaryLabel.Padding = new Padding(0, 4, 0, 4);
            batterySummaryLabel.Size = new Size(118, 43);
            batterySummaryLabel.TabIndex = 30;
            batterySummaryLabel.Text = "Battery";
            // 
            // panelsSummaryLabel
            // 
            panelsSummaryLabel.AutoSize = true;
            panelsSummaryLabel.Font = new Font("Arial", 11F, FontStyle.Bold);
            panelsSummaryLabel.ForeColor = Color.White;
            panelsSummaryLabel.Location = new Point(40, 95);
            panelsSummaryLabel.Name = "panelsSummaryLabel";
            panelsSummaryLabel.Padding = new Padding(0, 4, 0, 4);
            panelsSummaryLabel.Size = new Size(195, 43);
            panelsSummaryLabel.TabIndex = 26;
            panelsSummaryLabel.Text = "Solar Panels";
            // 
            // noOfOrdersLabel
            // 
            noOfOrdersLabel.AutoSize = true;
            noOfOrdersLabel.Font = new Font("Arial", 11F, FontStyle.Bold);
            noOfOrdersLabel.ForeColor = Color.White;
            noOfOrdersLabel.Location = new Point(40, 40);
            noOfOrdersLabel.Name = "noOfOrdersLabel";
            noOfOrdersLabel.Padding = new Padding(0, 4, 0, 4);
            noOfOrdersLabel.Size = new Size(206, 43);
            noOfOrdersLabel.TabIndex = 24;
            noOfOrdersLabel.Text = "No. of Orders";
            // 
            // summaryLabel
            // 
            summaryLabel.AutoSize = true;
            summaryLabel.Font = new Font("Arial", 10F);
            summaryLabel.ForeColor = Color.FromArgb(255, 255, 192);
            summaryLabel.Location = new Point(20, 0);
            summaryLabel.Name = "summaryLabel";
            summaryLabel.Padding = new Padding(0, 4, 0, 4);
            summaryLabel.Size = new Size(211, 40);
            summaryLabel.TabIndex = 23;
            summaryLabel.Text = "Quote Summary";
            // 
            // summaryHeadingLine
            // 
            summaryHeadingLine.BackColor = Color.FromArgb(255, 255, 192);
            summaryHeadingLine.ForeColor = Color.FromArgb(255, 255, 192);
            summaryHeadingLine.Location = new Point(0, 20);
            summaryHeadingLine.Name = "summaryHeadingLine";
            summaryHeadingLine.Size = new Size(1000, 2);
            summaryHeadingLine.TabIndex = 22;
            // 
            // toolTip
            // 
            toolTip.IsBalloon = true;
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Info";
            // 
            // Solar4UFormApp
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 0);
            ClientSize = new Size(1524, 1179);
            Controls.Add(summaryPanel);
            Controls.Add(optionsPanel);
            Controls.Add(selectionPanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Solar4UFormApp";
            Text = "Solar4U";
            ((System.ComponentModel.ISupportInitialize)logoImage).EndInit();
            selectionPanel.ResumeLayout(false);
            selectionPanel.PerformLayout();
            batterySelection.ResumeLayout(false);
            batterySelection.PerformLayout();
            optionsPanel.ResumeLayout(false);
            summaryPanel.ResumeLayout(false);
            summaryPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox logoImage;
        private Panel selectionPanel;
        private ListBox brandList;
        private Panel optionsPanel;
        private ListBox sizeList;
        private RadioButton battery5RadioButton;
        private GroupBox batterySelection;
        private RadioButton battery20RadioButton;
        private RadioButton battery10RadioButton;
        private Label brandLabel;
        private Label sizeLabel;
        private Label effectLabel;
        private Label brandPriceLabel;
        private Panel summaryPanel;
        private Label quantityLabel;
        private TextBox quantityInput;
        private CheckBox expInstallCheckBox;
        private Button quoteButton;
        private Button exitButton;
        private Button summaryButton;
        private Button orderButton;
        private Button clearButton;
        private ToolTip toolTip;
        private Label summaryLabel;
        private Panel summaryHeadingLine;
        private Label averageValueLabel;
        private Label grossValueLabel;
        private Label installationSummaryLabel;
        private Label invertorSummaryLabel;
        private Label batterySummaryLabel;
        private Label panelsSummaryLabel;
        private Label noOfOrdersLabel;
        private Panel summaryMidLine;
        private Label batteriesPercentage;
        private Label batteriesCostValue;
        private Label panelsPercentage;
        private Label panelsCostValue;
        private Label noOfOrders;
        private Label installationPercentage;
        private Label installationCostValue;
        private Label invertorsPercentage;
        private Label invertorsCostValue;
        private Label averageValue;
        private Label grossValue;
        private Label discountValueLabel;
        private Label netValueLabel;
        private Label noOfDiscountsLabel;
        private Label noOfDiscounts;
        private Label netValue;
        private Label discountValue;
        private Label panelDetails;
        private Label batteryDetails;
        private Label invertorDetails;
        private Label installationDetails;
    }
}
