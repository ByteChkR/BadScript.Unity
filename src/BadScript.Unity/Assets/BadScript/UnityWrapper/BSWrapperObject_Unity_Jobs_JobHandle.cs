using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using Unity.Jobs;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_Unity_Jobs_JobHandle : BSWrapperObject < JobHandle >

    {
        #region Public

        public BSWrapperObject_Unity_Jobs_JobHandle( JobHandle obj ) : base( obj )
        {
            m_Properties["IsCompleted"] = new BSReflectionReference(
                () => m_InternalObject.IsCompleted ? BSObject.One : BSObject.Zero,
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
