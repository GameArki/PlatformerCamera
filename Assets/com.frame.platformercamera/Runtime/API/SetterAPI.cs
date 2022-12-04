namespace PlatformerCamera {

    internal class SetterAPI : ISetterAPI {

        AllPlatfContext ctx;
        AllPlatfDomain domain;

        internal SetterAPI() {}

        internal void Inject(AllPlatfContext ctx, AllPlatfDomain domain) {
            this.ctx = ctx;
            this.domain = domain;
        }

    }
    
}