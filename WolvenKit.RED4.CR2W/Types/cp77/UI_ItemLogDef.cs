using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_ItemLogDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("ItemLogItem")] public gamebbScriptID_Variant ItemLogItem { get; set; }

		public UI_ItemLogDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
