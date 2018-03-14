using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    class Person
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnNameChanged();
            }
        }

        public delegate void DelegateHandler();

        public event DelegateHandler ChangeNameEvent;

        public void OnNameChanged()
        {
            ChangeNameEvent?.Invoke();
        }
    }
}
