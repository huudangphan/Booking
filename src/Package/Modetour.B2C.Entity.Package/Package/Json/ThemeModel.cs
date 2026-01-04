using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.Package.Json
{
    public class ThemeModel
    {
        public List<Theme> theme { get; set; }
    }

    public class Theme
    {
        public string themeId { get; set; }
        public string themeName { get; set; }
        public List<string> productMasterCodeIds { get; set; }
    }

}