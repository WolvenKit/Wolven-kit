using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorUsedSpotTokensList : ISerializable
	{
		private CArray<AISpotUsageToken> _tokens;

		[Ordinal(0)] 
		[RED("tokens")] 
		public CArray<AISpotUsageToken> Tokens
		{
			get
			{
				if (_tokens == null)
				{
					_tokens = (CArray<AISpotUsageToken>) CR2WTypeManager.Create("array:AISpotUsageToken", "tokens", cr2w, this);
				}
				return _tokens;
			}
			set
			{
				if (_tokens == value)
				{
					return;
				}
				_tokens = value;
				PropertySet(this);
			}
		}

		public AIbehaviorUsedSpotTokensList(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}