using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextFileImporterManipulatorExporter
{
    public partial class MainForm : Form
    {

        int itemCount;


        public MainForm()
        {
            InitializeComponent();
        }


        private void btnLoad_Click(object sender, EventArgs e)
        {            
            EditTextFromFile();
            OrganizeNumbers();
            CountNumberOccurences();
        } // end btnLoadClick


        private void btnSave_Click(object sender, EventArgs e)
        {

            System.IO.StreamWriter SaveFiles = new System.IO.StreamWriter(@"C:\Users\Netko\Documents\Visual Studio 2015\Projects\TextFileImporterManipulatorExporter\lottoNumbers.txt");
            System.IO.StreamWriter SaveNumberFile = new System.IO.StreamWriter(@"C:\Users\Netko\Documents\Visual Studio 2015\Projects\TextFileImporterManipulatorExporter\frequentPBNumbers.txt");

            foreach (var item in listTextFileDisplay.Items)
            {
                SaveFiles.WriteLine(item);
            }
            SaveFiles.Close();

            foreach(var item in listBoxCounted.Items)
            {
                SaveNumberFile.WriteLine(item);
            }
            SaveNumberFile.Close();

            MessageBox.Show("Text Saved");
        } // end btnSaveClick


        public void EditTextFromFile()
        {
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Netko\Documents\Visual Studio 2015\Projects\TextFileImporterManipulatorExporter\pbNumbers.txt");
            
            foreach (string line in lines)
            { 
                string tempString = line.Remove(0, 11);
                tempString = tempString.Remove(21);
                
                listTextFileDisplay.Items.Add(tempString);
            }

            listTextFileDisplay.Items.RemoveAt(0);
            itemCount = listTextFileDisplay.Items.Count;
        } // end EditTextFromFile


        public void OrganizeNumbers()
        {
            for(int x = 0; x < itemCount; x++)
            {
                string[] numbers;

                string tempString = listTextFileDisplay.Items[x].ToString();

                numbers = tempString.Split(' ');

                foreach (string num in numbers)
                {
                    if(num != "")
                    listTextCollection.Items.Add(num);
                }
            }
           // listTextCollection.Items.Add(listTextCollection.Items.Count);
        } //end CountNumbers


        public void CountNumberOccurences()
        {
            for (int count = 0; count < 69; count++)
            {
                listBoxCounted.Items.Add("0");
            }

            for (int g = 0; g < listTextCollection.Items.Count; g++)
            {
                int tempNum;
                int tempText;
                int countNum;

                tempNum = Convert.ToInt16(listTextCollection.Items[g].ToString());

                tempText = Convert.ToUInt16(listBoxCounted.Items[tempNum - 1].ToString());
                countNum = tempText;
                countNum = countNum + 1;
                listBoxCounted.Items[tempNum - 1] = Convert.ToString(countNum);
                
            } // end for

            for (int t = 0; t < listBoxCounted.Items.Count; t++)
            {
                string tempTxt = listBoxCounted.Items[t].ToString();

                listBoxCounted.Items[t] = ("" + (t + 1) + ":\t" + tempTxt);
            } // end for
        } // end CountNumberOccurance
    } // end Main
}
