using UnityEngine;
using PlatformerCamera.Facades;
using PlatformerCamera.Phases;

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

            this.initPhase.Inject(ctx, domain);
            this.statePhase.Inject(ctx, domain);
            this.applyPhase.Inject(ctx, domain);

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