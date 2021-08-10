using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngineInternal;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngineInternal_GenericStack : BSWrapperObject < GenericStack >

    {
        #region Public

        public BSWrapperObject_UnityEngineInternal_GenericStack( GenericStack obj ) : base( obj )
        {
            m_Properties["Count"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.Count ),
                null );

            m_Properties["IsSynchronized"] = new BSReflectionReference(
                () => m_InternalObject.IsSynchronized ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["SyncRoot"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Object( m_InternalObject.SyncRoot ),
                null );

            m_Properties["Contains"] = new BSFunctionReference(
                new BSFunction(
                    "function Contains(obj)",
                    a => m_InternalObject.Contains( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

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
