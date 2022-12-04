using UnityEngine;

namespace PlatformerCamera {

    public class PlatfCore {

        // ==== API ====
        SetterAPI setterAPI;
        public ISetterAPI SetterAPI => setterAPI;

        // ==== Context ====
        AllPlatfContext ctx;
        AllPlatfDomain domain;

        // ==== Phases ====
        PlatfInitPhase initPhase;
        PlatfStatePhase statePhase;
        PlatfApplyPhase applyPhase;

        // ==== State ====
        bool isInit;

        public PlatfCore() {

            this.setterAPI = new SetterAPI();
            this.ctx = new AllPlatfContext();
            this.domain = new AllPlatfDomain();

            this.initPhase = new PlatfInitPhase();
            this.statePhase = new PlatfStatePhase();
            this.applyPhase = new PlatfApplyPhase();

            this.setterAPI.Inject(ctx, domain);

        }

        public void Initialize(Camera main) {
            this.ctx.Inject(main);

            initPhase.Init();

            isInit = true;
        }

        public void Tick(float dt) {
            if (!isInit) {
                return;
            }
            statePhase.Tick(dt);
            applyPhase.Tick(dt);
        }

    }

}