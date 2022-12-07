using PlatformerCamera.Entities;

namespace PlatformerCamera.Repo {

    internal class PFCameraRepo {

        PFCameraEntity current;
        public PFCameraEntity Current => current;

        internal PFCameraRepo() {}

        internal void SetCurrent(PFCameraEntity value) {
            this.current = value;
        }

    }

}