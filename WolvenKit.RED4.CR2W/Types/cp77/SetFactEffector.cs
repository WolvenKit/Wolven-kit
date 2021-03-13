using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetFactEffector : gameEffector
	{
		[Ordinal(0)] [RED("fact")] public CName Fact { get; set; }
		[Ordinal(1)] [RED("value")] public CInt32 Value { get; set; }

		public SetFactEffector(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
