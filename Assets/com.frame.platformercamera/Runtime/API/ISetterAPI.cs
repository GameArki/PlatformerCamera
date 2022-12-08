using UnityEngine;
using JackEasing;
using PlatformerCamera.Entities;

namespace PlatformerCamera {

    public interface ISetterAPI {

        // ==== Spawn ====
        PFCameraEntity Spawn(int id, Vector3 pos, float heightHalfSize);
        PFCameraEntity SpawnByMain(int id);

        // ==== Base Control ====
        void Move_Current(Vector3 offset);

        // ==== Follow ====
        void Follow_Current(Transform target, Vector3 offset, EasingType easingType, float duration);

        // ==== Confiner ====
        void Confiner_Set_Current(Vector2 min, Vector2 max);

    }

}