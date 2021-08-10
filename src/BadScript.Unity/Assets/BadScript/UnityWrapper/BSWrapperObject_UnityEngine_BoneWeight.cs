using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_BoneWeight : BSWrapperObject < BoneWeight >

    {
        #region Public

        public BSWrapperObject_UnityEngine_BoneWeight( BoneWeight obj ) : base( obj )
        {
            m_Properties["weight0"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.weight0 ),
                x => m_InternalObject.weight0 = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["weight1"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.weight1 ),
                x => m_InternalObject.weight1 = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["weight2"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.weight2 ),
                x => m_InternalObject.weight2 = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["weight3"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.weight3 ),
                x => m_InternalObject.weight3 = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["boneIndex0"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.boneIndex0 ),
                x => m_InternalObject.boneIndex0 = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["boneIndex1"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.boneIndex1 ),
                x => m_InternalObject.boneIndex1 = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["boneIndex2"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.boneIndex2 ),
                x => m_InternalObject.boneIndex2 = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["boneIndex3"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.boneIndex3 ),
                x => m_InternalObject.boneIndex3 = WrapperHelper.UnwrapObject < int >( x ) );

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
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < BoneWeight >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
