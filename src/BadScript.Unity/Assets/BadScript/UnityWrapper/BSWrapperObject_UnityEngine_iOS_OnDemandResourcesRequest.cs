using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.iOS;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_iOS_OnDemandResourcesRequest : BSWrapperObject < OnDemandResourcesRequest >

    {
        #region Public

        public BSWrapperObject_UnityEngine_iOS_OnDemandResourcesRequest( OnDemandResourcesRequest obj ) : base( obj )
        {
            m_Properties["error"] = new BSReflectionReference( () => new BSObject( m_InternalObject.error ), null );

            m_Properties["loadingPriority"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.loadingPriority ),
                x => m_InternalObject.loadingPriority = WrapperHelper.UnwrapObject < float >( x ) );

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

            m_Properties["GetResourcePath"] = new BSFunctionReference(
                new BSFunction(
                    "function GetResourcePath(resourceName)",
                    a => new BSObject(
                        m_InternalObject.GetResourcePath( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

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
