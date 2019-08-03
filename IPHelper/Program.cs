using System;
using System.Net;

namespace IPHelper
{
    class Program
    {
        static void Main(string[] args)
        {
#pragma warning disable CS0618 // Type or member is obsolete
            var test = IPNetwork.Contains(network: IPNetwork.Parse("10.0.0.0/13"), ipaddress: IPAddress.Parse("10.60.243.136"));
#pragma warning restore CS0618 // Type or member is obsolete
            Console.WriteLine(test);

            //var ipnetwork2 = IPNetwork.Parse("10.0.96.0/21");
            //var ipnetwork = IPNetwork.Parse("10.0.0.0/13");
            //var ipaddress = IPAddress.Parse("100.118.42.155");
            //Console.WriteLine(IPNetwork.Contains(ipnetwork, ipnetwork2));

            //Console.WriteLine(ExpandedIPvFunction(GetBinaryFromIPAddressString("2a01:111:e400:503e::29")));
            //Console.WriteLine(ExpandedIPvFunction(GetBinaryFromIPAddressString("::")));

            ////var ip = IPNetwork.Parse();
            ////Console.WriteLine(ip);
            //var mask = ip.ToString().Split('/')[1];
            //Console.WriteLine(mask);
            //Console.WriteLine((IPNetwork.Contains(IPNetwork.Parse("10.16.0.0/13"), IPNetwork.Parse("10.16.0.0/16"))));
            //Console.WriteLine((IPNetwork.Contains(IPNetwork.Parse("10.16.0.0/13"), IPNetwork.Parse("10.16.0.0/22"))));
            //Console.WriteLine((IPNetwork.Contains(IPNetwork.Parse("10.16.0.0/13"), IPNetwork.Parse("10.16.0.0/23"))));
            //Console.WriteLine((IPNetwork.Contains(IPNetwork.Parse("10.16.0.0/13"), IPNetwork.Parse("10.16.0.0/27"))));

            //Console.WriteLine(500000 % 100000);

            //int onesComplement = ~Convert.ToInt32(binRep, 2);

            //var intAddress = BitConverter.ToUInt32(IPAddress.Parse("137.116.2.14").GetAddressBytes(), 0);
            ////var intAddress = 1000003880;
            ////var ipAddress = new IPAddress(BitConverter.GetBytes(intAddress)).ToString();
            //Console.WriteLine(intAddress);
            //Console.WriteLine(ipAddress);
            //bool test = (IPNetwork.Contains(IPNetwork.Parse("40.77.225.0/24"), IPNetwork.Parse("40.77.225.0/25")));
            //Console.WriteLine(test);

            //var ip = "10.13.112.85";
            //int mask = 20;
            //Console.WriteLine(IPNetwork.Parse(ip + "/" + mask));

            //var ipnetwork = IPNetwork.Parse("100.112.0.0/13");
            //var ipnetwork2 = IPNetwork.Parse("100.115.210.0/23");
            ////var ipaddress = IPAddress.Parse("100.118.42.155");
            //Console.WriteLine(IPNetwork.Contains(ipnetwork, ipnetwork2));
            //Console.WriteLine(IPNetwork.Contains(ipnetwork, ipaddress));
            //Console.WriteLine(IPNetwork.Contains(ipnetwork2, ipaddress));

            //Console.WriteLine(IPNetwork.Parse("137.116.2.14" + "/" + "27").Network.ToString() + "/" + "27");

            //var ipnetwork = IPNetwork.Parse("2a01:111:e400:503e::29");
            //Console.WriteLine("Network : {0}", ipnetwork.Network);
            //Console.WriteLine("Netmask : {0}", ipnetwork.Netmask);
            //Console.WriteLine("Broadcast : {0}", ipnetwork.Broadcast);
            //Console.WriteLine("FirstUsable : {0}", ipnetwork.FirstUsable);
            //Console.WriteLine("LastUsable : {0}", ipnetwork.LastUsable);
            //Console.WriteLine("Usable : {0}", ipnetwork.Usable);
            //Console.WriteLine("Cidr : {0}", ipnetwork.Cidr);

            //ipnetwork = IPNetwork.Parse("2001:0db8::/64");

            //var ipaddress = IPAddress.Parse("2001:0db8::1");
            //Console.WriteLine(ipaddress);
            //var ipaddress2 = IPAddress.Parse("2001:0db9::1");

            //var ipnetwork2 = IPNetwork.Parse("2001:0db8::1/128");
            //var ipnetwork3 = IPNetwork.Parse("2001:0db9::1/64");

            //var contains1 = IPNetwork.Contains(ipnetwork, ipaddress);
            //var contains2 = IPNetwork.Contains(ipnetwork, ipaddress2);
            //var contains3 = IPNetwork.Contains(ipnetwork, ipnetwork2);
            //var contains4 = IPNetwork.Contains(ipnetwork, ipnetwork3);

            //var overlap1 = IPNetwork.Overlap(ipnetwork, ipnetwork2);
            //var overlap2 = IPNetwork.Overlap(ipnetwork, ipnetwork3);

            //Console.WriteLine("{0} contains {1} : {2}", ipnetwork, ipaddress, contains1);
            //Console.WriteLine("{0} contains {1} : {2}", ipnetwork, ipaddress2, contains2);
            //Console.WriteLine("{0} contains {1} : {2}", ipnetwork, ipnetwork2, contains3);
            //Console.WriteLine("{0} contains {1} : {2}", ipnetwork, ipnetwork3, contains4);

            //Console.WriteLine("{0} overlap {1} : {2}", ipnetwork, ipnetwork2, overlap1);
            //Console.WriteLine("{0} overlap {1} : {2}", ipnetwork, ipnetwork3, overlap2);

            //var ipnetwork = IPNetwork.Parse("192.168.168.100/24");

            //Console.WriteLine("Network : {0}", ipnetwork.Network);
            //Console.WriteLine("Netmask : {0}", ipnetwork.Netmask);
            //Console.WriteLine("Broadcast : {0}", ipnetwork.Broadcast);
            //Console.WriteLine("FirstUsable : {0}", ipnetwork.FirstUsable);
            //Console.WriteLine("LastUsable : {0}", ipnetwork.LastUsable);
            //Console.WriteLine("Usable : {0}", ipnetwork.Usable);
            //Console.WriteLine("Cidr : {0}", ipnetwork.Cidr);

            //ipnetwork = IPNetwork.Parse("137.116.2.0/27");
            //ipaddress = IPAddress.Parse("137.116.2.14");
            //ipaddress2 = IPAddress.Parse("192.168.1.100");

            //ipnetwork2 = IPNetwork.Parse("192.168.0.128/25");
            //ipnetwork3 = IPNetwork.Parse("192.168.1.1/24");

            //contains1 = IPNetwork.Contains(ipnetwork, ipaddress);
            //contains2 = IPNetwork.Contains(ipnetwork, ipaddress2);
            //contains3 = IPNetwork.Contains(ipnetwork, ipnetwork2);
            //contains4 = IPNetwork.Contains(ipnetwork, ipnetwork3);

            //overlap1 = IPNetwork.Overlap(ipnetwork, ipnetwork2);
            //overlap2 = IPNetwork.Overlap(ipnetwork, ipnetwork3);

            //Console.WriteLine("{0} contains {1} : {2}", ipnetwork, ipaddress, contains1);
            //Console.WriteLine("{0} contains {1} : {2}", ipnetwork, ipaddress2, contains2);
            //Console.WriteLine("{0} contains {1} : {2}", ipnetwork, ipnetwork2, contains3);
            //Console.WriteLine("{0} contains {1} : {2}", ipnetwork, ipnetwork3, contains4);

            //Console.WriteLine("{0} overlap {1} : {2}", ipnetwork, ipnetwork2, overlap1);
            //Console.WriteLine("{0} overlap {1} : {2}", ipnetwork, ipnetwork3, overlap2);

            Console.Read();
        }

