using UnityEngine;

namespace PlatformerCamera.Sample {

    public class PlatfSample : MonoBehaviour {

        PlatfCore platfCore;

        void Awake() {
            platfCore = new PlatfCore();
            platfCore.Initialize(Camera.main);
        }

        void Update() {

        }

        void LateUpdate() {
            float dt = Time.deltaTime;
            platfCore.Tick(dt);
        }

    }

}