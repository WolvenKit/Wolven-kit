using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class IsVehicleDoorQuestLockedState : gamePrereqState
	{
		[Ordinal(0)] [RED("psListener")] public CHandle<gameScriptedPrereqPSChangeListenerWrapper> PsListener { get; set; }

		public IsVehicleDoorQuestLockedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
