using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.U2D;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_U2D_SpriteShapeMetaData : BSWrapperObject < SpriteShapeMetaData >

    {
        #region Public

        public BSWrapperObject_UnityEngine_U2D_SpriteShapeMetaData( SpriteShapeMetaData obj ) : base( obj )
        {
            m_Properties["height"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.height ),
                x => m_InternalObject.height = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["bevelCutoff"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bevelCutoff ),
                x => m_InternalObject.bevelCutoff = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["bevelSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.bevelSize ),
                x => m_InternalObject.bevelSize = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["spriteIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.spriteIndex ),
                x => m_InternalObject.spriteIndex = WrapperHelper.UnwrapObject < uint >( x ) );

            m_Properties["corner"] = new BSReflectionReference(
                () => m_InternalObject.corner ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.corner = WrapperHelper.UnwrapObject < bool >( x ) );

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
