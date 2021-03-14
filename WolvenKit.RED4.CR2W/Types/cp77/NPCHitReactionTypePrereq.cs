using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NPCHitReactionTypePrereq : gameIScriptablePrereq
	{
		private CEnum<animHitReactionType> _hitReactionType;
		private CBool _invert;

		[Ordinal(0)] 
		[RED("hitReactionType")] 
		public CEnum<animHitReactionType> HitReactionType
		{
			get
			{
				if (_hitReactionType == null)
				{
					_hitReactionType = (CEnum<animHitReactionType>) CR2WTypeManager.Create("animHitReactionType", "hitReactionType", cr2w, this);
				}
				return _hitReactionType;
			}
			set
			{
				if (_hitReactionType == value)
				{
					return;
				}
				_hitReactionType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get
			{
				if (_invert == null)
				{
					_invert = (CBool) CR2WTypeManager.Create("Bool", "invert", cr2w, this);
				}
				return _invert;
			}
			set
			{
				if (_invert == value)
				{
					return;
				}
				_invert = value;
				PropertySet(this);
			}
		}

		public NPCHitReactionTypePrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}