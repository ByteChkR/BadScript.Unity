using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Object : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Object() : base( typeof( Object ) )
        {
            m_StaticProperties["Instantiate"] = new BSFunctionReference(
                new BSFunction(
                    "function Instantiate(original, position, rotation)",
                    a => new BSWrapperObject_UnityEngine_Object(
                        Object.Instantiate(
                            WrapperHelper.UnwrapObject < Object >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[2] ) ) ),
                    3 ) );

            m_StaticProperties["Instantiate"] = new BSFunctionReference(
                new BSFunction(
                    "function Instantiate(original, position, rotation, parent)",
                    a => new BSWrapperObject_UnityEngine_Object(
                        Object.Instantiate(
                            WrapperHelper.UnwrapObject < Object >( a[0] ),
                            WrapperHelper.UnwrapObject < Vector3 >( a[1] ),
                            WrapperHelper.UnwrapObject < Quaternion >( a[2] ),
                            WrapperHelper.UnwrapObject < Transform >( a[3] ) ) ),
                    4 ) );

            m_StaticProperties["Instantiate"] = new BSFunctionReference(
                new BSFunction(
                    "function Instantiate(original)",
                    a => new BSWrapperObject_UnityEngine_Object(
                        Object.Instantiate( WrapperHelper.UnwrapObject < Object >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Instantiate"] = new BSFunctionReference(
                new BSFunction(
                    "function Instantiate(original, parent)",
                    a => new BSWrapperObject_UnityEngine_Object(
                        Object.Instantiate(
                            WrapperHelper.UnwrapObject < Object >( a[0] ),
                            WrapperHelper.UnwrapObject < Transform >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Instantiate"] = new BSFunctionReference(
                new BSFunction(
                    "function Instantiate(original, parent, instantiateInWorldSpace)",
                    a => new BSWrapperObject_UnityEngine_Object(
                        Object.Instantiate(
                            WrapperHelper.UnwrapObject < Object >( a[0] ),
                            WrapperHelper.UnwrapObject < Transform >( a[1] ),
                            WrapperHelper.UnwrapObject < bool >( a[2] ) ) ),
                    3 ) );

        }

        #endregion
    }

}
