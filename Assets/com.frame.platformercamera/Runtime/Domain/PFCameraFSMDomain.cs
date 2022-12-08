using UnityEngine;
using PlatformerCamera.Facades;
using PlatformerCamera.Entities;

namespace PlatformerCamera.Domain {

    internal class PFCameraFSMDomain {

        AllPFContext ctx;

        internal PFCameraFSMDomain() { }

        internal void Inject(AllPFContext ctx) {
            this.ctx = ctx;
        }

        internal void TickFollow(PFCameraEntity cam, float dt) {
            cam.FollowCom.TickEasing(dt);
        }

    }

}