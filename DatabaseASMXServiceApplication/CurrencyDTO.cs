using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace DatabaseASMXServiceApplication
{
    [DataContract]
    public class CurrencyDTO
    {
        private string name;
        private string iso;
        private double exchangeRate;
        private int version;

        public CurrencyDTO(string name, string iso, double exchangeRate, int version)
        {
            this.name = name;
            this.iso = iso;
            this.exchangeRate = exchangeRate;
            this.version = version;
        }

        [DataMember]
        public int Version
        {
            get
            {
                return version;
            }
            set
            {
                version = value;
            }
        }

        [DataMember]
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        [DataMember]
        public string ISO
        {
            get
            {
                return iso;
            }
            set
            {
                iso = value;
            }
        }

        [DataMember]
        public double ExchangeRate
        {
            get
            {
                return exchangeRate;
            }
            set
            {
                exchangeRate = value;
            }
        }
    }

    
}