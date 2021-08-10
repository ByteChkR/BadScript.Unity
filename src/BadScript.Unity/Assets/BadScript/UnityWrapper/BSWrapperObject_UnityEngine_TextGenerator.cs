using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_TextGenerator : BSWrapperObject < TextGenerator >

    {
        #region Public

        public BSWrapperObject_UnityEngine_TextGenerator( TextGenerator obj ) : base( obj )
        {
            m_Properties["characterCountVisible"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.characterCountVisible ),
                null );

            m_Properties["rectExtents"] = new BSReflectionReference(
                () => new BSWrapperObject_UnityEngine_Rect( m_InternalObject.rectExtents ),
                null );

            m_Properties["vertexCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.vertexCount ),
                null );

            m_Properties["characterCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.characterCount ),
                null );

            m_Properties["lineCount"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.lineCount ),
                null );

            m_Properties["fontSizeUsedForBestFit"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.fontSizeUsedForBestFit ),
                null );

            m_Properties["GetPreferredWidth"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPreferredWidth(str, settings)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetPreferredWidth(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < TextGenerationSettings >( a[1] ) ) ),
                    2 ) );

            m_Properties["GetPreferredHeight"] = new BSFunctionReference(
                new BSFunction(
                    "function GetPreferredHeight(str, settings)",
                    a => new BSObject(
                        ( decimal ) m_InternalObject.GetPreferredHeight(
                            WrapperHelper.UnwrapObject < string >( a[0] ),
                            WrapperHelper.UnwrapObject < TextGenerationSettings >( a[1] ) ) ),
                    2 ) );

            m_Properties["PopulateWithErrors"] = new BSFunctionReference(
                new BSFunction(
                    "function PopulateWithErrors(str, settings, context)",
                    a => m_InternalObject.PopulateWithErrors(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < TextGenerationSettings >( a[1] ),
                        WrapperHelper.UnwrapObject < GameObject >( a[2] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    3 ) );

            m_Properties["Populate"] = new BSFunctionReference(
                new BSFunction(
                    "function Populate(str, settings)",
                    a => m_InternalObject.Populate(
                        WrapperHelper.UnwrapObject < string >( a[0] ),
                        WrapperHelper.UnwrapObject < TextGenerationSettings >( a[1] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    2 ) );

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
