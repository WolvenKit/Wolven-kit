using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CameraAreaSettings : IAreaSettings
	{
		private CFloat _cameraNearPlane;
		private CFloat _cameraFarPlane;
		private CBool _automated;
		private CUInt32 _iSO;
		private CFloat _shutterTime;
		private CFloat _fStop;

		[Ordinal(2)] 
		[RED("cameraNearPlane")] 
		public CFloat CameraNearPlane
		{
			get
			{
				if (_cameraNearPlane == null)
				{
					_cameraNearPlane = (CFloat) CR2WTypeManager.Create("Float", "cameraNearPlane", cr2w, this);
				}
				return _cameraNearPlane;
			}
			set
			{
				if (_cameraNearPlane == value)
				{
					return;
				}
				_cameraNearPlane = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("cameraFarPlane")] 
		public CFloat CameraFarPlane
		{
			get
			{
				if (_cameraFarPlane == null)
				{
					_cameraFarPlane = (CFloat) CR2WTypeManager.Create("Float", "cameraFarPlane", cr2w, this);
				}
				return _cameraFarPlane;
			}
			set
			{
				if (_cameraFarPlane == value)
				{
					return;
				}
				_cameraFarPlane = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("automated")] 
		public CBool Automated
		{
			get
			{
				if (_automated == null)
				{
					_automated = (CBool) CR2WTypeManager.Create("Bool", "automated", cr2w, this);
				}
				return _automated;
			}
			set
			{
				if (_automated == value)
				{
					return;
				}
				_automated = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("ISO")] 
		public CUInt32 ISO
		{
			get
			{
				if (_iSO == null)
				{
					_iSO = (CUInt32) CR2WTypeManager.Create("Uint32", "ISO", cr2w, this);
				}
				return _iSO;
			}
			set
			{
				if (_iSO == value)
				{
					return;
				}
				_iSO = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("shutterTime")] 
		public CFloat ShutterTime
		{
			get
			{
				if (_shutterTime == null)
				{
					_shutterTime = (CFloat) CR2WTypeManager.Create("Float", "shutterTime", cr2w, this);
				}
				return _shutterTime;
			}
			set
			{
				if (_shutterTime == value)
				{
					return;
				}
				_shutterTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("fStop")] 
		public CFloat FStop
		{
			get
			{
				if (_fStop == null)
				{
					_fStop = (CFloat) CR2WTypeManager.Create("Float", "fStop", cr2w, this);
				}
				return _fStop;
			}
			set
			{
				if (_fStop == value)
				{
					return;
				}
				_fStop = value;
				PropertySet(this);
			}
		}

		public CameraAreaSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}