using System;
using System.Collections.Generic;
using System.Text;
using IndianCensusAnalyser.POCO;
using Newtonsoft.Json;

namespace IndianCensusAnalyser
{
    public class CsvAdaptorFactory
    {
        public Dictionary<string, CensusDTO> LoadCsvData(CensusAnalyser.
            Country country, string csvFilePath,
           string dataheaders)
        {
            if (string.IsNullOrEmpty(csvFilePath))
            {
                throw new ArgumentException($"'{nameof(csvFilePath)}' cannot be null or empty.", nameof(csvFilePath));
            }

            if (string.IsNullOrEmpty(dataheaders))
            {
                throw new ArgumentException($"'{nameof(dataheaders)}' cannot be null or empty.", nameof(dataheaders));
            }

            switch (country)
            {
                case (CensusAnalyser.Country.INDIA):
                    return new IndianCensusAdapter().LoadCensusData(csvFilePath, dataheaders);
                ////case (CensusAnalyser.Country.US):
                ////    return new USCensusAdapter().LoadUSCensusData(csvFilePath, dataheaders);
                default:
                    return new Dictionary<string, CensusDTO>();
                    //throw new CensusAnalyserException("No such country",
                    //    CensusAnalyserException.ExceptionType.NO_SUCH_COUNTRY);
            }


        }
    }
}

