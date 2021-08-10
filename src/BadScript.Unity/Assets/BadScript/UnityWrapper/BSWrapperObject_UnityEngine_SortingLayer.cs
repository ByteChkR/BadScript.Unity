using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_SortingLayer : BSWrapperObject < SortingLayer >

    {
        #region Public

        public BSWrapperObject_UnityEngine_SortingLayer( SortingLayer obj ) : base( obj )
        {
            m_Properties["id"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.id ),
                null );

            m_Properties["name"] = new BSReflectionReference( () => new BSObject( m_InternalObject.name ), null );

            m_Properties["value"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.value ),
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
