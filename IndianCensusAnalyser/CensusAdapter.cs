using IndianCensusAnalyser.POCO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace IndianCensusAnalyser
{
     public abstract class CensusAdapter
    {

        /// <summary>
        /// Loads the census data.
        /// </summary>
        /// <param name="csvFilePath">The CSV file path.</param>
        /// <param name="dataHeader">The data header.</param>
        /// <returns></returns>
        /// <exception cref="Indian_StatesCensusAnalyser.CensusAnalyserException">File contains wrong delemiter</exception>

        protected string[] GetCensusData(string csvfilePath, string dataHeaders)
        {
            string[] censusData;
            if (!File.Exists(csvfilePath))
            {
                throw new CensusAnalyserException
                    ("File not found", CensusAnalyserException.ExceptionType.FILE_NOT_FOUND);
            }
            if (Path.GetExtension(csvfilePath) != ".csv")
            {
                throw new CensusAnalyserException("Invalid file type",
                    CensusAnalyserException.ExceptionType.INVALID_FILE_TYPE);
            }
            censusData = File.ReadAllLines(csvfilePath);
            if (censusData[0] != dataHeaders)
            {
                throw new CensusAnalyserException("Incorrect header in data",
                    CensusAnalyserException.ExceptionType.INCORRECT_HEADRER);

            }
            return censusData;
        }
    }
}