using System;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_ModuleHandle : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_ModuleHandle() : base( typeof( ModuleHandle ) )
        {
            m_StaticProperties["EmptyHandle"] = new BSReflectionReference(
                () => new BSWrapperObject_System_ModuleHandle( ModuleHandle.EmptyHandle ),
                null );

        }

        #endregion
    }

}
