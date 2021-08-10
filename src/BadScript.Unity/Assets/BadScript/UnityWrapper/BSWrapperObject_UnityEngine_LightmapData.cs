using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_LightmapData : BSWrapperObject < LightmapData >

    {
        #region Public

        public BSWrapperObject_UnityEngine_LightmapData( LightmapData obj ) : base( obj )
        {
            m_Properties["lightmapLight"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( m_InternalObject.lightmapColor ),
                x => m_InternalObject.lightmapColor = WrapperHelper.UnwrapObject < Texture2D >( x ) );

            m_Properties["lightmapColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( m_InternalObject.lightmapColor ),
                x => m_InternalObject.lightmapColor = WrapperHelper.UnwrapObject < Texture2D >( x ) );

            m_Properties["lightmapDir"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( m_InternalObject.lightmapDir ),
                x => m_InternalObject.lightmapDir = WrapperHelper.UnwrapObject < Texture2D >( x ) );

            m_Properties["shadowMask"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( m_InternalObject.shadowMask ),
                x => m_InternalObject.shadowMask = WrapperHelper.UnwrapObject < Texture2D >( x ) );

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
