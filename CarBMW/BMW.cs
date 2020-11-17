using System;
using System.ComponentModel.Composition;
using CarCommon;

namespace CarBMW
{
    [Export(typeof(ICarContract))]
    public class BMW : ICarContract
    {
        public string StartEngine(string name)
        {
            return String.Format("{0} starts the BMW.", name);
        }
    }
}
