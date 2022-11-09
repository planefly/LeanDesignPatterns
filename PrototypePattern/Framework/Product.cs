using System;

namespace PrototypePattern.Framework
{
    public interface IProduct : ICloneable
    {
        void Use(string s);
    }
}
