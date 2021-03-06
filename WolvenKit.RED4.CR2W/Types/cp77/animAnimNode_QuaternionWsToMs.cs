using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_QuaternionWsToMs : animAnimNode_QuaternionValue
	{
		private animQuaternionLink _quaternionWs;

		[Ordinal(11)] 
		[RED("quaternionWs")] 
		public animQuaternionLink QuaternionWs
		{
			get => GetProperty(ref _quaternionWs);
			set => SetProperty(ref _quaternionWs, value);
		}

		public animAnimNode_QuaternionWsToMs(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
