using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.IO;


namespace PictureManagement
{
    /*
     * 
     *      This class extracts exif data from every image in a source folder
     * 
     */ 



    public class ExifExtractor
    {
        private string[] lines;
        public ImageData[] exifData;    //imageData is public so it can be accessed
        private string directoryPath;


        //Select any image from source folder
        public ExifExtractor()
        {
            System.IO.Stream fileStream;
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Files|*.jpg;*.jpeg";
            openFile.Title = "Please select an image from your chosen source folder";
            openFile.FileName = "Select image";
            if (openFile.ShowDialog() == DialogResult.OK && (fileStream = openFile.OpenFile()) != null)
            {

                directoryPath = Path.GetDirectoryName(openFile.FileName);
                ExtractTest(directoryPath);
            }
        }

        public ExifExtractor(string directory)
        {
            ExtractTest(directory);
        }
        //Method for extraction
        private void ExtractTest(string directory)
        {
            PropertyItem propertyItem;
            ASCIIEncoding ascii = new ASCIIEncoding();
            UnicodeEncoding uni = new UnicodeEncoding();

            int[] tagDecimal = { 40091, 50971, 40094, 40095, 40092, 36867, 270 };

            /*  tagDecimal array stores Decimal Representation of relevant Exif properties tag ID
            *  40091 XPtitle ()              0
            *  50971 Date/time ISO8601       1
            *  40094 XPkeywords (category)   2
            *  40095 XPsubject (description) 3       
            *  40092 XPcomment               4
            *  36867 DateTimeOriginal
            *   270  ImageComment
             */
             
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);
            FileInfo[] files = directoryInfo.GetFiles("*.jpg");

            string[] imageFiles = Directory.GetFiles(directory, "*.jpg").Select(Path.GetFileName).ToArray();

            string[] extensions = new[] { ".jpg", ".jpeg", ".png" };

            FileInfo[] imagefiles =
                directoryInfo.EnumerateFiles()
                     .Where(f => extensions.Contains(f.Extension.ToLower()))
                     .ToArray();

            var varItem = (PropertyItem)FormatterServices.GetUninitializedObject(typeof(PropertyItem));
            propertyItem = varItem;             //PropertyItem contains no constructor that can be called without arguments, has a constructor with descernable arguments
            
            ImageData imageData = new ImageData();

            string[] tagID = { "FN=", "DT=", "CT=", "DS=", "CM=", };
            string[] tagArray = new string[tagID.Length - 1];
            lines = new string[imageFiles.Length];

            for (int i = 0; i < imageFiles.Length; i++)
            {

                imageData.FileName = tagID[0] + imageFiles[i];

                string filePath = directory + "\\" + imageFiles[i];
                Image testimage = new Bitmap(filePath);

                string extention = imageData.FileName.Substring(imageData.FileName.Length - 4, 4); // (dataExtractor.imageData[i].data[n].Equals(input, StringComparison.OrdinalIgnoreCase))
                if (extention.Equals(".jpg", StringComparison.OrdinalIgnoreCase))
                {

                    //This loop stores Exif data into lines
                    for (int j = 1; j < tagID.Length; j++)
                    {

                        foreach (string singleTag in tagID)
                        {
                            {   //Set property item id to the relevant tag decimal tag ID
                                propertyItem.Id = tagDecimal[j];
                                //The were errors transfering ascii and unicode to strings, and string arrays
                                if (j == 1)                             //these were completely avoided by storing to imageData.data[n] instead of arrays in this class
                                {
                                    try
                                    {
                                        imageData.Date = tagID[j];                                          //tagID[n] must be stored first storing after results in corrupted data
                                        propertyItem = testimage.GetPropertyItem(tagDecimal[j]); //ASCII                                                                                   
                                        imageData.Date += ascii.GetString(propertyItem.Value);              //Date tag uses ascii encoding
                                    }
                                    catch
                                    {
                                        imageData.Date += "";
                                        //set to ""
                                    }
                                }
                                else
                                {
                                    try
                                    {
                                        imageData.data[j] = tagID[j];
                                        propertyItem = testimage.GetPropertyItem(tagDecimal[j]); //Unicode 
                                        imageData.data[j] += uni.GetString(propertyItem.Value);             //all the other tags use unicode
                                    }
                                    catch
                                    {
                                        imageData.data[j] += "";
                                        //set to ""
                                    }
                                }
                            }
                        }
                    }
                }
                lines[i] = string.Join(",", imageData.data) + ",>";     //Now tags have been stored in imageData without being corrupted the data can now be stored in lines indirectly
            }
        }
        //Allows Exif data to be passed as a string
        public string[] GetExifArray()
        {
            return lines;
        }
        //Allows the file path used to be viewed
        public string FilePath
        {
            get { return directoryPath; }
        }
    }

}
