using BadScript.Common.Types;
using BadScript.Interfaces;
using BadScript.Tools.CodeGenerator.Runtime;

public class BadScriptWrapperInterface : ABSScriptInterface
{
    private ABSScriptInterface m_StaticInterface;
    private ABSScriptInterface m_WrapperInterface;

    #region Public

    public BadScriptWrapperInterface(
        string name,
        WrapperStaticDataBase staticData,
        IWrapperConstructorDataBase ctorData ) : base( name )
    {
        m_StaticInterface = staticData.CreateInterface( Name );
        m_WrapperInterface = ctorData.CreateInterface( Name );
    }

    public override void AddApi( ABSTable root )
    {
        m_WrapperInterface.AddApi( root );
        m_StaticInterface.AddApi( root );
    }

    #endregion
}
