using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VendingMachine : InteractiveDevice
	{
		private CHandle<VendorComponent> _vendorID;
		private CHandle<entIComponent> _advUiComponent;
		private CBool _isShortGlitchActive;
		private gameDelayID _shortGlitchDelayID;

		[Ordinal(93)] 
		[RED("vendorID")] 
		public CHandle<VendorComponent> VendorID
		{
			get
			{
				if (_vendorID == null)
				{
					_vendorID = (CHandle<VendorComponent>) CR2WTypeManager.Create("handle:VendorComponent", "vendorID", cr2w, this);
				}
				return _vendorID;
			}
			set
			{
				if (_vendorID == value)
				{
					return;
				}
				_vendorID = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("advUiComponent")] 
		public CHandle<entIComponent> AdvUiComponent
		{
			get
			{
				if (_advUiComponent == null)
				{
					_advUiComponent = (CHandle<entIComponent>) CR2WTypeManager.Create("handle:entIComponent", "advUiComponent", cr2w, this);
				}
				return _advUiComponent;
			}
			set
			{
				if (_advUiComponent == value)
				{
					return;
				}
				_advUiComponent = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get
			{
				if (_isShortGlitchActive == null)
				{
					_isShortGlitchActive = (CBool) CR2WTypeManager.Create("Bool", "isShortGlitchActive", cr2w, this);
				}
				return _isShortGlitchActive;
			}
			set
			{
				if (_isShortGlitchActive == value)
				{
					return;
				}
				_isShortGlitchActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get
			{
				if (_shortGlitchDelayID == null)
				{
					_shortGlitchDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "shortGlitchDelayID", cr2w, this);
				}
				return _shortGlitchDelayID;
			}
			set
			{
				if (_shortGlitchDelayID == value)
				{
					return;
				}
				_shortGlitchDelayID = value;
				PropertySet(this);
			}
		}

		public VendingMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}