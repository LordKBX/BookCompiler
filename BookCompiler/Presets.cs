using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookCompiler
{
    public class Preset
    {
        public string Name { get; set; } = "";
        public string IndexTitle { get; set; } = "";
        public string IndexParent { get; set; } = "";
        public string IndexObject { get; set; } = "";
        public string IndexObjectRegex { get; set; } = "";
        public string IndexTemplateName { get; set; } = "";
        public string IndexTemplateLink { get; set; } = "";
        public bool IndexOrderDescendent { get; set; } = false;

        public string PageParent { get; set; } = "";
        public string PageExcluded { get; set; } = "";
        public bool PageProtected { get; set; } = false;

        override public string ToString() { return Name; }
    }
}
