using Primal.Api;
using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;

namespace Undine.Primal
{
    public class PrimalEntity : IUnifiedEntity
    {
        public IEntity Entity { get; set; }

        public void AddComponent<A>(in A component) where A : struct
        {
            Entity.Add(new PrimalComponent<A> { Value = component });
        }

        public ref A GetComponent<A>() where A : struct
        {
            var component = Entity.Get<PrimalComponent<A>>();
            return ref component.Value;
        }
    }
}