using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_BoneWeight1 : BSWrapperObject < BoneWeight1 >

    {
        #region Public

        public BSWrapperObject_UnityEngine_BoneWeight1( BoneWeight1 obj ) : base( obj )
        {
            m_Properties["weight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.weight ),
                x => m_InternalObject.weight = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["boneIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.boneIndex ),
                x => m_InternalObject.boneIndex = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < BoneWeight1 >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
