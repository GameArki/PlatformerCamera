using PlatformerCamera.Facades;
using PlatformerCamera.Entities;

namespace PlatformerCamera.Phases {

    internal class PlatfInitPhase {

        AllPlatfContext ctx;
        AllPlatfDomain domain;

        internal PlatfInitPhase() { }

        internal void Inject(AllPlatfContext ctx, AllPlatfDomain domain) {
            this.ctx = ctx;
            this.domain = domain;
        }

        internal void Init() {
            var cam = new PlatfCameraEntity();
            cam.CurrentInfoCom.SetPos(ctx.MainCam.transform.position);
            ctx.Repo.SetCurrent(cam);
        }

    }

}