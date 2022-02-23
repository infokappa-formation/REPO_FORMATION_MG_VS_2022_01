using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingConsoleApplication {
    public class Person {
        public Person() {
            this.Guid = Guid.NewGuid();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Guid Guid { get; set; }
    }
}
