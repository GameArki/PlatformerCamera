using PFormerCamera.Facades;

namespace PFormerCamera.Phases {

    internal class PFApplyPhase {

        AllPFContext ctx;
        AllPFDomain domain;

        internal PFApplyPhase() { }

        internal void Inject(AllPFContext ctx, AllPFDomain domain) {
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