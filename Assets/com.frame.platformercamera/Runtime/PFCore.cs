using UnityEngine;
using PFormerCamera.Facades;
using PFormerCamera.Phases;

namespace PFormerCamera {

    public class PFCore {

        // ==== API ====
        SetterAPI setterAPI;
        public ISetterAPI SetterAPI => setterAPI;

        // ==== Context ====
        AllPFContext ctx;
        AllPFDomain domain;

        // ==== Phases ====
        PFInitPhase initPhase;
        PFStatePhase statePhase;
        PFApplyPhase applyPhase;

        // ==== State ====
        bool isInit;

        public PFCore() {

            this.setterAPI = new SetterAPI();
            this.ctx = new AllPFContext();
            this.domain = new AllPFDomain();

            this.initPhase = new PFInitPhase();
            this.statePhase = new PFStatePhase();
            this.applyPhase = new PFApplyPhase();

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