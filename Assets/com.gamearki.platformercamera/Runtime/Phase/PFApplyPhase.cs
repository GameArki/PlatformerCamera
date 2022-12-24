using UnityEngine;
using GameArki.PlatformerCamera.Facades;
using GameArki.PlatformerCamera.Entities;

namespace GameArki.PlatformerCamera.Phases {

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

            Apply(curCam, dt);

        }

        void Apply(PFCameraEntity cam, float dt) {

            var infoCom = cam.CurrentInfoCom;
            var followCom = cam.FollowCom;

            Vector3 pos;
            if (followCom.HasTarget()) {
                pos = followCom.GetFollowPos();
                infoCom.SetPos(pos);
            } else {
                pos = infoCom.Pos;
            }

            var mainCam = ctx.MainCam;
            mainCam.transform.position = pos;

            // Apply Confiner
            var confiner = cam.ConfinerCom;
            if (confiner.IsEnable) {
                float radio = (float)Screen.width / Screen.height;
                var viewSize = infoCom.GetViewSize(radio);
                var confinerSize = confiner.GetSize();
                var camPos = confiner.LockCameraInside(infoCom.Pos, viewSize);
                if (camPos != infoCom.Pos) {
                    infoCom.SetPos(camPos);
                    mainCam.transform.position = camPos;
                }
            }
        }

    }

}