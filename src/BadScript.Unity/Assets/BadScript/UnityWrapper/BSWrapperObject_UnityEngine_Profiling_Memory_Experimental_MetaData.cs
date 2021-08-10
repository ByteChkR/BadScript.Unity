using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Profiling.Memory.Experimental;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Profiling_Memory_Experimental_MetaData : BSWrapperObject < MetaData >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Profiling_Memory_Experimental_MetaData( MetaData obj ) : base( obj )
        {
            m_Properties["content"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.content ),
                x => m_InternalObject.content = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["platform"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.platform ),
                x => m_InternalObject.platform = WrapperHelper.UnwrapObject < string >( x ) );

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
