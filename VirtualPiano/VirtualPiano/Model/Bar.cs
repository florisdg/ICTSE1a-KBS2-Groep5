﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPiano.Model
{
    public enum ClefName { G, F, C , NULL}

    public class Bar
    {
        public List<Sign> signs;
        public ClefName clef;
        public int TimeSignatureAmount;
        public NoteName TimeSignatureName;
        public int duration = 0;

        public Bar()
        {
            clef = ClefName.G;
            signs = new List<Sign>();
        }

        public bool CheckBarSpace(Sign sign)
        {
            if (duration + sign.duration > 16) return false;
            else return true;
        }

        public void Add(Sign sign)
        {
            signs.Add(sign);
            duration += sign.duration;
        }
    }
}
