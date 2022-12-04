using PlatformerCamera.Facades;

namespace PlatformerCamera.Phases {

    internal class PlatfApplyPhase {

        AllPlatfContext ctx;
        AllPlatfDomain domain;

        internal PlatfApplyPhase() { }

        internal void Inject(AllPlatfContext ctx, AllPlatfDomain domain) {
            this.ctx = ctx;
            this.domain = domain;
        }

        internal void Tick(float dt) {
            var curCam = ctx.Repo.Current;
            var mainCam = ctx.MainCam;

            mainCam.transform.position = curCam.CurrentInfoCom.Pos;
        }

    }

}