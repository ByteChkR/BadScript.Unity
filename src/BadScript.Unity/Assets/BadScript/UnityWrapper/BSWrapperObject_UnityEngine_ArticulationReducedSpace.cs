using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_ArticulationReducedSpace : BSWrapperObject < ArticulationReducedSpace >

    {
        #region Public

        public BSWrapperObject_UnityEngine_ArticulationReducedSpace( ArticulationReducedSpace obj ) : base( obj )
        {
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

        }

        #endregion
    }

}