        public static uint ConvertIpToUint(string ip)
        {
            IPAddress ipAdd = IPAddress.Parse(ip);
            var octates = ipAdd.GetAddressBytes();
            var ipOut = (uint) ((octates[0] << 24) | (octates[1] << 16) | (octates[2] << 8) | (octates[3]));

            return ipOut;

        }

        private static bool validateForIPv6(string inputIPString)
        {
            System.Net.IPAddress ipAddress = default(System.Net.IPAddress);
            bool parsed = System.Net.IPAddress.TryParse(inputIPString, out ipAddress);
            if (parsed)
                parsed = ipAddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetworkV6;
            return parsed;
        }

        private static string ExpandedIPvFunction(byte[] bytes)
        {
            System.Text.StringBuilder bldr = new System.Text.StringBuilder();
            for (int i = 0; i < 16; i += 2)
            {
                bldr.AppendFormat("{0:x2}{1:x2}:", bytes[i], bytes[i + 1]);
            }
            bldr.Length = bldr.Length - 1; //last colon 
            String uncompressed = bldr.ToString();
            return uncompressed;
        }

        /// <summary>
        /// This stored procedure will returns decimal values for given IP address in two OUT parameters that is first four block 
        /// of IPv6 address in preIP variable(in case of IPv4, this is zero) and Last four block in postIp parameters
        /// </summary>
        /// <param name="ipAddress">Ip address (IPv4/IPv6) format</param>
        /// <param name="preip">Decimal value for Four block of IPv6 address/ 0 for IPv4 address </param>
        /// <param name="postIp">Decimal value for Four block of IPv6 address/ IPv4 address</param>
        public static Byte[] GetBinaryFromIPAddressString(String ipAddress)
        {
            byte[] res = new byte[16];
            //Is the input a valid IP Address?
            System.Net.IPAddress lobj = null;
            if (!System.Net.IPAddress.TryParse((string) ipAddress, out lobj))
            {
                Console.WriteLine("failed IPAddress.TryParse");
                return res;
            }
            //Get the bytes for the IP Address so we can convert them to numeric values.
            var ipres = lobj.GetAddressBytes();
            //little-endian machines store multi-byte integers with the 
            //least significant byte first. this is a problem, as integer 
            //values are sent over the network in big-endian mode. reversing 
            //the order of the bytes is a quick way to get the BitConverter 
            //methods to convert the byte arrays in big-endian mode.
            //if (System.BitConverter.IsLittleEndian)
            // Array.Reverse(ipres);
            Array.Copy(ipres, 0, res, 16 - ipres.Length, ipres.Length);
            return res;
        }

    }
}