using PlatformerCamera.Entities;

namespace PlatformerCamera.Facades {

    internal static class PFFactory {

        internal static PFCameraEntity CreateCameraEntity() {
            return new PFCameraEntity();
        }

    }

}