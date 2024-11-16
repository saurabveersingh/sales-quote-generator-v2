/* Student Name: Saurabveer Singh
 * Student ID: 24239833
 * Date:23/10/2024
 * Assignment: 2
 * Assignment: Create a form App that can be used by sales representatives to calculate quotations & finalize
 * orders for prospective clients while also being able to generate summary of all quotes generated
 */

namespace Solar4U
{
    public partial class Solar4UFormApp : Form
    {
        int numOfOrders, numOfDiscounts = 0;

        decimal totalPanelsCost,
            totalBatteriesCost,
            totalInvertorsCost,
            totalInstallationsCost,
            totalDiscountVal = 0;

        const decimal LONGI_SOLAR_PRICE = 129.5m,
            JINKO_SOLAR_PRICE = 135m,
            TRINA_SOLAR_PRICE = 112.79m,
            CANADIAN_SOLAR_PRICE = 149m,
            Q_CELLS_PRICE = 131m,
            FIRST_SOLAR_PRICE = 119m;

        public Solar4UFormApp()
        {
            InitializeComponent();
        }

        private void quoteButton_Click(object sender, EventArgs e)
        {
            // Validate Data
            int brandIndex = brandList.SelectedIndex;
            if (brandIndex == -1)
            {
                DisplayError("Please Select a Panel Brand");
                brandList.Focus();
                return;
            }

            int sizeIndex = sizeList.SelectedIndex;
            if (sizeIndex == -1)
            {
                DisplayError("Please Select a Panel Size");
                sizeList.Focus();
                return;
            }

            int quantity = 0;
            try
            {
                quantity = int.Parse(quantityInput.Text);
                if (quantity < 1) throw new ArgumentException($"quantity cannot be less than 1", nameof(quantity));
            }
            catch (Exception ex)
            {
                DisplayError("Please Enter a valid panel quantity");
                quantityInput.SelectAll();
                quantityInput.Focus();
                return;
            }


            // Disable Quote Button to prevent multiple clicks
            quoteButton.Enabled = false;

            // Disable Inputs to prevent user from changing input values
            EnableInputs(false);

            // Disable Summary Button until order confirmation or until form is cleared.
            summaryButton.Enabled = false;

            // Calculate Panels Cost
            decimal panelsCost = brandIndex == 0 ? LONGI_SOLAR_PRICE :
                brandIndex == 1 ? JINKO_SOLAR_PRICE :
                brandIndex == 2 ? TRINA_SOLAR_PRICE :
                brandIndex == 3 ? CANADIAN_SOLAR_PRICE :
                brandIndex == 4 ? Q_CELLS_PRICE :
                FIRST_SOLAR_PRICE;

            panelsCost += sizeIndex == 0 ? panelsCost * -25 / 100 :
                sizeIndex == 1 ? panelsCost * -15 / 100 :
                sizeIndex == 2 ? 0 :
                sizeIndex == 3 ? panelsCost * 15 / 100 :
                sizeIndex == 4 ? panelsCost * 25 / 100 :
                panelsCost * 40 / 100;

            panelsCost *= quantity;

            // Calculate Battery Cost
            decimal batteryCost = battery5RadioButton.Checked ? 4500 :
                battery10RadioButton.Checked ? 7500 :
                battery20RadioButton.Checked ? 9500 : 0;

            // Calculate Invertor Cost
            int noOfCells = sizeIndex == 0 ? 30 :
                sizeIndex == 1 ? 48 :
                sizeIndex == 2 ? 60 :
                sizeIndex == 3 ? 72 :
                sizeIndex == 4 ? 84 : 96;

            noOfCells *= quantity;

            bool hasBattery = battery5RadioButton.Checked || battery10RadioButton.Checked || battery20RadioButton.Checked;

            decimal invertorCost = noOfCells <= 700 ?
                hasBattery ? 1150 :
                650 :
                hasBattery ? 1350 :
                950;

            // Calculate Installation Cost
            decimal installationCost = expInstallCheckBox.Checked ? 798 : 499;

            // Calculate Gross Value
            decimal grossVal = panelsCost + batteryCost + invertorCost + installationCost;

            // Calculate Discount & Net Value
            bool hasLargeBattery = battery10RadioButton.Checked || battery20RadioButton.Checked;
            decimal discountVal = noOfCells > 700 && hasLargeBattery ? grossVal * 3 / 100 : 0;
            decimal netVal = grossVal - discountVal;

            // Update Relavent Labels
            noOfOrdersLabel.Visible = false;
            noOfOrders.Visible = false;

            string panelBrand = brandIndex == 0 ? "LONGi Solar" :
                brandIndex == 1 ? "JinkoSolar" :
                brandIndex == 2 ? "Trina Solar" :
                brandIndex == 3 ? "CanadianSolar" :
                brandIndex == 4 ? "Q-Cells" :
                "FirstSolar";

            string panelSize = sizeIndex == 0 ? "30-Cell" :
                sizeIndex == 1 ? "48-Cell" :
                sizeIndex == 2 ? "60-Cell" :
                sizeIndex == 3 ? "72-Cell" :
                sizeIndex == 4 ? "84-Cell" :
                "96-Cell";

            panelDetails.Visible = true;
            panelDetails.Text = $"{panelBrand} {panelSize} x{quantity}";
            panelsCostValue.Text = panelsCost.ToString("C2");
            panelsPercentage.Text = (panelsCost / netVal).ToString("P2");

            batteryDetails.Visible = true;
            batteryDetails.Text = battery5RadioButton.Checked ? "5KWh" :
                battery10RadioButton.Checked ? "10KWh" :
                battery20RadioButton.Checked ? "20KWh" : "";
            batteriesCostValue.Text = batteryCost.ToString("C2");
            batteriesPercentage.Text = (batteryCost / netVal).ToString("P2");

            invertorDetails.Visible = true;
            invertorDetails.Text = noOfCells <= 700 ?
                hasBattery ? "Regular with Battery" :
                "Regular without Battery" :
                hasBattery ? "Large with Battery" :
                "Large without Battery";
            invertorsCostValue.Text = invertorCost.ToString("C2");
            invertorsPercentage.Text = (invertorCost / netVal).ToString("P2");

            installationDetails.Visible = true;
            installationDetails.Text = expInstallCheckBox.Checked ? "Expedited Install" : "Regular Install";
            installationCostValue.Text = installationCost.ToString("C2");
            installationPercentage.Text = (installationCost / netVal).ToString("P2");

            grossValue.Text = grossVal.ToString("C2");
            discountValue.Text = discountVal.ToString("C2");
            netValue.Text = netVal.ToString("C2");
            averageValueLabel.Visible = false;
            averageValue.Visible = false;
            noOfDiscountsLabel.Visible = false;
            noOfDiscounts.Visible = false;

            // Display Summary to the user
            summaryPanel.Visible = true;

            // Enable Order Button
            orderButton.Enabled = true;
        }

