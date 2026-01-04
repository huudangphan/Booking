using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Entity.Package.Package
{
    public class ContentGNB
    {
        public string Title { get; set; }
        public int SortOrder { get; set; }
        public List<SubContent> SubContents { get; set; }
        public List<Country> Countries { get; set; }
    }

    public class GNBModel
    {
        public string SiteType { get; set; }
        public string DevicdType { get; set; }
        public string GnbType { get; set; }
        public List<ContentGNB> Contents { get; set; }
    }

    public class Country
    {
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public string GnbItemType { get; set; }
        public string CountryUnique { get; set; }
        public string ThemeId { get; set; }
        public List<AreaGNB> area { get; set; }
    }
    public class AreaGNB
    {
        public string Name { get; set; }
        public int SortOrder { get; set; }
        public string GnbItemType { get; set; }
        public string CountryUnique { get; set; }
        public string AreaUnique { get; set; }
        public string ThemeId { get; set; }
        public string AreaKeyWordId { get; set; }
        public string WebTempleteId { get; set; }
    }

    public class SubContent
    {
        public string GnbName { get; set; }
        public int SortOrder { get; set; }
        public string Uri { get; set; }
        public string ItemType { get; set; }
    }
}
