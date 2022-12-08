using UnityEngine;
using PlatformerCamera.Facades;

namespace PlatformerCamera.Phases {

    internal class PFApplyPhase {

        AllPFContext ctx;
        AllPFDomain domain;

        internal PFApplyPhase() { }

        internal void Inject(AllPFContext ctx, AllPFDomain domain) {
            this.ctx = ctx;
            this.domain = domain;
        }

        internal void Tick(float dt) {

            var curCam = ctx.Repo.Current;
            if (curCam == null) {
                return;
            }
            var info = curCam.CurrentInfoCom;

            var mainCam = ctx.MainCam;
            mainCam.transform.position = info.Pos;

            // Apply Confiner
            var confiner = curCam.ConfinerCom;
            if (confiner.IsEnable) {
                float radio = (float)Screen.width / Screen.height;
                var viewSize = info.GetViewSize(radio);
                var confinerSize = confiner.GetSize();
                if ((viewSize.x > confinerSize.x) || (viewSize.y > confinerSize.y)) {
                    Debug.LogError($"Confiner 尺寸:{confinerSize} 小于一屏尺寸:{viewSize}");
                    return;
                }
                var camPos = confiner.LockCameraInside(info.Pos, viewSize);
                info.SetPos(camPos);
                mainCam.transform.position = camPos;
            }

        }

    }

}