using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Keyframe : BSWrapperObject < Keyframe >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Keyframe( Keyframe obj ) : base( obj )
        {
            m_Properties["time"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.time ),
                x => m_InternalObject.time = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["value"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.value ),
                x => m_InternalObject.value = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["inTangent"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.inTangent ),
                x => m_InternalObject.inTangent = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["outTangent"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.outTangent ),
                x => m_InternalObject.outTangent = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["inWeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.inWeight ),
                x => m_InternalObject.inWeight = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["outWeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.outWeight ),
                x => m_InternalObject.outWeight = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["tangentMode"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.tangentMode ),
                x => m_InternalObject.tangentMode = WrapperHelper.UnwrapObject < int >( x ) );

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
