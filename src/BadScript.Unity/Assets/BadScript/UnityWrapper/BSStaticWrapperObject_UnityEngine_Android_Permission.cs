using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Android;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Android_Permission : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Android_Permission() : base( typeof( Permission ) )
        {
            m_StaticProperties["Camera"] = new BSReflectionReference( () => new BSObject( Permission.Camera ), null );

            m_StaticProperties["Microphone"] = new BSReflectionReference(
                () => new BSObject( Permission.Microphone ),
                null );

            m_StaticProperties["FineLocation"] = new BSReflectionReference(
                () => new BSObject( Permission.FineLocation ),
                null );

            m_StaticProperties["CoarseLocation"] = new BSReflectionReference(
                () => new BSObject( Permission.CoarseLocation ),
                null );

            m_StaticProperties["ExternalStorageRead"] = new BSReflectionReference(
                () => new BSObject( Permission.ExternalStorageRead ),
                null );

            m_StaticProperties["ExternalStorageWrite"] = new BSReflectionReference(
                () => new BSObject( Permission.ExternalStorageWrite ),
                null );

            m_StaticProperties["HasUserAuthorizedPermission"] = new BSFunctionReference(
                new BSFunction(
                    "function HasUserAuthorizedPermission(permission)",
                    a => Permission.HasUserAuthorizedPermission( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
