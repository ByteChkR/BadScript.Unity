using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_AssetBundleCreateRequest : BSWrapperObject < AssetBundleCreateRequest >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AssetBundleCreateRequest( AssetBundleCreateRequest obj ) : base( obj )
        {
            m_Properties["assetBundle"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_AssetBundle( m_InternalObject.assetBundle ),
                null );

            m_Properties["isDone"] = new BSReflectionReference(
                () => m_InternalObject.isDone ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["progress"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.progress ),
                null );

            m_Properties["priority"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.priority ),
                x => m_InternalObject.priority = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["allowSceneActivation"] = new BSReflectionReference(
                () => m_InternalObject.allowSceneActivation ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.allowSceneActivation = WrapperHelper.UnwrapObject < bool >( x ) );

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