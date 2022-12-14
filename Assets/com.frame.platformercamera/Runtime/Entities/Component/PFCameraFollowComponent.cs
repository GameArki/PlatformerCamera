using UnityEngine;
using JackEasing;

namespace PlatformerCamera.Entities {

    public class PFCameraFollowComponent {

        Transform followTF;
        public Transform FollowTF => followTF;
        public void SetTarget(Transform value) => followTF = value;

        Vector3 offset;
        public Vector3 Offset => offset;
        public void SetOffset(Vector3 value) => offset = value;

        EasingType easeingType;
        float easeingDuration;

        // ==== Temp ====
        [SerializeField] Vector3 easeingCurPos;
        [SerializeField] Vector3 easeingStartPos;
        [SerializeField] Vector3 easeingDstPos;
        [SerializeField] float easeingTime;

        public PFCameraFollowComponent() { }

        public void InitFollow(Transform target, Vector3 offset, EasingType easingType, float easeingDuration) {
            this.followTF = target;
            this.offset = offset;
            this.easeingType = easingType;
            this.easeingDuration = easeingDuration;
        }

        public void TickEasing(float dt) {

            if (followTF == null) {
                return;
            }

            if (easeingDuration == 0) {
                easeingCurPos = followTF.position;
                return;
            }

            if (easeingDstPos != followTF.position) {
                easeingStartPos = easeingCurPos;
                easeingDstPos = followTF.position;
                easeingTime = 0;
            }

            if (easeingTime >= easeingDuration) {
                return;
            }

            easeingTime += dt;

            easeingCurPos = EasingHelper.Ease3D(easeingType, easeingTime, easeingDuration, easeingStartPos, easeingDstPos);

        }

        public bool HasTarget() {
            return followTF != null;
        }

        public void MoveOffset(Vector3 diff) {
            this.offset += diff;
        }

        public Vector3 GetFollowPos() {
            if (followTF == null) {
                return Vector3.zero;
            }
            return easeingCurPos + offset;
        }

    }

}