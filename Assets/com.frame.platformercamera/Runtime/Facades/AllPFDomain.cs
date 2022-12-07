using PlatformerCamera.Domain;

namespace PlatformerCamera.Facades {

    internal class AllPFDomain {

        PFCameraDomain cameraDomain;
        internal PFCameraDomain CameraDomain => cameraDomain;

        internal AllPFDomain() {
            this.cameraDomain = new PFCameraDomain();
        }

        internal void Inject(AllPFContext ctx) {
            cameraDomain.Inject(ctx);
        }

    }

}