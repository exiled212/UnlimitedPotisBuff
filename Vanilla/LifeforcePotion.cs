﻿using Terraria.ID;
using UnlimitedPotionsBuffs.AbstractItems;

namespace UnlimitedPotisBuff.Vanilla {
    public class LifeforcePotion : VanillaItemBase {

        protected override int GetItemId() {
            return ItemID.LifeforcePotion;
        }

        protected override int GetBuffId() {
            return BuffID.Lifeforce;
        }

        protected override int GetRarityId() {
            return ItemRarityID.Orange;
        }

        protected override int GetTileId() {
            return TileID.AlchemyTable;
        }

    }
}
