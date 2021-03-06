using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CallOffReactionAction : SquadTask
	{
		private CEnum<EAISquadAction> _squadActionName;

		[Ordinal(0)] 
		[RED("squadActionName")] 
		public CEnum<EAISquadAction> SquadActionName
		{
			get => GetProperty(ref _squadActionName);
			set => SetProperty(ref _squadActionName, value);
		}

		public CallOffReactionAction(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
