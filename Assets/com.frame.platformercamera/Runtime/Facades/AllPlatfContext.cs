using UnityEngine;
using PlatformerCamera.Repo;

namespace PlatformerCamera.Facades {

    internal class AllPlatfContext {

        Camera mainCam;
        public Camera MainCam => mainCam;

        PlatfCameraRepo repo;
        public PlatfCameraRepo Repo => repo;

        internal AllPlatfContext() {
            this.repo = new PlatfCameraRepo();
        }

        internal void Inject(Camera main) {
            this.mainCam = main;
        }

    }

}