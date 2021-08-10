using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_CullingGroup : BSWrapperObject < CullingGroup >

    {
        #region Public

        public BSWrapperObject_UnityEngine_CullingGroup( CullingGroup obj ) : base( obj )
        {
            m_Properties["enabled"] = new BSReflectionReference(
                () => m_InternalObject.enabled ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.enabled = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["targetCamera"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Camera( m_InternalObject.targetCamera ),
                x => m_InternalObject.targetCamera = WrapperHelper.UnwrapObject < Camera >( x ) );

            m_Properties["IsVisible"] = new BSFunctionReference(
                new BSFunction(
                    "function IsVisible(index)",
                    a => m_InternalObject.IsVisible( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetDistance"] = new BSFunctionReference(
                new BSFunction(
                    "function GetDistance(index)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetDistance( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
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
