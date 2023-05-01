using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections.ObjectModel;

namespace BF_Tag_Alarmtool
{
    public partial class Form1 : Form
    {
        Einsätze dtsEinsätze = new Einsätze();
        ObservableCollection<Einsatz> listEinsätze = new ObservableCollection<Einsatz>();
        string applicationPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Berufsfeuerwehrtag\\";

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
            System.IO.Directory.CreateDirectory(applicationPath);
            try
            {
                einsätze.ReadXml(applicationPath + "\\Data.xml");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void Form1_Close(object sender, FormClosingEventArgs e)
        {
            einsätze.WriteXml(applicationPath + "\\Data.xml");
        }

        private void BtNeuerEinsatz_Click(object sender, EventArgs e)
        {
            string apiKey = tbApiKey.Text;
            string einsatzstichwort = cbEinsatzstichwort.Text;
            DateTime einsatzbeginn = dtpEinsatzbeginn.Value;
            string sachverhalt = tbSachverhalt.Text;
            string adresse = tbAdresse.Text;
            int.TryParse(tbEinsatznummer.Text, out int einsatznummer);
            string alarmdurchsage = tbAlarmdurchsage.Text;

            if (apiKey == "" || einsatzstichwort == "" || adresse == "" || apiKey == "" || einsatzbeginn < System.DateTime.Now)
            {
                MessageBox.Show("Ungültige Eingabe. Die Felder ApiKey, Einsatzstichwort, Adresse und Einsatzbeginn sind erforderlich.  Der Einsatzbeginn muss in der Zukunft liegen", "Fehler");
                return;
            }

            DataRow einsatzRow = einsätze.tblEinsätze.NewRow();
            einsatzRow[1] = apiKey;
            einsatzRow[2] = einsatzbeginn;
            einsatzRow[3] = einsatznummer;
            einsatzRow[4] = einsatzstichwort;
            einsatzRow[5] = adresse;
            einsatzRow[6] = sachverhalt;
            einsatzRow[7] = false;
            einsatzRow[8] = alarmdurchsage;

            einsätze.tblEinsätze.Rows.Add(einsatzRow);
        }

        private bool alarm(Einsatz einsatz)
        {
            string einsatzUploadPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\EinsatzUpload\\EinsatzUpload.exe";
            string parameters = "-K " + einsatz.ApiKey + " -S \"" + einsatz.Einsatzstichwort + "\" -A \"" + einsatz.Adresse + "\" -F \"" + einsatz.Sachverhalt + "\" -E \"" + einsatz.Einsatznummer + "\" -R \"" + "BF-TAG ALARMTOOL JUGENDFEUERWEHR\"";
            Console.WriteLine(parameters);
            try
            {
                Console.WriteLine("Einsatzalarm: " + einsatz.Einsatzstichwort + " * " + einsatz.Einsatzbeginn.ToString());
                System.Diagnostics.Process.Start(einsatzUploadPath, parameters);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //EinsatzUpload braucht ein paar Sekunden. Dient zur synchronisierung von Durchsage und Connect-Alarm.
            Thread.Sleep(2000);

            try
            {
                
                SoundPlayer player = new SoundPlayer();
                player.SoundLocation = einsatz.Alarmdurchsage;
                player.Play();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return true;
        }

        private void BtSearch_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = ".wav-Audiofiles (*.wav)|*.wav";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    tbAlarmdurchsage.Text = filePath;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = ".wav-Audiofiles (*.wav)|*.wav";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    textBox5.Text = filePath;

                }
            }
        }

        private void BtAlarm_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Soll der Einsatz wirklich jetzt alarmiert werden?", "Sicher?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DataRow foundRow = einsätze.tblEinsätze.Select("EinsatzId = " + tbEinsatzId.Text).FirstOrDefault();
                Einsatz einsatz = new Einsatz(foundRow.ItemArray.GetValue(1).ToString(), DateTime.Parse(foundRow.ItemArray.GetValue(2).ToString()), int.Parse(foundRow[3].ToString()), foundRow[4].ToString(), foundRow[5].ToString(), foundRow[6].ToString(), bool.Parse(foundRow[7].ToString()), foundRow[8].ToString(), int.Parse(foundRow[0].ToString()));
                foundRow[7] = true;
                alarm(einsatz);

            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            listEinsätze.Clear();
            foreach (DataRow row in einsätze.tblEinsätze.Rows)
            {
                Einsatz einsatz = new Einsatz(row.ItemArray.GetValue(1).ToString(), DateTime.Parse(row.ItemArray.GetValue(2).ToString()), int.Parse(row[3].ToString()), row[4].ToString(), row[5].ToString(), row[6].ToString(), bool.Parse(row[7].ToString()), row[8].ToString(), int.Parse(row[0].ToString()));
                Console.WriteLine(einsatz.isAlarmiert);
                listEinsätze.Add(einsatz);
            }
            foreach (Einsatz einsatz in listEinsätze)
            {
                TimeSpan ts = System.DateTime.Now - einsatz.Einsatzbeginn;
                if (einsatz.Einsatzbeginn < System.DateTime.Now & einsatz.isAlarmiert == false & ts.TotalMinutes < 5)
                {
                    einsatz.isAlarmiert = true;
                    DataRow foundRow = einsätze.tblEinsätze.Select("EinsatzId = " + einsatz.EinsatzId).FirstOrDefault();
                    foundRow[7] = true;

                    alarm(einsatz);

                    Console.WriteLine("ALARM: " + einsatz.Einsatzstichwort + "  -  " + einsatz.Einsatzbeginn.ToShortTimeString());


                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version 2023.04.30 - Entwickelt von: M. Jökel");
        }
    }
}
