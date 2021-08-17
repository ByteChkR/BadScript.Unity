using System;
using BadScript.Common.Types;
using BadScript.Common.Types.Implementations;
using BadScript.Common.Types.References;
using BadScript.Interfaces;
using BadScript.Tools.CodeGenerator.Runtime;
using UnityEngine;

namespace BadScript.Unity.Wrapper
{

    public class WrapperToolsInterface : ABSScriptInterface
    {
        public WrapperToolsInterface(  ) : base( "wrapper_tools" )
        {
        }

        public override void AddApi( ABSTable root )
        {
            root.InsertElement( new BSObject( "recast" ), new BSFunction( "function recast(obj)", WrapperRecast, 1,2 ) );
        }

        private ABSObject WrapperRecast( ABSObject[] arg )
        {
            ABSObject oIn = arg[0].ResolveReference();

            if ( oIn is IBSWrappedObject wo )
            {
                object o = wo.GetInternalObject();
                Type t = o.GetType();
            }

            ABSObject oOut = null;
            if ( arg.Length == 1 )
                oOut= WrapperHelper.RecastWrapper(oIn, true);
            else
            {
                oOut= WrapperHelper.RecastWrapper(oIn, arg[1].ConvertBool() );
            }

            return oOut;
        }
    }
}
