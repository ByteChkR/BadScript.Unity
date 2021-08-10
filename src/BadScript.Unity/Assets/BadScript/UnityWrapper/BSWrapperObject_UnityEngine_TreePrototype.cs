using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_TreePrototype : BSWrapperObject < TreePrototype >

    {
        #region Public

        public BSWrapperObject_UnityEngine_TreePrototype( TreePrototype obj ) : base( obj )
        {
            m_Properties["prefab"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_GameObject( m_InternalObject.prefab ),
                x => m_InternalObject.prefab = WrapperHelper.UnwrapObject < GameObject >( x ) );

            m_Properties["bendFactor"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bendFactor ),
                x => m_InternalObject.bendFactor = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["navMeshLod"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.navMeshLod ),
                x => m_InternalObject.navMeshLod = WrapperHelper.UnwrapObject < int >( x ) );

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
