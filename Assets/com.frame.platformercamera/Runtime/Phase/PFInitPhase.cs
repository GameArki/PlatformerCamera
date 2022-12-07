using PFormerCamera.Facades;
using PFormerCamera.Entities;

namespace PFormerCamera.Phases {

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
            cam.CurrentInfoCom.SetPos(ctx.MainCam.transform.position);
            ctx.Repo.SetCurrent(cam);
        }

    }

}