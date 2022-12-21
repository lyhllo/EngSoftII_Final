using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Patterns.Adapter
{
    // The Adapter makes the Adaptee's interface compatible with the Target's
    // interface.
    class AdapterAdapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public AdapterAdapter(Adaptee adaptee)
        {
            this._adaptee = adaptee;
        }

        public string GetRequest()
        {
            return $"This is '{this._adaptee.GetSpecificRequest()}'";
        }
    }
}
