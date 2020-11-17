﻿using System;
using System.ComponentModel.Composition;
using CarCommon;

namespace CarMercedes
{
    [Export(typeof(ICarContract))]
    public class Mercedes : ICarContract
    {
        public string StartEngine(string name)
        {
            return String.Format("{0} starts the Mercedes.", name);
        }
    }
}