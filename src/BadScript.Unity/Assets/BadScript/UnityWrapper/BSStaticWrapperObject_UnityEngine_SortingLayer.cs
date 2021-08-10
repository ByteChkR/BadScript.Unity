using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BSWrapperObjects.Internal.UnityWrapper
{

    public class BSStaticWrapperObject_UnityEngine_SortingLayer : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_UnityEngine_SortingLayer() : base( typeof( SortingLayer ) )
        {
            m_StaticProperties["GetLayerValueFromID"] = new BSFunctionReference(
                new BSFunction(
                    "function GetLayerValueFromID(id)",
                    a => new BSObject(
                        ( decimal ) SortingLayer.GetLayerValueFromID( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["GetLayerValueFromName"] = new BSFunctionReference(
                new BSFunction(
                    "function GetLayerValueFromName(name)",
                    a => new BSObject(
                        ( decimal ) SortingLayer.GetLayerValueFromName(
                            WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["NameToID"] = new BSFunctionReference(
                new BSFunction(
                    "function NameToID(name)",
                    a => new BSObject(
                        ( decimal ) SortingLayer.NameToID( WrapperHelper.UnwrapObject < string >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["IDToName"] = new BSFunctionReference(
                new BSFunction(
                    "function IDToName(id)",
                    a => new BSObject( SortingLayer.IDToName( WrapperHelper.UnwrapObject < int >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["IsValid"] = new BSFunctionReference(
                new BSFunction(
                    "function IsValid(id)",
                    a => SortingLayer.IsValid( WrapperHelper.UnwrapObject < int >( a[0] ) )
                        ? BSObject.One
                        : BSObject.Zero,
                    1 ) );

        }

        #endregion
    }

}
