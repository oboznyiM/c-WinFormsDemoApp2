<?xml version="1.0" encoding="utf-8"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
    xmlns:msxsl="urn:schemas-microsoft-com:xslt" exclude-result-prefixes="msxsl"
>
	<xsl:output method="xml" indent="yes"/>

	<xsl:template match="StaffBase">

		<table border="1">

			<TR>
				<TD>
					<strong>ID</strong>
				</TD>
				<TD>
					<strong>NAME</strong>
				</TD>
				<TD>
					<strong>DEPARTMENT</strong>
				</TD>
				<TD>
					<strong>BIRTHDAY</strong>
				</TD>
				<TD>
					<strong>GENDER</strong>
				</TD>
			</TR>

			<xsl:for-each select="Staff">
				<xsl:sort order="ascending" select="@ID"/>

				<TR>
					<TD>
						<xsl:value-of select="@ID"/>
					</TD>
					<TD>
						<xsl:value-of select="@NAME"/>
					</TD>
					<TD>
						<xsl:value-of select="@DEPARTMENT"/>
					</TD>
					<TD>
						<xsl:value-of select="@BIRTHDAY"/>
					</TD>
					<TD>
						<xsl:value-of select="@GENDER"/>
					</TD>
				</TR>
			</xsl:for-each>

		</table>


	</xsl:template>

</xsl:stylesheet>
