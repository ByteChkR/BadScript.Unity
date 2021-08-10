using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Experimental.GlobalIllumination;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_Experimental_GlobalIllumination_LinearColor : BSWrapperObject < LinearColor >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Experimental_GlobalIllumination_LinearColor( LinearColor obj ) : base( obj )
        {
            m_Properties["red"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.red ),
                x => m_InternalObject.red = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["green"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.green ),
                x => m_InternalObject.green = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["blue"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.blue ),
                x => m_InternalObject.blue = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["intensity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.intensity ),
                x => m_InternalObject.intensity = WrapperHelper.UnwrapObject < float >( x ) );

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
