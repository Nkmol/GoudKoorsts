using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Presentation
{
    static class FactoryView
    {
        private static readonly IDictionary<Type, Func<Tile, TileView>> CreateTileMap = new Dictionary
            <Type, Func<Tile, TileView>>()
            {
                {typeof(Tile), (Tile t) => new TileView(t)},
                {typeof(WaterTile), (Tile t) => new WaterView(t)},
                {typeof(SailTile), (Tile t) => new SailView(t)},
                {typeof(RailTile), (Tile t) => new RailView(t)},
                {typeof(SwitchTile), (Tile t) => new SwitchView(t)},
                {typeof(PortTile), (Tile t) => new PortView(t)},
                {typeof(ParkTile), (Tile t) => new ParkView(t)},
            };

        public static TileView CreateTile(Tile tile)
        {
            if (tile == null) return null;

            Func<Tile, TileView> value;
            return CreateTileMap.TryGetValue(tile.GetType(), out value) ? value(tile) : null;
        }

        private static readonly IDictionary<Type, Func<IContainObject, ContainView>> CreateContainMap = new Dictionary
            <Type, Func<IContainObject, ContainView>>()
            {
                {typeof(Cart), (IContainObject t) => new CartView(t)},
                {typeof(Boat), (IContainObject t) => new BoatView(t)},
                {typeof(Storage), (IContainObject t) => new StorageView(t)},
            };

        public static ContainView CreateContain(IContainObject obj)
        {
            if (obj == null) return null;

            Func<IContainObject, ContainView> value;
            return CreateContainMap.TryGetValue(obj.GetType(), out value) ? value(obj) : null;
        }
    }
}
