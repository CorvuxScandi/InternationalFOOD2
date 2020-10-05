using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecepyWebsight
{
    interface IMaintainable
    {
        void Save();

        void Update();

        void Delete();

    }
}
