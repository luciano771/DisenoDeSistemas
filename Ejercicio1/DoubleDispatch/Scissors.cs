using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PATRONES_DE_DISEÑO_PARTE1.DoubleDispatch
{
    internal class Scissors : IGameObject
    {
        public bool beats(IGameObject o)
        {
            return o.beatsPaper(o);
        }

        public bool beatsPaper(IGameObject o)
        {
            return true;
        }

        public bool beatsRock(IGameObject o)
        {
            return false;
        }

        public bool beatsScissors(IGameObject o)
        {
            return false;
        }
    }
}
