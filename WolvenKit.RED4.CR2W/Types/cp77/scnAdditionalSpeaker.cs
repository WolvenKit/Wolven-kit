using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnAdditionalSpeaker : CVariable
	{
		private scnActorId _actorId;
		private CEnum<scnAdditionalSpeakerType> _type;

		[Ordinal(0)] 
		[RED("actorId")] 
		public scnActorId ActorId
		{
			get
			{
				if (_actorId == null)
				{
					_actorId = (scnActorId) CR2WTypeManager.Create("scnActorId", "actorId", cr2w, this);
				}
				return _actorId;
			}
			set
			{
				if (_actorId == value)
				{
					return;
				}
				_actorId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("type")] 
		public CEnum<scnAdditionalSpeakerType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<scnAdditionalSpeakerType>) CR2WTypeManager.Create("scnAdditionalSpeakerType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		public scnAdditionalSpeaker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}