using UnityEngine;
using PlatformerCamera.Facades;
using PlatformerCamera.Entities;

namespace PlatformerCamera.Domain {

    internal class PlatfCameraDomain {

        AllPlatfContext ctx;

        internal PlatfCameraDomain() { }

        internal void Inject(AllPlatfContext ctx) {
            this.ctx = ctx;
        }

        internal void Move_Current(PlatfCameraEntity cam, Vector2 offset) {
            cam.Move(offset);
        }

    }

}