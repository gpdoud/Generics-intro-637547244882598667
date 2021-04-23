using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_intro {

    class GenericG<T> {

        public T value { get; set; }

        public void Print() {
            Console.WriteLine(value);
        }
    }
}
