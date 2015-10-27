using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoundingProgram
{
    public partial class frmRounding : Form
    {
        


        public frmRounding()
        {
            InitializeComponent();
        }

        private void mniExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            double numberToRound = 0;
            int numberOfDecimals = 0;
            double finalAnswer = 0;

            numberToRound = Convert.ToDouble(this.txtNumberToRound.Text);
            numberOfDecimals = Convert.ToInt32(this.nudAmountOfDecimals.Value);

            finalAnswer = Math.Round(numberToRound, numberOfDecimals);

            this.lblAnswer.Text = Convert.ToString(finalAnswer);
        }
    }
}
