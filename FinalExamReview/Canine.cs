using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExamReview
{
    public class Canine
    {
        private char _hairLength;


        public char HairLength 
        { 
            get { return _hairLength; }
            set { _hairLength = char.ToUpper(value); } 
        }

        public string HairLengthAsString
        {
            get
            {
                switch (_hairLength)
                {
                    case 'S':
                        return "Short";
                    case 'M':
                        return "Medium";
                    case 'L':
                        return "Long";
                    default:
                        return "Not Defined!";
                }
            }
            set
            {

                if (value.Contains("short"))
                {
                    this._hairLength = 'S';
                }
                else if (value.Contains("Medium"))
                {
                    this._hairLength = 'M';
                }
                else
                {
                    this._hairLength = 'L';
                }
            }
        }


        public string Breed { get; set; }
        public DateTime Birthdate { get; set; }
        public string Name { get; set; }

        private string size;

        public void SetSize(string size)
        {
            this.size = size;
        }

        public string GetSize()
        {
            return this.size;
        }
     
    }
}
