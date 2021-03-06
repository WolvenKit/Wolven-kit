using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class InterestingFactsListenersFunctions : CVariable
	{
		private CName _zone;

		[Ordinal(0)] 
		[RED("zone")] 
		public CName Zone
		{
			get => GetProperty(ref _zone);
			set => SetProperty(ref _zone, value);
		}

		public InterestingFactsListenersFunctions(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
