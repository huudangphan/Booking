using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Commons.Helper.Interface
{
    public interface INetworkHelper
    {
        public string GetDomainName();
        public string GetLocalIPAddress();
    }
}
