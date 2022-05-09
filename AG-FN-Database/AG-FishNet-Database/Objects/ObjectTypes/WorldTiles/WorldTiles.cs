using OpenAlienGarden.Core.Identities;

namespace OpenAlienGarden.ObjectTypes.WorldTiles
{
    public class WorldTiles : IdentityList<WorldTileType>
    {
        public static WorldTileType Grass       = new WorldTileType(nameof(Grass));
    }
}