using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.SceneManagement;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_SceneManagement_Scene : BSWrapperObject < Scene >

    {
        #region Public

        public BSWrapperObject_UnityEngine_SceneManagement_Scene( Scene obj ) : base( obj )
        {
            m_Properties["handle"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.handle ),
                null );

            m_Properties["path"] = new BSReflectionReference( () => new BSObject( m_InternalObject.path ), null );

            m_Properties["name"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.name ),
                x => m_InternalObject.name = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["isLoaded"] = new BSReflectionReference(
                () => m_InternalObject.isLoaded ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["buildIndex"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.buildIndex ),
                null );

            m_Properties["isDirty"] = new BSReflectionReference(
                () => m_InternalObject.isDirty ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["rootCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.rootCount ),
                null );

            m_Properties["isSubScene"] = new BSReflectionReference(
                () => m_InternalObject.isSubScene ? BSObject.One : BSObject.Zero,
                x => m_InternalObject.isSubScene = WrapperHelper.UnwrapObject < bool >( x ) );

            m_Properties["IsValid"] = new BSFunctionReference(
                new BSFunction(
                    "function IsValid()",
                    a => m_InternalObject.IsValid() ? BSObject.One : BSObject.Zero,
                    0 ) );

            m_Properties["GetHashCode"] = new BSFunctionReference(
                new BSFunction(
                    "function GetHashCode()",
                    a => new BSObject( ( decimal ) m_InternalObject.GetHashCode() ),
                    0 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["ToString"] = new BSFunctionReference(
                new BSFunction( "function ToString()", a => new BSObject( m_InternalObject.ToString() ), 0 ) );

        }

        #endregion
    }

}
