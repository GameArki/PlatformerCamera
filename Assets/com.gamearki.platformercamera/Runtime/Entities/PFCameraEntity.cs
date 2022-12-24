using UnityEngine;

namespace GameArki.PlatformerCamera.Entities {

    public class PFCameraEntity {

        int id;
        public int ID => id;
        public void SetID(int value) => id = value;

        PFCameraInfoComponent defaultInfoCom;
        public PFCameraInfoComponent DefaultInfoCom => defaultInfoCom;

        PFCameraInfoComponent currentInfoCom;
        public PFCameraInfoComponent CurrentInfoCom => currentInfoCom;

        PFCameraFollowComponent followCom;
        public PFCameraFollowComponent FollowCom => followCom;

        PFConfinerComponent confinerCom;
        public PFConfinerComponent ConfinerCom => confinerCom;

        public PFCameraEntity() {
            this.defaultInfoCom = new PFCameraInfoComponent();
            this.currentInfoCom = new PFCameraInfoComponent();
            this.followCom = new PFCameraFollowComponent();
            this.confinerCom = new PFConfinerComponent();
        }

        public void Move(Vector3 offset) {
            if (followCom.HasTarget()) {
                followCom.MoveOffset(offset);
            } else {
                currentInfoCom.Move(offset);
            }
        }

    }

}