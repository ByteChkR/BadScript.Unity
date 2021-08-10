using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_LOD : BSWrapperObject < LOD >

    {
        #region Public

        public BSWrapperObject_UnityEngine_LOD( LOD obj ) : base( obj )
        {
            m_Properties["screenRelativeTransitionHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.screenRelativeTransitionHeight ),
                x => m_InternalObject.screenRelativeTransitionHeight = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["fadeTransitionWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.fadeTransitionWidth ),
                x => m_InternalObject.fadeTransitionWidth = WrapperHelper.UnwrapObject < float >( x ) );

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
