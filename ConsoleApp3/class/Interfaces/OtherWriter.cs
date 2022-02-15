using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp {
    class OtherWriter : IDateWriter {
            private IOutput _output;
            public OtherWriter(IOutput output) {
                this._output = output;
            }

            public void WriteDate() {
                this._output.Write("This is another writer");
            }
    }
}


