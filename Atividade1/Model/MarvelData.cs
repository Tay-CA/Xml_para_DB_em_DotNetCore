using System;

namespace Atividade1.Model
{
    // Pega as informações do root do arquivo xml chamado marveldata
    [Serializable()]
    [System.Xml.Serialization.XmlRoot("marveldata")]
    public class MarvelData
    {

        [System.Xml.Serialization.XmlElement("item")]
        public MarvelDataItems[] Items { get; set; }
    }
}

