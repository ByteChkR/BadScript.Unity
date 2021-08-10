using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_CullingGroupEvent : BSWrapperObject < CullingGroupEvent >

    {
        #region Public

        public BSWrapperObject_UnityEngine_CullingGroupEvent( CullingGroupEvent obj ) : base( obj )
        {
            m_Properties["index"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.index ),
                null );

            m_Properties["isVisible"] = new BSReflectionReference(
                () => m_InternalObject.isVisible ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["wasVisible"] = new BSReflectionReference(
                () => m_InternalObject.wasVisible ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["hasBecomeVisible"] = new BSReflectionReference(
                () => m_InternalObject.hasBecomeVisible ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["hasBecomeInvisible"] = new BSReflectionReference(
                () => m_InternalObject.hasBecomeInvisible ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["currentDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.currentDistance ),
                null );

            m_Properties["previousDistance"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.previousDistance ),
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
