using System.Collections.Generic;

namespace DSTVtoFolders
{
    public class MyPlate
    {
        public string PlateProfile { get; set; }
        public string PlateMaterial { get; set; }

        public void Add(string PlateProfile, string PlateMaterial)
        {
            this.PlateProfile = PlateProfile;
            this.PlateMaterial = PlateMaterial;
        }

    }

    public class MyPlateComparer : IEqualityComparer<MyPlate>
    {
        public bool Equals(MyPlate x, MyPlate y)
        {
            return x.PlateMaterial == y.PlateMaterial
                   &&
                   x.PlateProfile == y.PlateProfile;
        }

        public int GetHashCode(MyPlate mp)
        {
            unchecked
            {
                return mp.PlateMaterial.GetHashCode() ^
                       mp.PlateProfile.GetHashCode();
            }
        }
    }
}
