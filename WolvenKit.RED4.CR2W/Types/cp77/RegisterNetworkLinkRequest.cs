using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class RegisterNetworkLinkRequest : gameScriptableSystemRequest
	{
		[Ordinal(0)] [RED("linksData")] public CArray<SNetworkLinkData> LinksData { get; set; }

		public RegisterNetworkLinkRequest(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
