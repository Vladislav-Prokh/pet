using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security;
using System.Text.RegularExpressions;
using FundamentalsSoftwareEngineeringLab2.extra_classes;
using FundamentalsSoftwareEngineeringLab2.FactoryMethodSystemSavingFiles;
using FundamentalsSoftwareEngineeringLab2.AbstractFactoryOpenFilesSystem;
using FundamentalsSoftwareEngineeringLab2.Observer;

namespace FundamentalsSoftwareEngineeringLab2
{
    public partial class MainForm : Form
    {
        private RichTextBox oldText = new RichTextBox();
        private TextStatisticProvider textStatisticProvider;
        private List<Component> elementsOnForm;
        private eventRegistrator registrator;
        private int FormWidth = 650;
        private int FormHeight = 605;
        FileSaver fileCreator;
        IObservable observable;
        private const int amountSymblosInauthorsPage = 1800;
        private int amountOfAuthorsPages;
        public MainForm()
        {
           InitializeComponent();
           elementsOnForm = new List<Component>();
           oldText.Text = "";
           registrator = ProtocolSytem.getInstance("C:\\Users\\User\\source\\repos\\FundamentalsSoftwareEngineeringLab2\\file.txt");
           observable = new TextEventNotifier();
           TextInfo eventNotifier = new TextInfo();
           observable.AddObserver(eventNotifier);
           amountOfAuthorsPages = 0;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
              try
                {
                    String OpenedFileType = openFileDialog1.FileName.Substring(openFileDialog1.FileName.LastIndexOf('.'));
                    FileReadersCreator fileReadersCreator = new FileReadersCreator();
                    String textFromFile = "";
                    if (OpenedFileType.Equals(".html"))
                    {
                        HtmlFileReader fileReader = (HtmlFileReader)fileReadersCreator.createHtmlFileReader();
                        textFromFile = fileReader.ReadHtmlFile(openFileDialog1.FileName);
                    }
                    else if (OpenedFileType.Equals(".dat"))
                    {
                        DatFileReader fileReader = (DatFileReader)fileReadersCreator.createDatFileReader();
                        textFromFile = fileReader.ReadDatFile(openFileDialog1.FileName);
                    }
                    else
                    {
                        txtFileReader fileReader = (txtFileReader)fileReadersCreator.createTxtFileReader();
                        textFromFile  = fileReader.ReadFileTxt(openFileDialog1.FileName);
                    }

                    SetTextToTextBox(textFromFile, editTextBox);


                }
                catch (SecurityException ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                    $"Details:\n\n{ex.StackTrace}");
                }
            }

        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
              SaveFileDialog SFD = new SaveFileDialog();
              SFD.FileName = "file";
        
