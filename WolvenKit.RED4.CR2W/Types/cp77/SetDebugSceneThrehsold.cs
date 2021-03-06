using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetDebugSceneThrehsold : gameScriptableSystemRequest
	{
		private CInt32 _newThreshold;

		[Ordinal(0)] 
		[RED("newThreshold")] 
		public CInt32 NewThreshold
		{
			get => GetProperty(ref _newThreshold);
			set => SetProperty(ref _newThreshold, value);
		}

		public SetDebugSceneThrehsold(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
