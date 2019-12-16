using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    class Human
    {
        public string Name { get; set; }
        public string Birtday { get; set; }

        // Переопределение метода Equals для сравнения значений объектов.
        public override bool Equals(Object obj)
        {
            Human human = obj as Human;
            if (human == null)
                return false;
            else
                return human.Name == Name && human.Birtday == Birtday; 
        }

        public override int GetHashCode()
        {
            return this.Name.GetHashCode();
        }
    }
}
