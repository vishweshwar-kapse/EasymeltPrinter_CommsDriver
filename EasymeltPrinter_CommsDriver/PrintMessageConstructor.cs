using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasymeltPrinter_CommsDriver
{
    public static class PrintMessageConstructor
    {
        public static string GetMessageForFileNameToPrinter(string FileName)
        {
            string[] splutString = FileName.Split('.');
            if (splutString.LastOrDefault() != "txb")
            {
                FileName += FileName + ".txb";
            }
            return "#LT=" + FileName;
        }

        public static string GetMessageForKeyValuePairs(List<TxbFileConfiguration> config)
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat("$MPCont={0}\t{1}", config[0].IdName,config[0].IdValue);
            for (int i = 1; i < config.Count; i++)
            {
                result.AppendFormat("\t{0}\t{1}",config[i].IdName,config[i].IdValue);
            }
            return result.ToString();
        }
    }
}
