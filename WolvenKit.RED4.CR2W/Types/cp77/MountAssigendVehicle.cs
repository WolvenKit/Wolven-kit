using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MountAssigendVehicle : AIVehicleTaskAbstract
	{
		private CEnum<AIbehaviorUpdateOutcome> _result;

		[Ordinal(0)] 
		[RED("result")] 
		public CEnum<AIbehaviorUpdateOutcome> Result
		{
			get => GetProperty(ref _result);
			set => SetProperty(ref _result, value);
		}

		public MountAssigendVehicle(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
