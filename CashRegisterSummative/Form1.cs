using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CashRegisterSummative
{/// <summary>
/// Anika Sindwani, October 2019, Cash Register Summative
/// </summary>

    public partial class Form1 : Form
    {
        //*Declaration of Variables

        //Item Prices
        const int RING_PRICE = 80;
        const int CHARM_PRICE = 20;
        const int BRACELET_PRICE = 100;

        //Tax Rate
        const double TAX_RATE = 0.13;

        //Number of Items Purchased
        int numRings = 0;
        int numCharms = 0;
        int numBracelets = 0;

        //Sub-Total
        int subTotal;

        //Tax Amount
        double taxAmount = 0;

        //Total Cost
        double totalCost = 0;

        //Amount Tendered
        double tendered = 0;

        //Change
        double change = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void calculateTotals_Click(object sender, EventArgs e)
        {
            //Items Purchased into Variable
            try
            {
                numRings = Convert.ToInt16(ringInput.Text);
                numCharms = Convert.ToInt16(charmInput.Text);
                numBracelets = Convert.ToInt16(braceletInput.Text);

                //Sub-Total
                subTotal = numRings * RING_PRICE + numCharms * CHARM_PRICE + numBracelets * BRACELET_PRICE;
                subtotalOutput.Text = subTotal.ToString("C");

                //Tax-Amount 
                taxAmount = subTotal * TAX_RATE;
                taxesOutput.Text = taxAmount.ToString("C");

                //Total Cost
                totalCost = subTotal + taxAmount;
                totalcostOutput.Text = totalCost.ToString("C");
            }
            catch
            {
                tryLabel.Text = "*Please enter a numeric value, or enter 0 into" +
                    " items that are not being purchased";
            }
        }
        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Tendered amount into Variable
                tendered = Convert.ToDouble(tenderedInput.Text);

                //Change Calculation
                change = tendered - totalCost;
                changeOuput.Text = change.ToString("C");
            }
            catch
            {
                tryLabel2.Text = "Please enter a value into the tendered box";
            }
        }

        private void receieptButton_Click(object sender, EventArgs e)
        {
            //Presets
            Graphics g = this.CreateGraphics();
            SolidBrush receiptBrush = new SolidBrush(Color.White);
            SoundPlayer receieptSound = new SoundPlayer(Properties.Resources.registerSound);
            Font drawFont = new Font("Courier New", 11, FontStyle.Bold);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            //First Rectangle
            g.FillRectangle(receiptBrush, 290, 63, 290, 50);
            g.DrawString("Pandora Inc.", drawFont, drawBrush, 380, 100);
            receieptSound.Play();
            Thread.Sleep(200);

            //Second Rectangle
            g.FillRectangle(receiptBrush, 290, 93, 290, 50);
            g.DrawString("Pandora Inc.", drawFont, drawBrush, 380, 100);
            Thread.Sleep(250);

            //Third Rectangle
            g.FillRectangle(receiptBrush, 290, 123, 290, 50);
            receieptSound.Play();
            Thread.Sleep(250);

            //Fourth Rectangle
            g.FillRectangle(receiptBrush, 290, 153, 290, 50);
            g.DrawString("Order #1909", drawFont, drawBrush, 310, 135);
            Thread.Sleep(250);

            //Fifth Rectangle 
            g.FillRectangle(receiptBrush, 290, 183, 290, 50);
            g.DrawString("September 19, 2019", drawFont, drawBrush, 310, 155);
            receieptSound.Play();
            Thread.Sleep(250);
            g.DrawString("Sub Total         " + subTotal, drawFont, drawBrush, 310, 200);

            //Sixth Rectangle
            g.FillRectangle(receiptBrush, 290, 203, 290, 50);
            g.DrawString("Rings       X" + numRings + "  @  " + RING_PRICE.ToString("C"), drawFont, drawBrush, 310, 200);
            Thread.Sleep(250);

            //Seventh Rectangle
            g.FillRectangle(receiptBrush, 290, 233, 290, 50);
            g.DrawString("Charms      X" + numCharms + "  @  " + CHARM_PRICE.ToString("C"), drawFont, drawBrush, 310, 220);
            receieptSound.Play();
            Thread.Sleep(250);

            //Eigth Rectangle
            g.FillRectangle(receiptBrush, 290, 263, 290, 50);
            g.DrawString("Bracelets   X" + numBracelets + "  @  " + BRACELET_PRICE.ToString("C"), drawFont, drawBrush, 310, 240);
            Thread.Sleep(250);

            //Ninth Rectangle
            g.FillRectangle(receiptBrush, 290, 293, 290, 50);
            receieptSound.Play();
            Thread.Sleep(250);

            //Tenth Rectangle
            g.FillRectangle(receiptBrush, 290, 313, 290, 50);
            g.DrawString("Subtotal     " + subTotal.ToString("C"), drawFont, drawBrush, 310, 280);
            Thread.Sleep(250);

            //Eleventh Rectangle
            g.FillRectangle(receiptBrush, 290, 343, 290, 50);
            g.DrawString("Tax          " + taxAmount.ToString("C"), drawFont, drawBrush, 310, 300);
            receieptSound.Play();
            Thread.Sleep(250);

            //Twelfth Rectangle
            g.FillRectangle(receiptBrush, 290, 373, 290, 50);
            g.DrawString("Total        " + totalCost.ToString("C"), drawFont, drawBrush, 310, 320);
            Thread.Sleep(250);
            receieptSound.Play();

            //Thirteenth Rectangle
            g.FillRectangle(receiptBrush, 290, 403, 290, 50);
            g.DrawString("Tendered     " + tendered.ToString("C"), drawFont, drawBrush, 310, 360);
            Thread.Sleep(250);
            g.DrawString("Change       " + change.ToString("C"), drawFont, drawBrush, 310, 380);
            Thread.Sleep(250);
            g.DrawString("Have A Great Day!    ", drawFont, drawBrush, 360, 410);
        }

        private void new_orderButton_Click(object sender, EventArgs e)

        {
            //Clear Variables
             numRings = 0;
             numCharms = 0;
             numBracelets = 0;

             subTotal = 0;

            taxAmount = 0;

            totalCost = 0;

            tendered = 0;

             change = 0;

            //Clear Inputs & Outputs
            ringInput.Text = "";
            charmInput.Text = "";
            braceletInput.Text = "";
            tenderedInput.Text = "";
            changeOuput.Text = "$0.00";
            subtotalOutput.Text = "$0.00";
            taxesOutput.Text = "$0.00";
            totalcostOutput.Text = "";

            //Clear Reciept
            Graphics g = this.CreateGraphics();
            g.Clear(Color.LightBlue);
        }

    }
}
