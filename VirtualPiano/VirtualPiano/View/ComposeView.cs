﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VirtualPiano.Model;
using VirtualPiano.Control;
using VirtualPiano.Properties;
using System.Media;

namespace VirtualPiano.View
{
    public partial class ComposeView : UserControl
    {
        public Song song = new Song();
        Button btnAddStaff = new Button();
        int y_staff = 140;
        internal static bool signSelected;
        internal static int FlatSharp = 0;
        internal static NoteName SelectedNoteName = NoteName.NULL;
        internal static RestName SelectedRestName = RestName.NULL;
        internal static ClefName SelectedClefName = ClefName.NULL;
        private List<Panel> staffViews = new List<Panel>();
        private bool firstStart = true;
        int tempint;

        public ComposeView()
        {
            InitializeComponent();
            if (firstStart)
            {
                ShowFirstStaffView();
                firstStart = false;
            }
                    
            MusicController m1 = new MusicController(Metronoom, rodeLijn, song);
            Controls.Add(MusicController.rewindBox);
            Controls.Add(MusicController.playBox);
            Controls.Add(MusicController.stopBox);
            Snelheid.Text = Metronoom.Interval.ToString();
            DoubleBuffered = true;
        }

        public void ShowFirstStaffView()    //Eerste notenbalk laten zien
        {
            foreach(Staff staff in song.GetStaffs())
            {
                staff.y = y_staff;
                AddStaffView(staff);
                if (staff == song.GetStaffs().Last())
                {
                    AddStaffButton();
                }
                y_staff += 200;
            }

        }

        public void RemoveStaffViews()
        {
            for (int i = 0; i < staffViews.Count; i++)
            {
                staffViews.ElementAt(i).Dispose();
            }
            y_staff = 140;
            Refresh();

        }


        private void btnAddStaff_Click(object sender, EventArgs e) //Notenbalk toevoegen knop
        {
            btnAddStaff.Dispose();
            AddNewStaff();
        }

        public void AddNewStaff()   //Nieuw notenbalk aan Song toevoegen
        {
            Staff newStaff = new Staff();
            newStaff.y = y_staff;
            song.AddStaff(newStaff);

            foreach (Staff staff in song.GetStaffs())
            {
                if (staff == song.GetStaffs().Last())
                {
                    AddStaffView(staff);
                    AddStaffButton();
                    y_staff += 190;
                }
            }
        }

        public void AddStaffView(Staff staff)   //nieuwe notenbalkpanel maken en vullen
        {
            Panel panel = new Panel();
            panel.Location = new Point(190, y_staff);
            panel.Size = new Size(1560, 150);
            Controls.Add(panel);
            StaffView _staffView = new StaffView(staff, FlatSharp)
            {
                Dock = DockStyle.None
            };
            staffViews.Add(panel);
            panel.Controls.Add(_staffView);
            
        }

        public void AddStaffButton()        //nieuwe "notenbalk toevoegen" knop toevoegen
        {
            btnAddStaff = new Button();
            btnAddStaff.Image = new Bitmap(Resources.add, 50, 50);
            btnAddStaff.Location = new Point(1780, y_staff + 35);
            btnAddStaff.Size = new Size(55, 55);
            btnAddStaff.BackColor = Color.Transparent;
            btnAddStaff.FlatStyle = FlatStyle.Flat;
            btnAddStaff.FlatAppearance.BorderSize = 0;
            btnAddStaff.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAddStaff.FlatAppearance.MouseOverBackColor = Color.Transparent;
            this.Controls.Add(btnAddStaff);
            btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
        }
        

        private void FullNote_MouseDown(object sender, MouseEventArgs e)
        {
            //deze code is voor alle mousedown events hetzelfde.
            //boolean om aan te geven dat een noot geslepen wordt.
            signSelected = true;
            //de bijbehorende naam van de noot.
            SelectedNoteName = NoteName.wholeNote;
            //de cursor veranderen naar de gewenste afbeelding.
            Cursor = CursorController.ChangeCursor(SelectedNoteName);
        }

        private void HalfNote_MouseDown(object sender, MouseEventArgs e)
        {
            signSelected = true;
            SelectedNoteName = NoteName.halfNote;
            Cursor = CursorController.ChangeCursor(SelectedNoteName);
        }

        private void QuarterNote_MouseDown(object sender, MouseEventArgs e)
        {
            signSelected = true;
            SelectedNoteName = NoteName.quarterNote;
            Cursor = CursorController.ChangeCursor(SelectedNoteName);
        }

        private void EightNote_MouseDown(object sender, MouseEventArgs e)
        {
            signSelected = true;
            SelectedNoteName = NoteName.eightNote;
            Cursor = CursorController.ChangeCursor(SelectedNoteName);
        }

        private void SixteenthNote_MouseDown(object sender, MouseEventArgs e)
        {
            signSelected = true;
            SelectedNoteName = NoteName.sixteenthNote;
            Cursor = CursorController.ChangeCursor(SelectedNoteName);
        }

        private void FullRest_MouseDown(object sender, MouseEventArgs e)
        {
            signSelected = true;
            SelectedRestName = RestName.wholeRest;
            Cursor = CursorController.ChangeCursor(SelectedRestName);

        }

