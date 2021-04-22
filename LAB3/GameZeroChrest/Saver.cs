using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZeroChrest
{
    internal class Saver
    {
        private List<GameMemento> mementos;
        internal Saver()
        {
            mementos = new List<GameMemento>();
        }
        internal void SetMemento(GameMemento memento)
        {
            if (mementos.Count > 0)
            {
                if (mementos[mementos.Count - 1] != memento)
                {
                    mementos.Add(memento);
                }
            }
            else
            {
                mementos.Add(memento);
            }
        }
        internal GameMemento GetLastMemento()
        {
            if (mementos.Count > 0)
            {
                mementos.RemoveAt(mementos.Count - 1);
            }
            return mementos[mementos.Count - 1];
        }
    }
}
