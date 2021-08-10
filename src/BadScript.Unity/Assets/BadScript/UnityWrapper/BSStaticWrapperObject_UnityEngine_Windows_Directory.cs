using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Windows;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Windows_Directory : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Windows_Directory() : base( typeof( Directory ) )
        {
            m_StaticProperties["temporaryFolder"] = new BSReflectionReference(
                () => new BSObject( Directory.temporaryFolder ),
                null );

            m_StaticProperties["localFolder"] = new BSReflectionReference(
                () => new BSObject( Directory.localFolder ),
                null );

            m_StaticProperties["roamingFolder"] = new BSReflectionReference(
                () => new BSObject( Directory.roamingFolder ),
                null );

            m_StaticProperties["Exists"] = new BSFunctionReference(
                new BSFunction(
                    "function Exists(path)",
                    a => Directory.Exists( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
