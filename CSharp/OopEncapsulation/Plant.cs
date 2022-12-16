using System;
using System.Collections.Generic;
using System.Text;

namespace OopEncapsulation
{
    public class Plant
    {
        //encapsulation thể hiện ở 2 chỗ
        // a) access modify   b) property

        // a) access modify
        private void Private() => Console.WriteLine("Private");
        protected void Protected() => Console.WriteLine("Protected");
        internal void Internal() => Console.WriteLine("Internal");
        private protected void PrivateProtected() => Console.WriteLine("Private Protected");
        protected internal void ProtectedInternal() => Console.WriteLine("Protected Internal");
        public void Public() => Console.WriteLine("Public");
    }
}
