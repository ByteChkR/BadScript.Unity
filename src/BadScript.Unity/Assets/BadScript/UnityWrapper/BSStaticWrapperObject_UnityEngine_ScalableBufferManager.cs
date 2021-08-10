using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_ScalableBufferManager : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_ScalableBufferManager() : base( typeof( ScalableBufferManager ) )
        {
            m_StaticProperties["widthScaleFactor"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) ScalableBufferManager.widthScaleFactor ),
                null );

            m_StaticProperties["heightScaleFactor"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) ScalableBufferManager.heightScaleFactor ),
                null );

        }

        #endregion
    }

}
