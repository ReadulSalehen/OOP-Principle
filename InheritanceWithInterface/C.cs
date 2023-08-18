using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceWithInterface
{
    internal class C
    {
        private readonly A a;
        private readonly B b;
        public C()
        {
            a = new A();
            b = new B();
        }
        public string Email { get; set; }
        public int GetId()
        {
            return a.Id;
        }

        public string GetName()
        {
            return b.Name;
        }

        public void SetId(int id)
        {
            this.a.Id = id;
        }

        public void SetName(string name)
        {
            this.b.Name = name;
        }
    }
}
