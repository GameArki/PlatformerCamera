using UnityEngine;
using JackEasing;
using PlatformerCamera.Facades;
using PlatformerCamera.Entities;

namespace PlatformerCamera.Domain {

    internal class PFCameraDomain {

        AllPFContext ctx;

        internal PFCameraDomain() { }

        internal void Inject(AllPFContext ctx) {
            this.ctx = ctx;
        }

        // ==== Spawn ====
        internal PFCameraEntity SpawnByMain(int id) {
            var main = ctx.MainCam;
            var pos = main.transform.position;
            return Spawn(id, pos, main.orthographicSize);
        }

        internal PFCameraEntity Spawn(int id, Vector3 pos, float heightHalfSize) {
            var entity = PFFactory.CreateCameraEntity();
            entity.CurrentInfoCom.SetPos(pos);
            entity.CurrentInfoCom.SetHeightHalfSize(heightHalfSize);
            entity.SetID(id);
            var repo = ctx.Repo;
            repo.Add(entity);
            return entity;
        }

        // ==== Base Control ====
        internal void Move_Current(PFCameraEntity cam, Vector3 offset) {
            cam.Move(offset);
        }

        // ==== Follow ====
        internal void Follow_Current(PFCameraEntity cur, Transform target, Vector3 offset, EasingType easingType, float duration) {
            cur.FollowCom.InitFollow(target, offset, easingType, duration);
        }

        // ==== Confiner ====
        internal void Confiner_Set_Current(PFCameraEntity cur, Vector2 min, Vector2 max) {
            cur.ConfinerCom.SetConfiner(min, max);
        }
    }

}