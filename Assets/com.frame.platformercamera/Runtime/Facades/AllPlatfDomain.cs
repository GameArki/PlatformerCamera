using PlatformerCamera.Domain;

namespace PlatformerCamera.Facades {

    internal class AllPlatfDomain {

        PlatfCameraDomain cameraDomain;
        internal PlatfCameraDomain CameraDomain => cameraDomain;

        internal AllPlatfDomain() {
            this.cameraDomain = new PlatfCameraDomain();
        }

        internal void Inject(AllPlatfContext ctx) {
            cameraDomain.Inject(ctx);
        }

    }

}