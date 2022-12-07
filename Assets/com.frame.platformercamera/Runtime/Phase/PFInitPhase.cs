using UnityEngine;
using PlatformerCamera.Facades;
using PlatformerCamera.Entities;

namespace PlatformerCamera.Phases {

    internal class PFInitPhase {

        AllPFContext ctx;
        AllPFDomain domain;

        internal PFInitPhase() { }

        internal void Inject(AllPFContext ctx, AllPFDomain domain) {
            this.ctx = ctx;
            this.domain = domain;
        }

        internal void Init() {
            var cam = new PFCameraEntity();
            var mainCam = ctx.MainCam;
            cam.CurrentInfoCom.SetPos(mainCam.transform.position);
            cam.CurrentInfoCom.SetHeightHalfSize(mainCam.orthographicSize);
            ctx.Repo.SetCurrent(cam);
        }

    }

}