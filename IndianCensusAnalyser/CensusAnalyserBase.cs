namespace IndianCensusAnalyser.POCO
{
    public class CensusAnalyserBase
    {
        public Dictionary<string, CensusDTO> LoadCensusData(Country country, string csvFilePath,
            string dataHeaders)
        {
            dataMap = new CsvAdaptorFactory().LoadCsvData(country, csvFilePath, dataHeaders);
            return dataMap;
        }
    }
}