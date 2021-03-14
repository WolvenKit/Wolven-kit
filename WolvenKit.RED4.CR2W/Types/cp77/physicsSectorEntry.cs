using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class physicsSectorEntry : CVariable
	{
		private Box _sectorBounds;
		private CUInt64 _sectorHash;
		private CUInt32 _entryOffset;
		private CUInt32 _entrySize;

		[Ordinal(0)] 
		[RED("sectorBounds")] 
		public Box SectorBounds
		{
			get
			{
				if (_sectorBounds == null)
				{
					_sectorBounds = (Box) CR2WTypeManager.Create("Box", "sectorBounds", cr2w, this);
				}
				return _sectorBounds;
			}
			set
			{
				if (_sectorBounds == value)
				{
					return;
				}
				_sectorBounds = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("sectorHash")] 
		public CUInt64 SectorHash
		{
			get
			{
				if (_sectorHash == null)
				{
					_sectorHash = (CUInt64) CR2WTypeManager.Create("Uint64", "sectorHash", cr2w, this);
				}
				return _sectorHash;
			}
			set
			{
				if (_sectorHash == value)
				{
					return;
				}
				_sectorHash = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("entryOffset")] 
		public CUInt32 EntryOffset
		{
			get
			{
				if (_entryOffset == null)
				{
					_entryOffset = (CUInt32) CR2WTypeManager.Create("Uint32", "entryOffset", cr2w, this);
				}
				return _entryOffset;
			}
			set
			{
				if (_entryOffset == value)
				{
					return;
				}
				_entryOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("entrySize")] 
		public CUInt32 EntrySize
		{
			get
			{
				if (_entrySize == null)
				{
					_entrySize = (CUInt32) CR2WTypeManager.Create("Uint32", "entrySize", cr2w, this);
				}
				return _entrySize;
			}
			set
			{
				if (_entrySize == value)
				{
					return;
				}
				_entrySize = value;
				PropertySet(this);
			}
		}

		public physicsSectorEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}