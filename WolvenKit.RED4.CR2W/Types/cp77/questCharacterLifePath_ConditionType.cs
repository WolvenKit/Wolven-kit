using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterLifePath_ConditionType : questICharacterConditionType
	{
		private TweakDBID _lifePathID;

		[Ordinal(0)] 
		[RED("lifePathID")] 
		public TweakDBID LifePathID
		{
			get
			{
				if (_lifePathID == null)
				{
					_lifePathID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "lifePathID", cr2w, this);
				}
				return _lifePathID;
			}
			set
			{
				if (_lifePathID == value)
				{
					return;
				}
				_lifePathID = value;
				PropertySet(this);
			}
		}

		public questCharacterLifePath_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}