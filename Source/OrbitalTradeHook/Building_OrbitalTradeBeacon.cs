﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Verse;
using UnityEngine;

namespace D9OTH
{
    public abstract class Building_OrbitalTradeBeacon : Building
    {
        public abstract IEnumerable<IntVec3> TradeableCells();
    }
}