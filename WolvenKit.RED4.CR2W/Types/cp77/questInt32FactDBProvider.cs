using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questInt32FactDBProvider : questIInt32ValueProvider
	{
		private CName _factName;

		[Ordinal(0)] 
		[RED("factName")] 
		public CName FactName
		{
			get => GetProperty(ref _factName);
			set => SetProperty(ref _factName, value);
		}

		public questInt32FactDBProvider(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
