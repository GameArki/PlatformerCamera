using UnityEngine;

namespace PlatformerCamera.Sample {

    public class PlatfSample : MonoBehaviour {

        PlatfCore platfCore;

        void Awake() {
            platfCore = new PlatfCore();
            platfCore.Initialize(Camera.main);
        }

        void Update() {

            var dir = Vector2.zero;

            if (Input.GetKey(KeyCode.A)) {
                dir.x = -1;
            } else if (Input.GetKey(KeyCode.D)) {
                dir.x = 1;
            }

            if (Input.GetKey(KeyCode.W)) {
                dir.y = 1;
            } else if (Input.GetKey(KeyCode.S)) {
                dir.y = -1;
            }

            if (dir != Vector2.zero) {
                platfCore.SetterAPI.Move_Current(dir * Time.deltaTime);
            }

        }

        void LateUpdate() {
            float dt = Time.deltaTime;
            platfCore.Tick(dt);
        }

    }

}