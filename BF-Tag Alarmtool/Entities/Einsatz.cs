using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BF_Tag_Alarmtool
{
    public class Einsatz
    {
        /// <summary>
        /// Die eindeutige ID des Einsatzes für die Datenbank
        /// </summary>
        public int EinsatzId { get; set; }

        /// <summary>
        /// Der API-Key zur öffentlichen Connect-Schnittstelle
        /// </summary>
        public string ApiKey { get; set; }

        /// <summary>
        /// Zeitpunkt, wann der Einsatz beginnt und alarmiert werden soll
        /// </summary>
        public DateTime Einsatzbeginn { get; set; }

        /// <summary>
        /// (Einsatznummer)
        /// nullable
        /// </summary>
        public int Einsatznummer { get; set; }

        /// <summary>
        /// Das Einsatzstichwort
        /// </summary>
        public string Einsatzstichwort { get; set; }

        /// <summary>
        /// Die Adresse
        /// </summary>
        public string Adresse { get; set; }

        /// <summary>
        /// Der Sachverhalt
        /// </summary>
        public string Sachverhalt { get; set; }

        /// <summary>
        /// Gibt an, ob der Einsatz schon an Connect zur Alarmierung übergeben wurde
        /// </summary>
        public bool isAlarmiert { get; set; }

        /// <summary>
        /// Der Dateipfad zur Alarmdurchsage im .wav-Format
        /// </summary>
        public string Alarmdurchsage { get; set; }

        /// <summary>
        /// Konstruktor für Klasse "Einsatz". Erstellt einen neuen Einsatz.
        /// </summary>
        /// <param name="apikey">Der API-Key zur öffentlichen Connect-Schnittstelle</param>
        /// <param name="Einsatzbeginn">Zeitpunkt, wann der Einsatz beginnt und alarmiert werden soll</param>
        /// <param name="einsatznummer">(Einsatznummer)</param>
        /// <param name="einsatzstichwort">Das Einsatzstichwort</param>
        /// <param name="adresse">Die Adresse</param>
        /// <param name="sachverhalt">Der Sachverhalt</param>
        public Einsatz(string apikey, DateTime einsatzbeginn, int einsatznummer, string einsatzstichwort, string adresse, string sachverhalt, bool isAlarmiert, string alarmdurchsage, int einsatzId)
        {
            this.ApiKey = apikey;
            this.Einsatzbeginn = einsatzbeginn;
            this.Einsatznummer = einsatznummer;
            this.Einsatzstichwort = einsatzstichwort;
            this.Adresse = adresse;
            this.Sachverhalt = sachverhalt;
            this.isAlarmiert = isAlarmiert;
            this.Alarmdurchsage = alarmdurchsage;
            this.EinsatzId = einsatzId;
        }
    }
}
