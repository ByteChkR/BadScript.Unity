using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Tilemaps;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Tilemaps_TileAnimationData : BSWrapperObject < TileAnimationData >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Tilemaps_TileAnimationData( TileAnimationData obj ) : base( obj )
        {
            m_Properties["animationSpeed"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.animationSpeed ),
                x => m_InternalObject.animationSpeed = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["animationStartTime"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.animationStartTime ),
                x => m_InternalObject.animationStartTime = WrapperHelper.UnwrapObject < float >( x ) );

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
