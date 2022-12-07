using UnityEngine;

namespace PlatformerCamera.Entities {

    public class PFCameraInfoComponent {

        Vector3 pos;
        public Vector3 Pos => pos;
        public void SetPos(Vector3 value) => pos = value;

        public PFCameraInfoComponent() {}

        internal void Move(Vector3 offset) {
            this.pos += offset;
        }

    }

}