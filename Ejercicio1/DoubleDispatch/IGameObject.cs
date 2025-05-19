using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PATRONES_DE_DISEÑO_PARTE1.DoubleDispatch
{
    internal interface IGameObject
    {
        public bool beats(IGameObject o);
        public bool beatsRock(IGameObject o);
        public bool beatsPaper(IGameObject o);
        public bool beatsScissors(IGameObject o);
    }
}
