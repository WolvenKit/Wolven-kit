using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class rendRenderMultilayerMaskResource : CVariable
	{
		[Ordinal(0)] [RED("renderResourceBlobPC")] public CHandle<IRenderResourceBlob> RenderResourceBlobPC { get; set; }

		public rendRenderMultilayerMaskResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
