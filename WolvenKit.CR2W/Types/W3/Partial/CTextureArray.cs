using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CTextureArray : CResource
	{
		[RED("bitmaps", 2,0)] 		public CArray<CTextureArrayEntry> Bitmaps { get; set;}

		[RED("textureGroup")] 		public CName TextureGroup { get; set;}

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CTextureArray(cr2w, parent, name);

	}
}