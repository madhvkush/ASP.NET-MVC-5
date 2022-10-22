using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Xml;
using System.Xml.Serialization;

namespace NonAction_ChilActionOnly.BusinessCalculation
{
    public class BusinessCalculation
    {
        /// <summary>
        /// Serializes an object to an XML string
        /// </summary>
        /// <param name="AnObject">The Object to serialize</param>
        /// <returns>XML string</returns>
        public static string SerializeAnObjectToXML(object AnObject)
        {
            XmlSerializer Xml_Serializer = new XmlSerializer(AnObject.GetType());
            StringWriter Writer = new StringWriter();

            Xml_Serializer.Serialize(Writer, AnObject);
            return Writer.ToString();
        }

        /// <summary>
        /// DeSerialize an object
        /// </summary>
        /// <param name="XmlOfAnObject">The XML string</param>
        /// <param name="ObjectType">The type of object</param>
        /// <returns>A deserialized object...must be cast to correct type</returns>
        public static Object DeSerializeAnObjectFromXML(string XmlOfAnObject, Type ObjectType)
        {
            StringReader StrReader = new StringReader(XmlOfAnObject);
            XmlSerializer Xml_Serializer = new XmlSerializer(ObjectType);
            XmlTextReader XmlReader = new XmlTextReader(StrReader);
            try
            {
                Object AnObject = Xml_Serializer.Deserialize(XmlReader);
                return AnObject;
            }
            finally
            {
                XmlReader.Close();
                StrReader.Close();
            }
        }

        /// <summary>
        /// <para>Convert XML to Json </para>
        /// </summary>
        /// <param name="XmlString">xml string</param>
        /// <returns></returns>
        public static string XMLToJson(string XmlString)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(XmlString);
            string jsonText = Newtonsoft.Json.JsonConvert.SerializeXmlNode(doc);
            return jsonText;
        }

        /// <summary>
        /// <para>Convert Json to XML</para>
        /// </summary>
        /// <param name="JsonText">Json Text string</param>
        /// <returns></returns>
        public static string JsonToXml(string JsonText)
        {
            XmlDocument xmlDoc = Newtonsoft.Json.JsonConvert.DeserializeXmlNode(JsonText);

            using (var stringWriter = new StringWriter())
            using (var xmlTextWriter = XmlWriter.Create(stringWriter))
            {
                xmlDoc.WriteTo(xmlTextWriter);
                xmlTextWriter.Flush();
                return stringWriter.GetStringBuilder().ToString();
            }
        }
    }
}