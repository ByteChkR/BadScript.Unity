using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_ScriptableObject : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_ScriptableObject() : base( typeof( ScriptableObject ) )
        {
            m_StaticProperties["CreateInstance"] = new BSFunctionReference(
                new BSFunction(
                    "function CreateInstance(className)",
                    a => new BSWrapperObject_UnityEngine_ScriptableObject(
                        ScriptableObject.CreateInstance( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
