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
                OnNameChanged(this, new ChangeNameEventArgs(30, name));
            }
        }

        public delegate void DelegateHandler(object sender, ChangeNameEventArgs args);

        public event DelegateHandler ChangeNameEvent;

        public void OnNameChanged(object sender, ChangeNameEventArgs args)
        {
            ChangeNameEvent?.Invoke(this, args);
        }
    }

    public class ChangeNameEventArgs : EventArgs
    {
        public int age { get; set; }
        public string name { get; set; }

        public ChangeNameEventArgs(int age, string name)
        {
            this.age = age;
            this.name = name;
        }
    }
}
