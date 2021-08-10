using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UILineInfo : BSWrapperObject < UILineInfo >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UILineInfo( UILineInfo obj ) : base( obj )
        {
            m_Properties["startCharIdx"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.startCharIdx ),
                x => m_InternalObject.startCharIdx = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["height"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.height ),
                x => m_InternalObject.height = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["topY"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.topY ),
                x => m_InternalObject.topY = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["leading"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.leading ),
                x => m_InternalObject.leading = WrapperHelper.UnwrapObject < float >( x ) );

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
