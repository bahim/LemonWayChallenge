using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace ChallengeLib
{
    public class XmlConverter
    {
        public string ConvertToJson(string xml)
        {
            var doc = new XmlDocument();
            doc.LoadXml(xml);

            return JsonConvert.SerializeXmlNode(doc);
        }
    }
}
