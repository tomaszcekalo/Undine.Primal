using Primal.Api;
using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;
using Primal;

namespace Undine.Primal
{
    public class PrimalSystem<T> : UpdateSystem, ISystem
        where T : struct
    {
        public UnifiedSystem<T> System { get; set; }
        public bool IsDrawSystem { get; set; }

        public PrimalSystem()
        {
            RegisterComponent<PrimalComponent<T>>();
        }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        protected override void UpdateEntity(IEntity entity, double elapsedMs)
        {
            System.ProcessSingleEntity(0, ref entity.Get<PrimalComponent<T>>().Value);
        }

        protected override bool IsDraw() => IsDrawSystem;
    }

    public class PrimalSystem<A, B> : UpdateSystem, ISystem
        where A : struct
        where B : struct
    {
        public UnifiedSystem<A, B> System { get; set; }
        public bool IsDrawSystem { get; set; }

        public PrimalSystem()
        {
            RegisterComponent<PrimalComponent<A>>();
            RegisterComponent<PrimalComponent<B>>();
        }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        protected override void UpdateEntity(IEntity entity, double elapsedMs)
        {
            var aComponent = entity.Get<PrimalComponent<A>>();
            var bComponent = entity.Get<PrimalComponent<B>>();
            System.ProcessSingleEntity(0, ref aComponent.Value, ref bComponent.Value);
        }

        protected override bool IsDraw() => IsDrawSystem;
    }

    public class PrimalSystem<A, B, C> : UpdateSystem, ISystem
        where A : struct
        where B : struct
        where C : struct
    {
        public UnifiedSystem<A, B, C> System { get; set; }
        public bool IsDrawSystem { get; set; }

        public PrimalSystem()
        {
            RegisterComponent<PrimalComponent<A>>();
            RegisterComponent<PrimalComponent<B>>();
            RegisterComponent<PrimalComponent<C>>();
        }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        protected override void UpdateEntity(IEntity entity, double elapsedMs)
        {
            var aComponent = entity.Get<PrimalComponent<A>>();
            var bComponent = entity.Get<PrimalComponent<B>>();
            var cComponent = entity.Get<PrimalComponent<C>>();
            System.ProcessSingleEntity(0, ref aComponent.Value, ref bComponent.Value, ref cComponent.Value);
        }

        protected override bool IsDraw() => IsDrawSystem;
    }

    public class PrimalSystem<A, B, C, D> : UpdateSystem, ISystem
        where A : struct
        where B : struct
        where C : struct
        where D : struct
    {
        public UnifiedSystem<A, B, C, D> System { get; set; }
        public bool IsDrawSystem { get; set; }

        public PrimalSystem()
        {
            RegisterComponent<PrimalComponent<A>>();
            RegisterComponent<PrimalComponent<B>>();
            RegisterComponent<PrimalComponent<C>>();
            RegisterComponent<PrimalComponent<D>>();
        }

        public void ProcessAll()
        {
            throw new NotImplementedException();
        }

        protected override void UpdateEntity(IEntity entity, double elapsedMs)
        {
            var aComponent = entity.Get<PrimalComponent<A>>();
            var bComponent = entity.Get<PrimalComponent<B>>();
            var cComponent = entity.Get<PrimalComponent<C>>();
            var dComponent = entity.Get<PrimalComponent<D>>();
            System.ProcessSingleEntity(0, ref aComponent.Value, ref bComponent.Value, ref cComponent.Value, ref dComponent.Value);
        }

        protected override bool IsDraw() => IsDrawSystem;
    }
}