using PlatformerCamera.Facades;

namespace PlatformerCamera.Phases {

    internal class PlatfStatePhase {

        AllPlatfContext ctx;
        AllPlatfDomain domain;

        internal PlatfStatePhase() { }

        internal void Inject(AllPlatfContext ctx, AllPlatfDomain domain) {
            this.ctx = ctx;
            this.domain = domain;
        }

        internal void Tick(float dt) {

        }

    }

}