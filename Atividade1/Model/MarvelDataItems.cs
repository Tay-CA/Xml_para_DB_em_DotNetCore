using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace Atividade1.Model
{
    // Classe de mapeamento do xml
    [Serializable()]
    public class MarvelDataItems
    {
        [XmlElement("id")]
        public int Id { get; set; }

        [XmlElement("title")]
        public string Title { get; set; }

        [XmlElement("release_date")]
        public DateTime ReleaseDate { get; set; }
    }
}
