using PFormerCamera.Entities;

namespace PFormerCamera.Facades {

    internal class PFFactory {

        internal PFCameraEntity CreateCameraEntity() {
            return new PFCameraEntity();
        }

    }

}