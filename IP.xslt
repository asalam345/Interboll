<?xml version='1.0'?>
<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
  <xsl:template match="/">
    <HTML>
      <BODY>
        <TABLE cellspacing="4" cellpadding="4">
          <xsl:for-each select="Locations/Location">
            <TR>
              <TD width="5%" bgcolor="#3BB9FF">
                <B>Ip</B>
              </TD>
              <TD width="5%" valign="top" bgcolor="#48CCCD">
                <xsl:value-of select="Ip"/>
              </TD>
              <TD></TD>
            </TR>
            <TR>
              <TD width="5%" bgcolor="#3BB9FF">
                <B>Status</B>
              </TD>
              <TD width="5%" valign="top" bgcolor="#48CCCD">
                <xsl:value-of select="Status"/>
              </TD>
              <TD></TD>
            </TR>
            <TR>
              <TD width="5%" bgcolor="#3BB9FF">
                <B>CountryCode</B>
              </TD>
              <TD width="5%" valign="top" bgcolor="#48CCCD">
                <xsl:value-of select="CountryCode"/>
              </TD>
              <TD></TD>
            </TR>
            <TR>
              <TD width="5%" bgcolor="#3BB9FF">
                <B>CountryName</B>
              </TD>
              <TD width="5%" valign="top" bgcolor="#48CCCD">
                <xsl:value-of select="CountryName"/>
              </TD>
              <TD></TD>
            </TR>
            <TR>
              <TD width="5%" bgcolor="#3BB9FF">
                <B>RegionCode</B>
              </TD>
              <TD width="5%" valign="top" bgcolor="#48CCCD">
                <xsl:value-of select="RegionCode"/>
              </TD>
              <TD></TD>
            </TR>
            <TR>
              <TD width="5%" bgcolor="#3BB9FF">
                <B>RegionName</B>
              </TD>
              <TD width="5%" valign="top" bgcolor="#48CCCD">
                <xsl:value-of select="RegionName"/>
              </TD>
              <TD></TD>
            </TR>
            <TR>
              <TD width="5%" bgcolor="#3BB9FF">
                <B>City</B>
              </TD>
              <TD width="5%" valign="top" bgcolor="#48CCCD">
                <xsl:value-of select="City"/>
              </TD>
              <TD></TD>
            </TR>
            <TR>
              <TD width="5%" bgcolor="#3BB9FF">
                <B>ZipPostalCode</B>
              </TD>
              <TD width="5%" valign="top" bgcolor="#48CCCD">
                <xsl:value-of select="ZipPostalCode"/>
              </TD>
              <TD></TD>
            </TR>
            <TR>
              <TD width="5%" bgcolor="#3BB9FF">
                <B>Latitude</B>
              </TD>
              <TD width="5%" valign="top" bgcolor="#48CCCD">
                <xsl:value-of select="Latitude"/>
              </TD>
              <TD></TD>
            </TR>
            <TR>
              <TD width="5%" bgcolor="#3BB9FF">
                <B>Longitude</B>
              </TD>
              <TD width="5%" valign="top" bgcolor="#48CCCD">
                <xsl:value-of select="Longitude"/>
              </TD>
              <TD></TD>
            </TR>
          </xsl:for-each>
        </TABLE>
      </BODY>
    </HTML>
  </xsl:template>
</xsl:stylesheet>