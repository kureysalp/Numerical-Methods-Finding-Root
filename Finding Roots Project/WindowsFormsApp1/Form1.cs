using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        int iteration = 0;


        public Form1()
        {
            InitializeComponent();
        }

        float Function(float x)
        {
            //Function is x^3 - 7x^2 + 14x - 6 = 0
            return x * x * x - 7 * x * x + 14 * x - 6;            
        }

        float DerivativeOfFunciton(float x)
        {
            //Function is 3x^2 - 14x + 14 = 0
            return 2 * x * x - 14 * x + 14;
        }

        float Bisection(float minInterval, float maxInterval)
        {            
            return (minInterval + maxInterval) / 2; // Average of current intervals.            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            iteration = 0;

            if (bisection.Checked)
            {
                //Bisection method.
                if (bisection.Checked)
                {
                    float minInterval = float.Parse(bisectionMinTxt.Text); //Declare min interval from user input.
                    float maxInterval = float.Parse(bisectionMaxTxt.Text); //Declare max interval from user input.

                    float root = 0; //Stopping criteria
                    float error = float.Parse(bisectionErrorTxt.Text); //Declare error from user input.

                    //For deciding if root is exist or not.
                    float minResult = Function(minInterval);
                    float maxResult = Function(maxInterval);

                    if (Function(minResult) * Function(maxResult) < 0)
                    {
                        do
                        {
                            float newResult = Bisection(minInterval, maxInterval); //Apply the bisection.

                            root = Math.Abs(maxInterval - minInterval) / (float)Math.Pow(2, iteration); //Find the root.

                            if (Function(newResult) * Function(maxInterval) < 0) //Decide which direction we will go.
                                minInterval = newResult;
                            else
                                maxInterval = newResult;
                            iteration++; //Increase the iteration number each time.
                        }
                        while (root >= error);

                        MessageBox.Show("After " + iteration + " iterations root is " + root + " with " + error + " error");
                    }
                    else
                        MessageBox.Show("There is no root between " + maxInterval + ", " + maxInterval + "for x^3 - 7x^2 + 14x - 6 = 0");
                }
            }
            else if (newton.Checked)
            {
                float currentN = 0, nPlusOne = 0, stopCondition = 0;
                float error = float.Parse(newtonError.Text);
                do
                {
                    if (iteration == 0)
                        if (newronStartMin.Checked)
                            currentN = float.Parse(newtonMinTxt.Text); //The first step that taking the minimum limit.
                        else
                            currentN = float.Parse(newtonMaxTxt.Text); //The first step that taking the maximum limit.
                    else
                        currentN = nPlusOne; //Other steps after first step that taking next 'x'.

                    nPlusOne = currentN - (Function(currentN) / DerivativeOfFunciton(currentN)); //Find next root with newton raphson.

                    if (relativeError.Checked) //Stopping condition.
                        stopCondition = Math.Abs(nPlusOne - currentN) / Math.Abs(nPlusOne);
                    else
                        stopCondition = Math.Abs(nPlusOne - currentN);

                    iteration++; //Increase the iteration number each time.
                } while (stopCondition >= error);

                MessageBox.Show("After " + iteration + " iterations root is " + currentN + " with " + error + " error ");

            }
            else if (secant.Checked)
            {
                float nMinusOne = 0, currentN = 0, nPlusOne = 0, stopCondition = 0;
                float error = float.Parse(secantError.Text);

                do
                {
                    if (iteration == 0)
                    {
                        nMinusOne = float.Parse(secantX0Txt.Text); //The first step that taking the X0.
                        currentN = float.Parse(secantX1Txt.Text); //The first step that taking the X1.
                    }
                    else
                    {
                        nMinusOne = currentN;
                        currentN = nPlusOne;
                    }

                    nPlusOne = currentN - (Function(currentN) * (currentN - nMinusOne)) / (Function(currentN) - Function(nMinusOne));

                    if (secantRelative.Checked) //Stopping condition.
                        stopCondition = Math.Abs(nPlusOne - currentN) / Math.Abs(nPlusOne);
                    else
                        stopCondition = Math.Abs(nPlusOne - currentN);
                    iteration++;
                }
                while (stopCondition > error);
                MessageBox.Show("After " + iteration + " iterations root is " + currentN + " with " + error + " error ");
            }
        }

        private void bisection_CheckedChanged(object sender, EventArgs e)
        {
            bisectionGroup.Visible = true;
            newtonMethod.Visible = false;
            secantGroup.Visible = false;
        }

        private void newton_CheckedChanged(object sender, EventArgs e)
        {
            bisectionGroup.Visible = false;
            newtonMethod.Visible = true;
            secantGroup.Visible = false;
        }

        private void secant_CheckedChanged(object sender, EventArgs e)
        {
            bisectionGroup.Visible = false;
            newtonMethod.Visible = false;
            secantGroup.Visible = true;
        }

        private void bisectionMinTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == ',')))
                e.Handled = true;
        }

        private void bisectionMaxTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == ',')))
                e.Handled = true;
        }

        private void bisectionErrorTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == ',')))
                e.Handled = true;
        }

        private void newtonMinTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == ',')))
                e.Handled = true;
        }

        private void newtonMaxTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == ',')))
                e.Handled = true;
        }

        private void newtonError_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == ',')))
                e.Handled = true;
        }

        private void secantX0Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == ',')))
                e.Handled = true;
        }

        private void secantX1Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == ',')))
                e.Handled = true;
        }

        private void secantError_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == ',')))
                e.Handled = true;
        }
    }
}
