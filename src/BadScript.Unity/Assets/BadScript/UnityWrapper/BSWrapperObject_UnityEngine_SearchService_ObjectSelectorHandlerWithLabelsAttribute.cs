using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.SearchService;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class
        BSWrapperObject_UnityEngine_SearchService_ObjectSelectorHandlerWithLabelsAttribute : BSWrapperObject <
            ObjectSelectorHandlerWithLabelsAttribute >

    {
        #region Public

        public BSWrapperObject_UnityEngine_SearchService_ObjectSelectorHandlerWithLabelsAttribute(
            ObjectSelectorHandlerWithLabelsAttribute obj ) : base( obj )
        {
            m_Properties["matchAll"] = new BSReflectionReference(
                () => m_InternalObject.matchAll ? BSObject.One : BSObject.Zero,
                null );

            m_Properties["TypeId"] = new BSReflectionReference(
                () => new BSWrapperObject_System_Object( m_InternalObject.TypeId ),
                null );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(obj)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

            m_Properties["Match"] = new BSFunctionReference(
                new BSFunction(
                    "function Match(obj)",
                    a => m_InternalObject.Match( WrapperHelper.UnwrapObject < object >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}