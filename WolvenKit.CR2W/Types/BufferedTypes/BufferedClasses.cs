﻿using WolvenKit.CR2W.Reflection;

namespace WolvenKit.CR2W.Types
{
    public partial class CCameraCompressedPose : CDefaultCompressedPose2
    {
        [REDBuffer] public CBytes bytes1 { get; set; }
        [REDBuffer] public CFloat float1 { get; set; }
        [REDBuffer] public CFloat float2 { get; set; }
        [REDBuffer] public CBytes bytes2 { get; set; }
    }

    public partial class CClipMap : CObject
    {
        [REDBuffer] public CArray<CHandle<CVariable>> tiles { get; set; }
    }

    public partial class CCookedExplorations : CResource
    {
        [REDBuffer] public CByteArray explfile { get; set; }
    }

    public partial class CCurve : CObject
    {
        [REDBuffer] public CBufferUInt32<SCurveData> curveData { get; set; }
    }

    public partial class CAnimPointCloudLookAtParam : ISkeletalAnimationSetEntryParam
    {
        [REDBuffer] public CBufferVLQ<SAnimPointCloudLookAtParamData> buffer { get; set; }
    }

    public partial class CAreaComponent : CBoundedComponent
    {
        [REDBuffer] public CByteArray2 bufferdata { get; set; }
    }
    public partial class CBehaviorGraph : CResource
    {
        [REDBuffer] public CHandle<CBehaviorVariable> Toplevelnode { get; set; }
        [REDBuffer] public CUInt32 Unk2 { get; set; }
        [REDBuffer] public CArray<IdHandle> Variables1 { get; set; }
        [REDBuffer] public CUInt32 Unk3 { get; set; }
        [REDBuffer] public CBufferVLQ<CHandle<CBehaviorVariable>> Descriptions { get; set; } //FIXME
        [REDBuffer] public CUInt32 Unk4 { get; set; }
        [REDBuffer] public CArray<IdHandle> Vectorvariables1 { get; set; }
        [REDBuffer] public CUInt32 Unk5 { get; set; }
        [REDBuffer] public CArray<IdHandle> Variables2 { get; set; }
        [REDBuffer] public CUInt32 Unk6 { get; set; }
        [REDBuffer] public CArray<IdHandle> Vectorvariables2 { get; set; }

    }
    public partial class CBehaviorGraphBlendMultipleNode : CBehaviorGraphNode
    {
        [REDBuffer] public CBufferVLQ<ShBlendMultipleNodeData> bufferinputvalues { get; set; }

    }
    public partial class CBehaviorGraphContainerNode : CBehaviorGraphNode
    {
        [REDBuffer] public CBufferVLQ<CHandle<CBehaviorVariable>> Inputnodes { get; set; }
        [REDBuffer] public CBufferVLQ<CName> Unk1 { get; set; }
        [REDBuffer] public CBufferVLQ<CName> Unk2 { get; set; }
        [REDBuffer] public CHandle<CBehaviorVariable> Outputnode { get; set; }
    }
    public partial class CBehaviorGraphStateMachineNode : CBehaviorGraphContainerNode
    {
        [REDBuffer] public CBufferVLQ<CHandle<CBehaviorVariable>> _inputnodes { get; set; } //FIXME
        [REDBuffer] public CBufferVLQ<CName> _unk1 { get; set; }
        [REDBuffer] public CBufferVLQ<CName> _unk2 { get; set; }
        [REDBuffer] public CBufferVLQ<CHandle<CBehaviorVariable>> unk3 { get; set; }
        [REDBuffer] public CBufferVLQ<CHandle<CBehaviorVariable>> unk4 { get; set; }
        [REDBuffer] public CHandle<CBehaviorVariable> handle1 { get; set; }
        [REDBuffer] public CHandle<CBehaviorVariable> _outputnode { get; set; }
    }

    public partial class CCutsceneTemplate : CSkeletalAnimationSet
    {
        [REDBuffer] public CUInt32 unk1 { get; set; }
        [REDBuffer] public CBufferUInt32<CVariantSizeType> animevents { get; set; }
    }
    public partial class CEntityTemplate : CResource
    {
        [REDBuffer] public CUInt32 unk1 { get; set; }
    }
    public partial class CEnvProbeComponent : CComponent
    {
        [REDBuffer] public CBufferUInt32<Vector> unk1 { get; set; }
    }

    public partial class CEvaluatorFloatCurve : IEvaluatorFloat
    {
        [REDBuffer] public CurveInfo curveInfo { get; set; }
    }
    public partial class CExtAnimEventsFile : CResource
    {
        [REDBuffer] public CUInt32 unk1 { get; set; }
    }
    public partial class CFoliageResource : CResource
    {
        [REDBuffer] public CBufferVLQInt32<SFoliageResourceData> Trees { get; set; }
        [REDBuffer] public CBufferVLQInt32<SFoliageResourceData> Grasses { get; set; }
    }
    public partial class CGameWorld : CWorld
    {
        [REDBuffer] public CHandle<CLayerGroup> firstlayer { get; set; }
    }

