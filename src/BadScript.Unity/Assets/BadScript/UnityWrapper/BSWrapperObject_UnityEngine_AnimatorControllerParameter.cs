using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_AnimatorControllerParameter : BSWrapperObject < AnimatorControllerParameter >

    {
        #region Public

        public BSWrapperObject_UnityEngine_AnimatorControllerParameter( AnimatorControllerParameter obj ) : base( obj )
        {
            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["nameHash"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.nameHash ),
                null );

            m_Properties["defaultFloat"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.defaultFloat ),
                x => m_InternalObject.defaultFloat = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["defaultInt"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.defaultInt ),
                x => m_InternalObject.defaultInt = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["defaultBool"] = new BSReflectionReference(
                () => m_InternalObject.defaultBool ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.defaultBool = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(o)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
