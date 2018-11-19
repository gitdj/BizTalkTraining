namespace BTDJ.SampleInterface {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTDJ.SampleInterface.OptumClientXML", typeof(global::BTDJ.SampleInterface.OptumClientXML))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"BTDJ.SampleInterface.OptumCanonical", typeof(global::BTDJ.SampleInterface.OptumCanonical))]
    public sealed class OptClientMap : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:s0=""http://OptumClient.V1"" xmlns:ns0=""http://BTDJ.SampleInterface.OptumCanonical"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:OptClient"" />
  </xsl:template>
  <xsl:template match=""/s0:OptClient"">
    <ns0:Canonical>
      <Record>
        <Name>
          <xsl:value-of select=""Data/PtName/text()"" />
        </Name>
        <Age>
          <xsl:value-of select=""Data/Age/text()"" />
        </Age>
        <Treatment>
          <xsl:value-of select=""Data/Treatment/text()"" />
        </Treatment>
      </Record>
    </ns0:Canonical>
  </xsl:template>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"BTDJ.SampleInterface.OptumClientXML";
        
        private const global::BTDJ.SampleInterface.OptumClientXML _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"BTDJ.SampleInterface.OptumCanonical";
        
        private const global::BTDJ.SampleInterface.OptumCanonical _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"BTDJ.SampleInterface.OptumClientXML";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"BTDJ.SampleInterface.OptumCanonical";
                return _TrgSchemas;
            }
        }
    }
}
