using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_ArticulationJacobian : BSWrapperObject < ArticulationJacobian >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ArticulationJacobian( ArticulationJacobian obj ) : base( obj )
        {
            m_Properties["rows"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.rows ),
                x => m_InternalObject.rows = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["columns"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.columns ),
                x => m_InternalObject.columns = WrapperHelper.UnwrapObject < int >( x ) );

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
