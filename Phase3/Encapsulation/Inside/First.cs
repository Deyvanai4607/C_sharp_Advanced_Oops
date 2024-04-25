using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OutSide;

namespace Inside
{
    public class First:Third
    {
        private int _privateNumber=10;
        public int PublicNumber=20;
        protected int ProtectedNumber=30;
        public int ProtectedInternalOut { get{return InternalProtected;} }
        
        
        public int PrivateOut { get{return _privateNumber;} }
    }
}