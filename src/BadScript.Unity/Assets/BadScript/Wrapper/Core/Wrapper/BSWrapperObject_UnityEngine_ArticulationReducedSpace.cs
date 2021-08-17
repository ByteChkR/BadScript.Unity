using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_ArticulationReducedSpace : BSWrapperObject < ArticulationReducedSpace >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ArticulationReducedSpace( ArticulationReducedSpace obj ) : base( obj )
        {
            m_Properties["get_Item"] = new BSFunctionReference(
                new BSFunction(
                    "function get_Item(i)",
                    a => new BSObject( ( decimal ) m_InternalObject[WrapperHelper.UnwrapObject < int >( a[0] )] ),
                    1 ) );

            m_Properties["set_Item"] = new BSFunctionReference(
                new BSFunction(
                    "function set_Item(i, value)",
                    a =>
                    {
                        m_InternalObject[WrapperHelper.UnwrapObject < int >( a[0] )] =
                            WrapperHelper.UnwrapObject < float >( a[1] );

                        return new BSObject( null );
                    },
                    2 ) );

            m_Properties["dofCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.dofCount ),
                x => m_InternalObject.dofCount = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

        }

        #endregion
    }

}
