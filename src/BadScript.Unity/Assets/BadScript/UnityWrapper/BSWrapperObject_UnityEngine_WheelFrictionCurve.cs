using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_WheelFrictionCurve : BSWrapperObject < WheelFrictionCurve >

    {
        #region Public

        public BSWrapperObject_UnityEngine_WheelFrictionCurve( WheelFrictionCurve obj ) : base( obj )
        {
            m_Properties["extremumSlip"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.extremumSlip ),
                x => m_InternalObject.extremumSlip = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["extremumValue"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.extremumValue ),
                x => m_InternalObject.extremumValue = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["asymptoteSlip"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.asymptoteSlip ),
                x => m_InternalObject.asymptoteSlip = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["asymptoteValue"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.asymptoteValue ),
                x => m_InternalObject.asymptoteValue = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["stiffness"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.stiffness ),
                x => m_InternalObject.stiffness = WrapperHelper.UnwrapObject < float >( x ) );

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
