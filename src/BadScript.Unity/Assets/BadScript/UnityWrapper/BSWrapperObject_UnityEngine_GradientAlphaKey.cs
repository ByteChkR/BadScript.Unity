using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_GradientAlphaKey : BSWrapperObject < GradientAlphaKey >

    {
        #region Public

        public BSWrapperObject_UnityEngine_GradientAlphaKey( GradientAlphaKey obj ) : base( obj )
        {
            m_Properties["alpha"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.alpha ),
                x => m_InternalObject.alpha = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["time"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.time ),
                x => m_InternalObject.time = WrapperHelper.UnwrapObject < float >( x ) );

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
