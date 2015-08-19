

using System.Xml.Serialization;
using System.IO;
using System;public class XMLHelper  {

	/* converts a plain object to xml */

	public static string ObjectToXML(object toSerialize)
	{
		XmlSerializer xmlSerializer = new XmlSerializer(toSerialize.GetType());
		
		using(StringWriter textWriter = new StringWriter())
		{
			xmlSerializer.Serialize(textWriter, toSerialize);
			return textWriter.ToString();
		}
	}

	/* converts a xml to object */
	
	public static T XmlDeserializeFromString<T>( string objectData)
	{
		var serializer = new XmlSerializer(typeof(T));

		using (TextReader reader = new StringReader(objectData))
		{
			return  (T)serializer.Deserialize(reader);
		}	
		 
	}
}
