using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entTemplateInclude : CVariable
	{
		[Ordinal(0)]  [RED("name")] public CName Name { get; set; }
		[Ordinal(1)]  [RED("template_")] public raRef<entEntityTemplate> Template_ { get; set; }

		public entTemplateInclude(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
