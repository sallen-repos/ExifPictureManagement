using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;

namespace PictureManagement
{
    public partial class Form1 : Form
    {

        /*     This class handles user input
         *      
         *     Form1 class has a has-a relationship with all other classes in the project besides static classes and imageData 
         *     
         *     The imageData array is constructed in the store data class
         * 
         */
    
       
        public int displayIndex = 0;
        public string directoryPath = "";
        public string textFileName = "";
                
        DataStore dataStore = new DataStore();
        
        CustomMessageBox customMessageBox; 
        public ExifExtractor exifExtractor;       

        public List<string> filteredList = new List<string>();
        //string buttonID;
        public Form1()
        {
            InitializeComponent();       
            fromDatePicker.Value = DateTime.Today.AddMonths(-5);
            ComboBox categoryComboBox = new ComboBox();
            fromDatePicker.MaxDate = toDatePicker.Value;
            toDatePicker.MinDate = fromDatePicker.Value;
            noneRadioButton.Checked = true;
            Capture = true;
        }
        //Changes the image to the images at indexed position
        public void ChangeListIndexedImage(int i)
        {
            imageDisplay.Image = new Bitmap(directoryPath + filteredList[i]);
            ChangeIndexText(i);
        }
        //Changes the text to corectly represent present list and position
        private void ChangeIndexText(int n)
        {
            imageNumberLabel.Text = "image " + (n + 1) + " of " + filteredList.Count;
        }
        //opens dialof to load text file
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            textFileName = openFileDialog.FileName;
            openFileDialog.Filter = "text files(*.txt)|*.jpg";
            directoryPath = Path.GetDirectoryName(textFileName) + "\\";
            if (directoryPath != "\\" && textFileName != "")
            {                
                DataExtractor dataExtractor = new DataExtractor(directoryPath, textFileName);               
                dataStore.Store(dataExtractor.GetArray());
                UnfilteredList();
                FillComboBox();
            }else
            {
                MyMessage("Error reading file path.\r\n\nTry again", "File Directory Missing!");
            }
        }
        //Generates unfiltered list of images from stored tags
        private void UnfilteredList()
        {
            filteredList.Clear();
            for (int i = 0; i < dataStore.ImageCount; i++)
            {
                filteredList.Add(dataStore.imageData[i].FileName);
            }
            CheckChangeImage(0);
        }

