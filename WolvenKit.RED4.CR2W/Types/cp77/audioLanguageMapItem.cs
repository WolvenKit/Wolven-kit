using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioLanguageMapItem : audioAudioMetadata
	{
		private audioLanguage _language;

		[Ordinal(1)] 
		[RED("language")] 
		public audioLanguage Language
		{
			get
			{
				if (_language == null)
				{
					_language = (audioLanguage) CR2WTypeManager.Create("audioLanguage", "language", cr2w, this);
				}
				return _language;
			}
			set
			{
				if (_language == value)
				{
					return;
				}
				_language = value;
				PropertySet(this);
			}
		}

		public audioLanguageMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}