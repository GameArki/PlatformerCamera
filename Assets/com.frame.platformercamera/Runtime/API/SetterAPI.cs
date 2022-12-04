using PlatformerCamera.Facades;
using UnityEngine;

namespace PlatformerCamera {

    internal class SetterAPI : ISetterAPI {

        AllPlatfContext ctx;
        AllPlatfDomain allDomain;

        internal SetterAPI() {}

        internal void Inject(AllPlatfContext ctx, AllPlatfDomain domain) {
            this.ctx = ctx;
            this.allDomain = domain;
        }

        void ISetterAPI.Move_Current(Vector2 offset) {
            var cur = ctx.Repo.Current;
            var domain = allDomain.CameraDomain;
            domain.Move_Current(cur, offset);
        }
    }
    
}