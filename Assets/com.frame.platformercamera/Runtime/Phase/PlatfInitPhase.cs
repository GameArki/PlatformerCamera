namespace PlatformerCamera {

    internal class PlatfInitPhase {

        AllPlatfContext ctx;
        AllPlatfDomain domain;

        internal PlatfInitPhase() { }

        internal void Inject(AllPlatfContext ctx, AllPlatfDomain domain) {
            this.ctx = ctx;
            this.domain = domain;
        }

        internal void Init() {

        }

    }

}