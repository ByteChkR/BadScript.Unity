using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_ContextMenu : BSWrapperObject < ContextMenu >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ContextMenu( ContextMenu obj ) : base( obj )
        {
            m_Properties["TypeId"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Object( m_InternalObject.TypeId ),
                null );

            m_Properties["menuItem"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.menuItem ),
                null );

            m_Properties["validate"] = new BSReflectionReference(
                () => m_InternalObject.validate ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["priority"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.priority ),
                null );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Match"] = new BSFunctionReference(
                new BSFunction(
                    "function Match(obj)",
                    a => m_InternalObject.Match( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
