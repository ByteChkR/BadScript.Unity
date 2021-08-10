using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Resources : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Resources() : base( typeof( Resources ) )
        {
            m_StaticProperties["Load"] = new BSFunctionReference(
                new BSFunction(
                    "function Load(path)",
                    a => new BSWrapperObject_UnityEngine_Object(
                        Resources.Load( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["LoadAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadAsync(path)",
                    a => new BSWrapperObject_UnityEngine_ResourceRequest(
                        Resources.LoadAsync( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["LoadAsync"] = new BSFunctionReference(
                new BSFunction(
                    "function LoadAsync(path)",
                    a => new BSWrapperObject_UnityEngine_ResourceRequest(
                        Resources.LoadAsync( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["InstanceIDToObject"] = new BSFunctionReference(
                new BSFunction(
                    "function InstanceIDToObject(instanceID)",
                    a => new BSWrapperObject_UnityEngine_Object(
                        Resources.InstanceIDToObject( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
