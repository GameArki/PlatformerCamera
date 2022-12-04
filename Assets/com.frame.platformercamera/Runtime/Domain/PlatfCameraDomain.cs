namespace PlatformerCamera {

    internal class PlatfCameraDomain {

        AllPlatfContext ctx;

        internal PlatfCameraDomain() { }

        internal void Inject(AllPlatfContext ctx) {
            this.ctx = ctx;
        }

    }

}