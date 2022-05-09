using AG_FishNet_Database.Objects.Core.Identities;

namespace AG_FishNet_Database.Objects.ObjectTypes.WorldTiles
{
    public class WorldTiles : IdentityList<WorldTileType>
    {
        public static WorldTileType Grass       = new WorldTileType(nameof(Grass));
    }
}