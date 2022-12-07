using UnityEngine;

namespace PlatformerCamera.Sample {

    public class PFSample : MonoBehaviour {

        PFCore pfCore;

        void Awake() {
            pfCore = new PFCore();
            pfCore.Initialize(Camera.main);
        }

        void Update() {

            var dir = Vector2.zero;
            float speed = 10f;

            if (Input.GetKey(KeyCode.A)) {
                dir.x = -speed;
            } else if (Input.GetKey(KeyCode.D)) {
                dir.x = speed;
            }

            if (Input.GetKey(KeyCode.W)) {
                dir.y = speed;
            } else if (Input.GetKey(KeyCode.S)) {
                dir.y = -speed;
            }

            if (dir != Vector2.zero) {
                pfCore.SetterAPI.Move_Current(dir * Time.deltaTime);
            }

        }

        void LateUpdate() {
            float dt = Time.deltaTime;
            pfCore.Tick(dt);
        }

        void OnDrawGizmos() {
            pfCore?.Editor_DrawGizmos();
        }

    }

}