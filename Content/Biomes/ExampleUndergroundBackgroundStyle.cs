using Terraria.ModLoader;

namespace clamshellboi.Backgrounds
{
	public class ExampleUndergroundBackgroundStyle : ModUndergroundBackgroundStyle
	{
		public override void FillTextureArray(int[] textureSlots) {
			textureSlots[0] = BackgroundTextureLoader.GetBackgroundSlot("clamshellboi/Assets/Textures/Backgrounds/ExampleBiomeUnderground0");
			textureSlots[1] = BackgroundTextureLoader.GetBackgroundSlot("clamshellboi/Assets/Textures/Backgrounds/ExampleBiomeUnderground1");
			textureSlots[2] = BackgroundTextureLoader.GetBackgroundSlot("clamshellboi/Assets/Textures/Backgrounds/ExampleBiomeUnderground2");
			textureSlots[3] = BackgroundTextureLoader.GetBackgroundSlot("clamshellboi/Assets/Textures/Backgrounds/ExampleBiomeUnderground3");
		}
	}
}