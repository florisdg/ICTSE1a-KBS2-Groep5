﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualPiano.Control;
using VirtualPiano.View;

namespace VirtualPiano.Model
{
    public class Song
    {
        public List<Staff> Staffs { get; set; }

        public int FlatSharp;

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SongId { get; set; }
        public string Composer { get; set; }
        private string title = "titel";
        public string Title
        {
            get
            {
                if(title != "")
                {
                    return title;
                }
                else
                {
                    return "Geen titel";
                }
            }
            set
            {
                if (value != "")
                {
                    title = value;
                }
            }
        }
        public Song()
        {

                Staffs = new List<Staff>();
                Staffs.Add(new Staff());
            

        }

        public void AddStaff(Staff s)
        {
            Staffs.Add(s);
        }

        public List<Staff> GetStaffs()
        {
            return Staffs.ToList();
        }

        public bool IsEmpty()
        {
            bool isEmpty = true;
            foreach (var staff in Staffs)
            {
                if (!staff.IsEmtpy())
                {
                    isEmpty = false;
                }
            }
            return isEmpty;
        }

        public int getDuration()
        {
            int duration = 0;
            foreach (Staff staff in Staffs)
            {
                foreach (Bar bar in staff.Bars)
                {
                    duration = duration + bar.duration;
                }
            }
            return duration; // 1 maat is 16
        }

        public async void PlaySong()
        {
            for(int i = 0; i < Staffs.Count(); i++)
            {
                for(int b = 0; b <  Staffs[i].Bars.Count();b++)
                {
                    for(int c = 0; c< Staffs[i].Bars[b].Signs.Count();c++)
                    {
                        if(Staffs[i].Bars[b].Signs[c] is Note note&&MusicController.isPlayingSong)
                        {
                            note.PlaySound();
                            await PutTaskDelay(note.duration * 120);
                            
                        }

                        else if (Staffs[i].Bars[b].Signs[c] is Rest rest)
                        {
                            await PutTaskDelay(rest.duration * 120);

                        }
                    }
                }
            }
        }

        public void PlayNote()
        {
            foreach (var staff in Staffs)
            {
                if (staff.IsBeingPlayed)
                {
                    foreach (var bar in staff.Bars)
                    {
                        foreach (var sign in bar.Signs)
                        {
                            if (sign is Note note && note.x >= ComposeView.RedLineX + 63 && note.x <= ComposeView.RedLineX + 67)
                            {
                                note.PlaySound();
                            }
                        }
                    }
                }
            }
        }

        public void ChangeSharpFlat(int Flatsharp)
        {
            foreach(Staff staff in Staffs)
            {
                foreach (Bar bar in staff.Bars)
                {
                    bar.FlatSharp = Flatsharp;
                    foreach (Sign sign in bar.Signs)
                    {
                        if (sign is Note note)
                        {
                            if (note.tone == "Fis") { note.tone = "F"; }
                            if (note.tone == "Cis") { note.tone = "C"; }
                            if (note.tone == "Gis") { note.tone = "G"; }
                            if (note.tone == "Dis") { note.tone = "D"; }
                            if (note.tone == "Ais") { note.tone = "A"; }
                            if (note.tone == "Bes") { note.tone = "B"; }
                            if (note.tone == "Es") { note.tone = "E"; }
                            if (note.tone == "As") { note.tone = "A"; }
                            if (note.tone == "Des") { note.tone = "D"; }
                            if (note.tone == "Ges") { note.tone = "G"; }


                            if (Flatsharp >= 1) { if (note.tone == "F") { note.tone = "Fis"; } }
                            if (Flatsharp >= 2) { if (note.tone == "C") { note.tone = "Cis"; } }
                            if (Flatsharp >= 3) { if (note.tone == "G") { note.tone = "Gis"; } }
                            if (Flatsharp >= 4) { if (note.tone == "D") { note.tone = "Dis"; } }
                            if (Flatsharp >= 5) { if (note.tone == "A") { note.tone = "Ais"; } }

                            if (Flatsharp <= -1) { if (note.tone == "B") { note.tone = "Bes"; } }
                            if (Flatsharp <= -2) { if (note.tone == "E") { note.tone = "Es"; } }
                            if (Flatsharp <= -3) { if (note.tone == "A") { note.tone = "As"; } }
                            if (Flatsharp <= -4) { if (note.tone == "D") { note.tone = "Des"; } }
                            if (Flatsharp <= -5) { if (note.tone == "G") { note.tone = "Ges"; } }
                        }
                    }
                }
            }
        }

        async Task PutTaskDelay(int delay)
        {
            await Task.Delay(delay);
        }
        
        public void SetStaffs(List<Staff> staffs)
        {
            Staffs = staffs;
        }

    }
}
