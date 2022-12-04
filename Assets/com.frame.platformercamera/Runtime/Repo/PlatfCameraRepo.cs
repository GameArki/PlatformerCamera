using PlatformerCamera.Entities;

namespace PlatformerCamera.Repo {

    internal class PlatfCameraRepo {

        PlatfCameraEntity current;
        public PlatfCameraEntity Current => current;

        internal PlatfCameraRepo() {}

        internal void SetCurrent(PlatfCameraEntity value) {
            this.current = value;
        }

    }

}