using FactoryMethodPattern.Framework;
using System.Collections;

namespace FactoryMethodPattern
{
    public class IDCardFactory : Factory
    {
        private readonly ArrayList _owners = new ArrayList();

        protected override Product CreateProduct(string owner)
        {
            return new IDCard(owner);
        }

        protected override void RegisterProduct(Product product)
        {
            _owners.Add(((IDCard)product).GetOwner());
        }

        public ArrayList GetOwners()
        {
            return _owners;
        }
    }
}
