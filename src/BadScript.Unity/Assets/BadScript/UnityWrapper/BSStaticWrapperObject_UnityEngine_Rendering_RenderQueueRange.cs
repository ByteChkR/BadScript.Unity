using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Rendering_RenderQueueRange : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Rendering_RenderQueueRange() : base( typeof( RenderQueueRange ) )
        {
            m_StaticProperties["all"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_RenderQueueRange( RenderQueueRange.all ),
                null );

            m_StaticProperties["opaque"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_RenderQueueRange( RenderQueueRange.opaque ),
                null );

            m_StaticProperties["transparent"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rendering_RenderQueueRange( RenderQueueRange.transparent ),
                null );

            m_StaticProperties["minimumBound"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) RenderQueueRange.minimumBound ),
                null );

            m_StaticProperties["maximumBound"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) RenderQueueRange.maximumBound ),
                null );

        }

        #endregion
    }

}
