using AG_FishNet_Shared.Objects.Core.Identities;

namespace AG_FishNet_Shared.Objects.ObjectTypes.WorldTiles
{
    public class WorldTiles : IdentityList<WorldTileType>
    {
        public static WorldTileType Grass       = new WorldTileType(nameof(Grass));
    }
}