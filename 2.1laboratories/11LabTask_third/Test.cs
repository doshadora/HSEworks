using System;
using System.Collections.Generic;
using System.Text;

namespace _11LabTask_third
{
    class Test : Challenge
    {
        public int Result { get; set; }

        public Test() : base()
        {
            Result = rnd.Next(0, 100);
        }
        
        public Test(string n, int q, int r) : base(n, q)
        {
            Result = r;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + Result + "%";
        }

        public Challenge GetBase()
        {
            return new Challenge(this.Name, this.Questions);
        }

        new public object Clone()
        {
            return new Test(this.Name, this.Questions, this.Result);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Questions.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj) && (this.Result == ((Test)obj).Result);
        }
    }
}

