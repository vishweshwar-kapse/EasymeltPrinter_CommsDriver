using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasymeltPrinter_CommsDriver
{
    public class PrinterConfiguration
    {
        public string IpAddress { get; set; }
        public int PortNumber { get; set; }
        public List<LableFileConfiguration> LabelFileCollection { get; set; } = new List<LableFileConfiguration>();

        public bool ContainsFilename(string fileName)
        {
            return LabelFileCollection.Any(x => x.TxbFileName == fileName);
        }

        public LableFileConfiguration GetConfigForFile(string fileName)
        {
            return LabelFileCollection.Where(x => x.TxbFileName == fileName).FirstOrDefault();
        }

        public void AddFileConfiguration(LableFileConfiguration currentConfig)
        {
            var existingFileConfig = LabelFileCollection.Where(x => x.TxbFileName == currentConfig.TxbFileName).FirstOrDefault();
            if (existingFileConfig != null)
            {
                existingFileConfig.FileConfiguration = currentConfig.FileConfiguration;
            }
            else
            {
                LabelFileCollection.Add(currentConfig);
            }
        }
    }

    public class LableFileConfiguration
    {
        public string TxbFileName { get; set; }
        public BindingList<TxbFileConfiguration> FileConfiguration { get; set; } = new BindingList<TxbFileConfiguration>();

        public void AddConfiguration(string idName, string IdValue)
        {
            if (string.IsNullOrWhiteSpace(idName))
            {
                throw new ArgumentException("IdName can not be empty");
            }
            if (string.IsNullOrWhiteSpace(IdValue))
            {
                throw new ArgumentException("IdValue can not be empty");
            }

            var existingConfig = FileConfiguration.Where(x => x.IdName == idName).FirstOrDefault();
            if (existingConfig != null)
            {
                existingConfig.IdValue = IdValue;
            }
            else
            {
                TxbFileConfiguration configuration = new TxbFileConfiguration();
                configuration.IdName = idName;
                configuration.IdValue = IdValue;

                FileConfiguration.Add(configuration);
            }
        }

        public void RemoveConfiguration(string idName)
        {
           var currentConfig = FileConfiguration.Where(x => x.IdName == idName).FirstOrDefault();
            if (currentConfig != null)
            {
                FileConfiguration.Remove(currentConfig);
            }
        }

        public override string ToString()
        {
            return TxbFileName;
        }
    }

    public class TxbFileConfiguration
    {
        public string IdName { get; set; }
        public string IdValue { get; set; }
    }

}
