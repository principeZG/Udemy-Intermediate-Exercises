using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;


namespace Inheritance_exercise
{

    public class Stack
    {
        private readonly List<object> _objects;

        public Stack()
        {
            _objects = new List<object>();
        }

        public void Push(object obj)
        {
            /*        The Push() method stores the given object on top of the stack. We use the “object” type here so
                    we can store any objects inside the stack.*/

            if (obj == null)
                throw new InvalidOperationException();

            _objects.Add(obj);
        }

        public object Pop()
        {
            //        The Pop() method removes the object on top of the stack and returns it. Make sure to take into 
            //        account the scenario that we call the Pop() method on an empty stack.In this case, this method
            //        should throw an InvalidOperationException.Remember, your classes should always be in a valid
            //        state and used properly. When they are misused, they should throw exceptions.Again, thinking
            //        of all these edge cases, separates you from an average programmer.The code written this way
            //        will be more robust and with less bugs.

            if (_objects == null)
                throw new InvalidOperationException();

            var lastItem = _objects[_objects.Count - 1];
            _objects.RemoveAt(_objects.Count - 1);
            return lastItem;
        }

        void Clear()
        {
            //        The Clear() method removes all objects from the stack.

            if (_objects != null)
                _objects.Clear();
        }
    }
}