using UnityEngine;
using JackEasing;

namespace PlatformerCamera.Entities {

    public class PlatfCameraFollowComponent {

        Transform target;
        public Transform Target => target;
        public void SetTarget(Transform value) => target = value;

        Vector2 offset;
        public Vector2 Offset => offset;
        public void SetOffset(Vector2 value) => offset = value;

        EasingType easingType;
        float easingTime;
        float easingDuration;

        public PlatfCameraFollowComponent() { }

        public void InitFollow(Transform target, Vector2 offset, EasingType easingType, float easingTime, float easingDuration) {
            this.target = target;
            this.offset = offset;
            this.easingType = easingType;
            this.easingTime = easingTime;
            this.easingDuration = easingDuration;
        }

        public bool HasTarget() {
            return target != null;
        }

        public void MoveOffset(Vector2 value) {
            this.offset += value;
        }

    }

}