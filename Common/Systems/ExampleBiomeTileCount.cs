using System;
using clamshellboi.Content.Tiles;
using Terraria.ModLoader;

namespace clamshellboi.Common.Systems
{
	public class ExampleBiomeTileCount : ModSystem
	{
		public int exampleBlockCount;

		public override void TileCountsAvailable(ReadOnlySpan<int> tileCounts) {
			exampleBlockCount = tileCounts[ModContent.TileType<ExampleBlock>()];
		}
	}
}
