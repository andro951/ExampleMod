using clamshellboi.Content.Rarities;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace clamshellboi.Content.Items.Weapons
{
	public class SanguineEssence : ModItem
	{
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("TSE");
            Tooltip.SetDefault("This blade eminates an unholy aura. You feel as if you are going insane just by holding it...");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }
        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 10;
            Item.useAnimation = 10;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 2100;
            Item.knockBack = 5.0f;
            Item.crit = 50;

            Item.value = Item.buyPrice(copper: 50, silver: 29, gold: 55);
            Item.rare = ItemRarityID.Purple;

            Item.UseSound = SoundID.Item1;
        }
        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.HellstoneBar, 50);
            recipe.AddIngredient(ItemID.Obsidian, 110);
            recipe.AddIngredient(ItemID.MeteoriteBar, 10);
            recipe.AddIngredient(ItemID.HallowedBar, 35);
            recipe.AddIngredient(ItemID.SoulofNight, 10);
            recipe.AddIngredient(ItemID.HellstoneBrick, 100);
            recipe.AddTile(TileID.Anvils);
            recipe.AddTile(TileID.HeavyWorkBench);
            recipe.Register();
        }
    }
}
