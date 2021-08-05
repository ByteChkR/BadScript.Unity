using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
namespace BadScript.Unity.Utils.Expressions
{



    [Serializable]
    public struct BadScriptExpressionArgument
    {
        private decimal ConvertNumber( object o )
        {
            switch ( o )
            {
                case decimal d:
                    return d;
                case sbyte sb:
                    return sb;
                case byte b:
                    return b;
                case short s:
                    return s;
                case ushort us:
                    return us;
                case int i:
                    return i;
                case uint ui:
                    return ui;
                case long l:
                    return l;
                case ulong ul:
                    return ul;
                case float f:
                    return ( decimal ) f;
                case double dd:
                    return ( decimal ) dd;
            }

            throw new Exception( "Can not Convert Object: " + o + " into a Decimal" );
        }

        public string Name;
        public BadScriptExpressionArgumentTypeHint TypeHint;

        public ABSObject CreateObject(object o)
        {
            if ( TypeHint == BadScriptExpressionArgumentTypeHint.Number )
                return new BSObject( ConvertNumber(o) );

            if ( TypeHint == BadScriptExpressionArgumentTypeHint.String )
                return new BSObject( ( o is string s ) ? s : o.ToString() );

            if (TypeHint == BadScriptExpressionArgumentTypeHint.ABSObject)
            {
                if (o is ABSObject obj)
                {
                    return obj;
                }
                throw new Exception("Type Hint is set to ABSObject, but no ABSObject is passed!");

            }

            if (TypeHint == BadScriptExpressionArgumentTypeHint.None)
            {
                return new BSObject(o);
            }

            throw new Exception("Invalid Type: " + o.GetType().Name);
        }
    } 
}