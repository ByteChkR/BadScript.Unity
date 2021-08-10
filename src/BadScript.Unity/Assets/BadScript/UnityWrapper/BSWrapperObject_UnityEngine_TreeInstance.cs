using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_TreeInstance : BSWrapperObject < TreeInstance >

    {
        #region Public

        public BSWrapperObject_UnityEngine_TreeInstance( TreeInstance obj ) : base( obj )
        {
            m_Properties["position"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Vector3( m_InternalObject.position ),
                x => m_InternalObject.position = WrapperHelper.UnwrapObject < Vector3 >( x ) );

            m_Properties["widthScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.widthScale ),
                x => m_InternalObject.widthScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["heightScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.heightScale ),
                x => m_InternalObject.heightScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["rotation"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.rotation ),
                x => m_InternalObject.rotation = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["color"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color32( m_InternalObject.color ),
                x => m_InternalObject.color = WrapperHelper.UnwrapObject < Color32 >( x ) );

            m_Properties["lightmapColor"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Color32( m_InternalObject.lightmapColor ),
                x => m_InternalObject.lightmapColor = WrapperHelper.UnwrapObject < Color32 >( x ) );

            m_Properties["prototypeIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.prototypeIndex ),
                x => m_InternalObject.prototypeIndex = WrapperHelper.UnwrapObject < int >( x ) );

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
