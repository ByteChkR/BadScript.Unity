using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_BillboardAsset : BSWrapperObject < BillboardAsset >

    {
        #region Public

        public BSWrapperObject_UnityEngine_BillboardAsset( BillboardAsset obj ) : base( obj )
        {
            m_Properties["width"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.width ),
                x => m_InternalObject.width = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["height"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.height ),
                x => m_InternalObject.height = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["bottom"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bottom ),
                x => m_InternalObject.bottom = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["imageCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.imageCount ),
                null );

            m_Properties["vertexCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.vertexCount ),
                null );

            m_Properties["indexCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.indexCount ),
                null );

            m_Properties["material"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Material( m_InternalObject.material ),
                x => m_InternalObject.material = WrapperHelper.UnwrapObject < Material >( x ) );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
