using PlatformerCamera.Entities;

namespace PlatformerCamera.Facades {

    internal class PFFactory {

        internal PFCameraEntity CreateCameraEntity() {
            return new PFCameraEntity();
        }

    }

}