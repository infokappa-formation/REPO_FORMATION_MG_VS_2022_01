namespace RefactoringTester
{

    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System;
    using System.Threading.Tasks;

    class Person
    {


        #region Person > Constructor

        public Person()
        {
            this.Guid = Guid.NewGuid();
        }

        #endregion Person > Constructor


        #region Person > Methods

        public void Dummy()
        {
            Console.WriteLine(this.BadProperty);
        }

        #endregion Person > Methods


        #region Person > Properties

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string BadProperty { get; set; }

        public Guid Guid { get; set; }

        #endregion Person > Properties


        #region Person > Old properties

        private string oldStyleProperty;
        public string OldStyleProperty
        {
            get { return this.oldStyleProperty; }
            set { this.oldStyleProperty = value; }
        }

        #endregion Person > Old properties
    }
}
