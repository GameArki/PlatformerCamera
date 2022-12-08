using PlatformerCamera.Domain;

namespace PlatformerCamera.Facades {

    internal class AllPFDomain {

        PFCameraDomain cameraDomain;
        internal PFCameraDomain CameraDomain => cameraDomain;

        PFCameraFSMDomain cameraFSMDomain;
        internal PFCameraFSMDomain CameraFSMDomain => cameraFSMDomain;

        internal AllPFDomain() {
            this.cameraDomain = new PFCameraDomain();
            this.cameraFSMDomain = new PFCameraFSMDomain();
        }

        internal void Inject(AllPFContext ctx) {
            cameraDomain.Inject(ctx);
            cameraFSMDomain.Inject(ctx);
        }

    }

}