using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameZeroChrest
{
    public class Saver
    {
        private List<GameMemento> mementos;
        public Saver()
        {
            mementos = new List<GameMemento>();
        }
        public void SetMemento(GameMemento memento)
        {
            if(mementos.Count==2)
            {
                mementos.RemoveAt(0);
            }
            mementos.Add(memento);
        }
        public GameMemento GetLastMemento()
        {
            return mementos[0];
        }
    }
}
