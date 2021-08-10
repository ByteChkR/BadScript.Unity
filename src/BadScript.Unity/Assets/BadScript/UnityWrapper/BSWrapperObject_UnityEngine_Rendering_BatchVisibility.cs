using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Rendering_BatchVisibility : BSWrapperObject < BatchVisibility >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_BatchVisibility( BatchVisibility obj ) : base( obj )
        {
            m_Properties["offset"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.offset ),
                null );

            m_Properties["instancesCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.instancesCount ),
                null );

            m_Properties["visibleCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.visibleCount ),
                x => m_InternalObject.visibleCount = WrapperHelper.UnwrapObject < int >( x ) );

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
