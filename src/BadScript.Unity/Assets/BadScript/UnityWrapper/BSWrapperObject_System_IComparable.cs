using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_IComparable : BSWrapperObject < IComparable >

    {
        #region Public

        public BSWrapperObject_System_IComparable( IComparable obj ) : base( obj )
        {
            m_Properties["CompareTo"] = new BSFunctionReference(
                new BSFunction(
                    "function CompareTo(obj)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.CompareTo( WrapperHelper.UnwrapObject < object >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
