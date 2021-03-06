using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LightDirectionSettings : IAreaSettings
	{
		private GlobalLightingTrajectoryOverride _direction;

		[Ordinal(2)] 
		[RED("direction")] 
		public GlobalLightingTrajectoryOverride Direction
		{
			get => GetProperty(ref _direction);
			set => SetProperty(ref _direction, value);
		}

		public LightDirectionSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
