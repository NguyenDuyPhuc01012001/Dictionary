using System;

namespace Từ_điển
{
    public class DictionaryData
    {
        public string Key { get; set; }
        public string Explanation { get; set; }

        public override string ToString()
        {
            //Not adding below 2 lines might throw OutOfMemoryException in listbox.Items.Add or listbox.DataSOurce = somelist
            if (string.IsNullOrEmpty(Explanation)) //Added this check to avoid 
                return this.GetType().Name; //Return string.Empty or something other than null else you will get OutOfMemoryException error when you add or bind this object to listbox
            return Key+"\r\n"+Explanation;
        }
    }
}
