namespace PlatformerCamera {

    internal class PlatfApplyPhase {

        AllPlatfContext ctx;
        AllPlatfDomain domain;

        internal PlatfApplyPhase() { }

        internal void Inject(AllPlatfContext ctx, AllPlatfDomain domain) {
            this.ctx = ctx;
            this.domain = domain;
        }

        internal void Tick(float dt) {
            
        }

    }

}