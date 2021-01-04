using ICities;
using UnityEngine;

namespace CitySkylines_Mod_UnlockAllAreas
{
    public class UnlockAllAreas : IUserMod
    {
        public string Name { get { return "UnlockAllAreas"; } }
        public string Description { get { return "Unlock All 25 Areas"; } }
    }
    public class Areas : AreasExtensionBase
    {
        public override void OnCreated(IAreas areas)
        {
            base.OnCreated(areas);
            areas.maxAreaCount = 25;
        }
    }

}
