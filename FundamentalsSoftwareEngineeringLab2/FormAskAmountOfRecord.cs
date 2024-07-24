using FundamentalsSoftwareEngineeringLab2.extra_classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FundamentalsSoftwareEngineeringLab2
{
    public partial class FormAskAmountOfRecord : Form
    {
        MainForm mainForm;
        public FormAskAmountOfRecord(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();

        }
        private void AcceptAmountRecordsBtn_Click(object sender, EventArgs e)
        {
            this.mainForm.editTextBox.Text = "";
            string patternOnlyNum = @"^\d+$";
            string num = textBoxAmountRecords.Text;
            if (System.Text.RegularExpressions.Regex.IsMatch(num, patternOnlyNum))
            {
                WebDataProvider dataProvider = new WebDataProvider();
                List<String> listHeadline = dataProvider.getData(Int16.Parse(num), "https://www.znu.edu.ua/cms/index.php?action=news/view&start=0&site_id=27&lang=ukr");
                foreach (string headline in listHeadline)
                {
                    this.mainForm.editTextBox.Text += "* " + headline + '\n';
                }
            }
        }

        private void textBoxAmountRecords_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
