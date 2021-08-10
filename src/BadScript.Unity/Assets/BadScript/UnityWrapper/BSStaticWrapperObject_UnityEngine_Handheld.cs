using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Handheld : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Handheld() : base( typeof( Handheld ) )
        {
            m_StaticProperties["use32BitDisplayBuffer"] = new BSReflectionReference(
                () => Handheld.use32BitDisplayBuffer ? BSObject.One : BSObject.Zero,
                x => Handheld.use32BitDisplayBuffer = WrapperHelper.UnwrapObject < bool >( x ) );

            m_StaticProperties["PlayFullScreenMovie"] = new BSFunctionReference(
                new BSFunction(
                    "function PlayFullScreenMovie(path, bgColor)",
                    a => Handheld.PlayFullScreenMovie(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < Color >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

            m_StaticProperties["PlayFullScreenMovie"] = new BSFunctionReference(
                new BSFunction(
                    "function PlayFullScreenMovie(path)",
                    a => Handheld.PlayFullScreenMovie( WrapperHelper.UnwrapObject < string >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
