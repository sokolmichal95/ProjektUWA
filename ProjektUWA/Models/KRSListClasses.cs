﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace ProjektUWA.Models
{
    public class Rootobject
    {
        public ObservableCollection<Dataobject> Dataobject { get; set; }
        public int Count { get; set; }
        public int Took { get; set; }
        public Links Links { get; set; }
    }

    public class Links
    {
        public string self { get; set; }
        public string first { get; set; }
        public string prev { get; set; }
        public string next { get; set; }
        public string last { get; set; }
    }

    public class Dataobject
    {
        public string id { get; set; }
        public string dataset { get; set; }
        public string url { get; set; }
        public string mp_url { get; set; }
        public string schema_url { get; set; }
        public string global_id { get; set; }
        public string slug { get; set; }
        public object score { get; set; }
        public Data data { get; set; }
    }

    public class Data
    {
        [JsonProperty("krs_podmioty.nazwa_organu_reprezentacji")]
        public string krs_podmiotynazwa_organu_reprezentacji { get; set; }
        [JsonProperty("krs_podmioty.dotacje_ue_beneficjent_id")]
        public string krs_podmiotydotacje_ue_beneficjent_id { get; set; }
        [JsonProperty("krs_podmioty.liczba_prokurentow")]
        public int krs_podmiotyliczba_prokurentow { get; set; }
        public string krs_podmiotyoznaczenie_sadu { get; set; }
        [JsonProperty("krs_podmioty.regon")]
        public string krs_podmiotyregon { get; set; }
        [JsonProperty("krs_podmioty.adres_kod_pocztowy")]
        public string krs_podmiotyadres_kod_pocztowy { get; set; }
        public string krs_podmiotyopp { get; set; }
        public string krs_podmiotyforma_prawna_str { get; set; }
        public int krs_podmiotyliczba_zmian_umow { get; set; }
        public int krs_podmiotyliczba_dzialalnosci { get; set; }
        public string krs_podmiotysiedziba { get; set; }
        public string krs_podmiotygpw_spolka_id { get; set; }
        public int krs_podmiotynumer_wpisu { get; set; }
        [JsonProperty("krs_podmioty.adres_ulica")]
        public string krs_podmiotyadres_ulica { get; set; }
        public string krs_podmiotyforma_prawna_typ_id { get; set; }
        [JsonProperty("krs_podmioty.adres_lokal")]
        public string krs_podmiotyadres_lokal { get; set; }
        public string krs_podmiotyrejestr { get; set; }
        public string krs_podmiotyforma_prawna_id { get; set; }
        [JsonProperty("krs_podmioty.firma")]
        public string krs_podmiotyfirma { get; set; }
        public string krs_podmiotyknf_ostrzezenie_id { get; set; }
        [JsonProperty("krs_podmioty.liczba_wspolnikow")]
        public int krs_podmiotyliczba_wspolnikow { get; set; }
        public int krs_podmiotywartosc_nominalna_podwyzszenia_kapitalu { get; set; }
        [JsonProperty("krs_podmioty.adres_poczta")]
        public string krs_podmiotyadres_poczta { get; set; }
        [JsonProperty("krs_podmioty.wartosc_nominalna_akcji")]
        public int krs_podmiotywartosc_nominalna_akcji { get; set; }
        [JsonProperty("krs_podmioty.data_dokonania_wpisu")]
        public string krs_podmiotydata_dokonania_wpisu { get; set; }
        [JsonProperty("krs_podmioty.liczba_emisji_akcji")]
        public int krs_podmiotyliczba_emisji_akcji { get; set; }
        public string krs_podmiotysygnatura_akt { get; set; }
        [JsonProperty("krs_podmioty.data_rejestracji")]
        public string krs_podmiotydata_rejestracji { get; set; }
        public int krs_podmiotyliczba_zmian { get; set; }
        public string krs_podmiotyadres_numer { get; set; }
        public string krs_podmiotyumowa_spolki_cywilnej { get; set; }
        public string krs_podmiotynazwa_organu_nadzoru { get; set; }
        public string krs_podmiotywykreslony { get; set; }
        public int krs_podmiotywartosc_czesc_kapitalu_wplaconego { get; set; }
        [JsonProperty("krs_podmioty.krs")]
        public string krs_podmiotykrs { get; set; }
        [JsonProperty("krs_podmioty.email")]
        public string krs_podmiotyemail { get; set; }
        public int krs_podmiotyliczba_akcji_wszystkich_emisji { get; set; }
        public DateTime krs_podmiotydata_sprawdzenia { get; set; }
        public int krs_podmiotyliczba_reprezentantow { get; set; }
        public string krs_podmiotytwitter_account_id { get; set; }
        public string krs_podmiotysposob_reprezentacji { get; set; }
        public string krs_podmiotywczesniejsza_rejestracja_str { get; set; }
        public string krs_podmiotywww { get; set; }
        public string krs_podmiotyostatni_wpis_id { get; set; }
        public int krs_podmiotywartosc_kapital_docelowy { get; set; }
        public string krs_podmiotyid { get; set; }
        public string krs_podmiotycel_dzialania { get; set; }
        public int krs_podmiotyliczba_jedynych_akcjonariuszy { get; set; }
        public int krs_podmiotyliczba_nadzorcow { get; set; }
        public string krs_podmiotyadres_miejscowosc { get; set; }
        //
        [JsonProperty("krs_podmioty.nazwa")]
        public string krs_podmiotynazwa { get; set; }
        //
        [JsonProperty("krs_podmioty.adres_kraj")]
        public string krs_podmiotyadres_kraj { get; set; }
        public string krs_podmiotygmina_id { get; set; }
        public string krs_podmiotymiejscowosc_id { get; set; }
        [JsonProperty("krs_podmioty.adres")]
        public string krs_podmiotyadres { get; set; }
        public string krs_podmiotyrejestr_stowarzyszen { get; set; }
        public string krs_podmiotypowiat_id { get; set; }
        public int krs_podmiotywartosc_kapital_zakladowy { get; set; }
        public string krs_podmiotykod_pocztowy_id { get; set; }
        public string krs_podmiotywojewodztwo_id { get; set; }
        public string krs_podmiotynieprzedsiebiorca { get; set; }
        public int krs_podmiotyliczba_czlonkow_komitetu_zal { get; set; }
        public string krs_podmiotynazwa_skrocona { get; set; }
        [JsonProperty("krs_podmioty.liczba_oddzialow")]
        public int krs_podmiotyliczba_oddzialow { get; set; }
        [JsonProperty("krs_podmioty.nip")]
        public string krs_podmiotynip { get; set; }
    }
}
