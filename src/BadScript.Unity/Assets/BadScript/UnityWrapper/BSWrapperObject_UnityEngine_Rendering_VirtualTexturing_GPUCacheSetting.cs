using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Rendering.VirtualTexturing;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_Rendering_VirtualTexturing_GPUCacheSetting : BSWrapperObject < GPUCacheSetting >

    {
        #region Public

        public BSWrapperObject_UnityEngine_Rendering_VirtualTexturing_GPUCacheSetting( GPUCacheSetting obj ) : base(
            obj )
        {
            m_Properties["sizeInMegaBytes"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.sizeInMegaBytes ),
                x => m_InternalObject.sizeInMegaBytes = WrapperHelper.UnwrapObject < uint >( x ) );

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
