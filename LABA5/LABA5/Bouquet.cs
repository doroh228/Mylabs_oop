using System;
using System.Collections.Generic;
using System.Text;

namespace LABA5
{
    class Bouquet : flower
    {
        public int Height { get; set; }

        public int Weight { get; set; }

        public override void DoClone()
        {
            throw new NotImplementedException();
        }
    }
}
