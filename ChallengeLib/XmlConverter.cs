using Newtonsoft.Json;
using System;
using System.Xml;

namespace ChallengeLib
{
    public class XmlConverter
    {
        public string ConvertToJson(string xml)
        {
            if (xml == null)
                throw new ArgumentNullException();

            var doc = new XmlDocument();
            doc.LoadXml(xml);

            return JsonConvert.SerializeXmlNode(doc);
        }
    }
}
