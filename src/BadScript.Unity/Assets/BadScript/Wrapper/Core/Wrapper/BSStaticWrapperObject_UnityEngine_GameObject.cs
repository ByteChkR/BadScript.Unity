using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_UnityEngine_GameObject : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_GameObject() : base( typeof( GameObject ) )
        {
            m_StaticProperties["FindWithTag"] = new BSFunctionReference(
                new BSFunction(
                    "function FindWithTag(tag)",
                    a => new BSWrapperObject_UnityEngine_GameObject(
                        GameObject.FindWithTag( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["FindGameObjectWithTag"] = new BSFunctionReference(
                new BSFunction(
                    "function FindGameObjectWithTag(tag)",
                    a => new BSWrapperObject_UnityEngine_GameObject(
                        GameObject.FindGameObjectWithTag( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Find"] = new BSFunctionReference(
                new BSFunction(
                    "function Find(name)",
                    a => new BSWrapperObject_UnityEngine_GameObject(
                        GameObject.Find( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
