using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRONES_DE_DISEÑO_PARTE1.DoubleDispatch
{
    internal class Rock : IGameObject
    {
        public bool beats(IGameObject o)
        {
            return o.beatsRock(o);
        }

        public bool beatsPaper(IGameObject o)
        {
            return false;
        }

        public bool beatsRock(IGameObject o)
        {
            return false;
        }

        public bool beatsScissors(IGameObject o)
        {
            return true;
        }
    }
}
