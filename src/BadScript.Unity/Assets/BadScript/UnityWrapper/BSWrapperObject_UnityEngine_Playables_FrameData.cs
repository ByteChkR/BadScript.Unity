using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Playables;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Playables_FrameData : BSWrapperObject < FrameData >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Playables_FrameData( FrameData obj ) : base( obj )
        {
            m_Properties["frameId"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.frameId ),
                null );

            m_Properties["deltaTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.deltaTime ),
                null );

            m_Properties["weight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.weight ),
                null );

            m_Properties["effectiveWeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.effectiveWeight ),
                null );

            m_Properties["effectiveParentDelay"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.effectiveParentDelay ),
                null );

            m_Properties["effectiveParentSpeed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.effectiveParentSpeed ),
                null );

            m_Properties["effectiveSpeed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.effectiveSpeed ),
                null );

            m_Properties["seekOccurred"] = new BSReflectionReference(
                () => m_InternalObject.seekOccurred ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["timeLooped"] = new BSReflectionReference(
                () => m_InternalObject.timeLooped ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["timeHeld"] = new BSReflectionReference(
                () => m_InternalObject.timeHeld ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["output"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Playables_PlayableOutput( m_InternalObject.output ),
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
