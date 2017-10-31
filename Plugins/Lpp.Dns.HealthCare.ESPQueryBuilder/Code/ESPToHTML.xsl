﻿<xsl:stylesheet id="stylesheet" version="2.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:output omit-xml-declaration="yes" method="html" indent="yes"/>

  <xsl:template match="/">
    <xsl:apply-templates select="ESPQueryBuilderModel"/>
  </xsl:template>
  
  <xsl:template match="ESPQueryBuilderModel">
    <html>
      <body>
        <table style="border-collapse: collapse; border: 1px solid black;">
          <xsl:apply-templates select="@*"/>
          <!-- xsl:apply-templates select="*"/ -->
        </table>
      </body>
    </html>
  </xsl:template>

  <xsl:template match="node()|@*">
    <tr>
      <td style="border: 1px solid black;">
        <xsl:value-of select="name(.)"/>
      </td>
      <td style="border: 1px solid black;">
        <xsl:value-of select="."/>
      </td>
    </tr>
  </xsl:template>

  <xsl:template match="xsl:stylesheet" />

</xsl:stylesheet>