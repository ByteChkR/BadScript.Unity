using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_ClusterInput : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_ClusterInput() : base( typeof( ClusterInput ) )
        {
            m_StaticProperties["GetAxis"] = new BSFunctionReference(
                new BSFunction(
                    "function GetAxis(name)",
                    a => new BSObject(
                        ( decimal ) ClusterInput.GetAxis( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetButton"] = new BSFunctionReference(
                new BSFunction(
                    "function GetButton(name)",
                    a => ClusterInput.GetButton( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_StaticProperties["GetTrackerPosition"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTrackerPosition(name)",
                    a => new BSWrapperObject_UnityEngine_Vector3(
                        ClusterInput.GetTrackerPosition( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetTrackerRotation"] = new BSFunctionReference(
                new BSFunction(
                    "function GetTrackerRotation(name)",
                    a => new BSWrapperObject_UnityEngine_Quaternion(
                        ClusterInput.GetTrackerRotation( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["CheckConnectionToServer"] = new BSFunctionReference(
                new BSFunction(
                    "function CheckConnectionToServer(name)",
                    a => ClusterInput.CheckConnectionToServer( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
