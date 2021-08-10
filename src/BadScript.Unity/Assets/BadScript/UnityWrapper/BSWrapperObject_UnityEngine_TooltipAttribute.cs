using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_TooltipAttribute : BSWrapperObject < TooltipAttribute >

    {
        #region Public

        public BSWrapperObject_UnityEngine_TooltipAttribute( TooltipAttribute obj ) : base( obj )
        {
            m_Properties["order"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.order ),
                x => m_InternalObject.order = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["TypeId"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Object( m_InternalObject.TypeId ),
                null );

            m_Properties["tooltip"] = new BSReflectionReference( () => new BSObject( m_InternalObject.tooltip ), null );

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
