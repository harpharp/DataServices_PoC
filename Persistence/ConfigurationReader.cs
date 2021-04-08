using System.Xml.Linq;

namespace Persistence
{
    class ConfigurationReader
    {
        private XElement xml;

        public ConfigurationReader()
        {

        }
        public void LoadXML(string fileURL)
        {
            xml = XElement.Load(fileURL);
        }

        public string ReadFromFile(string elementToRead)
        {
            return xml.Element(elementToRead).Value;
        }
    }
}