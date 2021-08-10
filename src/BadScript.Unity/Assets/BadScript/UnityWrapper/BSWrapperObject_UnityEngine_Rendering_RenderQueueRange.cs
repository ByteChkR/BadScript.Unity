using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_Rendering_RenderQueueRange : BSWrapperObject < RenderQueueRange >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_RenderQueueRange( RenderQueueRange obj ) : base( obj )
        {
            m_Properties["lowerBound"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.lowerBound ),
                x => m_InternalObject.lowerBound = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["upperBound"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.upperBound ),
                x => m_InternalObject.upperBound = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < RenderQueueRange >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
