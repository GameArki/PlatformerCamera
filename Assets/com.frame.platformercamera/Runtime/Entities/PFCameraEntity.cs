using UnityEngine;

namespace PFormerCamera.Entities {

    internal class PFCameraEntity {

        PFCameraInfoComponent defaultInfoCom;
        public PFCameraInfoComponent DefaultInfoCom => defaultInfoCom;

        PFCameraInfoComponent currentInfoCom;
        public PFCameraInfoComponent CurrentInfoCom => currentInfoCom;

        PFCameraFollowComponent followCom;
        public PFCameraFollowComponent FollowCom => followCom;

        internal PFCameraEntity() {
            this.defaultInfoCom = new PFCameraInfoComponent();
            this.currentInfoCom = new PFCameraInfoComponent();
            this.followCom = new PFCameraFollowComponent();
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