              if (SFD.ShowDialog() == DialogResult.OK)
              {
                String fileType = SFD.FileName.Substring(SFD.FileName.LastIndexOf('.'));
                if (fileType.Equals(".html"))
                {
                    fileCreator = new htmlFileSaver();
                }
                else if (fileType.Equals(".dat"))
                {
                    fileCreator = new binaryFileSaver();
                }
                else
                {
                    fileCreator = new txtFileSaver();
                }
                fileCreator.save(SFD,editTextBox.Text);
              }
   
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.editTextBox.Clear();
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void SetTextToTextBox(string text, TextBoxBase tx)
        {
            tx.Text = text;
        }
        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
        
        }
        private void showStatisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StatiscticForm form = new StatiscticForm();
          
            textStatisticProvider = new TextStatisticProvider(editTextBox.Text);
            Dictionary<string,string> statistics = textStatisticProvider.CalcStat();
            int txtBoxPosition_X = 10, txtBoxPosition_Y = 25;

            foreach (KeyValuePair<string, string> stat in statistics)
            {
                TextBox txtBox = new TextBox();
                txtBox.Text = stat.Key + " : " + stat.Value;
                txtBox.Location = new System.Drawing.Point(txtBoxPosition_X, txtBoxPosition_Y);
                Size size = TextRenderer.MeasureText(txtBox.Text, txtBox.Font);
                txtBox.Width = size.Width;
                txtBox.Height = size.Height;
                form.Controls.Add(txtBox);
                txtBoxPosition_Y +=25;
            }
            form.Show();
        }
         public void editTextBox_TextChanged(object sender, EventArgs e)
         {
            //count author's pages
            if(editTextBox.Text.Length/amountSymblosInauthorsPage != amountOfAuthorsPages)
            {
                observable.NotifyObservers(editTextBox.Text);
                amountOfAuthorsPages = editTextBox.Text.Length / amountSymblosInauthorsPage;
            }

            //Register operation
            string operation = "";
            int[] numOfLineAndIndexOfElementChanged;
            if (oldText.Text.Length < editTextBox.Text.Length)
            {
                numOfLineAndIndexOfElementChanged = findIndexAndLineNumberOfExtraSymbol(oldText.Text, editTextBox.Text);
                operation = "operation: add symbol";
            }
            else
            {
                numOfLineAndIndexOfElementChanged = findIndexAndLineNumberOfExtraSymbol(editTextBox.Text, oldText.Text);
                operation = "operation: delete symbol";
            }

            registrator.registerEventInFile(DateTime.Now, operation, numOfLineAndIndexOfElementChanged[0], numOfLineAndIndexOfElementChanged[1]);
            oldText.Text = editTextBox.Text;
         }
        private void correctTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RichTextBox txtBoxForCorrectedText = new RichTextBox(); //creating new textBox
            txtBoxForCorrectedText.Location = new Point(700, 37);
            txtBoxForCorrectedText.Size = editTextBox.Size;
            txtBoxForCorrectedText.Name = "CorrectedTextBox";

            this.Size = new Size((int)(FormWidth * 2.2), this.Size.Height); //expand current form

            TextHandler textHandler = new TextHandler(editTextBox.Text); //handle current text
            txtBoxForCorrectedText.Text = textHandler.handleText();

            buttonSaveCorrectedTxt.Location = new Point(1330,37); //show additional buttons on form 
            buttonSaveCorrectedTxt.BringToFront();

            buttonCancelCorrectedTxt.Location = new Point(1330, 60);
            buttonSaveCorrectedTxt.BringToFront();

            elementsOnForm.Add(txtBoxForCorrectedText);
            elementsOnForm.Add(buttonSaveCorrectedTxt);
            elementsOnForm.Add(buttonCancelCorrectedTxt);
            this.Controls.Add(txtBoxForCorrectedText);
        }
        private void buttonSaveCorrectedTxt_Click(object sender, EventArgs e)
        {
            var CorrectedTextBox = this.Controls.Find("CorrectedTextBox", true);
            editTextBox.Text = CorrectedTextBox[0].Text;
            RollBackFormCondition();
        }
        private void buttonCancelCorrectedTxt_Click(object sender, EventArgs e)
        {
            RollBackFormCondition();
        }
        private void RollBackFormCondition()
        {
            this.Size = new Size(FormWidth, FormHeight);
            foreach(Component c in elementsOnForm)
            {
                this.Controls.Remove((Control)c);
            }
        }
        private void loadZNUNewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAskAmountOfRecord form = new FormAskAmountOfRecord(this);
            form.Show();
        }
        private int[] findIndexAndLineNumberOfExtraSymbol(String txt1,String txt2)
        {
            int minLen = Math.Min(txt1.Length, txt2.Length);
            int indexOfLastNewLine = 0;
   
            for (int i = 0; i < minLen; i++)
            {
                if (txt1[i].Equals('\n'))
                         indexOfLastNewLine = i;
                if (!oldText.Text[i].Equals(editTextBox.Text[i]))
                {
                   return new int[2]{ indexOfLastNewLine, i - indexOfLastNewLine };
                }
            }
            int amountOfLinesCounter = editTextBox.Text.Count(c => c == '\n');
            String txt = txt1.Length > txt2.Length ? txt1 : txt2;

            string str = txt.Split('\n').ToList().Last();

            return new int[2] { amountOfLinesCounter, str.Length-1};
        }
    }
}
