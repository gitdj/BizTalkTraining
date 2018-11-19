namespace BTDJ.SampleInterface {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BTDJ.SampleInterface.OptumCanonical",@"Canonical")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Canonical"})]
    public sealed class OptumCanonical : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BTDJ.SampleInterface.OptumCanonical"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BTDJ.SampleInterface.OptumCanonical"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Canonical"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""Record"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""Name"" type=""xs:string"" />
              <xs:element name=""Age"" type=""xs:string"" />
              <xs:element name=""Treatment"" type=""xs:string"" />
              <xs:element name=""AgeGroup"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public OptumCanonical() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Canonical";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
