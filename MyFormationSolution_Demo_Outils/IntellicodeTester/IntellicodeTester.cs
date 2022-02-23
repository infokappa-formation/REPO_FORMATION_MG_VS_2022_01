namespace IntellicodeTester {

    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class IntellicodeTester {

        public void Eat(IEdible food, DateTime dateTime) { }

        public void EatBreakfast_v1() {
            Banana banana = new Banana();
            this.Eat(banana, DateTime.Now);
        }

        public void EatBreakfast_v2() {
            Banana banana = new Banana();
            Chocolate chocolate = new Chocolate();
            this.Eat(chocolate, DateTime.Now);
        }
        public void EatBreakfast_v3() {
            Banana banana = new Banana();
            DateTime tomorrow = DateTime.Now.AddDays(1);
            this.Eat(banana, tomorrow);
        }
    }
}
