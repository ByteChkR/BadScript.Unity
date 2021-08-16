using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine.UIElements;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSWrapperObject_UnityEngine_UIElements_IBinding : BSWrapperObject < IBinding >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_IBinding( IBinding obj ) : base( obj )
        {
            m_Properties["PreUpdate"] = new BSFunctionReference(
                new BSFunction(
                    "function PreUpdate()",
                    a =>
                    {
                        m_InternalObject.PreUpdate();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["Update"] = new BSFunctionReference(
                new BSFunction(
                    "function Update()",
                    a =>
                    {
                        m_InternalObject.Update();

                        return new BSObject( null );
                    },
                    0 ) );

            m_Properties["Release"] = new BSFunctionReference(
                new BSFunction(
                    "function Release()",
                    a =>
                    {
                        m_InternalObject.Release();

                        return new BSObject( null );
                    },
                    0 ) );

        }

        #endregion
    }

}
