using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questVendorPanel_NodeType : questIUIManagerNodeType
	{
		[Ordinal(0)]  [RED("openVendorPanel")] public CBool OpenVendorPanel { get; set; }
		[Ordinal(1)]  [RED("vendorId")] public CString VendorId { get; set; }
		[Ordinal(2)]  [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(3)]  [RED("scenarioName")] public CName ScenarioName { get; set; }
		[Ordinal(4)]  [RED("assetsLibrary")] public CString AssetsLibrary { get; set; }
		[Ordinal(5)]  [RED("rootItemName")] public CName RootItemName { get; set; }

		public questVendorPanel_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
