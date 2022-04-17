using clamshellboi.Content.Tiles.Furniture;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace clamshellboi.Content.Items.Placeable.Furniture
{
	public class ExampleDoor : ModItem
	{
		public override void SetStaticDefaults() {
			Tooltip.SetDefault("This is a modded door.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults() {
			Item.width = 14;
			Item.height = 28;
			Item.maxStack = 99;
			Item.useTurn = true;
			Item.autoReuse = true;
			Item.useAnimation = 15;
			Item.useTime = 10;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.consumable = true;
			Item.value = 150;
			Item.createTile = ModContent.TileType<ExampleDoorClosed>();
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
		public override void AddRecipes() {
			CreateRecipe()
				.AddIngredient<ExampleItem>()
				.AddTile<Tiles.Furniture.ExampleWorkbench>()
				.Register();
		}
	}
}