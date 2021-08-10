using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;
using UnityEngine.UIElements;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_UIElements_Background : BSWrapperObject < Background >

    {
        #region Public

        public BSWrapperObject_UnityEngine_UIElements_Background( Background obj ) : base( obj )
        {
            m_Properties["texture"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Texture2D( m_InternalObject.texture ),
                x => m_InternalObject.texture = WrapperHelper.UnwrapObject < Texture2D >( x ) );

            m_Properties["vectorImage"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_UIElements_VectorImage( m_InternalObject.vectorImage ),
                x => m_InternalObject.vectorImage = WrapperHelper.UnwrapObject < VectorImage >( x ) );

            m_Properties["Equals"] = new BSFunctionReference(
                new BSFunction(
                    "function Equals(other)",
                    a => m_InternalObject.Equals( WrapperHelper.UnwrapObject < Background >( a[0] ) )
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
