using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Gizmos : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Gizmos() : base( typeof( Gizmos ) )
        {
            m_StaticProperties["color"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color( Gizmos.color ),
                x => Gizmos.color = WrapperHelper.UnwrapObject < Color >( x ) );

            m_StaticProperties["matrix"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Matrix4x4( Gizmos.matrix ),
                x => Gizmos.matrix = WrapperHelper.UnwrapObject < Matrix4x4 >( x ) );

            m_StaticProperties["exposure"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture( Gizmos.exposure ),
                x => Gizmos.exposure = WrapperHelper.UnwrapObject < Texture >( x ) );

            m_StaticProperties["probeSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) Gizmos.probeSize ),
                null );

        }

        #endregion
    }

}
