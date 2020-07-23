using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Windows.Forms;

namespace PictureManagement
{
    /*
     *      This class saves tags take from .txt to a jpg images Exif data 
     * 
     *      Saves all images in a batch
     * 
     */



    public class ExifTag
    {
        public ExifTag()
        {

        }

        public ExifTag(string directory, string textFileName)
        {
            TagImages(directory, textFileName);
        }

        public void TagImages(string directory, string textFileName)
        {
            int[] tagDecimal = { 40091, 50971, 40094, 40095, 40092, 36867, 270 };
            /* Decimal Representation of relevant Exif properties tag ID
            * 40091 XPtitle ()              0
            * 50971 Date/time ISO8601       1
            * 40094 XPkeywords (category)   2
            * 40095 XPsubject (description) 3       
            * 40092 XPcomment               4
            * 36867 DateTimeOriginal
            *  270  ImageComment
             */


            //Initialise needed items, strings need to be encoded
            //PropertyItem will hold our tag then write the tag to a bit map of our image of our image which will finally be saved
            PropertyItem propertyItem;
            ASCIIEncoding ascii = new ASCIIEncoding();
            UnicodeEncoding uni = new UnicodeEncoding();

            //PropertyItem contains no constructor that can be called without arguments, has a constructor with descernable arguments
            propertyItem = (PropertyItem)FormatterServices.GetUninitializedObject(typeof(PropertyItem));  
               

            Image imageToTag;
            DataExtractor fromFile = new DataExtractor(directory, textFileName);
            DataStore dataStore = new DataStore(fromFile.GetArray());

            //get jpg source location
            /*string destination = "";
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (directory != "")
            {
                folderBrowser.SelectedPath = directory;
                destination = directory.Substring(0, directory.Length - 2);
            }
           
            //Get folder for destination of images
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                destination = folderBrowser.SelectedPath;
            }
            else 
            {
                
            }
            */

            string destination = directory.Substring(0, directory.Length - 2);               

            //Loop to store all images in batch
            for (int i = 0; i < dataStore.ImageCount; i++)
            {
                string extention = dataStore.imageData[i].FileName.Substring(dataStore.imageData[i].FileName.Length - 4, 4); // (dataExtractor.imageData[i].data[n].Equals(input, StringComparison.OrdinalIgnoreCase))
                if (extention.Equals(".jpg", StringComparison.OrdinalIgnoreCase))
                {
                    imageToTag = new Bitmap(directory + dataStore.imageData[i].FileName);       //Generate a bitmap image of our source image

                    for (int j = 0; j <= 4; j++)
                    {
                        propertyItem.Id = tagDecimal[j];        //Set property item id to the relevant tag decimal tag ID
                        if (j == 1)
                        {
                            propertyItem.Value = ascii.GetBytes(dataStore.imageData[i].Date);       //Date tag needs ascii encoding
                        }
                        else
                        {
                            propertyItem.Value = uni.GetBytes(dataStore.imageData[i].data[j]);      //All other tags unicode
                        }
                        propertyItem.Type = 1;
                        propertyItem.Len = propertyItem.Value.Length;       //relevante property item details set                      
                        imageToTag.SetPropertyItem(propertyItem);           //PropertyItems set in our image bitmap
                    }

                    imageToTag.Save(destination + dataStore.imageData[i].FileName);     //Save the bitmap with propertyItems now set to a jpg
                }
            }
        }
    }
}
