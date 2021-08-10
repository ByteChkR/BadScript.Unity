using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.VFX;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_VFX_VFXSpawnerState : BSWrapperObject < VFXSpawnerState >

    {
        #region Public

        public BSWrapperObject_UnityEngine_VFX_VFXSpawnerState( VFXSpawnerState obj ) : base( obj )
        {
            m_Properties["playing"] = new BSReflectionReference(
                () => m_InternalObject.playing ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.playing = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["newLoop"] = new BSReflectionReference(
                () => m_InternalObject.newLoop ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["spawnCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.spawnCount ),
                x => m_InternalObject.spawnCount = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["deltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.deltaTime ),
                x => m_InternalObject.deltaTime = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["totalTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.totalTime ),
                x => m_InternalObject.totalTime = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["delayBeforeLoop"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.delayBeforeLoop ),
                x => m_InternalObject.delayBeforeLoop = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["loopDuration"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.loopDuration ),
                x => m_InternalObject.loopDuration = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["delayAfterLoop"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.delayAfterLoop ),
                x => m_InternalObject.delayAfterLoop = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["loopIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.loopIndex ),
                x => m_InternalObject.loopIndex = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["loopCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.loopCount ),
                x => m_InternalObject.loopCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["vfxEventAttribute"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_VFX_VFXEventAttribute( m_InternalObject.vfxEventAttribute ),
                null );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
