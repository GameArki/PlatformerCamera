using JackEasing;
using PlatformerCamera.Entities;
using PlatformerCamera.Facades;
using UnityEngine;

namespace PlatformerCamera {

    internal class SetterAPI : ISetterAPI {

        AllPFContext ctx;
        AllPFDomain allDomain;

        internal SetterAPI() {}

        internal void Inject(AllPFContext ctx, AllPFDomain domain) {
            this.ctx = ctx;
            this.allDomain = domain;
        }

        // ==== Spawn ====
        PFCameraEntity ISetterAPI.Spawn(int id, Vector3 pos, float heightHalfSize) {
            var domain = allDomain.CameraDomain;
            return domain.Spawn(id, pos, heightHalfSize);
        }

        PFCameraEntity ISetterAPI.SpawnByMain(int id) {
            var domain = allDomain.CameraDomain;
            return domain.SpawnByMain(id);
        }

        // ==== Base Control ====
        void ISetterAPI.Move_Current(Vector3 offset) {
            var cur = ctx.Repo.Current;
            var domain = allDomain.CameraDomain;
            domain.Move_Current(cur, offset);
        }

        // ==== Follow ====
        void ISetterAPI.Follow_Current(Transform target, Vector3 offset, EasingType easingType, float duration) {
            var cur = ctx.Repo.Current;
            var domain = allDomain.CameraDomain;
            domain.Follow_Current(cur, target, offset, easingType, duration);
        }

        // ==== Confiner ====
        void ISetterAPI.Confiner_Set_Current(bool isEnable, Vector2 min, Vector2 max) {
            var cur = ctx.Repo.Current;
            var domain = allDomain.CameraDomain;
            domain.Confiner_Set_Current(cur, isEnable, min, max);
        }

        
    }
    
}