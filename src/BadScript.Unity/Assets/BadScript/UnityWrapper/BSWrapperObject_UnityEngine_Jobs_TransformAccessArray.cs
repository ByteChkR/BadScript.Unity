using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Jobs;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Jobs_TransformAccessArray : BSWrapperObject < TransformAccessArray >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Jobs_TransformAccessArray( TransformAccessArray obj ) : base( obj )
        {
            m_Properties["isCreated"] = new BSReflectionReference(
                () => m_InternalObject.isCreated ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["capacity"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.capacity ),
                x => m_InternalObject.capacity = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["length"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.length ),
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
