using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.OOpsConcepts
{
    class Bicycle : Vehicle
    {
        public override void Accelerate()
        {
            throw new NotImplementedException();
        }

        public override void Deaccelarate()
        {
            throw new NotImplementedException();
        }

        public override bool IsMoving()
        {
            return true;
        }

        public override void Stop()
        {
            throw new NotImplementedException();
        }

        public bool IsDrifter()
        {
            throw new NotImplementedException();
        }
    }
}
