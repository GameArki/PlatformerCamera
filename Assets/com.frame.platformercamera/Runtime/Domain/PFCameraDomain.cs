using UnityEngine;
using PlatformerCamera.Facades;
using PlatformerCamera.Entities;

namespace PlatformerCamera.Domain {

    internal class PFCameraDomain {

        AllPFContext ctx;

        internal PFCameraDomain() { }

        internal void Inject(AllPFContext ctx) {
            this.ctx = ctx;
        }

        internal void Move_Current(PFCameraEntity cam, Vector2 offset) {
            cam.Move(offset);
        }

    }

}