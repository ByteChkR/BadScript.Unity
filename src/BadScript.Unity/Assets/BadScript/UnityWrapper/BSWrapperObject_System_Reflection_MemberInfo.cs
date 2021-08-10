using System.Reflection;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_System_Reflection_MemberInfo : BSWrapperObject < MemberInfo >

    {
        #region Public

        public BSWrapperObject_System_Reflection_MemberInfo( MemberInfo obj ) : base( obj )
        {
            m_Properties["Name"] = new BSReflectionReference( () => new BSObject( m_InternalObject.Name ), null );

            m_Properties["MetadataToken"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.MetadataToken ),
                null );

            m_Properties["Module"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Reflection_Module( m_InternalObject.Module ),
                null );

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
