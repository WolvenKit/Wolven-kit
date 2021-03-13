using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questInjectLoot_NodeType : questIItemManagerNodeType
	{
		[Ordinal(0)] [RED("params")] public CArray<questInjectLoot_NodeTypeParams> Params { get; set; }

		public questInjectLoot_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