        //changes to the next image but loops back to start rather indexing beyond the list
        private void nextButton_Click(object sender, EventArgs e)
        {
            if (filteredList.Count > 0)
            {
                if (displayIndex >= filteredList.Count - 1)
                {
                    displayIndex = 0;
                }
                else
                {
                    displayIndex++;
                }
                ChangeListIndexedImage(displayIndex);
            }
        }
        //changes to the next image but loops to the end rather indexing into negative numbers
        private void previousButton_Click(object sender, EventArgs e)
        {
            if (filteredList.Count > 0)  
            {
                if (displayIndex <= 0)
                {
                    displayIndex = filteredList.Count - 1;
                }
                else
                {
                    displayIndex--;
                }
                ChangeListIndexedImage(displayIndex);
            }
        }
        //Fills the categoryComboBox with category tags
        private void FillComboBox()
        {
            for (int i = 0; i < dataStore.ImageCount - 1; i++)
            {
                if (!categoryComboBox.Items.Contains(dataStore.imageData[i].Category))
                {
                    categoryComboBox.Items.Add(dataStore.imageData[i].Category);

                }
            }
        }
        //Applies selected fileter if there is a list of images to filter
        private void filterButton_Click(object sender, EventArgs e)
        {
            if (filteredList.Count <= 0)
            {
                MyMessage("Check IMG_DATA.txt has been loaded.\r\r\nCheck images are in folder and filenames match with tags in IMG_DATA.txt", "No Images loaded to display!");
            }
            else
            {
                //Gets value of selected RadioButton without constructing a RadioButton
                var selectedButton = filterGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(radioButton => radioButton.Checked);

                if (selectedButton.Checked)
                {
                    switch (selectedButton.Text)
                    {
                        case "None":
                            NoneSelected();
                            break;
                        case "Date":
                            DateSelected(fromDatePicker.Text.ToString(), toDatePicker.Text.ToString());                     // 1
                            break;
                        case "Category":
                            CategorySelected(2, categoryComboBox.SelectedItem.ToString(), "Category");    // 2
                            break;
                        case "Description":
                            KeyWordSelected(3, descriptionTextBox.Text, "Description");     // 3                          
                            break;
                        case "Comments":
                            KeyWordSelected(4, commentsTextBox.Text, "Comments");           // 4                     
                            break;
                    }
                }
            }
        }
        //User has selected no filter, if unfiltered list is already displayed show a message, otherwise display unfiltered list
        private void NoneSelected()
        {
            if (filteredList.Count == dataStore.ImageCount)
            {
                MyMessage("No Filter Term selected.\r\r\nPlease select a term", "No filter term selected");
            }
            else
            {
                UnfilteredList();
            }
        }
        //Determine if date input is valid
        private void DateSelected(string dateFrom, string dateTo)
        {
            bool first = true;
           // DateSelected dateSelected = new DateSelected(dateFrom, dateTo, out first);


            if (dateFrom != "" && dateTo != "")
            {
                
                for (int i = 0; i < dataStore.ImageCount; i++)
                {
                    first = DateSelected(i, first);
                }
                FirstInList(@"No Image between dates selected found", "Image Not Found!", first);
            }
        }
        //determine category input isn't null, otherwise apply filter
        private void CategorySelected(int n, string input, string filter)
        {
            bool first = true;
            if (categoryComboBox.SelectedIndex > -1 && input != null)
            {
                first = ExactMatchFilter(0, n, categoryComboBox.SelectedItem.ToString(), first);
                FirstInList(@"Image matching """ + categoryComboBox.SelectedItem.ToString() + @""" keyword not found", "Image Not Found!", first);
            }
            else
            {
                MyMessage("Please select a category to filter", "No Category Selected!");
            }
        }
        //deterime selected Keyword filter isn't null, otherwise apply filter
        private void KeyWordSelected(int n, string input, string filter)
        {
            if (input != "" && input != null)
            {
                Filter(n, input);
            }
            else
            {
                MyMessage(filter + " box is empty\r\r\nPlease fill in order to filter", "Key Word is Missing!");
            }
        }
        //Calls key Word filter
        private void Filter(int n, string input)
        {           
            bool first = true;
            first = KeyWordFilter(0, n, input, first);
            FirstInList(@"Image matching """ + input + @""" keyword not found", "Image Not Found!", first);
        }
        //Checks whether index of image should be changed
        public void CheckChangeImage(int i)
        {
            if (i <= filteredList.Count)
            {
                ChangeListIndexedImage(i);
            }
            if (i < 0)
            {
                ChangeListIndexedImage(i--);
            }
        }
        //Method determines whether image date tags fall within the date set by the user with the provided Data/timePickers 
        public bool DateSelected(int i, bool first)
        {            
            DateTime imageDate = DateTime.ParseExact(dataStore.imageData[i].Date, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);

            if (imageDate > fromDatePicker.Value && imageDate < toDatePicker.Value)
            {
                first = IsFirst(first, i);
                filteredList.Add(dataStore.imageData[i].FileName);                
            }
            return first;
        }

        //The Category filter uses a case insensitive exact match for which an Extention to the .Equals() method has been created
        public bool ExactMatchFilter(int i, int n, string input, bool first)
        {            
            if (dataStore.imageData[i].data[n].Equals(input, StringComparison.OrdinalIgnoreCase))
            {
                    first = IsFirst(first, i);
                    filteredList.Add(dataStore.imageData[i].FileName);     
            }
            i++;
            if (i < dataStore.ImageCount)
            {
                first = ExactMatchFilter(i, n, input, first);
            }
            return first;
        }

        //Comments and Description filter with an extention of String.Contains, that gives a case insensitive comparison
        public bool KeyWordFilter(int i, int n, string input, bool first)
        {
            if (dataStore.imageData[i].data[n].Contains(input, StringComparison.OrdinalIgnoreCase))
            {
                first = IsFirst(first, i);
                filteredList.Add(dataStore.imageData[i].FileName);
            }
            i++;
            if (i < dataStore.ImageCount)
            {
                first = KeyWordFilter(i, n, input, first);
            }
            return first;
        }
        //Determins if image is first image that matches filter
        public bool IsFirst(bool first, int i)
        {
            if (first)
            {
                DeleteList();       //Deleted list if a match is found and a new list must be generated
            }
            return false;
        }
        //This method is called after all images habe been checked
        //If first is still true        
        //then the filter has not found any matches and the user should be informed
        //If 
        public void FirstInList(string message, string caption, bool firstInList)
        {
            if (firstInList)
            {
                MyMessage(message, caption);
            }
            else
            {
                CheckChangeImage(0);
            }
        }

        //Change selected radioButton for filter, when user interacts by changing the input for that filter
        private void descriptionTextBox_TextChanged(object sender, EventArgs e)
        {
           descriptionRadioButton.Checked = true;
        }
        private void commentsTextBox_TextChanged(object sender, EventArgs e)
        {
           commentsRadioButton.Checked = true;
        }
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            categoryRadioButton.Checked = true;
        }
        private void fromDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dateRadioButton.Checked = true;
            toDatePicker.MinDate = fromDatePicker.Value;
        }
        private void toDatePicker_ValueChanged(object sender, EventArgs e)
        {
            dateRadioButton.Checked = true;
            fromDatePicker.MaxDate = toDatePicker.Value;
        }


        //Button for aditional feature to extract image Exif tags
        private void UseExifButton_Click(object sender, EventArgs e)
        {
            if (directoryPath != "" || directoryPath != "\\" || textFileName == "")
            {
                 exifExtractor = new ExifExtractor();
            }
            else
            {
                exifExtractor = new ExifExtractor(directoryPath);
            }
            directoryPath = exifExtractor.FilePath + "\\";
            dataStore.Store(exifExtractor.GetExifArray());     
            UnfilteredList();
            FillComboBox();
        }

        //Button for additional feature to save data from .txt to Exif tagged images
        private void saveExifButton_Click(object sender, EventArgs e)
        {
            if (directoryPath + textFileName != "" && directoryPath != "\\")
            {
                ExifTag exifTag = new ExifTag(directoryPath, textFileName);
            }
            else
            {
                MyMessage("Text File not found!", "Load text file to save tags as Exif data");            
            }
        }

        //call instance of a custom message box, that can be dismissed using any key informing the user whilst not impeeding them.
        public void MyMessage(string message, string caption)
        {
            customMessageBox = new CustomMessageBox(message, caption);
            customMessageBox.Location = new Point(this.Location.X + ((this.Size.Width - customMessageBox.Width) / 2),
             this.Location.Y + ((this.Size.Height - customMessageBox.Height) / 2));
            customMessageBox.StartPosition = FormStartPosition.Manual;
            customMessageBox.Show(this);
        }
        //Clears list when new list is to be formed
        public void DeleteList()
        {
            filteredList.Clear();
        }


    }
}
    
