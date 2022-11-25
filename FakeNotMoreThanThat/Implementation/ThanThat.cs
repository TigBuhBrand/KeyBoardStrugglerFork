using FakeNotMoreThanThat.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FakeNotMoreThanThat.Implementation
{
    public class ThanThat : IThanThat
    {
        public ThanThat(bool thakeItOrLeaveIt)
        {
            this.ThakeThat = thakeItOrLeaveIt;
        }
        public bool ThakeThat { get; }

        public int PickIt(int countOfPickups)
        {
            return this.ThakeThat ? int.MaxValue / 2  : int.MinValue;
        }
    }
}
