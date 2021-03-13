using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CustomValueTimeout : AITimeoutCondition
	{
		[Ordinal(1)] [RED("timeoutValue")] public CFloat TimeoutValue { get; set; }

		public CustomValueTimeout(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
