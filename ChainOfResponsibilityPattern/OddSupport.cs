﻿namespace ChainOfResponsibilityPattern
{
    public class OddSupport : Support
    {
        public OddSupport(string name) : base(name)
        {
        }

        protected override bool Resolve(Trouble trouble)
        {
            return trouble.GetNumber() % 2 == 1;
        }
    }
}
