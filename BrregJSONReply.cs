using System;
using System.Collections.Generic;

public class BrregJSONReply
{
    public string Organisasjonsnummer { get; set; }
    public string Navn { get; set; }
    public Organisasjonsform Organisasjonsform { get; set; }
    public string Hjemmeside { get; set; }
    public string RegistreringsdatoEnhetsregisteret { get; set; }
    public bool RegistrertIMvaregisteret { get; set; }
    public Naeringskode1 Naeringskode1 { get; set; }
    public bool HarRegistrertAntallAnsatte { get; set; }
    public string RegistreringsdatoMerverdiavgiftsregisteret { get; set; }
    public string RegistreringsdatoMerverdiavgiftsregisteretEnhetsregisteret { get; set; }
    public string RegistreringsdatoAntallAnsatteEnhetsregisteret { get; set; }
    public string RegistreringsdatoAntallAnsatteNAVAaregisteret { get; set; }
    public string Telefon { get; set; }
    public string Mobil { get; set; }
    public Forretningsadresse Forretningsadresse { get; set; }
    public string Stiftelsesdato { get; set; }
    public InstitusjonellSektorkode InstitusjonellSektorkode { get; set; }
    public bool RegistrertIForetaksregisteret { get; set; }
    public bool RegistrertIStiftelsesregisteret { get; set; }
    public bool RegistrertIFrivillighetsregisteret { get; set; }
    public string SisteInnsendteAarsregnskap { get; set; }
    public bool Konkurs { get; set; }
    public bool UnderAvvikling { get; set; }
    public bool UnderTvangsavviklingEllerTvangsopplosning { get; set; }
    public string Maalform { get; set; }
    public string Vedtektsdato { get; set; }
    public List<string> VedtektsfestetFormaal { get; set; }
    public List<string> Aktivitet { get; set; }
    public string RegistreringsdatoForetaksregisteret { get; set; }
    public bool RegistrertIPartiregisteret { get; set; }
    public Links Links { get; set; }
    public string Konkursdato { get; set; }
}