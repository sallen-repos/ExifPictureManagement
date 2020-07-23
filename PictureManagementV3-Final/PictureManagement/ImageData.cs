using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PictureManagement
{
    /*      This class is where image tags are stored
     * 
     *      Tags are stored in a public array string[] data
     *      
     *      Data in the array may also be changed from the provided fields
     */

    public class ImageData
    {
        public string[] data;

        public ImageData()
        {
            data = new string[5];
            data[0] = ""; //FileName
            data[1] = ""; //Date
            data[2] = ""; //Category 
            data[3] = ""; //Description
            data[4] = ""; //Comments
        }

        public string FileName
        {
            get { return data[0]; }
            set { data[0] = value; }
        }

        public string Date
        {
            get { return data[1]; }
            set { data[1] = value; }
        }

        public string Category
        {
            get { return data[2]; }
            set { data[2] = value; }
        }

        public string Description
        {
            get { return data[3]; }
            set { data[3] = value; }
        }

        public string Comments
        {
            get { return data[4]; }
            set { data[4] = value; }
        }
    }

}
