using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CCubeTexture : CResource
	{

		public override CVariable Create(CR2WFile cr2w) => new CCubeTexture(cr2w);

	}
}