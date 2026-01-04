using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.Json
{
    public class NationModel
    {
        public string CreateDateTime { get; set; }
        public List<NationListModel> NationList { get; set; }
    }
    public class NationListModel
    {
        public string Continent { get; set; }
        public string Name { get; set; }
        public List<string> AreaCategory { get; set; }
        public List<RestrictionContentListModel> RestrictionContentList { get; set; }
    }
    public class RestrictionContentListModel
    {
        public string Title { get; set; }
        public string Contents { get; set; }

    }
}
