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

namespace VirtualPiano.View
{
    public partial class ComposeView : UserControl
    {
        Song song = new Song();
        Button btnAddStaff = new Button();
        int y_staff = 150;
        internal static bool tempBool;
        internal static NoteName tempNotename = NoteName.NULL;
        internal static RestName tempRestName = RestName.NULL;
        internal static ClefName tempClefName = ClefName.NULL;

        public ComposeView()
        {
            InitializeComponent();
            ShowFirstStaffView();
        }

        public void ShowFirstStaffView()    //Eerste notenbalk laten zien
        {
            for (int x = 1; x <= song.GetStaffs().Count; x++)
            {
                AddStaffView(song.GetStaffs()[x - 1]);
                if (x == song.GetStaffs().Count)
                {
                    AddStaffButton();
                }
                y_staff += 150;
            }

        }

        private void btnAddStaff_Click(object sender, EventArgs e) //Notenbalk toevoegen knop
        {
            btnAddStaff.Dispose();
            AddNewStaff();
        }

        public void AddNewStaff()   //Nieuw notenbalk aan song toevoegen
        {
            song.AddStaff(new Staff());
            for (int x = 1; x <= song.GetStaffs().Count; x++)
            {
                if (x == song.GetStaffs().Count)
                {
                    AddStaffView(song.GetStaffs()[x - 1]);
                    AddStaffButton();
                    y_staff += 150;
                }
            }
        }

        public void AddStaffView(Staff staff)   //nieuwe notenbalkpanel maken en vullen
        {
            Panel panel = new Panel();
            panel.Location = new Point(200, y_staff);
            panel.Size = new Size(1600, 150);
            Controls.Add(panel);
            StaffView _staffView = new StaffView(staff)
            {
                Dock = DockStyle.None
            };
            panel.Controls.Add(_staffView);
        }

        public void AddStaffButton()        //nieuwe "notenbalk toevoegen" knop toevoegen
        {
            btnAddStaff = new RoundButton();
            btnAddStaff.Location = new Point(970, y_staff + 170);
            btnAddStaff.Size = new Size(50, 50);
            btnAddStaff.Text = "+";
            btnAddStaff.ForeColor = Color.White;
            btnAddStaff.BackColor = Color.Black;
            btnAddStaff.Font = new Font(Font.FontFamily, 20);
            btnAddStaff.TabStop = false;
            btnAddStaff.FlatStyle = FlatStyle.Flat;
            btnAddStaff.FlatAppearance.BorderSize = 0;
            this.Controls.Add(btnAddStaff);
            btnAddStaff.Click += new System.EventHandler(this.btnAddStaff_Click);
            btnAddStaff.MouseEnter += OnMouseEnterButtonAddStaff;
            btnAddStaff.MouseLeave += OnMouseLeaveButtonAddStaff;
        }

        private void OnMouseEnterButtonAddStaff(object sender, EventArgs e)
        {
            btnAddStaff.BackColor = Color.White;
            btnAddStaff.ForeColor = Color.Black;
        }
        private void OnMouseLeaveButtonAddStaff(object sender, EventArgs e)
        {
            btnAddStaff.BackColor = Color.Black;
            btnAddStaff.ForeColor = Color.White;
        }

        private void FullNote_MouseDown(object sender, MouseEventArgs e)
        {
            tempBool = true;
            tempNotename = NoteName.wholeNote;
            tempRestName = RestName.NULL;
            tempClefName = ClefName.NULL;
            Cursor = CursorController.ChangeCursor(tempNotename);
        }

        private void HalfNote_MouseDown(object sender, MouseEventArgs e)
        {
            tempBool = true;
            tempNotename = NoteName.halfNote;
            tempRestName = RestName.NULL;
            tempClefName = ClefName.NULL;
            Cursor = CursorController.ChangeCursor(tempNotename);
        }

        private void QuarterNote_MouseDown(object sender, MouseEventArgs e)
        {
            tempBool = true;
            tempNotename = NoteName.quarterNote;
            tempRestName = RestName.NULL;
            tempClefName = ClefName.NULL;
            Cursor = CursorController.ChangeCursor(tempNotename);
        }

        private void EightNote_MouseDown(object sender, MouseEventArgs e)
        {
            tempBool = true;
            tempNotename = NoteName.eightNote;
            tempRestName = RestName.NULL;
            tempClefName = ClefName.NULL;
            Cursor = CursorController.ChangeCursor(tempNotename);
        }

        private void SixteenthNote_MouseDown(object sender, MouseEventArgs e)
        {
            tempBool = true;
            tempNotename = NoteName.sixteenthNote;
            tempRestName = RestName.NULL;
            tempClefName = ClefName.NULL;
            Cursor = CursorController.ChangeCursor(tempNotename);
        }

        private void FullRest_MouseDown(object sender, MouseEventArgs e)
        {
            tempBool = true;
            tempRestName = RestName.wholeRest;
            tempNotename = NoteName.NULL;
            tempClefName = ClefName.NULL;
            Cursor = CursorController.ChangeCursor(tempRestName);

        }

        private void HalfRest_MouseDown(object sender, MouseEventArgs e)
        {
            tempBool = true;
            tempRestName = RestName.halfRest;
            tempNotename = NoteName.NULL;
            tempClefName = ClefName.NULL;
            Cursor = CursorController.ChangeCursor(tempRestName);

        }

        private void QuarterRest_MouseDown(object sender, MouseEventArgs e)
        {
            tempBool = true;
            tempRestName = RestName.quarterRest;
            tempNotename = NoteName.NULL;
            tempClefName = ClefName.NULL;
            Cursor = CursorController.ChangeCursor(tempRestName);
        }
        
        private void GKey_MouseDown(object sender, MouseEventArgs e)
        {
            tempBool = true;
            tempClefName = ClefName.G;
            tempNotename = NoteName.NULL;
            tempRestName = RestName.NULL;
            Cursor = CursorController.ChangeCursor(tempClefName);
        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
             
        }
        private void FKey_MouseDown(object sender, MouseEventArgs e)
        {
            tempBool = true;
            tempClefName = ClefName.F;
            tempNotename = NoteName.NULL;
            tempRestName = RestName.NULL;
            Cursor = CursorController.ChangeCursor(tempClefName);
        }

        private void ComposeView_MouseEnter(object sender, EventArgs e)
        {
            if (tempBool == false)
            {
                Cursor = Cursors.Default;
            }
        }

        private void EightRest_MouseDown(object sender, MouseEventArgs e)
        {
            tempBool = true;
            tempRestName = RestName.eightRest;
            tempNotename = NoteName.NULL;
            tempClefName = ClefName.NULL;
            Cursor = CursorController.ChangeCursor(tempRestName);
        }

        private void SixteenthRest_MouseDown(object sender, MouseEventArgs e)
        {
            tempBool = true;
            tempRestName = RestName.sixteenthRest;
            tempNotename = NoteName.NULL;
            tempClefName = ClefName.NULL;
            Cursor = CursorController.ChangeCursor(tempRestName);
        }
    }
}
