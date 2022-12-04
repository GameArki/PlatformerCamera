using UnityEngine;

namespace PlatformerCamera {

    internal class AllPlatfContext {

        Camera mainCam;
        public Camera MainCam => mainCam;

        internal AllPlatfContext() { }

        internal void Inject(Camera main) {
            this.mainCam = main;
        }

    }

}