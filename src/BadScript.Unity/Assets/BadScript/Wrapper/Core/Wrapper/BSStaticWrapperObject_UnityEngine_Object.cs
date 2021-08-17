using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;
#pragma warning disable 618

namespace BadScript.Unity.Wrapper.Core.Generated
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

            m_StaticProperties["Destroy"] = new BSFunctionReference(
                new BSFunction(
                    "function Destroy(obj, t)",
                    a =>
                    {
                        Object.Destroy(
                            WrapperHelper.UnwrapObject < Object >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["Destroy"] = new BSFunctionReference(
                new BSFunction(
                    "function Destroy(obj)",
                    a =>
                    {
                        Object.Destroy( WrapperHelper.UnwrapObject < Object >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_StaticProperties["DestroyImmediate"] = new BSFunctionReference(
                new BSFunction(
                    "function DestroyImmediate(obj, allowDestroyingAssets)",
                    a =>
                    {
                        Object.DestroyImmediate(
                            WrapperHelper.UnwrapObject < Object >( a[0] ),
                            WrapperHelper.UnwrapObject < bool >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["DestroyImmediate"] = new BSFunctionReference(
                new BSFunction(
                    "function DestroyImmediate(obj)",
                    a =>
                    {
                        Object.DestroyImmediate( WrapperHelper.UnwrapObject < Object >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_StaticProperties["DontDestroyOnLoad"] = new BSFunctionReference(
                new BSFunction(
                    "function DontDestroyOnLoad(target)",
                    a =>
                    {
                        Object.DontDestroyOnLoad( WrapperHelper.UnwrapObject < Object >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

            m_StaticProperties["DestroyObject"] = new BSFunctionReference(
                new BSFunction(
                    "function DestroyObject(obj, t)",
                    a =>
                    {
                        Object.DestroyObject(
                            WrapperHelper.UnwrapObject < Object >( a[0] ),
                            WrapperHelper.UnwrapObject < float >( a[1] ) );

                        return new BSObject( null );
                    },
                    2 ) );

            m_StaticProperties["DestroyObject"] = new BSFunctionReference(
                new BSFunction(
                    "function DestroyObject(obj)",
                    a =>
                    {
                        Object.DestroyObject( WrapperHelper.UnwrapObject < Object >( a[0] ) );

                        return new BSObject( null );
                    },
                    1 ) );

        }

        #endregion
    }

}
