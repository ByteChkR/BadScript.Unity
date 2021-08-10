using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_Font : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_Font() : base( typeof( Font ) )
        {
            m_StaticProperties["CreateDynamicFontFromOSFont"] = new BSFunctionReference(
                new BSFunction(
                    "function CreateDynamicFontFromOSFont(fontname, size)",
                    a => new BSWrapperObject_UnityEngine_Font(
                        Font.CreateDynamicFontFromOSFont(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["GetMaxVertsForString"] = new BSFunctionReference(
                new BSFunction(
                    "function GetMaxVertsForString(str)",
                    a => new BSObject(
                        ( decimal ) Font.GetMaxVertsForString( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
