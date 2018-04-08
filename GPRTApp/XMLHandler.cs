using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPRTApp
{
    class XMLHandler
    {
        public void SaveToFile(Dictionary<string, DataSet> modules)
        {
            foreach (var module in modules)
            {
                var dataSource = module.Value;
                if (dataSource != null)
                {
                    dataSource.WriteXml(module.Key);
                }
            }
        }

        public Dictionary<string, DataSet> ReadFromFile()
        {
            var levelList = new Dictionary<string, DataSet>();

            var dataSetLevel4 = new DataSet();
            dataSetLevel4.ReadXmlSchema("schema.xsd");
            if (File.Exists("level4.xml"))
            {
                dataSetLevel4.ReadXml("level4.xml");
            }
            levelList["level4.xml"] = dataSetLevel4;

            var dataSetLevel5 = new DataSet();
            dataSetLevel5.ReadXmlSchema("schema.xsd");
            if (File.Exists("level4.xml"))
            {
                dataSetLevel5.ReadXml("level5.xml");
            }
            levelList["level5.xml"] = dataSetLevel5;

            var dataSetLevel6 = new DataSet();
            dataSetLevel6.ReadXmlSchema("schema.xsd");
            if (File.Exists("level4.xml"))
            {
                dataSetLevel6.ReadXml("level6.xml");
            }
            levelList["level6.xml"] = dataSetLevel6;

            return levelList;
        }
    }
}
