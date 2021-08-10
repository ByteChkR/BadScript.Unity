using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.Events;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Events_UnityEvent : BSWrapperObject < UnityEvent >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Events_UnityEvent( UnityEvent obj ) : base( obj )
        {
            m_Properties["GetPersistentTarget"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPersistentTarget(index)",
                    a => new BSWrapperObject_UnityEngine_Object(
                        m_InternalObject.GetPersistentTarget( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_Properties["GetPersistentMethodName"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPersistentMethodName(index)",
                    a => new BSObject(
                        m_InternalObject.GetPersistentMethodName( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
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
