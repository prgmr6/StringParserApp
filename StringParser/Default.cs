using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringParserApplication
{
    public partial class StringParser : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public StringParser()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOne_Click(object sender, EventArgs e)
        {
            BaseClass bc = new BaseClass();
            List<string> splitArray = new List<string>();
            if (bc.CheckNumbers(textBox1.Text, out splitArray) == false)
            {
                lblErrorOutput.Text = bc.ErrorString;
                return;
            }
            List<int> mylist = splitArray.Select(n => int.Parse(n)).ToList();
            Sum sum = bc.RetrieveIndexOfTopSum(mylist);
            lblMethodOneTime.Text = bc.RunTime();
            lblMethodOneAnswer.Text = sum.minValue.ToString();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTwo_Click(object sender, EventArgs e)
        {
            try
            {
                BaseClass bc = new BaseClass();
                List<string> splitArray = new List<string>();
                if (bc.CheckNumbers(textBox1.Text, out splitArray) == false)
                {
                    lblErrorOutput.Text = bc.ErrorString;
                    return;
                }
                List<int> mylist = splitArray.Select(n => int.Parse(n)).ToList();
                Sum sum = new Sum(int.MinValue, int.MinValue);
                bc.RetrieveIndexOfTopSum(mylist, out sum);
                lblMethodTwoTime.Text = bc.RunTime();
                lblMethodTwoAnswer.Text = sum.minValue.ToString();
            }
            catch (ApplicationError err)
            {
                lblErrorOutput.Text = err.Message;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThree_Click(object sender, EventArgs e)
        {
            BaseClass bc = new BaseClass();
            List<string> splitArray = new List<string>();
            if (bc.CheckNumbers(textBox1.Text, out splitArray) == false)
            {
                lblErrorOutput.Text = bc.ErrorString;
                return;
            }
            List<int> mylist = splitArray.Select(n => int.Parse(n)).ToList();
            IEnumerable<Sum> sums = new List<Sum>();
            Sum sum = bc.RetrieveIndexOfTopSum(mylist, sums);
            lblMethodThreeTime.Text = bc.RunTime();
            lblMethodThreeAnswer.Text = sum.minValue.ToString();
        }    
    }
   
   

    public class ApplicationError : Exception
    {

    }
}
