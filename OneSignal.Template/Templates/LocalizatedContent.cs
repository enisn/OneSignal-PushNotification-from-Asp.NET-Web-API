using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneSignal.Template.Templates
{
    public class LocalizatedContent : Dictionary<string,string>
    {
        public LocalizatedContent()
        {

        }
        public LocalizatedContent(string _en, string _tr = null)
        {
            this.Add("en", _en);
            this.Add("tr", _tr);
        }
        public static implicit operator LocalizatedContent(string value)
        {
            return new LocalizatedContent(value);
        }
    }
}
