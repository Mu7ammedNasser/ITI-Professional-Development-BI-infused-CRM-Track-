using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab05
{
    enum NICType {
        Ethernet,
        tokenRing
    }
    internal class NIC
    {
        public string? Manufacture { get; set; }
        public string? MacAddress { get; set; }
        public NICType Type { get; set; }

        private NIC()
        {
            Manufacture = "google";
            MacAddress = "0x4513545343";
            Type = NICType.Ethernet;
        }

        private NIC(string? manufacture, string? macAddress, NICType type)
        {
            Manufacture = manufacture;
            MacAddress = macAddress;
            Type = type;

        }

        public override string ToString()
        {
            return $"Manufacture:{Manufacture},MacAddress{MacAddress} , NICType{Type} ";
        }

        public static readonly NIC nIC = new NIC();

    }
}
