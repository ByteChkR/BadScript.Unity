using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngineInternal;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngineInternal_MathfInternal : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngineInternal_MathfInternal() : base( typeof( MathfInternal ) )
        {
            m_StaticProperties["FloatMinNormal"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) MathfInternal.FloatMinNormal ),
                x => MathfInternal.FloatMinNormal = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["FloatMinDenormal"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) MathfInternal.FloatMinDenormal ),
                x => MathfInternal.FloatMinDenormal = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["IsFlushToZeroEnabled"] = new BSReflectionReference(
                () => MathfInternal.IsFlushToZeroEnabled ? BSObject.One : BSObject.Zero,
                x => MathfInternal.IsFlushToZeroEnabled = WrapperHelper.UnwrapObject < bool >( x ) );

        }

        #endregion
    }

}
