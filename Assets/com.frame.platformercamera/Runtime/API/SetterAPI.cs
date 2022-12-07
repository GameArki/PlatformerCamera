using PFormerCamera.Facades;
using UnityEngine;

namespace PFormerCamera {

    internal class SetterAPI : ISetterAPI {

        AllPFContext ctx;
        AllPFDomain allDomain;

        internal SetterAPI() {}

        internal void Inject(AllPFContext ctx, AllPFDomain domain) {
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