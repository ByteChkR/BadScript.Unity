using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.Scripting;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Scripting_GarbageCollector : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Scripting_GarbageCollector() : base( typeof( GarbageCollector ) )
        {
            m_StaticProperties["isIncremental"] = new BSReflectionReference(
                () => GarbageCollector.isIncremental ? BSObject.One : BSObject.Zero,
                null );

            m_StaticProperties["incrementalTimeSliceNanoseconds"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) GarbageCollector.incrementalTimeSliceNanoseconds ),
                x => GarbageCollector.incrementalTimeSliceNanoseconds = WrapperHelper.UnwrapObject < ulong >( x ) );

            m_StaticProperties["CollectIncremental"] = new BSFunctionReference(
                new BSFunction(
                    "function CollectIncremental(nanoseconds)",
                    a => GarbageCollector.CollectIncremental( WrapperHelper.UnwrapObject < ulong >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