        // Toggles between enabling and disabling inputs
        private void EnableInputs(bool enable)
        {
            selectionPanel.Enabled = enable;
            selectionPanel.BackColor = enable ? Color.Maroon : Color.FromArgb(128, 64, 64);
            batterySelection.BackColor = enable ? Color.Maroon : Color.FromArgb(128, 64, 64);
        }

        //Displays Error Box
        private void DisplayError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        // Resets the Form
        private void clearButton_Click(object sender, EventArgs e)
        {
            // Reset Inputs
            brandList.ClearSelected();
            sizeList.ClearSelected();
            quantityInput.Text = "0";
            battery5RadioButton.Checked = false;
            battery10RadioButton.Checked = false;
            battery20RadioButton.Checked = false;
            expInstallCheckBox.Checked = false;

            // Enable Inputs
            EnableInputs(true);

            // Enable Buttons
            quoteButton.Enabled = true;
            summaryButton.Enabled = numOfOrders > 0;

            // Disable Order Button
            orderButton.Enabled = false;

            // Hide summary panel
            summaryPanel.Visible = false;
        }

        // Places the order and updates Summary
        private void orderButton_Click(object sender, EventArgs e)
        {
            // retrieve values from form
            decimal panelsCost = decimal.Parse(panelsCostValue.Text.Substring(1)),
            batteryCost = decimal.Parse(batteriesCostValue.Text.Substring(1)),
            invertorCost = decimal.Parse(invertorsCostValue.Text.Substring(1)),
            installationCost = decimal.Parse(installationCostValue.Text.Substring(1)),
            discountVal = decimal.Parse(discountValue.Text.Substring(1)),
            netVal = decimal.Parse(netValue.Text.Substring(1));


            // Order Confirmation Message Box
            string res = MessageBox.Show($"{panelDetails.Text}\n{batteryDetails.Text}\nInvertor {invertorDetails.Text}\n{installationDetails.Text}\nTotal Cost ${netVal}", "Do you wish to confirm this order?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();

            // Return if User doesn't confirm order. 
            if (res == "No") return;

            // Update Summary values on order confirmation
            numOfOrders++;
            totalPanelsCost += panelsCost;
            totalBatteriesCost += batteryCost;
            totalInvertorsCost += invertorCost;
            totalInstallationsCost += installationCost;
            if (discountVal > 0)
            {
                totalDiscountVal += discountVal;
                numOfDiscounts++;
            }

            clearButton_Click(sender, e);
        }

        // Displays a summary of previous orders.
        private void summaryButton_Click(object sender, EventArgs e)
        {
            // Disable Summary Button to avoid multiple clicks
            summaryButton.Enabled = false;

            // Update Summary Panel Data
            noOfOrdersLabel.Visible = true;
            noOfOrders.Visible = true;
            noOfOrders.Text = numOfOrders.ToString("N0");

            decimal grossVal = totalPanelsCost + totalBatteriesCost + totalInvertorsCost + totalInstallationsCost;
            decimal netVal = grossVal - totalDiscountVal;

            panelDetails.Visible = false;
            panelsCostValue.Text = totalPanelsCost.ToString("C2");
            panelsPercentage.Text = (totalPanelsCost/netVal).ToString("P2");

            batteryDetails.Visible = false;
            batteriesCostValue.Text = totalBatteriesCost.ToString("C2");
            batteriesPercentage.Text = (totalBatteriesCost / netVal).ToString("P2");

            invertorDetails.Visible = false;
            invertorsCostValue.Text = totalInvertorsCost.ToString("C2");
            invertorsPercentage.Text = (totalInvertorsCost / netVal).ToString("P2");

            installationDetails.Visible = false;
            installationCostValue.Text = totalInstallationsCost.ToString("C2");
            installationPercentage.Text = (totalInstallationsCost / netVal).ToString("P2");

            grossValue.Text = grossVal.ToString("C2");
            discountValue.Text = totalDiscountVal.ToString("C2");
            netValue.Text = netVal.ToString("C2");

            averageValueLabel.Visible = true;
            averageValue.Visible = true;
            averageValue.Text = (netVal/numOfOrders).ToString("C2");

            noOfDiscountsLabel.Visible = true;
            noOfDiscounts.Visible = true;
            noOfDiscounts.Text = numOfDiscounts.ToString("N0");

            // Show summary panel
            summaryPanel.Visible = true;
        }

        // Closes the Form App
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
