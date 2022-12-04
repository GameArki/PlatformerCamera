using UnityEngine;

namespace PlatformerCamera.Entities {

    public class PlatfCameraInfoComponent {

        Vector3 pos;
        public Vector3 Pos => pos;
        public void SetPos(Vector3 value) => pos = value;

        public PlatfCameraInfoComponent() {}

        internal void Move(Vector3 offset) {
            this.pos += offset;
        }

    }

}