        private void HalfRest_MouseDown(object sender, MouseEventArgs e)
        {
            signSelected = true;
            SelectedRestName = RestName.halfRest;
            Cursor = CursorController.ChangeCursor(SelectedRestName);

        }

        private void QuarterRest_MouseDown(object sender, MouseEventArgs e)
        {
            signSelected = true;
            SelectedRestName = RestName.quarterRest;
            Cursor = CursorController.ChangeCursor(SelectedRestName);
        }

        private void GKey_MouseDown(object sender, MouseEventArgs e)
        {
            signSelected = true;
            SelectedClefName = ClefName.G;
            Cursor = CursorController.ChangeCursor(SelectedClefName);
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void FKey_MouseDown(object sender, MouseEventArgs e)
        {
            signSelected = true;
            SelectedClefName = ClefName.F;
            Cursor = CursorController.ChangeCursor(SelectedClefName);
        }

        private void ComposeView_MouseEnter(object sender, EventArgs e)
        {
            if (signSelected == false)
            {
                Cursor = Cursors.Default;
            }
        }

        private void EightRest_MouseDown(object sender, MouseEventArgs e)
        {
            signSelected = true;
            SelectedRestName = RestName.eightRest;
            Cursor = CursorController.ChangeCursor(SelectedRestName);
        }

        private void SixteenthRest_MouseDown(object sender, MouseEventArgs e)
        {
            signSelected = true;
            SelectedRestName = RestName.sixteenthRest;
            Cursor = CursorController.ChangeCursor(SelectedRestName);
        }

        private void Flat_Click(object sender, EventArgs e)
        {
            FlatSharp--;

            foreach (Staff staf in song.GetStaffs())
            {
                foreach (Bar bar in staf.Bars)
                {
                    bar.FlatSharp--;
                }
            }
            Refresh();
        }

        public void Metronoom_Tick(object sender, EventArgs e)
        {
            Refresh();
        }


        private void Sharp_MouseDown(object sender, MouseEventArgs e)
        {
            signSelected = true;
            FlatSharp++;

            foreach (Staff staf in song.GetStaffs())
            {
                foreach (Bar bar in staf.Bars)
                {
                    bar.FlatSharp++;

                }
            }
            Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Draw(e);
        }

        public void Draw(PaintEventArgs e) //WIP
        {
            Pen p1 = new Pen(Color.White, 2);
            Pen p2 = new Pen(Color.Black, 8);
            SolidBrush s1 = new SolidBrush(Color.White);
            SolidBrush s2 = new SolidBrush(Color.Black);
            
            //for (int i = 0; i < tempint; i++)
            //{

                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            e.Graphics.DrawLine(p2, new Point(200, 10), new Point(200 + tempint, 10));
            //foreach (Staff staff in Song.staffs)
            //    {
            //        foreach (Bar bar in staff.Bars)
            //        {
            //        int temp = 0;
            //            e.Graphics.DrawLine(p2, new Point(200, 10), new Point(200, +temp*2));
            //        temp++;
            //        }
            //    }

            //}
        }


        private void Snelheid_TextChanged(object sender, EventArgs e)
        {
            int isNumber = 0;
            int.TryParse(Snelheid.Text.ToString(), out isNumber);
            if (isNumber != 0)
            {
                int interval = Int32.Parse(Snelheid.Text);
                MusicController.setMetronoom(interval);
            }

        }

        private void rodeLijn_Tick(object sender, EventArgs e)
        {

            int temp = song.getDuration();
            //Console.WriteLine(rodeLijn.Interval);
            tempint++;
            Invalidate();



            if (tempint >= song.getDuration() * 25)
            {
                rodeLijn.Stop();
            }
        }

        private void NoteSnapTimer_Tick(object sender, EventArgs e)
        {
            
            foreach (Staff staff in song.GetStaffs())
            {
                int barBegin = 250;
                int barEnd = 615;
                foreach (Bar bar in staff.Bars)
                {

                    if (PointToClient(Cursor.Position).X < barEnd && PointToClient(Cursor.Position).X > barBegin && PointToClient(Cursor.Position).Y > staff.y + 15 && PointToClient(Cursor.Position).Y < staff.y + 105)
                    {
                        int NewY = PointToClient(Cursor.Position).Y - staff.y;
                        Note newNote = StaffView.CreateNote(NewY, SelectedNoteName, bar.clef.ToString());
                        Rest newRest = new Rest(SelectedRestName);

                        if (bar.CheckBarSpace(newNote) && SelectedNoteName != NoteName.NULL)
                        {
                            bar.Add(newNote);
                            bar.hasPreview = true;
                            Refresh();
                            bar.RemovePreview();
                        }
                        else if (bar.CheckBarSpace(newRest) && SelectedRestName != RestName.NULL)
                        {
                                bar.clef = ClefName.G.ToString();
                                bar.Add(newRest);
                                bar.hasPreview = true;
                                Refresh();
                                bar.RemovePreview();
                        }
                    }
                    barBegin += 375;
                    barEnd += 375;
                }
            }
        }
    }
    }