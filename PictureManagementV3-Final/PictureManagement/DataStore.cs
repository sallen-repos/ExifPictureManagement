using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureManagement
{

    /*
     *  Class stores data taken from text files or Exif data, passed to it through an array
     * 
     *  The data is stored in an array of the ImageData class
     *  
     *  Each tag is stored in the array within Image data - imageData[n].data[n] 
     * 
     */

    public class DataStore
    {
        //imageCount aught not be accesible
        private int imageCount;

        public ImageData[] imageData;

        public DataStore()
        {

        }
        public DataStore(string[] lines)
        {
            Store(lines);
        }
        //initialises length of imagedata
        public void Store(string[] lines)
        {
            imageCount = lines.Length;
            imageData = new ImageData[imageCount];

            for (int i = 0; i < imageCount; i++)
            {
                StoreData(i, lines[i]);
            }
        }
        //tagID's are read here to store tags in relevant locations
        //This code separates tags then stores them in imageData[n].data[n]
        private void StoreData(int i, string line)
        {
            imageData[i] = new ImageData();
            string[] tagID = { "FN=", "DT=", "CT=", "DS=", "CM=", };            

            //Split to separate tags
            string[] tagArray = line.Split(',');
            for (int j = 0; j < tagArray.Length - 1; j++)
            {
                if (j < imageData[i].data.Length - 1)
                    foreach (string singleTag in tagArray)                                  //Tags will be stored here the first three chars will be removed to dispose of the tagIDs
                    {
                        if (singleTag.Length >= 4 && singleTag.Substring(0, 3) == tagID[j])  //checking length is below 4 prevents error
                        {
                            if (j == 1)
                            {
                                imageData[i].Date = singleTag.Substring(3, 10);     //Date Format has a specified length
                            }
                            else
                            {
                                imageData[i].data[j] = tagArray[j].Substring(3, singleTag.Length - 3);         
                            }
                        }
                    }
            }

        }
        //allow count of all images extracted and stored to be viewed but not altered
        public int ImageCount
        {
            get { return imageCount; }           
        }
    }
}
