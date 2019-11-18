using System;
using System.Windows.Forms;
using System.IO;

namespace UebungenGrundkursPgmCSharp_WinForms_Aufg1
{
    public partial class Form_Aufgabe1 : Form
    {
        string filename = "C:\\Temp\\Inhalt.txt";

        public Form_Aufgabe1()
        {
            InitializeComponent();

            Btn_read.Width = 349;
            Btn_read.Height = 56;
            Btn_read.Left = 45;
            Btn_read.Top = 104;
            Btn_read.BackColor = System.Drawing.Color.GreenYellow;

            Btn_clear.Width = 349;
            Btn_clear.Height = 56;
            Btn_clear.Left = 413;
            Btn_clear.Top = 104;
            Btn_clear.BackColor = System.Drawing.Color.Blue;

        }
 //   }

        private void Btn_Read_Click(object sender, EventArgs e)
        {
            int[] eingaben = new int[100];       //
            string ausgabe = "";

            if (!(File.Exists(filename)))
            {
                MessageBox.Show("Datei nicht gefunden !");
            }
            else
            {
                // Aus der Datei lesen        
                System.IO.FileStream lesen = new System.IO.FileStream(filename, System.IO.FileMode.Open);
                
                int i = 0;                          // 
                eingaben[0] = 0;
                do
                {
                    if (eingaben[i] != -1)
                    {
                        eingaben[i] = lesen.ReadByte();
                        ausgabe += (char)eingaben[i]; 
                    }
                    i++;
                }
                while (eingaben[i-1] != -1); 
                lesen.Close();
                TBx_file.Text = ausgabe;
            }
        }

        private void Btn_clear_Click(object sender, EventArgs e)
        {
            TBx_file.Text = "";
        }

        private void Btn_copy_Click(object sender, EventArgs e)
        {
            string[] kopien;
            string kopiename = "C:\\Temp\\" + TBx_Kopie.Text + ".txt";
            if (File.Exists(kopiename)) { File.Delete(kopiename); }
            File.Copy(filename, kopiename);
            if (File.Exists(kopiename) && TBx_Kopie.Text != "")
            {
                kopien = File.ReadAllLines(kopiename);
                foreach (string s in kopien)
                {
                    Console.WriteLine(s);
                }
                MessageBox.Show("Der Inhalt wurde in die Datei " + kopiename + " kopiert.");
            }
            else
            {
                MessageBox.Show("ERROR: Datei " + kopiename + " konnte nicht erstellt werden!");
            }
        }

        private void Btn_Verschl_Click(object sender, EventArgs e)
        {
            int anz = 100;
            int[] eingaben = new int[anz];       //
            int[] verschl = new int[anz];
            string ausgabe = "";

            if (!(File.Exists(filename)))
            {
                MessageBox.Show("Datei nicht gefunden !");
            }
            else
            {
                // Aus der Datei lesen        
                System.IO.FileStream lesen = new System.IO.FileStream(filename, System.IO.FileMode.Open);
                int len = 0;
                for (int i = 1; eingaben[i-1] != -1; i++)
                {
                    eingaben[i] = lesen.ReadByte();
                    verschl[i] = eingaben[i] + 1;      // Die Verschlüsselung
                    ausgabe += (char)(verschl[i]/*eingaben[i]*/);
                    len = i;
                }
                
                lesen.Close();
                TBx_file.Text = ausgabe;
                string fileverschl = "C:\\Temp\\Verschluessel.txt";

                // Den verschlüsselten Text speichern
                System.IO.FileStream schreiben = new System.IO.FileStream
                    (fileverschl, System.IO.FileMode.Create);
                for (int i = 1; i < len; i++)
                {
                    schreiben.WriteByte(Convert.ToByte(verschl[i]));
                }
                schreiben.Close();
                if (File.Exists(fileverschl))
                {
                    MessageBox.Show("Die Verschlüsselung wurde kopiert !");
                }
                else
                {
                    MessageBox.Show("ERROR: Verschlüsselung wurde nicht gespeichert !");
                }
            }
        }
    }
}
