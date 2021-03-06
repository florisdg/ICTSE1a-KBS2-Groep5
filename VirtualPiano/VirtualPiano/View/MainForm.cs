﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualPiano.Control;
using VirtualPiano.View;


namespace VirtualPiano
{
    public partial class MainForm : Form
        {
        public MainForm()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            menuBarView1.Song = formContent.song;
            menuBarView1.selectedSong += ChangeSong;
            menuBarView1.newSong += NewSong;
            DatabaseController.InitializeDatabase();
        }

        private void NewSong(object sender, EventArgs e)
        {
            formContent.SetNewSong();
        }

        //song veranderen op het moment dat het event selectedsong uitgevoerd wordt.
        private void ChangeSong(object sender, EventArgs e)
        {
            MusicController.song = menuBarView1.Song;
            formContent.TitelBox.Text = menuBarView1.Song.Title;
            //oorspronkelijke notenbalken verwijderen.
            formContent.SetLoadedSong(menuBarView1.Song);

        }
    }
}
