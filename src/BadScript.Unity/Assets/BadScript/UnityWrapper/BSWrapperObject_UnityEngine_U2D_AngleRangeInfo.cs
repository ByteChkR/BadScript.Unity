using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.U2D;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_U2D_AngleRangeInfo : BSWrapperObject < AngleRangeInfo >

    {
        #region Public

        public BSWrapperObject_UnityEngine_U2D_AngleRangeInfo( AngleRangeInfo obj ) : base( obj )
        {
            m_Properties["start"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.start ),
                x => m_InternalObject.start = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["end"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.end ),
                x => m_InternalObject.end = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["order"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.order ),
                x => m_InternalObject.order = WrapperHelper.UnwrapObject < uint >( x ) );

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
