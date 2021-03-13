using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AmmoStateHitTriggeredPrereq : HitTriggeredPrereq
	{
		[Ordinal(5)] [RED("valueToListen")] public CEnum<EMagazineAmmoState> ValueToListen { get; set; }

		public AmmoStateHitTriggeredPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
