using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Modetour.B2C.Commons.Helper.Interface
{
    public class NetworkHelper : INetworkHelper
    {
        public string GetLocalIPAddress()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("No network adapters with an IPv4 address in the system!");
        }
        public string GetDomainName()
        {
            string _domain = IPGlobalProperties.GetIPGlobalProperties()?.DomainName ?? "";
            Ping ping = new Ping();
            try
            {
                if (!string.IsNullOrEmpty(_domain))
                {
                    PingReply reply = ping.Send(_domain);

                    if (reply.Status == IPStatus.Success)
                    {
                        return _domain;
                    }
                    else
                    {
                        return reply.Status.ToString();
                    }
                }
            }
            catch (PingException pExp)
            {
                if (pExp.InnerException.ToString() == "No such host is known")
                {
                    return "Network not detected!";
                }

                return "Ping Exception";
            }
            return "";
        }
    }
}
