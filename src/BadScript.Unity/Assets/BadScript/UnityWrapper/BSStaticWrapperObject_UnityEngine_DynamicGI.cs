using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_DynamicGI : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_DynamicGI() : base( typeof( DynamicGI ) )
        {
            m_StaticProperties["indirectScale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) DynamicGI.indirectScale ),
                x => DynamicGI.indirectScale = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["updateThreshold"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) DynamicGI.updateThreshold ),
                x => DynamicGI.updateThreshold = WrapperHelper.UnwrapObject < float >( x ) );

            m_StaticProperties["materialUpdateTimeSlice"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) DynamicGI.materialUpdateTimeSlice ),
                x => DynamicGI.materialUpdateTimeSlice = WrapperHelper.UnwrapObject < int >( x ) );

            m_StaticProperties["synchronousMode"] = new BSReflectionReference(
                () => DynamicGI.synchronousMode ? BSObject.One : BSObject.Zero,
                x => DynamicGI.synchronousMode = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["isConverged"] = new BSReflectionReference(
                () => DynamicGI.isConverged ? BSObject.One : BSObject.Zero,
                null );

        }

        #endregion
    }

}
