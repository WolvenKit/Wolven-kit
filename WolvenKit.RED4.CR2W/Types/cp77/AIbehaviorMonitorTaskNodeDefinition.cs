using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMonitorTaskNodeDefinition : AIbehaviorTaskNodeDefinition
	{
		private CFloat _timeout;

		[Ordinal(2)] 
		[RED("timeout")] 
		public CFloat Timeout
		{
			get => GetProperty(ref _timeout);
			set => SetProperty(ref _timeout, value);
		}

		public AIbehaviorMonitorTaskNodeDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
