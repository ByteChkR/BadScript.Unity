using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using BadScript.Utils.Reflection;
using UnityEngine.TextCore;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSWrapperObject_UnityEngine_TextCore_FaceInfo : BSWrapperObject < FaceInfo >

    {
        #region Public

        public BSWrapperObject_UnityEngine_TextCore_FaceInfo( FaceInfo obj ) : base( obj )
        {
            m_Properties["familyName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.familyName ),
                x => m_InternalObject.familyName = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["styleName"] = new BSReflectionReference(
                () => new BSObject( m_InternalObject.styleName ),
                x => m_InternalObject.styleName = WrapperHelper.UnwrapObject < string >( x ) );

            m_Properties["pointSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.pointSize ),
                x => m_InternalObject.pointSize = WrapperHelper.UnwrapObject < int >( x ) );

            m_Properties["scale"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.scale ),
                x => m_InternalObject.scale = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["lineHeight"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.lineHeight ),
                x => m_InternalObject.lineHeight = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["ascentLine"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.ascentLine ),
                x => m_InternalObject.ascentLine = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["capLine"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.capLine ),
                x => m_InternalObject.capLine = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["meanLine"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.meanLine ),
                x => m_InternalObject.meanLine = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["baseline"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.baseline ),
                x => m_InternalObject.baseline = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["descentLine"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.descentLine ),
                x => m_InternalObject.descentLine = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["superscriptOffset"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.superscriptOffset ),
                x => m_InternalObject.superscriptOffset = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["superscriptSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.superscriptSize ),
                x => m_InternalObject.superscriptSize = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["subscriptOffset"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.subscriptOffset ),
                x => m_InternalObject.subscriptOffset = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["subscriptSize"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.subscriptSize ),
                x => m_InternalObject.subscriptSize = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["underlineOffset"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.underlineOffset ),
                x => m_InternalObject.underlineOffset = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["underlineThickness"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.underlineThickness ),
                x => m_InternalObject.underlineThickness = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["strikethroughOffset"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.strikethroughOffset ),
                x => m_InternalObject.strikethroughOffset = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["strikethroughThickness"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.strikethroughThickness ),
                x => m_InternalObject.strikethroughThickness = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["tabWidth"] = new BSReflectionReference(
                () => new BSObject( ( decimal ) m_InternalObject.tabWidth ),
                x => m_InternalObject.tabWidth = WrapperHelper.UnwrapObject < float >( x ) );

            m_Properties["Compare"] = new BSFunctionReference(
                new BSFunction(
                    "function Compare(other)",
                    a => m_InternalObject.Compare( WrapperHelper.UnwrapObject < FaceInfo >( a[0] ) )
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
