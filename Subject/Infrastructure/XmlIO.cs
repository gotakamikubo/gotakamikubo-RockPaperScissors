using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Text;

namespace Subject.Infrastructure
{
    class XmlIO
    {
        public bool Output(Domain.RockPaperScissorsState rockPaperScissorsState, string filePath)
        {
            System.Xml.Serialization.XmlSerializer serializer =
            new System.Xml.Serialization.XmlSerializer(typeof(Domain.RockPaperScissorsState));

            System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(filePath);

            serializer.Serialize(streamWriter, rockPaperScissorsState);

            streamWriter.Close();

            return true;
        }
    }
}
