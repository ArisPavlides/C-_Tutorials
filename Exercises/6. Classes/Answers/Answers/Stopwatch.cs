using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Answers
{
    public class Stopwatch
    {
        private DateTime _start;
        private DateTime _stop;
        private bool _started;

        public Stopwatch()
        {
            _started = false;
        }

        public void Start()
        {
            if (_started) { throw new System.InvalidOperationException("Stopwatch already started"); }
            else
            {
                _start = DateTime.Now;
                _started = true;
            }
        }

        public void Stop()
        {
            _stop = DateTime.Now;
        }

        // this is just a variable the value of which can only be retrieved
        public int Duration
        {
            get
            {
                if (_start == DateTime.MinValue || _stop == DateTime.MinValue)
                {
                    throw new System.InvalidOperationException("Define start and end dates");
                }

                return (this._stop - this._start).Seconds;
            }
        }
    }
}
