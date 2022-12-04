using UnityEngine;

namespace PlatformerCamera.Entities {

    internal class PlatfCameraEntity {

        PlatfCameraInfoComponent defaultInfoCom;
        public PlatfCameraInfoComponent DefaultInfoCom => defaultInfoCom;

        PlatfCameraInfoComponent currentInfoCom;
        public PlatfCameraInfoComponent CurrentInfoCom => currentInfoCom;

        PlatfCameraFollowComponent followCom;
        public PlatfCameraFollowComponent FollowCom => followCom;

        internal PlatfCameraEntity() {
            this.defaultInfoCom = new PlatfCameraInfoComponent();
            this.currentInfoCom = new PlatfCameraInfoComponent();
            this.followCom = new PlatfCameraFollowComponent();
        }

        internal void Move(Vector2 offset) {
            if (followCom.HasTarget()) {
                followCom.MoveOffset(offset);
            } else {
                currentInfoCom.Move(offset);
            }
        }

    }

}