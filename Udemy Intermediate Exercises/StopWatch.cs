using System;

namespace Udemy_Intermediate_Exercises
{
    public class StopWatch
    {
        private DateTime _startTime;
        private DateTime _endTime;
        private TimeSpan _timeSpan;
        private bool _isRunning = false;


        
        public void Start()
        {
            if (_isRunning)
                throw new InvalidOperationException("STOPWATCH ALREADY STARTED");

            this._isRunning = true;
            this._startTime = DateTime.Now;

        }
        
        public void Stop()
        {
            this._endTime = DateTime.Now;
            _timeSpan = this._endTime - this._startTime;
            this._isRunning = false;
        }

        public TimeSpan Duration()
        {
            return _endTime - _startTime;
        }

        

    }
}