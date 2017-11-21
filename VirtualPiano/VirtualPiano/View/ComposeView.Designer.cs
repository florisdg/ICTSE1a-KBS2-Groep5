﻿using System;
using System.Windows.Forms;

namespace VirtualPiano.View
{
    partial class ComposeView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComposeView));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.GKey = new System.Windows.Forms.ToolStripButton();
            this.FKey = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.FullNote = new System.Windows.Forms.ToolStripButton();
            this.HalfNote = new System.Windows.Forms.ToolStripButton();
            this.QuarterNote = new System.Windows.Forms.ToolStripButton();
            this.EightNote = new System.Windows.Forms.ToolStripButton();
            this.SixteenthNote = new System.Windows.Forms.ToolStripButton();
            this.ThirtySecondNote = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.FullRest = new System.Windows.Forms.ToolStripButton();
            this.HalfRest = new System.Windows.Forms.ToolStripButton();
            this.QuarterRest = new System.Windows.Forms.ToolStripButton();
            this.EightRest = new System.Windows.Forms.ToolStripButton();
            this.SixteenthRest = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Sharp = new System.Windows.Forms.ToolStripButton();
            this.Flat = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            this.toolStripContainer1.BottomToolStripPanelVisible = false;
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripContainer1.ContentPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripContainer1.ContentPanel.Controls.Add(this.toolStrip1);
            this.toolStripContainer1.ContentPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.toolStripContainer1.ContentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripContainer1.ContentPanel.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(66, 1000);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 4);
            this.toolStripContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(66, 1000);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStrip1.CanOverflow = false;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GKey,
            this.FKey,
            this.toolStripSeparator1,
            this.FullNote,
            this.HalfNote,
            this.QuarterNote,
            this.EightNote,
            this.SixteenthNote,
            this.ThirtySecondNote,
            this.toolStripSeparator2,
            this.FullRest,
            this.HalfRest,
            this.QuarterRest,
            this.EightRest,
            this.SixteenthRest,
            this.toolStripSeparator3,
            this.Sharp,
            this.Flat});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(-1, 5);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(66, 950);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // GKey
            // 
            this.GKey.AutoSize = false;
            this.GKey.BackColor = System.Drawing.Color.Transparent;
            this.GKey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GKey.Image = global::VirtualPiano.Properties.Resources.Gsleutel_icon;
            this.GKey.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GKey.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.GKey.Name = "GKey";
            this.GKey.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.GKey.Size = new System.Drawing.Size(50, 50);
            this.GKey.Text = "G-Sleutel";
            // 
            // FKey
            // 
            this.FKey.AutoSize = false;
            this.FKey.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FKey.Image = global::VirtualPiano.Properties.Resources.fsleutel_icon1;
            this.FKey.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FKey.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FKey.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.FKey.Name = "FKey";
            this.FKey.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.FKey.Size = new System.Drawing.Size(50, 50);
            this.FKey.Text = "F-Sleutel";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.AutoSize = false;
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripSeparator1.Size = new System.Drawing.Size(50, 6);
            // 
            // FullNote
            // 
            this.FullNote.AutoSize = false;
            this.FullNote.BackColor = System.Drawing.Color.Transparent;
            this.FullNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FullNote.Image = global::VirtualPiano.Properties.Resources.helenoot_icon;
            this.FullNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FullNote.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.FullNote.Name = "FullNote";
            this.FullNote.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.FullNote.Size = new System.Drawing.Size(50, 50);
            this.FullNote.Text = "Hele noot";
            this.FullNote.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FullNote_MouseDown);
            // 
            // HalfNote
            // 
            this.HalfNote.AutoSize = false;
            this.HalfNote.BackColor = System.Drawing.Color.Transparent;
            this.HalfNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HalfNote.Image = global::VirtualPiano.Properties.Resources.halvenoot_icon;
            this.HalfNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HalfNote.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.HalfNote.Name = "HalfNote";
            this.HalfNote.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.HalfNote.Size = new System.Drawing.Size(50, 50);
            this.HalfNote.Text = "Halve noot";
            this.HalfNote.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HalfNote_MouseDown);
            // 
            // QuarterNote
            // 
            this.QuarterNote.AutoSize = false;
            this.QuarterNote.BackColor = System.Drawing.Color.Transparent;
            this.QuarterNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.QuarterNote.Image = ((System.Drawing.Image)(resources.GetObject("QuarterNote.Image")));
            this.QuarterNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.QuarterNote.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.QuarterNote.Name = "QuarterNote";
            this.QuarterNote.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.QuarterNote.Size = new System.Drawing.Size(50, 50);
            this.QuarterNote.Text = "Kwart noot";
            this.QuarterNote.MouseDown += new System.Windows.Forms.MouseEventHandler(this.QuarterNote_MouseDown);
            // 
            // EightNote
            // 
            this.EightNote.AutoSize = false;
            this.EightNote.BackColor = System.Drawing.Color.Transparent;
            this.EightNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EightNote.Image = global::VirtualPiano.Properties.Resources.achtstenoot_icon;
            this.EightNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EightNote.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.EightNote.Name = "EightNote";
            this.EightNote.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.EightNote.Size = new System.Drawing.Size(50, 50);
            this.EightNote.Text = "1/8e noot";
            this.EightNote.MouseDown += new System.Windows.Forms.MouseEventHandler(this.EightNote_MouseDown);
            // 
            // SixteenthNote
            // 
            this.SixteenthNote.AutoSize = false;
            this.SixteenthNote.BackColor = System.Drawing.Color.Transparent;
            this.SixteenthNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SixteenthNote.Image = global::VirtualPiano.Properties.Resources.zestiendenoot_icon;
            this.SixteenthNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SixteenthNote.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.SixteenthNote.Name = "SixteenthNote";
            this.SixteenthNote.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.SixteenthNote.Size = new System.Drawing.Size(50, 50);
            this.SixteenthNote.Text = "1/16e noot";
            this.SixteenthNote.MouseDown += new System.Windows.Forms.MouseEventHandler(this.SixteenthNote_MouseDown);
            // 
            // ThirtySecondNote
            // 
            this.ThirtySecondNote.AutoSize = false;
            this.ThirtySecondNote.BackColor = System.Drawing.Color.Transparent;
            this.ThirtySecondNote.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ThirtySecondNote.Image = global::VirtualPiano.Properties.Resources.tweeendertigstenoot_icon;
            this.ThirtySecondNote.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ThirtySecondNote.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.ThirtySecondNote.Name = "ThirtySecondNote";
            this.ThirtySecondNote.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.ThirtySecondNote.Size = new System.Drawing.Size(50, 50);
            this.ThirtySecondNote.Text = "1/32e noot";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripSeparator2.Size = new System.Drawing.Size(50, 6);
            //
            // Sharp
            //
            this.Sharp.AutoSize = false;
            this.Sharp.Image = global::VirtualPiano.Properties.Resources.Kruis;
            this.Sharp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Sharp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sharp.Name = "Sharp";
            this.Sharp.Size = new System.Drawing.Size(130, 55);
            this.Sharp.Text = "Kruis";
            // 
            // Flat
            // 
            this.Flat.AutoSize = false;
            this.Flat.Image = global::VirtualPiano.Properties.Resources.Mol;
            this.Flat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.Flat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Flat.Name = "Flat";
            this.Flat.Size = new System.Drawing.Size(130, 55);
            this.Flat.Text = "Mol";
            // 
            // GKey
            // 
            this.GKey.AutoSize = false;
            this.GKey.Image = global::VirtualPiano.Properties.Resources.Gsleutel_icon;
            this.GKey.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.GKey.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GKey.Name = "GKey";
            this.GKey.Size = new System.Drawing.Size(130, 55);
            this.GKey.Text = "G-Sleutel";
            this.GKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GKey_MouseDown);
            // 
            // FKey
            // 
            this.FKey.AutoSize = false;
            this.FKey.Image = global::VirtualPiano.Properties.Resources.fsleutel;
            this.FKey.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FKey.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FKey.Name = "FKey";
            this.FKey.Size = new System.Drawing.Size(130, 55);
            this.FKey.Text = "F-Sleutel";
            this.FKey.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FKey_MouseDown);
            // 
            // FullRest
            // 
            this.FullRest.AutoSize = false;
            this.FullRest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FullRest.Image = ((System.Drawing.Image)(resources.GetObject("FullRest.Image")));
            this.FullRest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.FullRest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FullRest.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.FullRest.Name = "FullRest";
            this.FullRest.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.FullRest.Size = new System.Drawing.Size(50, 50);
            this.FullRest.Text = "Hele Rust";
            this.FullRest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FullRest_MouseDown);
            // 
            // HalfRest
            // 
            this.HalfRest.AutoSize = false;
            this.HalfRest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HalfRest.Image = ((System.Drawing.Image)(resources.GetObject("HalfRest.Image")));
            this.HalfRest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.HalfRest.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.HalfRest.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.HalfRest.Name = "HalfRest";
            this.HalfRest.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.HalfRest.Size = new System.Drawing.Size(50, 50);
            this.HalfRest.Text = "Halve Rust";
            this.HalfRest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HalfRest_MouseDown);
            // 
            // QuarterRest
            // 
            this.QuarterRest.AutoSize = false;
            this.QuarterRest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.QuarterRest.Image = global::VirtualPiano.Properties.Resources.KwartRust;
            this.QuarterRest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.QuarterRest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.QuarterRest.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.QuarterRest.Name = "QuarterRest";
            this.QuarterRest.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.QuarterRest.Size = new System.Drawing.Size(50, 50);
            this.QuarterRest.Text = "Kwart rust";
            this.QuarterRest.MouseDown += new System.Windows.Forms.MouseEventHandler(this.QuarterRest_MouseDown);
            // 
            // EightRest
            // 
            this.EightRest.AutoSize = false;
            this.EightRest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EightRest.Image = global::VirtualPiano.Properties.Resources.achtsterust_icon;
            this.EightRest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.EightRest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EightRest.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.EightRest.Name = "EightRest";
            this.EightRest.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.EightRest.Size = new System.Drawing.Size(50, 50);
            this.EightRest.Text = "Achtste rust";
            // 
            // SixteenthRest
            // 
            this.SixteenthRest.AutoSize = false;
            this.SixteenthRest.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SixteenthRest.Image = global::VirtualPiano.Properties.Resources.zestienderust_icon;
            this.SixteenthRest.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SixteenthRest.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SixteenthRest.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.SixteenthRest.Name = "SixteenthRest";
            this.SixteenthRest.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.SixteenthRest.Size = new System.Drawing.Size(50, 50);
            this.SixteenthRest.Text = "SixteenthRest";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(1);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.toolStripSeparator3.Size = new System.Drawing.Size(50, 6);
            // 
            // Sharp
            // 
            this.Sharp.AutoSize = false;
            this.Sharp.BackColor = System.Drawing.Color.Transparent;
            this.Sharp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Sharp.Image = global::VirtualPiano.Properties.Resources.Kruis;
            this.Sharp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Sharp.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.Sharp.Name = "Sharp";
            this.Sharp.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.Sharp.Size = new System.Drawing.Size(50, 50);
            this.Sharp.Text = "Kruis";
            // 
            // Flat
            // 
            this.Flat.AutoSize = false;
            this.Flat.BackColor = System.Drawing.Color.Transparent;
            this.Flat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Flat.Image = global::VirtualPiano.Properties.Resources.Mol;
            this.Flat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Flat.Margin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.Flat.Name = "Flat";
            this.Flat.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.Flat.Size = new System.Drawing.Size(50, 50);
            this.Flat.Text = "Mol";
            // 
            // ComposeView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.toolStripContainer1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ComposeView";
            this.Size = new System.Drawing.Size(75, 1000);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ComposeView_MouseDown);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        private void ComposeView_MouseDown(object sender, MouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton FullNote;
        private System.Windows.Forms.ToolStripButton HalfNote;
        private System.Windows.Forms.ToolStripButton QuarterNote;
        private System.Windows.Forms.ToolStripButton EightNote;
        private System.Windows.Forms.ToolStripButton SixteenthNote;
        private System.Windows.Forms.ToolStripButton ThirtySecondNote;
        private System.Windows.Forms.ToolStripButton Sharp;
        private System.Windows.Forms.ToolStripButton Flat;
        private System.Windows.Forms.ToolStripButton GKey;
        private System.Windows.Forms.ToolStripButton FKey;
        private System.Windows.Forms.ToolStripButton FullRest;
        private System.Windows.Forms.ToolStripButton HalfRest;
        private System.Windows.Forms.ToolStripButton QuarterRest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton EightRest;
        private System.Windows.Forms.ToolStripButton SixteenthRest;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}
