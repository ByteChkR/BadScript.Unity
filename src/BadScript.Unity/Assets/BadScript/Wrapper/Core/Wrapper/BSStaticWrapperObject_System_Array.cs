using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Tools.CodeGenerator.Runtime;

namespace BadScript.Unity.Wrapper.Core.Generated
{

    public class BSStaticWrapperObject_System_Array : BSStaticWrapperObject

    {
        public BSStaticWrapperObject_System_Array() : base(typeof(System.Array))
        {
            m_StaticProperties["BinarySearch"] = new BSFunctionReference(new BSFunction("function BinarySearch(array, value)", a => new BSObject((decimal)System.Array.BinarySearch(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Object>(a[1]))), 2));
            m_StaticProperties["Copy"] = new BSFunctionReference(new BSFunction("function Copy(sourceArray, destinationArray, length)", a => {
                System.Array.Copy(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Array>(a[1]), WrapperHelper.UnwrapObject<System.Int64>(a[2]));
                return new BSObject(null);
            }, 3));
            m_StaticProperties["Copy"] = new BSFunctionReference(new BSFunction("function Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length)", a => {
                System.Array.Copy(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Int64>(a[1]), WrapperHelper.UnwrapObject<System.Array>(a[2]), WrapperHelper.UnwrapObject<System.Int64>(a[3]), WrapperHelper.UnwrapObject<System.Int64>(a[4]));
                return new BSObject(null);
            }, 5));
            m_StaticProperties["BinarySearch"] = new BSFunctionReference(new BSFunction("function BinarySearch(array, index, length, value)", a => new BSObject((decimal)System.Array.BinarySearch(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Object>(a[3]))), 4));
            m_StaticProperties["BinarySearch"] = new BSFunctionReference(new BSFunction("function BinarySearch(array, value, comparer)", a => new BSObject((decimal)System.Array.BinarySearch(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Object>(a[1]), WrapperHelper.UnwrapObject<System.Collections.IComparer>(a[2]))), 3));
            m_StaticProperties["BinarySearch"] = new BSFunctionReference(new BSFunction("function BinarySearch(array, index, length, value, comparer)", a => new BSObject((decimal)System.Array.BinarySearch(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Object>(a[3]), WrapperHelper.UnwrapObject<System.Collections.IComparer>(a[4]))), 5));
            m_StaticProperties["IndexOf"] = new BSFunctionReference(new BSFunction("function IndexOf(array, value)", a => new BSObject((decimal)System.Array.IndexOf(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Object>(a[1]))), 2));
            m_StaticProperties["IndexOf"] = new BSFunctionReference(new BSFunction("function IndexOf(array, value, startIndex)", a => new BSObject((decimal)System.Array.IndexOf(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Object>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]))), 3));
            m_StaticProperties["IndexOf"] = new BSFunctionReference(new BSFunction("function IndexOf(array, value, startIndex, count)", a => new BSObject((decimal)System.Array.IndexOf(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Object>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]))), 4));
            m_StaticProperties["LastIndexOf"] = new BSFunctionReference(new BSFunction("function LastIndexOf(array, value)", a => new BSObject((decimal)System.Array.LastIndexOf(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Object>(a[1]))), 2));
            m_StaticProperties["LastIndexOf"] = new BSFunctionReference(new BSFunction("function LastIndexOf(array, value, startIndex)", a => new BSObject((decimal)System.Array.LastIndexOf(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Object>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]))), 3));
            m_StaticProperties["LastIndexOf"] = new BSFunctionReference(new BSFunction("function LastIndexOf(array, value, startIndex, count)", a => new BSObject((decimal)System.Array.LastIndexOf(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Object>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]))), 4));
            m_StaticProperties["Reverse"] = new BSFunctionReference(new BSFunction("function Reverse(array)", a => {
                System.Array.Reverse(WrapperHelper.UnwrapObject<System.Array>(a[0]));
                return new BSObject(null);
            }, 1));
            m_StaticProperties["Reverse"] = new BSFunctionReference(new BSFunction("function Reverse(array, index, length)", a => {
                System.Array.Reverse(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]));
                return new BSObject(null);
            }, 3));
            m_StaticProperties["Sort"] = new BSFunctionReference(new BSFunction("function Sort(array)", a => {
                System.Array.Sort(WrapperHelper.UnwrapObject<System.Array>(a[0]));
                return new BSObject(null);
            }, 1));
            m_StaticProperties["Sort"] = new BSFunctionReference(new BSFunction("function Sort(array, index, length)", a => {
                System.Array.Sort(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]));
                return new BSObject(null);
            }, 3));
            m_StaticProperties["Sort"] = new BSFunctionReference(new BSFunction("function Sort(array, comparer)", a => {
                System.Array.Sort(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Collections.IComparer>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["Sort"] = new BSFunctionReference(new BSFunction("function Sort(array, index, length, comparer)", a => {
                System.Array.Sort(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Collections.IComparer>(a[3]));
                return new BSObject(null);
            }, 4));
            m_StaticProperties["Sort"] = new BSFunctionReference(new BSFunction("function Sort(keys, items)", a => {
                System.Array.Sort(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Array>(a[1]));
                return new BSObject(null);
            }, 2));
            m_StaticProperties["Sort"] = new BSFunctionReference(new BSFunction("function Sort(keys, items, comparer)", a => {
                System.Array.Sort(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Array>(a[1]), WrapperHelper.UnwrapObject<System.Collections.IComparer>(a[2]));
                return new BSObject(null);
            }, 3));
            m_StaticProperties["Sort"] = new BSFunctionReference(new BSFunction("function Sort(keys, items, index, length)", a => {
                System.Array.Sort(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Array>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]));
                return new BSObject(null);
            }, 4));
            m_StaticProperties["Sort"] = new BSFunctionReference(new BSFunction("function Sort(keys, items, index, length, comparer)", a => {
                System.Array.Sort(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Array>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]), WrapperHelper.UnwrapObject<System.Collections.IComparer>(a[4]));
                return new BSObject(null);
            }, 5));
            m_StaticProperties["Clear"] = new BSFunctionReference(new BSFunction("function Clear(array, index, length)", a => {
                System.Array.Clear(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]));
                return new BSObject(null);
            }, 3));
            m_StaticProperties["Copy"] = new BSFunctionReference(new BSFunction("function Copy(sourceArray, destinationArray, length)", a => {
                System.Array.Copy(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Array>(a[1]), WrapperHelper.UnwrapObject<System.Int32>(a[2]));
                return new BSObject(null);
            }, 3));
            m_StaticProperties["Copy"] = new BSFunctionReference(new BSFunction("function Copy(sourceArray, sourceIndex, destinationArray, destinationIndex, length)", a => {
                System.Array.Copy(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.Array>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]), WrapperHelper.UnwrapObject<System.Int32>(a[4]));
                return new BSObject(null);
            }, 5));
            m_StaticProperties["ConstrainedCopy"] = new BSFunctionReference(new BSFunction("function ConstrainedCopy(sourceArray, sourceIndex, destinationArray, destinationIndex, length)", a => {
                System.Array.ConstrainedCopy(WrapperHelper.UnwrapObject<System.Array>(a[0]), WrapperHelper.UnwrapObject<System.Int32>(a[1]), WrapperHelper.UnwrapObject<System.Array>(a[2]), WrapperHelper.UnwrapObject<System.Int32>(a[3]), WrapperHelper.UnwrapObject<System.Int32>(a[4]));
                return new BSObject(null);
            }, 5));

        }
    }

}