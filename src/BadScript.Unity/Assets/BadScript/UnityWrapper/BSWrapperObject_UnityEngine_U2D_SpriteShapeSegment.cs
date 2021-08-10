using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.U2D;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_U2D_SpriteShapeSegment : BSWrapperObject < SpriteShapeSegment >

    {
        #region Public

        public BSWrapperObject_UnityEngine_U2D_SpriteShapeSegment( SpriteShapeSegment obj ) : base( obj )
        {
            m_Properties["geomIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.geomIndex ),
                x => m_InternalObject.geomIndex = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["indexCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.indexCount ),
                x => m_InternalObject.indexCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["vertexCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.vertexCount ),
                x => m_InternalObject.vertexCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["spriteIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.spriteIndex ),
                x => m_InternalObject.spriteIndex = WrapperHelper.UnwrapObject < int >( x ) );

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
