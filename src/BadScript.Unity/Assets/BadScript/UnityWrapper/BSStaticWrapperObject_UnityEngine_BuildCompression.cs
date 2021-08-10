using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_BuildCompression : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_BuildCompression() : base( typeof( BuildCompression ) )
        {
            m_StaticProperties["Uncompressed"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_BuildCompression( BuildCompression.Uncompressed ),
                null );

            m_StaticProperties["LZ4"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_BuildCompression( BuildCompression.LZ4 ),
                null );

            m_StaticProperties["LZMA"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_BuildCompression( BuildCompression.LZMA ),
                null );

            m_StaticProperties["UncompressedRuntime"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_BuildCompression( BuildCompression.UncompressedRuntime ),
                null );

            m_StaticProperties["LZ4Runtime"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_BuildCompression( BuildCompression.LZ4Runtime ),
                null );

        }

        #endregion
    }

}
