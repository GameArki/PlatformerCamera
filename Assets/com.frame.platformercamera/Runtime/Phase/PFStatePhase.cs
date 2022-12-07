using PlatformerCamera.Facades;

namespace PlatformerCamera.Phases {

    internal class PFStatePhase {

        AllPFContext ctx;
        AllPFDomain domain;

        internal PFStatePhase() { }

        internal void Inject(AllPFContext ctx, AllPFDomain domain) {
            this.ctx = ctx;
            this.domain = domain;
        }

        internal void Tick(float dt) {

        }

    }

}