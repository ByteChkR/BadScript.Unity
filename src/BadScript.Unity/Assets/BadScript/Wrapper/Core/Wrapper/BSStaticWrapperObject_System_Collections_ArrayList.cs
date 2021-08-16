using System.Collections;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Collections_ArrayList : BSStaticWrapperObject

    {
        #region Public

        public BSStaticWrapperObject_System_Collections_ArrayList() : base( typeof( ArrayList ) )
        {
            m_StaticProperties["Adapter"] = new BSFunctionReference(
                new BSFunction(
                    "function Adapter(list)",
                    a => new BSWrapperObject_System_Collections_ArrayList(
                        ArrayList.Adapter( WrapperHelper.UnwrapObject < IList >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["FixedSize"] = new BSFunctionReference(
                new BSFunction(
                    "function FixedSize(list)",
                    a => new BSWrapperObject_System_Collections_IList(
                        ArrayList.FixedSize( WrapperHelper.UnwrapObject < IList >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["FixedSize"] = new BSFunctionReference(
                new BSFunction(
                    "function FixedSize(list)",
                    a => new BSWrapperObject_System_Collections_ArrayList(
                        ArrayList.FixedSize( WrapperHelper.UnwrapObject < ArrayList >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["ReadOnly"] = new BSFunctionReference(
                new BSFunction(
                    "function ReadOnly(list)",
                    a => new BSWrapperObject_System_Collections_IList(
                        ArrayList.ReadOnly( WrapperHelper.UnwrapObject < IList >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["ReadOnly"] = new BSFunctionReference(
                new BSFunction(
                    "function ReadOnly(list)",
                    a => new BSWrapperObject_System_Collections_ArrayList(
                        ArrayList.ReadOnly( WrapperHelper.UnwrapObject < ArrayList >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Repeat"] = new BSFunctionReference(
                new BSFunction(
                    "function Repeat(value, count)",
                    a => new BSWrapperObject_System_Collections_ArrayList(
                        ArrayList.Repeat(
                            WrapperHelper.UnwrapObject < object >( a[0] ),
                            WrapperHelper.UnwrapObject < int >( a[1] ) ) ),
                    2 ) );

            m_StaticProperties["Synchronized"] = new BSFunctionReference(
                new BSFunction(
                    "function Synchronized(list)",
                    a => new BSWrapperObject_System_Collections_IList(
                        ArrayList.Synchronized( WrapperHelper.UnwrapObject < IList >( a[0] ) ) ),
                    1 ) );

            m_StaticProperties["Synchronized"] = new BSFunctionReference(
                new BSFunction(
                    "function Synchronized(list)",
                    a => new BSWrapperObject_System_Collections_ArrayList(
                        ArrayList.Synchronized( WrapperHelper.UnwrapObject < ArrayList >( a[0] ) ) ),
                    1 ) );

        }

        #endregion
    }

}
