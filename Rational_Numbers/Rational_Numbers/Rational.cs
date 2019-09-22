using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rational_Numbers
{
    class Rational
    {
        private int x;
        private int y;

        public Rational(int x, int y) {
            this.x = x;
            this.y = y;
        }

        public int GetNumerator() { return this.x; }
        public int GetDenom() { return this.y; }

        public bool IsEqual(Rational num) {

            return num.x * this.y == num.y * this.x;
        }

        public Rational Multiply(Rational num) {
            Rational p1 = new Rational(this.x * num.x, this.y * num.y);
            return p1;
        }

        public Rational Divide(Rational num) {
            if (num.x == 0) {
                return null;
            }
            Rational p1 = new Rational(this.x * num.y, this.y * num.x);
            return p1;
        }

        public override string ToString()
        {
            return "<" + this.x + ">/<" + this.y + ">";
        }
    }
}
