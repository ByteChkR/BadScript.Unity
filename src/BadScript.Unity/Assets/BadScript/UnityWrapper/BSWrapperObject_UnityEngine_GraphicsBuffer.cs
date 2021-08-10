using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_GraphicsBuffer : BSWrapperObject < GraphicsBuffer >

    {
        #region Public

        public BSWrapperObject_UnityEngine_GraphicsBuffer( GraphicsBuffer obj ) : base( obj )
        {
            m_Properties["count"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.count ),
                null );

            m_Properties["stride"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.stride ),
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