    public partial class CLayerGroup : ISerializable
    {
        [REDBuffer] public CHandle<CGameWorld> worldhandle { get; set; }
        [REDBuffer] public CHandle<CLayerGroup> layergrouphandle { get; set; }
        [REDBuffer] public CBufferVLQ<CHandle<CLayerGroup>> childrenGroups { get; set; }
        [REDBuffer] public CBufferVLQ<CHandle<CLayerGroup>> childrenInfos { get; set; }
    }

    public partial class CMaterialGraph : IMaterialDefinition
    {
        [REDBuffer] public CBufferVLQ<SMaterialGraphParameter> pixelParameters { get; set; }
        [REDBuffer] public CBufferVLQ<SMaterialGraphParameter> vertexParameters { get; set; }
    }

    public partial class CMaterialInstance : IMaterial
    {
        [REDBuffer] public CArray<CVariantSizeNameType> InstanceParameters { get; set; }
    }

    public partial class CMesh : CMeshTypeResource
    {
        // ATTENTION: don't read and write like a normal VLQ array
        // this one is padded by 4 bytes after each inner list
        [REDBuffer] public CBufferVLQ<CPaddedBuffer<CUInt16>> ChunkgroupIndeces { get; set; }

        [REDBuffer] public CBufferVLQ<CName> BoneNames { get; set; }
        [REDBuffer] public CBufferVLQ<CMatrix4x4> Bonematrices { get; set; }
        [REDBuffer] public CBufferVLQ<CFloat> Block3 { get; set; }
        [REDBuffer] public CBufferVLQ<CUInt32> BoneIndecesMappingBoneIndex { get; set; }
    }

    public partial class CNode : CObject
    {
        [REDBuffer] public CArray<CHandle<IAttachment>> AttachmentsReference { get; set; }
        [REDBuffer] public CArray<CHandle<IAttachment>> AttachmentsChild { get; set; }
    }

    public partial class CParticleEmitter : IParticleModule
    {
        [REDBuffer] public SParticleEmitterModuleData moduleData { get; set; }
    }
    public partial class CPhysicsDestructionResource : CMesh
    {
        [REDBuffer] public CArray<SMeshBlock5> block5 { get; set; }
    }

    public partial class CRagdoll : CResource
    {
        [REDBuffer] public CXml Ragdolldata { get; set; }

        public override CVariable SetValue(object val)
        {
            if (val is CXml)
            {
                Ragdolldata = (CXml)val;
            }

            return this;
        }
    }

    public partial class CSkeletalAnimationSetEntry : ISerializable
    {
        [REDBuffer] public CArray<CVariantSizeType> Entries { get; set; }
    }

    public partial class CStorySceneSection : CStorySceneControlPart
    {
        [REDBuffer] public CArray<CVariantSizeTypeName> sceneEventElements { get; set; }
    }

    public partial class CSwarmCellMap : CResource
    {
        [REDBuffer()] public CFloat CellSize1 { get; set; }
        [REDBuffer()] public CInt32 DataSizeBits1 { get; set; }
        [REDBuffer()] public CUInt16 DataSize1 { get; set; }
        [REDBuffer()] public CByteArray Data { get; set; }
        [REDBuffer()] public CFloat CornerPositionX { get; set; }
        [REDBuffer()] public CFloat CornerPositionY { get; set; }
        [REDBuffer()] public CFloat CornerPositionZ { get; set; }
        [REDBuffer()] public CInt32 DataSizeX { get; set; }
        [REDBuffer()] public CInt32 DataSizeY { get; set; }
        [REDBuffer()] public CInt32 DataSizeZ { get; set; }
        [REDBuffer()] public CInt32 DataSizeBits { get; set; }
        [REDBuffer()] public CFloat SizeInKbytes { get; set; }
    }

    public partial class CSwfResource : CResource
    {
        [REDBuffer] public CByteArray swfResource { get; set; }
        [REDBuffer] public CUInt32 unk1 { get; set; }
    }

    public partial class CUmbraScene : CResource
    {
        [REDBuffer] public CUInt32 Unk1 { get; set; }
        [REDBuffer] public CFloat Unk2 { get; set; }
        [REDBuffer] public CBufferUInt32<SUmbraSceneData> tiles { get; set; }
    }

    public partial class CWayPointsCollectionsSet : CResource
    {
        [REDBuffer] public CBufferUInt32<SWayPointsCollectionsSetData> waypointcollections { get; set; }
    }
    public partial class CUmbraTile : CResource
    {

        //public CBufferUInt32<CHandle<>> tiles;


    }
}