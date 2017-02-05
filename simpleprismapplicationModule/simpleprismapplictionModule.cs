using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;

namespace simpleprismapplicationModule
{
    public class simpleprismapplictionModule :IModule
    {
        private readonly IRegionManager regionManager;
        public simpleprismapplictionModule(IRegionManager regionManager)
        {
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            regionManager.RegisterViewWithRegion("MainRegion", typeof(View.simpleprismapplicationview));
        }
    }
}
