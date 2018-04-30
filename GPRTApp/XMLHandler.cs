using GPRTCommon;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace GPRTApp
{
    class XMLHandler
    {
        public void SaveToFile(Dictionary<string, DataSet> modules)
        {
            // Write to the file using seperate thread. 
            Thread t = new Thread(new ThreadStart(() => {
                foreach (var module in modules)
                {
                    var dataSource = module.Value;
                    if (dataSource != null)
                    {
                        dataSource.WriteXml(module.Key);
                    }
                }
            }));
            t.Start();
        }

        public void SaveAssesments(string fileName, List<Assesment> assesment)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(List<Assesment>));
            using (XmlWriter writer = XmlWriter.Create(fileName))
            {
                xsSubmit.Serialize(writer, assesment);
            }
        }

        public List<Assesment> ReadAssesments(string fileName)
        {
            XmlSerializer xsSubmit = new XmlSerializer(typeof(List<Assesment>));
            using (XmlReader reader = XmlReader.Create(fileName))
            {
                return (List<Assesment>) xsSubmit.Deserialize(reader);
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
