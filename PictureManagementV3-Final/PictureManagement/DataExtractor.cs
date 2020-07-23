using System;
using System.IO;
/*
 *  This class servs as a lexer for the selected .txt file
 * 
 */

namespace PictureManagement
{
    public class DataExtractor
    {
        // lines of tags where file names are valid
        private string[] validLines;

        public DataExtractor()
        {

        }

        public DataExtractor(string directory, string filePath)
        {
            ExtractData(directory, filePath);
        }
        //Reads text file and splits tags to be analysed
        private void ExtractData(string directoryPath, string textFilePath)
        {

            if (textFilePath != "")
            {
                string fileText = File.ReadAllText(textFilePath);
                int end = fileText.LastIndexOf("//");
                fileText = fileText.Substring(0, end);

                Char[] angleBrackets = { (char)60, (char)62 };

                string[] fileLines = fileText.Split(angleBrackets);

                CheckImageFileValidity(directoryPath, fileLines);
            }
        }
        //Checks if image file exists and is a file extention that can be displayed by the winforms pictureBox
        private void CheckImageFileValidity(string directoryPath, string[] lineArray)
        {
            int end;
            validLines = new string[lineArray.Length - 1];
            int displayableImages = 0;
            for (int i = 0; i < lineArray.Length - 1; i++)
            {

                end = lineArray[i].IndexOf(',');
                if (end > 3)        //If end is less than 3, there is no information stored in the tag
                {
                    string imgName = lineArray[i].Substring(3, end - 3);    //To remove the "FN=" ID
                    if (File.Exists(directoryPath + imgName))
                    {
                        string fileExtension = imgName.Substring(imgName.Length - 4, 4);            //Get last 4 chars to check file extention
                        if (fileExtension == ".bmp" || fileExtension == ".ico" || fileExtension == ".gif" || fileExtension == ".wmf" ||
                            fileExtension == ".jpg" || fileExtension == ".png" || fileExtension == "jpeg")
                        {
                            validLines[displayableImages] = lineArray[i];
                            displayableImages++;
                        }
                    }
                }
                else if (lineArray[i] != "")
                {
                    DisplayFileReadErrorMessage(lineArray[i]);
                }
            }
        }
        //Simple error messasge
        private void DisplayFileReadErrorMessage(string name)
        {
            System.Windows.Forms.MessageBox.Show("Could not find image!\n\r" 
                + "Check filename''" + name 
                + "'' is correct!\n\r\r If incorrect name or extension is displayed here, fix in IMG_DATA.txt");
        }

        public string[] GetArray()
        {
            return validLines;
        }
    }
}

