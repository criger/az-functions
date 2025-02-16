using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Forretningsadresse
{
    public string Land { get; set; }
    public string Landkode { get; set; }
    public string Postnummer { get; set; }
    public string Poststed { get; set; }
    public List<string> Adresse { get; set; }
    public string Kommune { get; set; }
    public string Kommunenummer { get; set; }
}
