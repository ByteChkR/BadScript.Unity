using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_DelayedAttribute : BSWrapperObject < DelayedAttribute >

    {
        #region Public

        public BSWrapperObject_UnityEngine_DelayedAttribute( DelayedAttribute obj ) : base( obj )
        {
            m_Properties["order"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.order ),
                x => m_InternalObject.order = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["TypeId"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Object( m_InternalObject.TypeId ),
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
