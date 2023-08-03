using Primal;
using Primal.Api;
using System;
using System.Collections.Generic;
using System.Text;
using Undine.Core;

namespace Undine.Primal
{
    public class PrimalContainer : EcsContainer
    {
        private IPrimalWorld World { get; set; }

        public PrimalContainer()
        {
            //Primal.Api.WorldFactory.Create();
            World = WorldFactory.Create();
        }

        public override void AddSystem<A>(UnifiedSystem<A> system)
        {
            World.AddSystem(new PrimalSystem<A>()
            {
                System = system
            });
        }

        public override void AddSystem<A, B>(UnifiedSystem<A, B> system)
        {
            World.AddSystem(new PrimalSystem<A, B>()
            {
                System = system
            });
        }

        public override void AddSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            World.AddSystem(new PrimalSystem<A, B, C>()
            {
                System = system
            });
        }

        public override void AddSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            World.AddSystem(new PrimalSystem<A, B, C, D>()
            {
                System = system
            });
        }

        public override IUnifiedEntity CreateNewEntity()
        {
            var entity = World.CreateEntity();
            return new PrimalEntity { Entity = entity };
        }

        public override ISystem GetSystem<A>(UnifiedSystem<A> system)
        {
            return new PrimalSystem<A>()
            {
                System = system
            };
        }

        public override ISystem GetSystem<A, B>(UnifiedSystem<A, B> system)
        {
            return new PrimalSystem<A, B>()
            {
                System = system
            };
        }

        public override ISystem GetSystem<A, B, C>(UnifiedSystem<A, B, C> system)
        {
            return new PrimalSystem<A, B, C>()
            {
                System = system
            };
        }

        public override ISystem GetSystem<A, B, C, D>(UnifiedSystem<A, B, C, D> system)
        {
            return new PrimalSystem<A, B, C, D>()
            {
                System = system
            };
        }

        public override void Run()
        {
            World.Update(1000);
        }
    }
}