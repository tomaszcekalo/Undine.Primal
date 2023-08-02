using Primal.Api;
using System;
using System.Collections.Generic;
using System.Text;

namespace Undine.Primal
{
    public class PrimalComponent<T> : IComponent where T : struct
    {
        public T Value;
    }
}