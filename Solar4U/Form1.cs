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
        // Panel Brand Data
        const string PANEL_1_BRAND = "LONGi Solar",
            PANEL_2_BRAND = "JinkoSolar",
            PANEL_3_BRAND = "Trina Solar",
            PANEL_4_BRAND = "CanadianSolar",
            PANEL_5_BRAND = "Q-Cells",
            PANEL_6_BRAND = "FirstSolar";

        const decimal PANEL_1_PRICE = 129.5m,
            PANEL_2_PRICE = 135m,
            PANEL_3_PRICE = 112.79m,
            PANEL_4_PRICE = 149m,
            PANEL_5_PRICE = 131m,
            PANEL_6_PRICE = 119m;

        // Panel Size and Discount Data
        const int PANEL_SIZE_1 = 30,
            PANEL_SIZE_2 = 48,
            PANEL_SIZE_3 = 60,
            PANEL_SIZE_4 = 72,
            PANEL_SIZE_5 = 84,
            PANEL_SIZE_6 = 96,
            DISCOUNT_SIZE = 700;

        const decimal PANEL_SIZE_1_PERCENT = -.25m,
            PANEL_SIZE_2_PERCENT = -.15m,
            PANEL_SIZE_3_PERCENT = 0m,
            PANEL_SIZE_4_PERCENT = .15m,
            PANEL_SIZE_5_PERCENT = .25m,
            PANEL_SIZE_6_PERCENT = .4m,
            DISCOUNT_PERCENT = .03m;

        // Battery Data
        const string BATTERY_1_SIZE = "20KWh",
            BATTERY_2_SIZE = "10KWh",
            BATTERY_3_SIZE = "5KWh",
            BATTERY_4_SIZE = "Not Required";

        const decimal BATTERY_1_PRICE = 9500m,
            BATTERY_2_PRICE = 7500m,
            BATTERY_3_PRICE = 4500m,
            BATTERY_4_PRICE = 0;

        // Invertor and Installation Data
        const string INVERTOR_1_TYPE = "Regular without Battery",
            INVERTOR_2_TYPE = "Large without Battery",
            INVERTOR_3_TYPE = "Regular with Battery",
            INVERTOR_4_TYPE = "Large with Battery",
            INSTALLATION_1_TYPE = "Regular Install",
            INSTALLATION_2_TYPE = "Expedited Install";

        const decimal INVERTOR_1_PRICE = 650m,
            INVERTOR_2_PRICE = 950m,
            INVERTOR_3_PRICE = 1150m,
            INVERTOR_4_PRICE = 1350m,
            INSTALLATION_1_PRICE = 499m,
            INSTALLATION_2_PRICE = 798m;

        // Field Variables
        int numOfOrders, numOfDiscounts, numOfPanels, numOfCells = 0;

        decimal totalPanelsCost, totalBatteriesCost, totalInvertorsCost, totalInstallationsCost, totalDiscountVal,
            panelsCost, batteryCost, invertorCost, installationCost, discountVal = 0;

        string orderDetails = "";

        public Solar4UFormApp()
        {
            InitializeComponent();
        }

        //Displays Error Box
        private void DisplayError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        // Displays a Detailed Price Quote based on User Inputs
        private void QuoteButton_Click(object sender, EventArgs e)
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

            // Validate quantity input
            if (numOfPanels < 1)
            {
                DisplayError("Please Enter a valid panel quantity");
                quantityInput.SelectAll();
                quantityInput.Focus();
                return;
            }

            // Handle No Battery Selection
            if (!battery1RadioButton.Checked && !battery2RadioButton.Checked && !battery3RadioButton.Checked && !battery4RadioButton.Checked)
            {
                battery4RadioButton.Checked = true;
            }

            // Disable Quote Button to prevent multiple clicks
            quoteButton.Enabled = false;

            // User is allowed to switch between summary and quote screens using buttons when one or more order exist.
            summaryButton.Enabled = numOfOrders > 0;

            // Calculate Panels Cost
            panelsCost = brandIndex == 0 ? PANEL_1_PRICE :
                brandIndex == 1 ? PANEL_2_PRICE :
                brandIndex == 2 ? PANEL_3_PRICE :
                brandIndex == 3 ? PANEL_4_PRICE :
                brandIndex == 4 ? PANEL_5_PRICE :
                PANEL_6_PRICE;

            panelsCost *= 1 + (sizeIndex == 0 ? PANEL_SIZE_1_PERCENT :
                sizeIndex == 1 ? PANEL_SIZE_2_PERCENT :
                sizeIndex == 2 ? PANEL_SIZE_3_PERCENT :
                sizeIndex == 3 ? PANEL_SIZE_4_PERCENT :
                sizeIndex == 4 ? PANEL_SIZE_5_PERCENT :
                PANEL_SIZE_6_PERCENT);

            panelsCost *= numOfPanels;

            // Calculate Battery Cost
            batteryCost = battery1RadioButton.Checked ? BATTERY_1_PRICE :
                battery2RadioButton.Checked ? BATTERY_2_PRICE :
                battery3RadioButton.Checked ? BATTERY_3_PRICE :
                BATTERY_4_PRICE;

            // Calculate Invertor Cost
            invertorCost = battery4RadioButton.Checked ?
                numOfCells <= DISCOUNT_SIZE ? INVERTOR_1_PRICE :
                INVERTOR_2_PRICE :
                numOfCells <= DISCOUNT_SIZE ? INVERTOR_3_PRICE :
                INVERTOR_4_PRICE;

            // Calculate Installation Cost
            installationCost = expInstallCheckBox.Checked ? INSTALLATION_2_PRICE : INSTALLATION_1_PRICE;

            // Calculate Gross Value
            decimal grossVal = panelsCost + batteryCost + invertorCost + installationCost;

            // Calculate Discount & Net Value
            bool hasLargeBattery = battery2RadioButton.Checked || battery1RadioButton.Checked;
            discountVal = numOfCells > DISCOUNT_SIZE && hasLargeBattery ? grossVal * DISCOUNT_PERCENT : 0;
            decimal netVal = grossVal - discountVal;

            // Update Relavent Labels
            noOfOrdersLabel.Visible = false;
            noOfOrders.Visible = false;

            string panelBrand = brandIndex == 0 ? PANEL_1_BRAND :
                brandIndex == 1 ? PANEL_2_BRAND :
                brandIndex == 2 ? PANEL_3_BRAND :
                brandIndex == 3 ? PANEL_4_BRAND :
                brandIndex == 4 ? PANEL_5_BRAND :
                PANEL_6_BRAND;

            string panelSize = sizeIndex == 0 ? $"{PANEL_SIZE_1}-Cell" :
                sizeIndex == 1 ? $"{PANEL_SIZE_2}-Cell" :
                sizeIndex == 2 ? $"{PANEL_SIZE_3}-Cell" :
                sizeIndex == 3 ? $"{PANEL_SIZE_4}-Cell" :
                sizeIndex == 4 ? $"{PANEL_SIZE_5}-Cell" :
                $"{PANEL_SIZE_6}-Cell";

            panelDetails.Visible = true;
            string panelDetailsText = $"{panelBrand} {panelSize} x{numOfPanels}";
            panelDetails.Text = panelDetailsText;
            panelsCostValue.Text = panelsCost.ToString("C2");
            panelsPercentage.Text = (panelsCost / netVal).ToString("P2");

            batteryDetails.Visible = true;
            string batteryDetailsText = battery1RadioButton.Checked ? BATTERY_1_SIZE :
                battery2RadioButton.Checked ? BATTERY_2_SIZE :
                battery3RadioButton.Checked ? BATTERY_3_SIZE :
                BATTERY_4_SIZE;
            batteryDetails.Text = batteryDetailsText;
            batteriesCostValue.Text = batteryCost.ToString("C2");
            batteriesPercentage.Text = (batteryCost / netVal).ToString("P2");

            invertorDetails.Visible = true;
            string invertorDetailsText = battery4RadioButton.Checked ?
                numOfCells <= DISCOUNT_SIZE ? INVERTOR_1_TYPE :
                INVERTOR_2_TYPE :
                numOfCells <= DISCOUNT_SIZE ? INVERTOR_3_TYPE :
                INVERTOR_4_TYPE;
            invertorDetails.Text = invertorDetailsText;
            invertorsCostValue.Text = invertorCost.ToString("C2");
            invertorsPercentage.Text = (invertorCost / netVal).ToString("P2");

            installationDetails.Visible = true;
            string installationDetailsText = expInstallCheckBox.Checked ? INSTALLATION_2_TYPE : INSTALLATION_1_TYPE;
            installationDetails.Text = installationDetailsText;
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

            // Prepare Order Confirmation Message
            orderDetails = $"{panelDetailsText}\nBattery {batteryDetailsText}\nInvertor {invertorDetailsText}\n{installationDetailsText}\nTotal Cost {netVal.ToString("C2")}";
        }

        // Resets the Form
        private void ClearButton_Click(object sender, EventArgs e)
        {
            // Disable Order Button
            orderButton.Enabled = false;

            // Reset Inputs
            brandList.ClearSelected();
            sizeList.ClearSelected();
            quantityInput.Text = "0";
            battery1RadioButton.Checked = false;
            battery2RadioButton.Checked = false;
            battery3RadioButton.Checked = false;
            battery4RadioButton.Checked = false;
            expInstallCheckBox.Checked = false;

            // Hide Discount Offer
            discountOffer.Visible = false;

            // Enable Buttons
            quoteButton.Enabled = true;
            summaryButton.Enabled = numOfOrders > 0;

            // Hide summary panel
            summaryPanel.Visible = false;
        }

        // Places the order and updates Summary
        private void OrderButton_Click(object sender, EventArgs e)
        {
            // Order Confirmation Message Box
            string res = MessageBox.Show($"{orderDetails}", "Do you wish to confirm this order?", MessageBoxButtons.YesNo, MessageBoxIcon.Question).ToString();

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

            ClearButton_Click(sender, e);
        }

        // Displays a summary of previous orders.
        private void SummaryButton_Click(object sender, EventArgs e)
        {
            // Disable Summary Button to avoid multiple clicks
            summaryButton.Enabled = false;

            // Enables user to switch between quote and summary screens when required inputs are provided.
            quoteButton.Enabled = true;

            // Disables order button until user has the quotation clearly visible.
            orderButton.Enabled = false;

            // Update Summary Panel Data
            noOfOrdersLabel.Visible = true;
            noOfOrders.Visible = true;
            noOfOrders.Text = numOfOrders.ToString("N0");

            decimal grossVal = totalPanelsCost + totalBatteriesCost + totalInvertorsCost + totalInstallationsCost;
            decimal netVal = grossVal - totalDiscountVal;

            panelDetails.Visible = false;
            panelsCostValue.Text = totalPanelsCost.ToString("C2");
            panelsPercentage.Text = (totalPanelsCost / netVal).ToString("P2");

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
            averageValue.Text = (netVal / numOfOrders).ToString("C2");

            noOfDiscountsLabel.Visible = true;
            noOfDiscounts.Visible = true;
            noOfDiscounts.Text = numOfDiscounts.ToString("N0");

            // Show summary panel
            summaryPanel.Visible = true;
        }

        // Closes the Form App
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Handle panel brand input change
        private void BrandList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderButton.Enabled)
            {
                QuoteButton_Click(sender, e);
            }
        }

        // Handle panel size input change
        private void SizeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Offers Discount if conditions are met and updates quotation if its visible
            OfferDiscount(sender, e);
        }

        // Handle panel quantity input change
        private void QuantityInput_TextChanged(object sender, EventArgs e)
        {
            string quantity = quantityInput.Text;

            // Panel quantity can be zero at this stage for smooth UI.
            // However, user recieves an error message on click of quote button with a panel quantity less than 1.
            // User also recieves an error message dynamically when panel quantity is changed to less than 1 while quotation is visible.
            if (quantity == "")
            {
                numOfPanels = 0;
            }
            else
            {
                try
                {
                    numOfPanels = int.Parse(quantity);
                    if (numOfPanels < 0)
                    {
                        DisplayError("Please Enter a valid panel quantity");
                        quantityInput.SelectAll();
                        quantityInput.Focus();
                        return;
                    }
                }
                catch (Exception ex)
                {
                    DisplayError("Please Enter a valid panel quantity");
                    quantityInput.SelectAll();
                    quantityInput.Focus();
                    return;
                }
            }

            // Offers Discount if conditions are met and updates quotation if its visible
            OfferDiscount(sender, e);
        }

        // Handle Battery Selection Change
        private void Battery1RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (orderButton.Enabled)
            {
                QuoteButton_Click(sender, e);
            }
        }

        // Handle Battery Selection Change
        private void Battery2RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (orderButton.Enabled)
            {
                QuoteButton_Click(sender, e);
            }
        }

        // Handle Battery Selection Change
        private void Battery3RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (orderButton.Enabled)
            {
                QuoteButton_Click(sender, e);
            }
        }

        // Handle Battery Selection Change
        private void Battery4RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (orderButton.Enabled)
            {
                QuoteButton_Click(sender, e);
            }
        }

        // Handle Expedited Install Input Change
        private void ExpInstallCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (orderButton.Enabled)
            {
                QuoteButton_Click(sender, e);
            }
        }

        // Offers Discount if conditions are met and updates quotation if its visible
        private void OfferDiscount(object sender, EventArgs e)
        {
            int sizeIndex = sizeList.SelectedIndex;

            if (sizeIndex == -1) return;

            numOfCells = sizeIndex == 0 ? PANEL_SIZE_1 :
                sizeIndex == 1 ? PANEL_SIZE_2 :
                sizeIndex == 2 ? PANEL_SIZE_3 :
                sizeIndex == 3 ? PANEL_SIZE_4 :
                sizeIndex == 4 ? PANEL_SIZE_5 :
                PANEL_SIZE_6;

            numOfCells *= numOfPanels;

            if (numOfCells > DISCOUNT_SIZE)
            {
                discountOffer.Visible = true;
            }
            else
            {
                discountOffer.Visible = false;
            }

            if (orderButton.Enabled)
            {
                QuoteButton_Click(sender, e);
            }
        }
    }
}
