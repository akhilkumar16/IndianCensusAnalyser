using System;
using System.Collections.Generic;
using System.Text;

namespace IndianCensusAnalyser.POCO
{
    class StateCodeDAO
    {
        public int serialNumber;
        public string stateName;
        public int tin;
        public string stateCode;

        public StateCodeDAO(string V1, string V2, string V3, string v4)
        {
            this.serialNumber = Convert.ToInt32(V1);
            this.stateName = V2;
            this.tin = Convert.ToInt32(V3);
            this.stateCode = v4;
        }

    }
}