using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class LibTreeDefTreeVariableInt32 : LibTreeDefTreeVariable
	{
		private CBool _exportAsProperty;
		private CInt32 _defaultValue;

		[Ordinal(2)] 
		[RED("exportAsProperty")] 
		public CBool ExportAsProperty
		{
			get => GetProperty(ref _exportAsProperty);
			set => SetProperty(ref _exportAsProperty, value);
		}

		[Ordinal(3)] 
		[RED("defaultValue")] 
		public CInt32 DefaultValue
		{
			get => GetProperty(ref _defaultValue);
			set => SetProperty(ref _defaultValue, value);
		}

		public LibTreeDefTreeVariableInt32(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
