<?xml version="1.0" encoding="UTF-16"?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:msxsl="urn:schemas-microsoft-com:xslt" xmlns:var="http://schemas.microsoft.com/BizTalk/2003/var" exclude-result-prefixes="msxsl var userCSharp ScriptNS0" version="1.0" xmlns:ns0="http://BTDJ.SampleInterface.OptumCanonical" xmlns:userCSharp="http://schemas.microsoft.com/BizTalk/2003/userCSharp" xmlns:ScriptNS0="http://schemas.microsoft.com/BizTalk/2003/ScriptNS0">
  <xsl:output omit-xml-declaration="yes" method="xml" version="1.0" />
  <xsl:template match="/">
    <xsl:apply-templates select="/OptumClient" />
  </xsl:template>
  <xsl:template match="/OptumClient">
    <ns0:Canonical>
      <xsl:for-each select="Data">
        <xsl:variable name="var:v1" select="userCSharp:StringConcat(&quot;Patient Name:&quot; , string(Name/text()))" />
        <Record>
          <Name>
            <xsl:value-of select="$var:v1" />
          </Name>
          <Age>
            <xsl:value-of select="Age/text()" />
          </Age>
          <Treatment>
            <xsl:value-of select="Treatment/text()" />
          </Treatment>
          <xsl:variable name="var:v2" select="ScriptNS0:AgeGrp(string(Age/text()))" />
          <AgeGroup>
            <xsl:value-of select="$var:v2" />
          </AgeGroup>
        </Record>
      </xsl:for-each>
    </ns0:Canonical>
  </xsl:template>
  <msxsl:script language="C#" implements-prefix="userCSharp"><![CDATA[
public string StringConcat(string param0, string param1)
{
   return param0 + param1;
}



]]></msxsl:script>
</xsl:stylesheet>