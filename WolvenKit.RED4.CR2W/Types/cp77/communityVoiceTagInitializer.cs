using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class communityVoiceTagInitializer : communitySpawnInitializer
	{
		private CName _voiceTagName;

		[Ordinal(0)] 
		[RED("voiceTagName")] 
		public CName VoiceTagName
		{
			get
			{
				if (_voiceTagName == null)
				{
					_voiceTagName = (CName) CR2WTypeManager.Create("CName", "voiceTagName", cr2w, this);
				}
				return _voiceTagName;
			}
			set
			{
				if (_voiceTagName == value)
				{
					return;
				}
				_voiceTagName = value;
				PropertySet(this);
			}
		}

		public communityVoiceTagInitializer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}