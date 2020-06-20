using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SSbUiExtraTemplate : CVariable
	{
		[RED("templatePath")] 		public CString TemplatePath { get; set;}

		[RED("caption")] 		public CString Caption { get; set;}

		[RED("subCategory1")] 		public CString SubCategory1 { get; set;}

		[RED("subCategory2")] 		public CString SubCategory2 { get; set;}

		public SSbUiExtraTemplate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SSbUiExtraTemplate(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}