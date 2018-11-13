using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExercise
{
    public class Stack
    {
        readonly List<object> _objList;

        public Stack()
        {
            _objList = new List<object>();
        }

        public void Push(object obj)
        {
            if (obj == null) { throw new InvalidOperationException("Cannot add null to stack!"); }
            else { _objList.Add(obj); }
        }

        public object Pop()
        {
            if (_objList.Count > 0)
            {
                object topItem = _objList[_objList.Count - 1];
                _objList.RemoveAt(_objList.Count - 1);

                return topItem;
            }

            else { throw new Exception("The stack is empty!"); }
            
        }

        public void Clear()
        { _objList.Clear(); }
    }
}
